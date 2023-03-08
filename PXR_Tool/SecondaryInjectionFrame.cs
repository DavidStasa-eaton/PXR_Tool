using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StasaLibrary;

namespace PXR_Tool
{
    public partial class SecondaryInjectionFrame : UserControl
    {
        public delegate Task PostTestCallBack(string siType, string waveType, bool withTrip, char phaseChar, int targetCurrent, EtuResponse testResponse);

        private DeviceDiscovery.DeviceType _currentType = DeviceDiscovery.DeviceType.None;
        private ActiveSecondaryInjectionGroups siGroup;

        private ParameterGroup _rmsWithTripPG;
        private ParameterGroup _rmsNoTripPG;
        private ParameterGroup _peakWithTripPG;
        private ParameterGroup _peakNoTripPG;
        private ParameterGroup _cancelTestPG;

        private PostTestCallBack postTestDel;

        private BindingList<StasaLibrary.DataFrames.SiTestInfo> resultHistoryList;

        private char PhaseChar
        {
            get
            {
                if (phaseARadioButton.Checked) return 'A';
                else if (phaseBRadioButton.Checked) return 'B';
                else if (phaseCRadioButton.Checked) return 'C';
                else if (phaseNRadioButton.Checked) return 'N';
                else if (phaseGRadioButton.Checked) return 'G';
                return 'A';
            }
        }

        public SecondaryInjectionFrame()
        {
            InitializeComponent();

            Program.DeviceChangedEvent += Program_DeviceChangedEvent;
            postTestDel = ReadPostTripData;
            resultHistoryList = new BindingList<StasaLibrary.DataFrames.SiTestInfo>();
            bindedDataSource.BindEvents(resultHistoryList);
        }

        #region Setup Device Type
        private void Program_DeviceChangedEvent(BroadDeviceChangedEventArgs obj)
        {
            BindDeviceType(Program.currentBDT);
        }

        public void BindDeviceType(DeviceDiscovery.DeviceType dt)
        {
            if (_currentType == dt) return;

            _currentType = dt;
            switch (dt)
            {
                case DeviceDiscovery.DeviceType.PdPxr25:
                case DeviceDiscovery.DeviceType.PdPxr20:
                    BindAsPd();
                    break;
                case DeviceDiscovery.DeviceType.Tokyo:
                    BindAsTokyo();
                    break;
            }
        }

        public void BindAsPd()
        {
            csifButton.paramGroup = Program.connectedDevice.calFactorDict[(int)PdDeviceInfo.Calibration.SIClearFactor];
            bccButton.paramGroup = Program.connectedDevice.calFactorDict[(int)PdDeviceInfo.Calibration.SIBaseCounter];
            dccButton.paramGroup = Program.connectedDevice.calFactorDict[(int)PdDeviceInfo.Calibration.SIDelatCounter];

            dccButton.Text = "Delta Counter Calibration";

            siGroup = new ActiveSecondaryInjectionGroups()
            {
                SoftwareRmsNoTrip = Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.SoftwareRmsTestNoTrip],
                SoftwarePeakNoTrip = Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.SoftwarePeakTestNoTrip],
                SoftwareRmsWithTrip = Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.SoftwareRmsTestWithTrip],
                SoftwarePeakWithTrip = Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.SoftwarePeakTestWithTrip],
                HardwareRmsNoTrip =    Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.HardwareRmsTestNoTrip],
                HardwarePeakNoTrip =   Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.HardwarePeakTestNoTrip],
                HardwareRmsWithTrip =  Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.HardwareRmsTestWithTrip],
                HardwarePeakWithTrip = Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.HardwarePeakTestWithTrip],
                HardwareCancel = Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.HardwareTestCancel],
                SoftwareCancel = Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.SoftwareTestCancel],
                TestResults = Program.connectedDevice.remoteControlDict[(int)PdDeviceInfo.RemoteControl.SI_Results],
                
            };

            peakNoTripButton.Visible = true;
            peakWithTripButton.Visible = true;

            SetSiTypeParameterGroups();
        }

        public void BindAsTokyo()
        {
            csifButton.paramGroup = Program.connectedDevice.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.Cal_SI_ScaleFactor];
            bccButton.paramGroup = Program.connectedDevice.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.Cal_SI_BaseCount];
            dccButton.paramGroup = Program.connectedDevice.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.Cal_SI_CoilOpen];

            dccButton.Text = "Open Coil Calibration";

            siGroup = new ActiveSecondaryInjectionGroups()
            {
                SoftwareRmsNoTrip = Program.connectedDevice.remoteControlDict[(int)TokyoDeviceInfo.RemoteControl.SoftwareTestNoTri],
                SoftwareRmsWithTrip = Program.connectedDevice.remoteControlDict[(int)TokyoDeviceInfo.RemoteControl.SoftwareTestWithTrip],
                HardwareRmsNoTrip = Program.connectedDevice.remoteControlDict[(int)TokyoDeviceInfo.RemoteControl.HardwareTestNoTrip],
                HardwareRmsWithTrip = Program.connectedDevice.remoteControlDict[(int)TokyoDeviceInfo.RemoteControl.HardwareTestWithTrip],
                HardwareCancel = Program.connectedDevice.remoteControlDict[(int)TokyoDeviceInfo.RemoteControl.HardwareTestCancel],
                SoftwareCancel = Program.connectedDevice.remoteControlDict[(int)TokyoDeviceInfo.RemoteControl.SoftwareTestCancel],
                TestResults = Program.connectedDevice.remoteControlDict[(int)TokyoDeviceInfo.RemoteControl.SI_Results],

            };

            peakNoTripButton.Visible = false;
            peakWithTripButton.Visible = false;

            SetSiTypeParameterGroups();
        }

        #endregion __Setup Device Type__

        #region Control SI
        private void ToggleTestState(bool doEnable)
        {
            foreach (Control c in siTypeGroupbox.Controls)
            {
                c.Enabled = doEnable;
            }

            foreach (Control c in phaseGroupBox.Controls)
            {
                c.Enabled = doEnable;
            }

            rmsNoTripButton.Enabled = doEnable;
            rmsWithTripButton.Enabled = doEnable;
            peakNoTripButton.Enabled = doEnable;
            peakWithTripButton.Enabled = doEnable;
        }

        

        private async void rmsWithTripButton_Click(object sender, EventArgs e)
        {
            rmsWithTripButton.WorkStart();
            ToggleTestState(false);
            EtuResponse response = await StartSecondaryInjectionTest(_rmsWithTripPG, PhaseChar, currentEntry.Text, postTestDel);
            rmsWithTripButton.ParseBool(response.goodResponse);
        }

        private async void rmsNoTripButton_Click(object sender, EventArgs e)
        {
            rmsNoTripButton.WorkStart();
            ToggleTestState(false);
            EtuResponse response = await StartSecondaryInjectionTest(_rmsNoTripPG, PhaseChar, currentEntry.Text, postTestDel);
            rmsNoTripButton.ParseBool(response.goodResponse);
        }

        private async void peakWithTripButton_Click(object sender, EventArgs e)
        {
            peakWithTripButton.WorkStart();
            ToggleTestState(false);
            EtuResponse response = await StartSecondaryInjectionTest(_peakWithTripPG, PhaseChar, currentEntry.Text, postTestDel);
            peakWithTripButton.ParseBool(response.goodResponse);
        }

        private async void peakNoTripButton_Click(object sender, EventArgs e)
        {
            peakNoTripButton.WorkStart();
            ToggleTestState(false);
            EtuResponse response = await StartSecondaryInjectionTest(_peakNoTripPG, PhaseChar, currentEntry.Text, postTestDel);
            peakNoTripButton.ParseBool(response.goodResponse);
        }

        private async void cancelTestButton_Click(object sender, EventArgs e)
        {
            cancelTestButton.WorkStart();
            EtuResponse response = await MainForm.instance.device.AsyncTransaction(_cancelTestPG.ActionCheckRequest());
            cancelTestButton.ParseBool(response.goodResponse);
        }

        /// <summary>
        /// Will convert phaseChar and injectionValue to bytes and send the request to start SI
        /// </summary>
        /// <param name="phaseChar"></param>
        /// <param name="injectionValue"></param>
        /// <returns></returns>
        public async Task<EtuResponse> StartSecondaryInjectionTest(ParameterGroup pg ,char phaseChar, string injectionValue, PostTestCallBack callBack = null)
        {
            string phaseByte = "0";

            int targetCurrent = 0;
            try
            {
                targetCurrent = int.Parse(injectionValue);
            }
            catch
            {
                MessageBox.Show("Input value must be an integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return EtuResponse.FromBadRequest(new EtuRequest());
            }

            string siType = "?";
            if (pg.description.StartsWith("Hardware")) siType = "Hardware";
            else if (pg.description.StartsWith("Software")) siType = "Software";

            bool withTrip = pg.description.EndsWith("With Trip");

            string waveType = "RMS"; // Tokyo does not have peak trip and Peak and RMS will not be in description. Assume RMS is Peak is not found in description
            if (pg.description.Contains("Peak")) waveType = "Peak";

            switch (char.ToUpper(phaseChar))
            {
                case 'A':
                    phaseByte = "1";
                    break;
                case 'B':
                    phaseByte = "2";
                    break;
                case 'C':
                    phaseByte = "3";
                    break;
                case 'N':
                    phaseByte = "4";
                    break;
                case 'G':
                    phaseByte = "5";
                    break;
                default:
                    return EtuResponse.FromBadRequest(new EtuRequest());
            }

            EtuRequest request = pg.ActionCheckRequest(new string[] {"0", phaseByte, injectionValue });

            EtuResponse response = await MainForm.instance.device.AsyncTransaction(request);

            callBack?.Invoke(siType, waveType, withTrip, char.ToUpper(phaseChar), targetCurrent, response);

            return response;
        }
        
        private async Task ReadPostTripData(string siType, string waveType, bool withTrip, char phaseChar, int targetCurrent, EtuResponse testResponse)
        {
            ToggleTestState(true);
            if (!testResponse.goodResponse)
            {
                return; // TODO - Add something to give feedback that the test failed. 
            }

            EtuRequest request = siGroup.TestResults.ReadRequest();
            EtuResponse response = await MainForm.instance.device.AsyncTransaction(request);

            if (response.goodResponse)
            {
                string[] values = response.Values;

                currentLabel.Text = values[4];
                primaryLabel.Text = values[1];
                secondaryLabel.Text = values[2];
                causeLabel.Text = values[3];
                timeLabel.Text = values[0];

                StasaLibrary.DataFrames.SiTestInfo siTestInfo = new StasaLibrary.DataFrames.SiTestInfo(
                        siType, waveType, withTrip, targetCurrent, double.Parse(values[4]), int.Parse(values[0]), values[1], values[2], values[3]);
                resultHistoryList.Add(siTestInfo);
            }


        }
        #endregion __SI Control__

        private void SetSiTypeParameterGroups()
        {
            if (simulatedRadiobutton.Checked)
            {
                _rmsWithTripPG = siGroup.SoftwareRmsWithTrip;
                _rmsNoTripPG = siGroup.SoftwareRmsNoTrip;
                _peakWithTripPG = siGroup.SoftwarePeakWithTrip;
                _peakNoTripPG = siGroup.SoftwarePeakNoTrip;
                _cancelTestPG = siGroup.SoftwareCancel;
            }
            else
            {
                _rmsWithTripPG = siGroup.HardwareRmsWithTrip;
                _rmsNoTripPG = siGroup.HardwareRmsNoTrip;
                _peakWithTripPG = siGroup.HardwarePeakWithTrip;
                _peakNoTripPG = siGroup.HardwarePeakNoTrip;
                _cancelTestPG = siGroup.HardwareCancel;
            }
        }

        private void hardwareRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            SetSiTypeParameterGroups();
        }

        private void simulatedRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            SetSiTypeParameterGroups();
        }
    }

    public class ActiveSecondaryInjectionGroups
    {
        public ParameterGroup SoftwareRmsNoTrip { get; set; }
        public ParameterGroup SoftwareRmsWithTrip { get; set; }
        public ParameterGroup SoftwarePeakNoTrip { get; set; }
        public ParameterGroup SoftwarePeakWithTrip { get; set; }
        public ParameterGroup HardwareRmsNoTrip { get; set; }
        public ParameterGroup HardwareRmsWithTrip { get; set; }
        public ParameterGroup HardwarePeakNoTrip { get; set; }
        public ParameterGroup HardwarePeakWithTrip { get; set; }
        public ParameterGroup HardwareCancel { get; set; }
        public ParameterGroup SoftwareCancel { get; set; }
        public ParameterGroup TestResults { get; set; }
    }
}

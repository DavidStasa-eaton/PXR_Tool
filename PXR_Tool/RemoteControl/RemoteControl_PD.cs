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

namespace PXR_Tool.RemoteControl
{
    public partial class RemoteControl_PD : UserControl, IDeviceControlFrame
    {
        public DeviceInfo deviceInfo { get; set; } = DeviceDiscovery.GetDevice(DeviceDiscovery.DeviceType.PdPxr25);

        public RemoteControl_PD()
        {
            InitializeComponent();
        }

        public void InitButtons()
        {
            foreach (Control c in resetFunctionGroupbox.Controls)
            {
                ((StasaLibrary.DataFrames.ControlButton)c).BindDevice(MainForm.instance.device);
                
            }
            foreach (Control c in resetIntGroupBox.Controls)
            {
                ((StasaLibrary.DataFrames.ControlButton)c).BindDevice(MainForm.instance.device);

            }
            foreach (Control c in resetExtGroupBox.Controls)
            {
                ((StasaLibrary.DataFrames.ControlButton)c).BindDevice(MainForm.instance.device);

            }
            foreach (Control c in armsGroupBox.Controls)
            {
                ((StasaLibrary.DataFrames.ControlButton)c).BindDevice(MainForm.instance.device);

            }

            resetEtuButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetTripUnit);
            resetAllMinMaxButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetAllMinMax);
            resetMinMaxCurrentButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetCurrentMinMax);
            resetMinMaxLlVoltageButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetVllMinMax);
            resetMinMaxLnVoltageButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetVlnMinMax);
            resetEnergyButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetAccumulatedEnergy);
            resetPowerUpButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetPowerUpFlag);
            resetPeakPowerDemandButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetPeakPowerDemand);
            resetPeakCurrentDemandButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetCurrentDemand);

            intResetAllButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetDiagInt);
            intResetTripCountersButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetIntTripCounters);
            intResetOperationsButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetIntOperations);
            intResetMaxTemperatureButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetIntTemperature);
            intResetRunTimeButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetIntRunTime);

            extResetAllButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetDiagExt);
            extResetTripCountersButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetExtTripCounters);
            extResetOperationsButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetExtOperations);
            extResetMaxTemperatureButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetExtTemperature);
            extResetRunTimeButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ResetExtRunTime);

            enableArmsButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.EnableMaintenanceMode);
            disableArmsButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.DisableMaintenanceMode);

            openBreakerButton.BindDevice(MainForm.instance.device);
            openBreakerButton.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.OpenBreaker);

            dateTimeFrame.BindDevice(MainForm.instance.device);
            dateTimeFrame.paramGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.ReadTime);
            dateTimeFrame.writeParamGroup = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.WriteTime);

        }

        private void RemoteControl_PD_Load(object sender, EventArgs e)
        {

        }

        #region Relays
        private async void closeRelayOneButton_Click(object sender, EventArgs e)
        {
            closeRelayOneButton.WorkStart();
            EtuResponse response = await ChangeRelayState(1, 1);
            closeRelayOneButton.ParseBool(response.goodResponse);
        }
        private async void openRelayOneButton_Click(object sender, EventArgs e)
        {
            openRelayOneButton.WorkStart();
            EtuResponse response = await ChangeRelayState(2, 1);
            openRelayOneButton.ParseBool(response.goodResponse);
        }

        private async void closeRelayTwoButton_Click(object sender, EventArgs e)
        {
            closeRelayTwoButton.WorkStart();
            EtuResponse response = await ChangeRelayState(1, 2);
            closeRelayTwoButton.ParseBool(response.goodResponse);
        }
        private async void openRelayTwoButton_Click(object sender, EventArgs e)
        {
            openRelayTwoButton.WorkStart();
            EtuResponse response = await ChangeRelayState(2, 2);
            openRelayTwoButton.ParseBool(response.goodResponse);
        }

        private async void closeRelayThreeButton_Click(object sender, EventArgs e)
        {
            closeRelayThreeButton.WorkStart();
            EtuResponse response = await ChangeRelayState(1, 3);
            closeRelayThreeButton.ParseBool(response.goodResponse);
        }
        private async void openRelayThreeButton_Click(object sender, EventArgs e)
        {
            openRelayThreeButton.WorkStart();
            EtuResponse response = await ChangeRelayState(2, 3);
            openRelayThreeButton.ParseBool(response.goodResponse);
        }

        /// <summary>
        /// Send request to open or close a relay
        /// </summary>
        /// <param name="newState">1 = Close ::: 2 = Open</param>
        /// <param name="relayNumber">1, 2, or 3</param>
        /// <returns></returns>
        private async Task<EtuResponse> ChangeRelayState(int newState, int relayNumber)
        {
            ParameterGroup pg = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.RelayOutput);

            EtuRequest request = pg.ActionCheckRequest(new string[] {"0", newState.ToString(), relayNumber.ToString() });

            return await MainForm.instance.device.AsyncTransaction(request);
        }
        #endregion __Relays__

        private async void readFirmwareButton_Click(object sender, EventArgs e)
        {
            readFirmwareButton.WorkStart();
            EtuRequest request = deviceInfo.firmwareVersionPG.ReadRequest();

            EtuResponse response = await MainForm.instance.device.AsyncTransaction(request);

            if (response.goodResponse)
            {
                string[] values = response.Values;
                mcu1Label.Text = $"{values[0]}.{values[1]}.{values[2]}";
                mcu2Label.Text = $"{values[3]}.{values[4]}.{values[5]}";
                usbVersionLabel.Text = $"{values[6]}.{values[7]}";
            }

            readFirmwareButton.ParseBool(response.goodResponse);


        }

        private void openCoilBitParameterFrame_Paint(object sender, PaintEventArgs e)
        {
            openCoilBitParameterFrame.PopulateControl(deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.CoilOpenDetection));
        }

        private async void openCoilDetectionButton_Click(object sender, EventArgs e)
        {
            openCoilDetectionButton.WorkStart();
            EtuRequest request = deviceInfo.GetRemotePG(PdDeviceInfo.RemoteControl.CoilOpenDetection).ActionCheckRequest();

            EtuResponse response = await MainForm.instance.device.AsyncTransaction(request);

            if (response.goodResponse)
            {
                openCoilBitParameterFrame.UpdateValues(response.Values);
            }

            openCoilDetectionButton.ParseBool(response.goodResponse);
        }
    }
}

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
    public partial class RemoteControl_PD : UserControl, IRemoteControl
    {
        public RemoteControl_PD()
        {
            InitializeComponent();
        }

        public void InitButtons()
        {
            DeviceInfo di = DeviceDiscovery.GetDevice(DeviceDiscovery.DeviceType.PdPxr25);
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

            foreach (Control c in relayGroupBox.Controls)
            {
                ((StasaLibrary.DataFrames.ControlButton)c).BindDevice(MainForm.instance.device);

            }

            resetEtuButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetTripUnit);
            resetAllMinMaxButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetAllMinMax);
            resetMinMaxCurrentButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetCurrentMinMax);
            resetMinMaxLlVoltageButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetVllMinMax);
            resetMinMaxLnVoltageButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetVlnMinMax);
            resetEnergyButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetAccumulatedEnergy);
            resetPowerUpButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetPowerUpFlag);
            resetPeakPowerDemandButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetPeakPowerDemand);
            resetPeakCurrentDemandButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetCurrentDemand);

            intResetAllButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetDiagInt);
            intResetTripCountersButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetIntTripCounters);
            intResetOperationsButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetIntOperations);
            intResetMaxTemperatureButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetIntTemperature);
            intResetRunTimeButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetIntRunTime);

            extResetAllButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetDiagExt);
            extResetTripCountersButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetExtTripCounters);
            extResetOperationsButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetExtOperations);
            extResetMaxTemperatureButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetExtTemperature);
            extResetRunTimeButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetExtRunTime);

            enableArmsButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.EnableMaintenanceMode);
            disableArmsButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.DisableMaintenanceMode);

            openBreakerButton.BindDevice(MainForm.instance.device);
            openBreakerButton.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.OpenBreaker);

            dateTimeFrame.BindDevice(MainForm.instance.device);
            dateTimeFrame.paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ReadTime);
            dateTimeFrame.writeParamGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.WriteTime);
        }

        private void RemoteControl_PD_Load(object sender, EventArgs e)
        {

        }
    }
}

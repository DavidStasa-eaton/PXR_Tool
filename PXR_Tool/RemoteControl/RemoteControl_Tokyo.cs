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
    public partial class RemoteControl_Tokyo : UserControl, IDeviceControlFrame
    {
        public DeviceInfo deviceInfo { get; set; } = DeviceDiscovery.GetDevice(DeviceDiscovery.DeviceType.Tokyo);

        public RemoteControl_Tokyo()
        {
            InitializeComponent();
        }

        public void InitButtons()
        {
            foreach (Control c in resetFunctionGroupbox.Controls)
            {
                ((StasaLibrary.DataFrames.ControlButton)c).BindDevice(MainForm.instance.device);

            }

            resetEtuButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetTripUnit);
            resetAllMinMaxButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetAllMinMax);
            resetMinMaxCurrentButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetCurrentMinMax);
            resetMinMaxLlVoltageButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetVllMinMax);
            resetMinMaxLnVoltageButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetVlnMinMax);
            resetEnergyButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetAccumulatedEnergy);
            resetPeakPowerDemandButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetPeakPowerDemand);

            resetOperationsButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetOperations);
            resetExternalDiagsButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetDiagExt);
            resetInternalDiagsButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetDiagInt);
            resetRunTimeButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetRunTime);
            resetTripCountersButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ResetTripCounters);

            openBreakerButton.BindDevice(MainForm.instance.device);
            openBreakerButton.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.OpenBreaker);

            dateTimeFrame.BindDevice(MainForm.instance.device);
            dateTimeFrame.paramGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.ReadTime);
            dateTimeFrame.writeParamGroup = deviceInfo.GetRemotePG(TokyoDeviceInfo.RemoteControl.WriteTime);

        }
    }

    
}

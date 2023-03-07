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
        private DeviceDiscovery.DeviceType _currentType = DeviceDiscovery.DeviceType.None;

        public SecondaryInjectionFrame()
        {
            InitializeComponent();

            Program.DeviceChangedEvent += Program_DeviceChangedEvent;
        }

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

            peakNoTripButton.Visible = true;
            peakWithTripButton.Visible = true;
        }

        public void BindAsTokyo()
        {
            csifButton.paramGroup = Program.connectedDevice.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.Cal_SI_ScaleFactor];
            bccButton.paramGroup = Program.connectedDevice.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.Cal_SI_BaseCount];
            dccButton.paramGroup = Program.connectedDevice.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.Cal_SI_CoilOpen];

            dccButton.Text = "Open Coil Calibration";

            peakNoTripButton.Visible = false;
            peakWithTripButton.Visible = false;
        }
    }
}

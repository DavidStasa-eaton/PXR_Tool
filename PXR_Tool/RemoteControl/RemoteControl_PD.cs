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
                ((StasaLibrary.DataFrames.ControlButton)c).etuDevice = MainForm.instance.device;
                ((StasaLibrary.DataFrames.ControlButton)c).paramGroup = di.GetRemotePG(PdDeviceInfo.RemoteControl.ResetTripUnit);
            }
        }

        private void RemoteControl_PD_Load(object sender, EventArgs e)
        {

        }
    }
}

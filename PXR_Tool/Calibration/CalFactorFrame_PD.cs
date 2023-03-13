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

namespace PXR_Tool.Calibration
{
    public partial class CalFactorFrame_PD : UserControl, IDeviceControlFrame
    {
        public DeviceInfo deviceInfo { get; set; } = DeviceDiscovery.GetDevice(DeviceDiscovery.DeviceType.PdPxr25);

        private TextBox[] internalCalFactorTextboxes;

        public CalFactorFrame_PD()
        {
            InitializeComponent();

            intCalFactorsPG.UpdateParmeterGroup(deviceInfo.calFactorDict[(int)PdDeviceInfo.Calibration.RW_IntCurrentFactors]);

            int index = 0;
            internalCalFactorTextboxes = new TextBox[12];
            foreach (Control c in intCalFactorsTL.Controls)
            {
                if (c is TextBox)
                {
                    internalCalFactorTextboxes[index] = (TextBox)c;
                    index++;
                }
            }
        }

        private void intCalFactorsPG_PostReadEvent(object sender, PostTransactionEventArgs e)
        {
            EtuResponse response = e.response;

            if (response.goodResponse)
            {
                string[] values = response.Values;
                internalCalFactorTextboxes[0].Text = values[0];
                internalCalFactorTextboxes[1].Text = values[1];
                internalCalFactorTextboxes[2].Text = values[2];
                internalCalFactorTextboxes[3].Text = values[3];
                internalCalFactorTextboxes[4].Text = values[4];
                internalCalFactorTextboxes[5].Text = values[5];

                internalCalFactorTextboxes[6].Text = values[12];
                internalCalFactorTextboxes[7].Text = values[13];
                internalCalFactorTextboxes[8].Text = values[14];
                internalCalFactorTextboxes[9].Text = values[15];
                internalCalFactorTextboxes[10].Text = values[16];
                internalCalFactorTextboxes[11].Text = values[17];
            }
            

        }

        public void UpdateButtons()
        {

        }

        public void InitButtons()
        {

        }
    }
}

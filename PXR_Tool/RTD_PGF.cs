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
    public partial class RTD_PGF : ParameterGroupFrame
    {

        public RTD_PGF()
        {
            InitializeComponent();
            IsReadOnly = true;

            CheckIfDesignMode();

            SizeAltered += RTD_PGF_SizeAltered;
            Program.DeviceChangedEvent += Program_DeviceChangedEvent;

            
        }

        private void RTD_PGF_SizeAltered(object sender, SizeChangeEventArgs e)
        {
            keyValuesDGV.Location = new Point(e.x, e.y);
            keyValuesDGV.Size = new Size(e.width, e.height);
        }

        private void Program_DeviceChangedEvent(BroadDeviceChangedEventArgs obj)
        {
            UpdateParmeterGroup();
        }

        public override void UpdateParmeterGroup()
        {
            //base.BufferByteUpdated();

            DeviceInfo di = GetDeviceInfo(_isInDesignMode);
            if (di == null)
            {
                groupBox.Text = "Null Info";
                return;
            }

            try
            {
                _pGroup = di.rtdDict[BufferByte];
            }
            catch (KeyNotFoundException)
            {
                Enabled = false;
                return;
            }
            

            groupBox.Text = $"RTD {_pGroup.bufferByte}: {_pGroup.description}";

            Size s = keyValuesDGV.PopulateControl(_pGroup);

            AutoHeight(s.Height + keyValuesDGV.Location.Y);
        }

        private async void readButton_Click(object sender, EventArgs e)
        {
            if (_pGroup == null) return;
            readButton.WorkStart();

            EtuRequest req = _pGroup.ReadRequest();
            EtuResponse response = await MainForm.instance.AsyncTransaction(req);
            if (response.goodResponse)
            {
                string[] values = response.Values;

                keyValuesDGV.UpdateValues(values);
            }

            readButton.ParseBool(response.goodResponse);
        }
    }
}

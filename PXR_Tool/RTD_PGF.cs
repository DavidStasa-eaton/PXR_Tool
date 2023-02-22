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
            rtdDGV.Location = new Point(e.x, e.y);
            rtdDGV.Size = new Size(e.width, e.height);
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

            rtdDGV.Rows.Clear();

            int height = 20;
            foreach (UniParameter p in _pGroup.parameters)
            {
                int index = rtdDGV.Rows.Add();

                rtdDGV.Rows[index].Cells[0].Value = p.pName;
                rtdDGV.Rows[index].Cells[1].Value = "-";

                height += rtdDGV.Rows[index].Height;
            }

            AutoHeight(height);
        }

        private async void readButton_Click(object sender, EventArgs e)
        {
            if (_pGroup == null) return;
            readButton.WorkStart();

            UniRequest req = _pGroup.ReadRequest();
            UniResponse response = await MainForm.instance.AsyncTransaction(req);
            if (response.goodResponse)
            {
                string[] values = response.Values;

                if (values.Length < rtdDGV.Rows.Count) // More values than rows
                {
                    foreach (DataGridViewRow dgvr in rtdDGV.Rows)
                    {
                        dgvr.Cells[1].Value = "Length Error";
                    }
                }
                else
                {
                    for (int i = 0; i < rtdDGV.Rows.Count; i++)
                    {
                        rtdDGV.Rows[i].Cells[1].Value = values[i];
                    }
                }
            }

            readButton.ParseBool(response.goodResponse);
        }
    }
}

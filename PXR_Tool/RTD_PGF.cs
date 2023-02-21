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

            SizeAltered += RTD_PGF_SizeAltered;
        }

        private void RTD_PGF_SizeAltered(object sender, SizeChangeEventArgs e)
        {
            rtdDGV.Location = new Point(e.x, e.y);
            rtdDGV.Size = new Size(e.width, e.height);
        }

        public override void UpdateParmeterGroup()
        {
            //base.BufferByteUpdated();

            // Check if there is a connected device and that the RTD contains the buffer byte
            if (MainForm.instance == null) return;
            if (MainForm.instance.connectedDevice == null) return;
            if (!MainForm.instance.connectedDevice.rtdDict.ContainsKey(BufferByte)) return;

            _pGroup = MainForm.instance.connectedDevice.rtdDict[BufferByte];

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

            UniRequest req = _pGroup.ReadRequest();
            UniResponse response = await MainForm.instance.AsyncTransaction(req);
        }
    }
}

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

    public partial class SP_PGF : ParameterGroupFrame
    {
        private bool _isVertical = false;

        private uint _rows = 0;
        public uint Rows { get { return _rows; }
            set
            {
                _rows = value;
                lvFrame.Rows = _rows;
                
                
            }
        }

        private uint _columns = 0;
        public uint Column
        {
            get { return _columns; }
            set
            {
                _columns = value;
                lvFrame.Columns = _columns;
            }
        }

        private uint _splitIndex = 0;
        public uint SplitIndex
        {
            get { return _splitIndex; }
            set
            {
                _splitIndex = value;
                lvFrame.SplitIndex = _splitIndex;
            }
        }

        public SP_PGF()
        {
            InitializeComponent();

            CheckIfDesignMode();

            SizeAltered += SP_PGF_SizeAltered;
            Program.DeviceChangedEvent += Program_DeviceChangedEvent;
        }

        private void Program_DeviceChangedEvent(BroadDeviceChangedEventArgs obj)
        {
            UpdateParmeterGroup();
        }

        private void SP_PGF_SizeAltered(object sender, SizeChangeEventArgs e)
        {
            lvFrame.Location = new Point(e.x, e.y);
            lvFrame.Size = new Size(e.width, e.height);
        }

        public override void UpdateParmeterGroup()
        {
            DeviceInfo di = GetDeviceInfo(_isInDesignMode);
            if (di == null)
            {
                groupBox.Text = "Null Info";
                return;
            }

            try
            {
                _pGroup = di.spDict[BufferByte];
            }
            catch (KeyNotFoundException)
            {
                Enabled = false;
                return;
            }
            

            groupBox.Text = $"Group {_pGroup.bufferByte}: {_pGroup.description}";

            Size s = lvFrame.PopulateControl(_pGroup);
            AdjustSize(new Size(s.Width + 10, s.Height + lvFrame.Location.Y + 5));
        }

        private async void readButton_Click(object sender, EventArgs e)
        {
            readButton.WorkStart();
            if (_pGroup == null) return;

            EtuRequest req = _pGroup.ReadRequest();
            EtuResponse response = await MainForm.instance.AsyncTransaction(req);

            if (response.goodResponse)
            {
                lvFrame.UpdateValues(response.Values);
            }

            readButton.ParseBool(response.goodResponse);
        }

        private void SP_PGF_Load(object sender, EventArgs e)
        {
            
        }

        private async void writeButton_Click(object sender, EventArgs e)
        {
            writeButton.WorkStart();
            if (_pGroup == null) return;

            string[] values = lvFrame.GetValues();

            EtuRequest req = _pGroup.WriteRequest(values);
            EtuResponse response = await MainForm.instance.AsyncTransaction(req);

            writeButton.ParseBool(response.goodResponse);
        }
    }
}

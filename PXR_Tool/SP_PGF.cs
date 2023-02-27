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

        // Rows is the last thing to be set (based on testing)
        // Do not want pack cells mutliple times on startup
        // This flag will prevent cells from paking until all props are set. 
        private bool _allSet = false;  

        private int _rows = 0;
        public int Rows { get { return _rows; }
            set
            {
                _rows = value;
                _allSet = true;
                if (value > 0)
                {
                    _isVertical = false;
                    PackCells();
                }
                
                
            }
        }

        private int _columns = 0;
        public int Column
        {
            get { return _columns; }
            set
            {
                _columns = value;
                if (value > 0)
                {
                    _isVertical = true;
                    _rows = 0;
                    PackCells();
                }
            }
        }

        private int longestLabel = 0;

        private List<LabeledCell> cells;

        private Point _packCellPosition = new Point(3, 3);

        public SP_PGF()
        {
            InitializeComponent();

            CheckIfDesignMode();
            cells = new List<LabeledCell>();

            SizeAltered += SP_PGF_SizeAltered;
            Program.DeviceChangedEvent += Program_DeviceChangedEvent;
        }

        private void Program_DeviceChangedEvent(BroadDeviceChangedEventArgs obj)
        {
            UpdateParmeterGroup();
        }

        private void SP_PGF_SizeAltered(object sender, SizeChangeEventArgs e)
        {
            packPanel.Location = new Point(e.x, e.y);
            packPanel.Size = new Size(e.width, e.height);
        }

        /// <summary>
        /// Remove cells from control
        /// </summary>
        private void UnpackCells()
        {
            foreach (LabeledCell lc in cells)
            {
                packPanel.Controls.Remove(lc);
            }
            _packCellPosition = new Point(3, 3);
        }

        /// <summary>
        /// Creates controls to pack
        /// </summary>
        private void UpdateCells()
        {
            if (cells.Count > 0)
                cells.Clear();

            int index = 0;

            longestLabel = 0;
            foreach (EtuParameter p in _pGroup.parameters)
            {
                cells.Add(new LabeledCell(p.pName, !_isVertical));

                if (cells[index].LabelWidth > longestLabel)
                    longestLabel = cells[index].LabelWidth;

                index++;
            }
        }

        /// <summary>
        /// Packs cells into control
        /// cells must be populated already.
        /// </summary>
        private void PackCells()
        {
            //if (!_allSet) return;

            if (_pGroup == null) return;

            PackVertical();
        }

        private void PackVertical()
        {
            if (_columns == 0) return;

            int splitIndex = (int)Math.Ceiling((double)cells.Count / _columns);

            int packCount = 0;
            int highest = 0;
            foreach (LabeledCell lc in cells)
            {
                lc.SetLabelWidth(longestLabel);

                lc.Location = _packCellPosition;
                packPanel.Controls.Add(lc);

                packCount++;
                if (packCount < splitIndex) // Remain in same column
                {
                    _packCellPosition = new Point(_packCellPosition.X, _packCellPosition.Y + lc.Height + 3); // keep x pos. Add height of control + padding to next control.
                    
                }
                else
                {
                    if (highest < _packCellPosition.Y) highest = _packCellPosition.Y + lc.Height + 3;
                    _packCellPosition = new Point(_packCellPosition.X + lc.Width + 20, 3); // Reset Y position. Add longest to to X pos
                    packCount = 0;
                }
            }
            AdjustSize(_columns * cells[0].Width + _columns * 20, highest + packPanel.Location.Y);
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

            UnpackCells();
            UpdateCells();
            PackCells();
        }

        private async void readButton_Click(object sender, EventArgs e)
        {
            readButton.WorkStart();
            if (_pGroup == null) return;

            EtuRequest req = _pGroup.ReadRequest();
            EtuResponse response = await MainForm.instance.AsyncTransaction(req);

            if (response.goodResponse)
            {
                string[] values = response.Values;

                if (values.Length != cells.Count)
                {
                    // Display error
                    return;
                }

                for (int i = 0; i < cells.Count; i++)
                {
                    cells[i].Set(values[i]);
                }
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

            string[] values = new string[_pGroup.parameters.Length];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = cells[i].Value;
            }

            EtuRequest req = _pGroup.WriteRequest(values);
            EtuResponse response = await MainForm.instance.AsyncTransaction(req);

            writeButton.ParseBool(response.goodResponse);
        }
    }
}

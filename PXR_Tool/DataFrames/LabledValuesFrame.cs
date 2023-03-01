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

namespace PXR_Tool.DataFrames
{
    public partial class LabledValuesFrame : UserControl, IDataFrame
    {
        private ParameterGroup _pg;
        public ParameterGroup paramGroup
        {
            get { return _pg; }
            set
            {
                _pg = value;
                if (_pg != null)
                    PopulateControl(_pg);
            }
        }

        private uint _rows = 0;
        public uint Rows
        {
            get { return _rows; }
            set
            {
                _rows = value;
                if (_rows > 0)
                    _columns = 0;

                if (_rows == 0 && _columns == 0)
                    _rows = 1;
                PackCells();
            }
        }

        private uint _columns = 0;
        public uint Columns
        {
            get { return _columns; }
            set
            {
                _columns = value;
                if (_columns > 0)
                    _rows = 0;

                if (_rows == 0 && _columns == 0)
                    _rows = 1;

                PackCells();
            }
        }

        private uint _splitIndex = 0;
        public uint SplitIndex
        {
            get { return _splitIndex; }
            set
            {
                _splitIndex = value;
                PackCells(); ;
            }
        }

        private int longestLabel = 0;
        private List<LabeledCell> cells;
        private Point _packCellPosition = new Point(3, 3);

        public int Count { get { return 0; } }

        public LabledValuesFrame()
        {
            InitializeComponent();
            cells = new List<LabeledCell>();
        }

        public void UpdateValues(string[] values)
        {
            if (values.Length == cells.Count)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    cells[i].Set(values[i]);
                }
            }
            else if (values.Length > cells.Count)
            {
                for (int i = 0; i < cells.Count; i++)
                {
                    cells[i].Set(values[i]);
                }
                MessageBox.Show($"Number of values ({values.Length}) cannot fit in this data grid ({cells.Count})", "Value Count Mismatch",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // More rows than values
            {
                int index = 0;
                for (int i = 0; i < values.Length; i++)
                {
                    cells[i].Set(values[i]);
                    index = i;
                }

                for (int j = index; j < cells.Count; j++)
                {
                    cells[j].Set("! No Data !");
                }
            }

        }

        public string[] GetValues()
        {
            string[] values = new string[cells.Count];
            
            for (int i = 0; i < values.Length; i++)
            {
                string val = cells[i].Value;
                if (string.IsNullOrEmpty(val))
                    val = "0";

                values[i] = val;
            }

            return values;
        }

        public Size PopulateControl(ParameterGroup pg)
        {
            _pg = pg;

            int height = 20;
            UpdateCells();

            Size s = PackCells();

            return s;
        }

        /// <summary>
        /// Remove cells from control
        /// </summary>
        private void UpdateCells()
        {
            if (_pg.parameters.Length < cells.Count) // remove extra cells
            {
                int indexToRemove = _pg.parameters.Length;
                int maxIndexToRemove = cells.Count - 1;

                while (maxIndexToRemove >= indexToRemove)
                {
                    Controls.RemoveAt(maxIndexToRemove);
                    cells.RemoveAt(maxIndexToRemove);
                    maxIndexToRemove--;
                }
                
            }
            while (_pg.parameters.Length > cells.Count)
            {
                int index = cells.Count;
                cells.Add(new LabeledCell());

                Controls.Add(cells[index]);
                index++;
            }

            longestLabel = 0;
            for (int i = 0; i < cells.Count; i++)
            {
                cells[i].SetLabel(_pg.parameters[i].pName);
                if (cells[i].LabelWidth > longestLabel)
                    longestLabel = cells[i].LabelWidth;
            }
        }

        public uint CalcSplitIndex()
        {
            if (_splitIndex == 0)
            {
                if (_columns > 0)
                    return (uint)Math.Ceiling((double)cells.Count / _columns);
                else
                    return (uint)Math.Ceiling((double)cells.Count / _rows);
            }
            return _splitIndex;
        }

        private Size PackCells()
        {
            Size frameSize = new Size();
            if (cells.Count == 0) return frameSize;


            // labels should already be included in cells variable. 
            

            frameSize.Width = cells[0].Width;

            uint activeSplitIndex = CalcSplitIndex();

            _packCellPosition = new Point(3, 3);

            int packCount = 0;

            int colCount = 1;
            foreach (LabeledCell lc in cells)
            {
                lc.SetLabelWidth(longestLabel);
                lc.Location = _packCellPosition;

                packCount++;
                if (packCount < activeSplitIndex)
                {
                    _packCellPosition = new Point(_packCellPosition.X, _packCellPosition.Y + lc.Height + 3); // keep x pos. Add height of control + padding to next control.

                    if (_packCellPosition.Y > frameSize.Height)
                        frameSize.Height = _packCellPosition.Y + lc.Height + 3;
                }
                else
                {
                    colCount++;
                    _packCellPosition = new Point(_packCellPosition.X + lc.Width + 20, 3); // Reset Y position. Add longest to to X pos
                    packCount = 0;
                }
            }

            //frameSize.Width = frameSize.Width * colCount;
            return PreferredSize;
            
        }

        private void LabledValuesFrame_Load(object sender, EventArgs e)
        {
            //DeviceInfo di = DeviceDiscovery.GetDevice(DeviceDiscovery.DeviceType.Pxr35);

            //PopulateControl(di.spDict[2]);
        }
    }
}

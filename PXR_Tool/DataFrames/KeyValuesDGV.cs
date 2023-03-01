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
    public partial class KeyValuesDGV : UserControl, IDataFrame
    {
        private ParameterGroup _pg;
        public ParameterGroup paramGroup { get { return _pg; }
            set
            {
                _pg = value;
                if (_pg != null)
                    PopulateControl(_pg);
            }     
        }

        public int Count { get { return dgv.Rows.Count; } }

        public DataGridView DGV { get { return dgv; } }

        public KeyValuesDGV()
        {
            InitializeComponent();
        }

        public void UpdateValues(string[] values)
        {
            if (values.Length == dgv.Rows.Count)
            {
                int i = 0;
                foreach (DataGridViewRow dgvr in dgv.Rows)
                {
                    dgvr.Cells[1].Value = values[i];
                    i++;
                }
            }
            else if (values.Length > dgv.Rows.Count)
            {
                int i = 0;
                foreach (DataGridViewRow dgvr in dgv.Rows)
                {
                    dgvr.Cells[1].Value = values[i];
                    i++;
                }
                MessageBox.Show($"Number of values ({values.Length}) cannot fit in this data grid ({dgv.Rows.Count})", "Value Count Mismatch",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // More rows than values
            {
                int i = 0;
                foreach (string val in values)
                {
                    dgv.Rows[i].Cells[1].Value = values[i];
                    i++;
                }

                for (int j=i; j < dgv.Rows.Count; j++)
                {
                    dgv.Rows[i].Cells[1].Value = "! No Data !";
                }
            }

            
        }

        public string[] GetValues()
        {
            string[] values = new string[dgv.Rows.Count];

            int i = 0;
            foreach (DataGridViewRow dgvr in dgv.Rows)
            {
                values[i] = dgvr.Cells[0].Value.ToString();
                i++;
            }
            return values;
        }

        public Size PopulateControl(ParameterGroup pg)
        {
            _pg = pg;

            dgv.Rows.Clear();
            int height = 20;
            foreach (EtuParameter p in pg.parameters)
            {
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = p.pName;
                dgv.Rows[index].Cells[1].Value = "-";

                height += dgv.Rows[index].Height;
            }

            return new Size(dgv.PreferredSize.Width, dgv.PreferredSize.Height - 25);
        }
    }
}

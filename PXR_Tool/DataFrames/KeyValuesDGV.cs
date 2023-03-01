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
        public ParameterGroup paramGroup { get; set; }

        public KeyValuesDGV()
        {
            InitializeComponent();
        }

        public void PackValues(string[] values)
        {
            if (values.Length == dgv.Rows.Count)
            {
                int i = 0;
                foreach (DataGridViewRow dgvr in dgv.Rows)
                {
                    dgvr.Cells[0].Value = values[i];
                    i++;
                }
            }
            else if (values.Length > dgv.Rows.Count)
            {
                int i = 0;
                foreach (DataGridViewRow dgvr in dgv.Rows)
                {
                    dgvr.Cells[0].Value = values[i];
                    i++;
                }
                MessageBox.Show($"Number of values ({values.Length}) cannot fit in this data grid ({dgv.Rows})", "Value Count Mismatch",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // More rows than values
            {
                int i = 0;
                foreach (string val in values)
                {
                    dgv.Rows[i].Cells[0].Value = values[i];
                    i++;
                }

                for (int j=i; j < dgv.Rows.Count; j++)
                {
                    dgv.Rows[i].Cells[0].Value = "! No Data !";
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

        public void PopulateControl(ParameterGroup pg)
        {
            paramGroup = pg;

            foreach (EtuParameter p in pg.parameters)
            {
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = p.pName;
                dgv.Rows[index].Cells[1].Value = "-";
            }
        }
    }
}

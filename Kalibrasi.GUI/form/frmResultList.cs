using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kalibrasi.form
{
    public partial class frmResultList : Form
    {
        public frmResultList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void frmResultList_Load(object sender, EventArgs e)
        {
            dgvResult.DataSource = Kalibrasi.global_variable.global.gdtALAT;             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kalibrasi.global_variable.global.gcSELECTEDVALUE = dgvResult.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kalibrasi
{
    public partial class mdiKalibrasi : Form
    {
        public mdiKalibrasi()
        {
            InitializeComponent();
        }

        private void mdiKalibrasi_Load(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close(); 
            }

            form.frmLogin frmLogin = new Kalibrasi.form.frmLogin();
            frmLogin.ShowDialog();
            toolStripLabel1.Text = " USER NAME : " + Kalibrasi.global_variable.global.gcUSERID;     
        }

        private void mnuKeluar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void mnuAlat_Click(object sender, EventArgs e)
        {
            form.frmAlat frmAlat = new Kalibrasi.form.frmAlat();
            frmAlat.MdiParent = this;
            frmAlat.Dock = DockStyle.Fill;  
            frmAlat.Show();  
        }

        private void mnuGantiUser_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            form.frmLogin frmLogin = new Kalibrasi.form.frmLogin();
            frmLogin.ShowDialog();
            toolStripLabel1.Text = " USER NAME : " + Kalibrasi.global_variable.global.gcUSERID;
        }

        private void mnuDepartemen_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            form.frmDepartemen frmDepartemen = new Kalibrasi.form.frmDepartemen();
            frmDepartemen.MdiParent = this;
            frmDepartemen.Dock = DockStyle.Fill;
            frmDepartemen.Show();
        }        
    }
}

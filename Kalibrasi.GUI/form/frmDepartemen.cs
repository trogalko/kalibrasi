using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Kalibrasi.Data;
using Kalibrasi.Data.CollectionClasses;
using Kalibrasi.Data.HelperClasses;
using Kalibrasi.Data.EntityClasses;
using Kalibrasi.Data.RelationClasses;
using Kalibrasi.Data.TypedViewClasses;
using Kalibrasi.Data.FactoryClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.form
{
    public partial class frmDepartemen : Form
    {
        public bool lAdd = false;

        public frmDepartemen()
        {
            InitializeComponent();
        }

        private void frmDepartemen_Load(object sender, EventArgs e)
        {
            refresh();             
            txtIdDepartemen.DataBindings.Add("Text", bsDepartemen, "CIdDept");
            txtNamaDepartemen.DataBindings.Add("Text", bsDepartemen, "CNamaDept");
        }

        private void refresh()
        {
            cmbCari.Items.Clear();
            cmbCari.Items.Add("By ID");
            cmbCari.Items.Add("By Nama");

            mDepartemen.GetMulti(null);
            Kalibrasi.global_variable.global.gentDEPARTEMEN = mDepartemen;
            bsDepartemen.DataSource = Kalibrasi.global_variable.global.gentDEPARTEMEN;
            bsDepartemen.MoveLast();
            bindingNavigator1.BindingSource = bsDepartemen;
        }

        private void cmdTop_Click(object sender, EventArgs e)
        {
            bsDepartemen.MoveFirst();
        }

        private void cmdPrevious_Click(object sender, EventArgs e)
        {
            bsDepartemen.MovePrevious();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            bsDepartemen.MoveNext();
        }

        private void cmdBottom_Click(object sender, EventArgs e)
        {
            bsDepartemen.MoveLast();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            cmdAdd.Enabled = false;
            cmdEdit.Enabled = false;
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;

            bsDepartemen.SuspendBinding();
            emptyText();
            enableText();

            lAdd = true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtIdDepartemen.Text == "" ||txtNamaDepartemen.Text == "")
            {
                MessageBox.Show("Harap isi semua isian");
                return;
            }
            if (lAdd)
            {
                try
                {
                    cmdAdd.Enabled = true;
                    cmdEdit.Enabled = true;
                    cmdSave.Enabled = false;
                    cmdCancel.Enabled = false;

                    MDepartementEntity md = new MDepartementEntity();
                    md.CIdDept = txtIdDepartemen.Text;
                    md.CNamaDept = txtNamaDepartemen.Text;
                    md.CUserId = global_variable.global.gcUSERID;

                    md.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    cmdAdd.Enabled = true;
                    cmdEdit.Enabled = true;
                    cmdSave.Enabled = false;
                    cmdCancel.Enabled = false;

                    MDepartementEntity md = new MDepartementEntity(txtIdDepartemen.Text);
                    md.CNamaDept = txtNamaDepartemen.Text;
                    md.CUserId = global_variable.global.gcUSERID;

                    md.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            mDepartemen.GetMulti(null);
            Kalibrasi.global_variable.global.gentDEPARTEMEN = mDepartemen;
            bsDepartemen.ResumeBinding();
            bsDepartemen.MoveLast();
            disableText();

            lAdd = false;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            cmdAdd.Enabled = true;
            cmdEdit.Enabled = true;
            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;

            emptyText();
            bsDepartemen.MoveFirst();
            bsDepartemen.ResumeBinding();
            disableText();

            lAdd = false;
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            lAdd = false;
            txtNamaDepartemen.Enabled = true;

            cmdAdd.Enabled = false;
            cmdEdit.Enabled = false;
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;
        }

        private void cmdCari_Click(object sender, EventArgs e)
        {
            DataTable dtAlat = new DataTable();
            DataColumn dcIdAlat;
            DataColumn dcNamaAlat;
            DataRow dr;

            dcIdAlat = new DataColumn();
            dcIdAlat.DataType = System.Type.GetType("System.String");
            dcIdAlat.ColumnName = "Id_Departemen";
            dcIdAlat.Caption = "ID DEPARTEMEN";
            dcIdAlat.AutoIncrement = false;
            dcIdAlat.ReadOnly = true;
            dcIdAlat.Unique = false;
            dcIdAlat.MaxLength = 5;

            dtAlat.Columns.Add(dcIdAlat);

            dcNamaAlat = new DataColumn();
            dcNamaAlat.DataType = System.Type.GetType("System.String");
            dcNamaAlat.ColumnName = "Nama_Departemen";
            dcNamaAlat.Caption = "NAMA DEPARTEMEN";
            dcNamaAlat.AutoIncrement = false;
            dcNamaAlat.ReadOnly = true;
            dcNamaAlat.Unique = false;
            dcNamaAlat.MaxLength = 30;

            dtAlat.Columns.Add(dcNamaAlat);


            if (cmbCari.Text.Length != 0)
            {
                if (cmbCari.Text == "By ID")
                {
                    foreach (MDepartementEntity MA in mDepartemen)
                    {
                        if (MA.CIdDept.Contains(txtCari.Text))
                        {
                            dr = dtAlat.NewRow();
                            dr["Id_Departemen"] = MA.CIdDept;
                            dr["Nama_Departemen"] = MA.CNamaDept;
                            dtAlat.Rows.Add(dr);
                        }
                    }
                }

                if (cmbCari.Text == "By Nama")
                {
                    foreach (MDepartementEntity MA in mDepartemen)
                    {
                        if (MA.CNamaDept.Contains(txtCari.Text))
                        {
                            dr = dtAlat.NewRow();
                            dr["Id_Departemen"] = MA.CIdDept;
                            dr["Nama_Departemen"] = MA.CNamaDept;
                            dtAlat.Rows.Add(dr);
                        }
                    }
                }
                if (cmbCari.Text == "")
                {
                    return;
                }
            }
            else
            {
                return;
            }
            if (dtAlat.Rows.Count > 0)
            {
                Kalibrasi.global_variable.global.gdtALAT = dtAlat;
            }
            else
            {
                return;
            }
            frmResultList frmResultList = new frmResultList();
            frmResultList.ShowDialog();
            bsDepartemen.MoveFirst();             
            while (txtIdDepartemen.Text != Kalibrasi.global_variable.global.gcSELECTEDVALUE)
            {
                bsDepartemen.MoveNext();
            }
        } 

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enableText()
        {
            txtIdDepartemen.Enabled = true;
            txtNamaDepartemen.Enabled = true;
        }

        private void disableText()
        {
            txtIdDepartemen.Enabled = false;
            txtNamaDepartemen.Enabled = false;
        }

        private void emptyText()
        {
            txtIdDepartemen.Text = "";
            txtNamaDepartemen.Text = "";
        }               
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading; 
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
    public partial class frmAlat : Form
    {
        public DataTable dtAlat;
        public bool lAdd = false;
        public frmAlat()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.MdiParent.Controls)
            {
                ctrl.Enabled = true;
            }
            this.Close();                        
        }

        private void frmAlat_Load(object sender, EventArgs e)
        {
            refresh();
            txtIdAlat.DataBindings.Add("text", bsAlat, "CIdAlat");
            txtNamaAlat.DataBindings.Add("text", bsAlat, "CNamaAlat");
            txtBatasToleransi.DataBindings.Add("text", bsAlat, "CBatasToleransi");
            txtInterval.DataBindings.Add("text", bsAlat, "NInterval");
            txtIntEks.DataBindings.Add("text", bsAlat, "NIntervalEks");
            chkInternal.DataBindings.Add("checked", bsAlat, "LJkInternal");
            chkExternal.DataBindings.Add("checked", bsAlat, "LJkEksternal");
            optAktif.DataBindings.Add("checked", bsAlat, "LStatusAlat");
            if (optAktif.Checked == false)
                optNonAktif.Checked = true;
        }

        private void refresh()
        {
            cmbCari.Items.Clear();
            cmbCari.Items.Add("By ID");
            cmbCari.Items.Add("By Nama");

            mAlat.GetMulti(null);            
            Kalibrasi.global_variable.global.gentMAlat = mAlat;       
            bsAlat.DataSource = Kalibrasi.global_variable.global.gentMAlat;              
            bsAlat.MoveLast();  
            bindingNavigator1.BindingSource = bsAlat;             
        }

        private void cmdTop_Click(object sender, EventArgs e)
        {
            bsAlat.MoveFirst();
            if (optAktif.Checked == false)
                optNonAktif.Checked = true;  
        }

        private void cmdPrevious_Click(object sender, EventArgs e)
        {
            bsAlat.MovePrevious();
            if (optAktif.Checked == false)
                optNonAktif.Checked = true;
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            bsAlat.MoveNext();
            if (optAktif.Checked == false)
                optNonAktif.Checked = true;
        }

        private void cmdBottom_Click(object sender, EventArgs e)
        {
            bsAlat.MoveLast();
            if (optAktif.Checked == false)
                optNonAktif.Checked = true;
        }

        private void cmdCari_Click(object sender, EventArgs e)
        {
            DataTable dtAlat = new DataTable();
            DataColumn dcIdAlat;
            DataColumn dcNamaAlat;
            DataRow dr;            
            
            dcIdAlat = new DataColumn();
            dcIdAlat.DataType = System.Type.GetType("System.String");
            dcIdAlat.ColumnName = "Id_Alat";
            dcIdAlat.Caption = "ID ALAT";
            dcIdAlat.AutoIncrement = false;
            dcIdAlat.ReadOnly = true;
            dcIdAlat.Unique = false;
            dcIdAlat.MaxLength = 20;

            dtAlat.Columns.Add(dcIdAlat);

            dcNamaAlat = new DataColumn();
            dcNamaAlat.DataType = System.Type.GetType("System.String");
            dcNamaAlat.ColumnName = "Nama_Alat";
            dcNamaAlat.Caption = "NAMA ALAT";
            dcNamaAlat.AutoIncrement = false;
            dcNamaAlat.ReadOnly = true;
            dcNamaAlat.Unique = false;
            dcNamaAlat.MaxLength = 100;

            dtAlat.Columns.Add(dcNamaAlat);


            if (cmbCari.Text.Length != 0)
            {
                if (cmbCari.Text == "By ID")
                {
                    foreach (MAlatEntity MA in mAlat)
                    {
                        if (MA.CIdAlat.Contains(txtCari.Text))
                        {
                            dr = dtAlat.NewRow();
                            dr["Id_Alat"] = MA.CIdAlat;
                            dr["Nama_Alat"] = MA.CNamaAlat;
                            dtAlat.Rows.Add(dr);
                        }
                    }
                }

                if (cmbCari.Text == "By Nama")
                {
                    foreach (MAlatEntity MA in mAlat)
                    {
                        if (MA.CNamaAlat.Contains(txtCari.Text))
                        {
                            dr = dtAlat.NewRow();
                            dr["Id_Alat"] = MA.CIdAlat;
                            dr["Nama_Alat"] = MA.CNamaAlat;
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
            bsAlat.MoveFirst();
            while (txtIdAlat.Text != Kalibrasi.global_variable.global.gcSELECTEDVALUE)
            {
                bsAlat.MoveNext();
            }                     
        }

        public DataTable CollectionToDataTable<TEntity>(EntityCollectionBase<TEntity> collection, string TableName)
        where TEntity : EntityBase, IEntity
        {
            List<IEntityPropertyProjector> propertyProjectors =
                EntityFields.ConvertToProjectors(collection.EntityFactoryToUse.CreateFields());
            DataTable dt = new DataTable(TableName);
            collection.DefaultView.CreateProjection(propertyProjectors, dt);
            return dt;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            cmdAdd.Enabled = false;
            cmdEdit.Enabled = false;
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;

            bsAlat.SuspendBinding();
            emptyText();
            enableText();

            lAdd = true;
        }        

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            cmdAdd.Enabled = true;
            cmdEdit.Enabled = true;
            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;

            emptyText();
            bsAlat.MoveFirst();
            bsAlat.ResumeBinding();                        
            disableText();

            lAdd = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (lAdd)
            {
                foreach (MAlatEntity m in mAlat)
                {
                    if (m.CIdAlat == txtIdAlat.Text)
                    {
                        MessageBox.Show("Record already exist");
                        return;
                    }
                }
            }

            if (txtBatasToleransi.Text == "" || txtIdAlat.Text == "" || txtIntEks.Text == "" || txtInterval.Text == "" || txtNamaAlat.Text == "" || (chkExternal.Checked == false & chkInternal.Checked == false)||(optAktif.Checked ==false & optNonAktif.Checked ==false))
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

                    MAlatEntity MAlatEnt = new MAlatEntity();
                    MAlatEnt.CIdAlat = txtIdAlat.Text;
                    MAlatEnt.CNamaAlat = txtNamaAlat.Text;
                    MAlatEnt.CBatasToleransi = txtBatasToleransi.Text;
                    MAlatEnt.CUserId = global_variable.global.gcUSERID;
                    MAlatEnt.NInterval = Convert.ToInt16(txtInterval.Text);
                    MAlatEnt.NIntervalEks = Convert.ToInt16(txtIntEks.Text);
                    MAlatEnt.LJkInternal = chkInternal.Checked;
                    MAlatEnt.LJkEksternal = chkExternal.Checked;
                    MAlatEnt.LStatusAlat = optAktif.Checked;
                    MAlatEnt.DEntry = DateTime.Now;

                    MAlatEnt.Save();
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

                    MAlatEntity MAlatEnt = new MAlatEntity(txtIdAlat.Text);                    
                    MAlatEnt.CNamaAlat = txtNamaAlat.Text;
                    MAlatEnt.CBatasToleransi = txtBatasToleransi.Text;
                    MAlatEnt.CUserId = global_variable.global.gcUSERID;
                    MAlatEnt.NInterval = Convert.ToInt16(txtInterval.Text);
                    MAlatEnt.NIntervalEks = Convert.ToInt16(txtIntEks.Text);
                    MAlatEnt.LJkInternal = chkInternal.Checked;
                    MAlatEnt.LJkEksternal = chkExternal.Checked;
                    MAlatEnt.LStatusAlat = optAktif.Checked;
                    MAlatEnt.DEntry = DateTime.Now;

                    MAlatEnt.Save();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            mAlat.GetMulti(null);
            Kalibrasi.global_variable.global.gentMAlat = mAlat;            
            bsAlat.ResumeBinding();
            bsAlat.MoveLast();
            disableText();

            lAdd = false;
        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            MAlatEntity m = new MAlatEntity(txtIdAlat.Text);
            if (Kalibrasi.global_variable.global.gcHAKAKSES == "KAL03") 
            {
                MessageBox.Show("Anda tidak berhak confirm");
                return;
            }
            if (m.DConfirm == null)
            {
                m.DConfirm = DateTime.Now.Date;
                m.CConfirm = DateTime.Now.ToLongTimeString();
                m.Save();
            }
            else
            {
                MessageBox.Show("Record ini sudah diconfirm");
                return;
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            lAdd = false;
            MAlatEntity m = new MAlatEntity(txtIdAlat.Text);
            if (m.DConfirm != null)
            {
                MessageBox.Show("Record ini sudah diconfirm, tidak bisa diedit");
                return;
            }

            cmdAdd.Enabled = false;
            cmdEdit.Enabled = false;
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;

            enableText();
            txtIdAlat.Enabled = false;
        }

        private void enableText()
        {
            txtBatasToleransi.Enabled = true;
            txtIdAlat.Enabled = true;
            txtIntEks.Enabled = true;
            txtInterval.Enabled = true;
            txtNamaAlat.Enabled = true;
            chkExternal.Enabled = true;
            chkInternal.Enabled = true;
            optAktif.Enabled = true;
            optNonAktif.Enabled = true;
        }

        private void disableText()
        {
            txtBatasToleransi.Enabled = false;
            txtIdAlat.Enabled = false;
            txtIntEks.Enabled = false;
            txtInterval.Enabled = false;
            txtNamaAlat.Enabled = false;
            chkExternal.Enabled = false;
            chkInternal.Enabled = false;
            optAktif.Enabled = false;
            optNonAktif.Enabled = false;
        }

        private void emptyText()
        {
            txtBatasToleransi.Text = "";
            txtIdAlat.Text = "";
            txtIntEks.Text = "";
            txtInterval.Text = "";
            txtNamaAlat.Text = "";
            chkExternal.Checked = false;
            chkInternal.Checked = false;
            optAktif.Checked = false;
            optNonAktif.Checked = false;
        }
    }
}

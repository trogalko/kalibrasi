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
    public partial class frmAlat : Form
    {
        public DataTable dtAlat;

        public frmAlat()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
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

            //retrieve all Master Alat records
            mAlat.GetMulti(null);
            //copy all Master Alat ke variabel global
            Kalibrasi.global_variable.global.gentMAlat = mAlat;             
            //dtAlat = CollectionToDataTable(mAlat, "dtAlat"); 
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
            DataRow drNamaAlat;

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
            }
            Kalibrasi.global_variable.global.gdtALAT = dtAlat;

            //bsSearchList.Filter = "cIdAlat like '%" + txtIdAlat.Text + "%'";
            //Kalibrasi.global_variable.global.gbsALAT = bsSearchList;
            //Kalibrasi.global_variable.global.gdtALAT = (DataTable)bsSearchList.DataSource;  
             
            //bsAlat.DataSource = mAlat; 
 
            //MessageBox.Show(bsSearchList.Count.ToString());
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
            MessageBox.Show(Kalibrasi.global_variable.global.gcSELECTEDVALUE);
        }
    }
}

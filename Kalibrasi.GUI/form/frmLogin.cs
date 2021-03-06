﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Kalibrasi.Data;
using Kalibrasi.Data.EntityClasses;
using Kalibrasi.Data.CollectionClasses;

namespace Kalibrasi.form
{
    public partial class frmLogin : Form
    {
        public string lcUserId = "";
        frmStatusBar frmStatusBar = new frmStatusBar();
 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdEXIT_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Chilkat.Crypt2 crypt = new Chilkat.Crypt2();
            crypt.UnlockComponent("Crypt!TEAM!BEAN_34F4144DpR6G");
            crypt.CryptAlgorithm = "aes";
            crypt.CipherMode = "cbc";
            crypt.KeyLength = 128;
            crypt.SecretKey = crypt.GenerateSecretKey(txtUser.Text);
            crypt.EncodingMode = "base64";
            lcUserId = Kalibrasi.global_variable.global.gcUSERID;
            Kalibrasi.global_variable.global.gcUSERID = txtUser.Text;  
            
            frmStatusBar = new frmStatusBar();
            frmStatusBar.Show(); 
            frmStatusBar.CancelButtonClicked += new CancelButtonEventHandler(frmStatusBar_CancelButtonClicked);
            loginWorker.RunWorkerAsync();                    
        }

        void frmStatusBar_CancelButtonClicked(object sender, CancelEventArgs e)
        {
            loginWorker.CancelAsync();
            Kalibrasi.global_variable.global.gcUSERID = lcUserId;
        }

        private void loginWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            MUserEntity MUser = new MUserEntity(Kalibrasi.global_variable.global.gcUSERID);
            Kalibrasi.global_variable.global.gcPASSWORD = MUser.CPassword;            
        }

        private void loginWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Chilkat.Crypt2 crypt = new Chilkat.Crypt2();
            crypt.UnlockComponent("Crypt!TEAM!BEAN_34F4144DpR6G");
            crypt.CryptAlgorithm = "aes";
            crypt.CipherMode = "cbc";
            crypt.KeyLength = 128;
            crypt.SecretKey = crypt.GenerateSecretKey(txtUser.Text);
            crypt.EncodingMode = "base64";

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            if (frmStatusBar != null)
            {
                frmStatusBar.Close();
            }

            if (Kalibrasi.global_variable.global.gcPASSWORD == crypt.EncryptStringENC(txtPassword.Text))
            {
                this.Close();                
            }
            else
            {
                Kalibrasi.global_variable.global.gcUSERID = lcUserId;
            }
            
        }                 
    }
}

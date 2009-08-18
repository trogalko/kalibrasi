using System;
using System.Collections.Generic;
using System.Data; 
using System.Text;
using System.Windows.Forms;

using SD.LLBLGen.Pro.ORMSupportClasses;
using Kalibrasi.Data.EntityClasses;
using Kalibrasi.Data.CollectionClasses;    

namespace Kalibrasi.global_variable
{
    class global
    {
        //Global Variable
        private static string _gcUSERID = "";
        private static string _gcHakAkses = "";
        private static string _gcPASSWORD = "";
        private static string _gcSelectedValue = "";
        private static string _gcReportName = "";
        private static BindingSource _gbsALAT = null;
        private static BindingSource _gbsDEPARTEMEN = null;
        private static DataTable _gdtALAT = null;
        private static DataTable _gdtDEPARTEMEN = null;
        private static MAlatCollection _gentMAlat = null;
        private static MDepartementCollection _gentDEPARTEMEN = null;

        public static string gcUSERID
        {
            get { return _gcUSERID; }
            set { _gcUSERID = value; } 
        }

        public static string gcPASSWORD
        {
            get { return _gcPASSWORD; }
            set { _gcPASSWORD = value; }
        }

        public static string gcHAKAKSES
        {
            get { return _gcHakAkses; }
            set { _gcHakAkses = value; }
        }

        public static string gcSELECTEDVALUE
        {
            get { return _gcSelectedValue; }
            set { _gcSelectedValue = value; }
        }

        public static string gcReportName
        {
            get { return _gcReportName; }
            set { _gcReportName = value; }
        }

        public static BindingSource gbsALAT
        {
            get { return _gbsALAT; }
            set { _gbsALAT = value; }
        }
        public static BindingSource gbsDEPARTEMEN
        {
            get { return _gbsDEPARTEMEN; }
            set { _gbsDEPARTEMEN = value; }
        }

        public static DataTable gdtALAT
        {
            get { return _gdtALAT; }
            set { _gdtALAT = value; }
        }

        public static DataTable gdtDEPARTEMEN
        {
            get { return _gdtDEPARTEMEN; }
            set { _gdtDEPARTEMEN = value; }
        }

        public static MAlatCollection gentMAlat
        {
            get { return _gentMAlat; }
            set { _gentMAlat = value; }
        }

        public static MDepartementCollection gentDEPARTEMEN
        {
            get { return _gentDEPARTEMEN; }
            set { _gentDEPARTEMEN = value; }
        }

        //Method
        //public void EnableControl(List<Control> listCtl)
        //{            
        //    foreach (Control ctl in listCtl)
        //    {
        //        ctl.Enabled = true;  
        //    }
        //}
    }
}

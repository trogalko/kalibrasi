using System;
using System.Collections.Generic;
using System.Data; 
using System.Text;
using System.Windows.Forms;  

namespace Kalibrasi.global_variable
{
    class global
    {
        private static string _gcUSERID = "";
        private static string _gcHakAkses = "";
        private static string _gcPASSWORD = "";
        private static BindingSource _gbsALAT = null;
        private static DataTable _gdtALAT = null; 

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

        public static BindingSource gbsALAT
        {
            get { return _gbsALAT; }
            set { _gbsALAT = value; }
        }

        public static DataTable gdtALAT
        {
            get { return _gdtALAT; }
            set { _gdtALAT = value; }
        }
    }
}

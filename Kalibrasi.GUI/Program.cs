﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kalibrasi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
	/// done
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdiKalibrasi());
        }
    }
}

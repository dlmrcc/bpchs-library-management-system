using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BPCHS___Library_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new wfLogIn());
        }
    }
}
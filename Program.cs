using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LandingRateMonitor
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
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(FormMain.UnhandledThreadExceptionHandler);
            Application.Run(new FormMain());
        }
    }
}

using RocketFreight.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RocketFreight.Classes.Statics;

namespace RocketFreight
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

            var frmSplash = new frmSplashScreen();
            Application.Run(frmSplash);
            if (frmSplash.isClosing)
                return;
            Application.Run(new frmDialogue());
        }
    }
}

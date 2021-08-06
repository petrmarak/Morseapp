using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morseapp_WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Creates a file used to store app configuration, if it doesn't exist yet
            string configPath = "config.ini";
            FileInfo configInfo = new(configPath);

            if (!configInfo.Exists || configInfo.Length < 6)
            {
                configInfo.Create().Close();
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());
        }
    }
}

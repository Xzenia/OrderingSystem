using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace OrderingSystem.Account
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
            Application.Run(new Login());
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            if (File.Exists("userData"))
            {
                File.Delete("userData");
            }
        }
    }
}

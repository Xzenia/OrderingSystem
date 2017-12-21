using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace User
{
    public partial class UserSplashScreen : Form
    {
        public UserSplashScreen()
        {
            InitializeComponent();
            tm.Start();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            loadBar.Increment(1);
            if (loadBar.Value == 50)
            {
                tm.Stop();
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(MainProcess));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();

            }
        }

        public static void MainProcess()
        {
            Application.Run(new UserMain());
        }
    }
}

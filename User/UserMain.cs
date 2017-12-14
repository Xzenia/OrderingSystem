using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using User.Global;
using DatabaseController;

namespace User
{
    public partial class UserMain : Form
    {
        //This is used for the custom window dragging takes Windows Frame 
        //Taken for mhttps://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        //Takes dynamic libraries for the the dragging effect
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        LoginCookie cookie = new LoginCookie();

        public UserMain()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.Form1_Closing);
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            if (File.Exists("userData"))
            {
                File.Delete("userData");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainMenu.ForeColor = Color.White;
            BackColor = Color.FromArgb(126, 64, 0);
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.FromArgb(126, 64, 0);
                    break;
                }
            }

            try
            {
                cookie.readFile();
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't logged in. Please do so through OrderingSystem.exe");
                this.Close();
            }
            loggedInLabel.Text = "Welcome " + cookie.CustomerName + "! ";
        }
        
        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string sbtn = btn.Name;

            switch (sbtn)
            {
                case "btnOrder":
                    NewOrder goToOrder = new NewOrder();
                    goToOrder.Show();
                    break;
                case "btnExit":
                    Environment.Exit(0);
                    break;
                case "btnMinimize":
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        this.WindowState = FormWindowState.Minimized;
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    break;
                case "btnHistory":
                    CustomerOrderHistory goToOrderHistory = new CustomerOrderHistory();
                    goToOrderHistory.Show();
                    break;
                case "userDetailsBtn":
                    ChangeAccountInformation goToChangeAccount = new ChangeAccountInformation();
                    goToChangeAccount.Show();
                    break;
                default:
                    MessageBox.Show("Something went wrong!");
                    break;
            }
        }

        //Contains the custom drag event
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void menu_itemClicked(object sender, EventArgs e)
        {
            string sbtn ="";
            //Gets the object reference of the item clicked
            var btn = (ToolStripMenuItem)sender;
            if (btn != null)
            {
               sbtn = btn.Name;
            }
            switch (sbtn)
            {
                case "mnuGenRep":
                    Environment.Exit(0);
                    break;
                case "btnResize":

                    break;
                case "btnMinimize":

                    break;
                default:
                    //MessageBox.Show("The event is : " + e.GetType().ToString());
                    break;
            }
        }

    }
}
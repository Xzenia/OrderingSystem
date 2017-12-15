using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseController;
using Admin;
using User;
namespace OrderingSystem.Account
{
    public partial class Login : Form
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

        AccountTableDatabaseController adc = new AccountTableDatabaseController();
        CustomerDatabaseController cdc = new CustomerDatabaseController();
        LoginCookie cookie = new LoginCookie();
        public Login()
        {
            InitializeComponent();
            usernameField.Text = "hello";
            passwordField.Text = "hello";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Boolean confirm = adc.authenticateUser(usernameField.Text, passwordField.Text);
            if (confirm)
            {
                MessageBox.Show("Access Granted!");
                if (adc.dbUserType.Equals("ADMIN"))
                {
                    System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(AdminProcess));
                    thread.SetApartmentState(ApartmentState.STA);
                    saveUserDataToCookie();
                    thread.Start();
                    this.Close();
                }
                else
                {
                    System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(UserProcess));
                    thread.SetApartmentState(ApartmentState.STA);
                    saveUserDataToCookie();
                    thread.Start();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Username or password invalid!");
                usernameField.Text = "";
                passwordField.Text = "";
            }
        }

        private void saveUserDataToCookie(){
            DataTable dt = cdc.getData(usernameField.Text);
            DataRow row = dt.Rows[0];
            cookie.UserId = Convert.ToInt32(row["CustomerId"]);
            cookie.CustomerName = Convert.ToString(row["CustomerName"]);
            cookie.CustomerType = Convert.ToString(row["CustomerType"]);
            cookie.CustomerUsername = usernameField.Text;
            cookie.writeToFile();
        }

        public static void RegisterProcess()
        {
            Application.Run(new Register());
        }

        public static void AdminProcess()
        {
            Application.Run(new AdminSplashScreen());
        }

        public static void UserProcess()
        {
            Application.Run(new UserSplashScreen());
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register goToRegister = new Register();
            this.Hide();
            goToRegister.Show();
              
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}

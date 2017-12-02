using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseController;
using Admin;
using User;
using System.Threading;


namespace OrderingSystem.Account
{
    public partial class Login : Form
    {
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
            cookie.UserId = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            cookie.CustomerName = Convert.ToString(dt.Rows[0].ItemArray[1]);
            cookie.CustomerType = Convert.ToString(dt.Rows[0].ItemArray[2]);
            cookie.writeToFile();
        }

        public static void RegisterProcess()
        {
            Application.Run(new Register());
        }

        public static void AdminProcess()
        {
            Application.Run(new AdminMain());
        }

        public static void UserProcess()
        {
            Application.Run(new UserMain());
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register goToRegister = new Register();
            goToRegister.Show();
            this.Hide();                    
        }


        
    }
}

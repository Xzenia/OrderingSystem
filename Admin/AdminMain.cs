using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DatabaseController;
using Admin.Reports;
namespace Admin
{
    public partial class AdminMain : Form
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
        AccountTableDatabaseController adc = new AccountTableDatabaseController();

        public AdminMain()
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

        private void AdminMain_Load(object sender, EventArgs e)
        {
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
            if (!adc.confirmIfAdmin(cookie.CustomerUsername))
            {
                MessageBox.Show("Non-admin user detected! Program will now close...");
                this.Close();
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string sbtn = btn.Name;

            switch (sbtn)
            {
                case "addProductBtn":
                    AddProduct goToOrder = new AddProduct();
                    goToOrder.Show();
                    break;
                case "manageProductsBtn":
                    ProductManagement goToProductManagement = new ProductManagement();
                    goToProductManagement.Show();
                    break;
                case "SalesReportBtn":
                    SalesReport goToSalesReport = new SalesReport();
                    goToSalesReport.Show();
                    break;
                case "orderHistoryBtn":
                    OrderHistory goToOrderHistory = new OrderHistory();
                    goToOrderHistory.Show();
                    break;
                default:
                    MessageBox.Show("Something went wrong!");
                    break;
            }
        }

        public void accountManagement(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string sbtn = btn.Name;

            switch (sbtn)
            {
                case "addUserBtn":
                    AddAccount goToAddAccount = new AddAccount();
                    goToAddAccount.Show();
                    break;
                case "manageCustomerBtn":
                    CustomerList goToCustomerList = new CustomerList();
                    goToCustomerList.Show();
                    break;
                default:
                    MessageBox.Show("Something went wrong!");
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
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
    }
}

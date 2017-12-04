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

namespace Admin
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
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

    }
}

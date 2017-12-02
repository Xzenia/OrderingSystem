using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Global;
using DatabaseController;

namespace Admin
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void productInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagement goToProductManagement = new ProductManagement();
            GlobalClass.CheckMdiChildren(goToProductManagement);
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList goToCustomerList = new CustomerList();
            GlobalClass.CheckMdiChildren(goToCustomerList);
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
        }
    }
}

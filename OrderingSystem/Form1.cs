using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystem.Global;
using OrderingSystem.Admin;

namespace OrderingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagement goToProductMgmt = new ProductManagement();
            GlobalClass.CheckMdiChildren(goToProductMgmt);
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList goToCustomerList = new CustomerList();
            GlobalClass.CheckMdiChildren(goToCustomerList);
        }


    }
}

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

namespace OrderingSystem.Admin
{
    public partial class CustomerList : Form
    {
        CustomerDatabaseController cdc = new CustomerDatabaseController();
        BindingSource bs = new BindingSource();
        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            loadDatabase();
        }
        private void loadDatabase()
        {
            bs.DataSource = cdc.viewAllData("SP_VIEWALLCUSTOMERDATA").Tables[0];
            customerListGridView.DataSource = bs;
        }
    }
}

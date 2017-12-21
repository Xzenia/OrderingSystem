using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using DatabaseController;
namespace User
{
    public partial class CustomerOrderHistory : Form
    {
        DataTable orderHistory = new DataTable();
        OrderDatabaseController odc = new OrderDatabaseController();
        SqlDataAdapter sda = new SqlDataAdapter();
        LoginCookie cookie = new LoginCookie();
        BindingSource bs = new BindingSource();
        
        public CustomerOrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            loadDatabase();
        }

        private void loadDatabase()
        {
            cookie.readFile();
            bs.DataSource = odc.viewUserOrderHistory(cookie.UserId);
            customerOrderHistoryGridView.DataSource = bs;
        }
    }
}

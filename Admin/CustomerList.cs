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
using DatabaseController;
using ProgramLibrary.Data;
using Admin.ImageClass;

namespace Admin
{
    public partial class CustomerList : Form
    {
        CustomerDatabaseController cdc = new CustomerDatabaseController();
        BindingSource customerBs = new BindingSource();
        BindingSource comboBoxBs = new BindingSource();
        byte[] tempImg;
        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            loadDatabase();
            loadCustomerType();
        }
        private void loadDatabase()
        {
            customerBs.DataSource = cdc.viewAllData("SP_VIEWALLCUSTOMERDATA").Tables[0];
            customerListGridView.DataSource = customerBs;
        }

        private void loadCustomerType()
        {
            comboBoxBs.DataSource = cdc.viewAllData("SP_CUSTOMERTYPE").Tables[0];
            membershipTypeComboBox.DisplayMember = "CustomerType";
            membershipTypeComboBox.DataSource = comboBoxBs;
        }

        private void customerListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.customerListGridView.Rows[e.RowIndex];
                    tempImg = (byte[])row.Cells[1].Value;
                    MemoryStream ms = new MemoryStream(tempImg);
                    customerPictureBox.Image = Image.FromStream(ms);
                    customerNameField.Text = row.Cells[2].Value.ToString();
                    membershipTypeComboBox.Text = row.Cells[7].Value.ToString();
                    customerCellphoneNumberField.Text = row.Cells[6].Value.ToString();
                    customerEmailField.Text = row.Cells[5].Value.ToString();
                }
            }
            catch (Exception cellClickException)
            {
                MessageBox.Show(cellClickException.Message);
            }    
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

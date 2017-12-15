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
        ImageLibrary imgLib = new ImageLibrary();
        String imageLocation = "";
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
                    customerIdField.Text = row.Cells[0].Value.ToString(); 
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
            if (AreAnyFieldsEmpty() == false)
            {
                byte[] customerImage = tempImg;
                if (imageLocation != "")
                {
                    customerImage = (byte[])imgLib.addImage(imageLocation);
                }
                int customerId = Convert.ToInt32(customerIdField.Text);
                String customerName = customerNameField.Text;
                String customerBirthday = customerBirthdayField.Text;
                String cellphoneNumber = customerCellphoneNumberField.Text;
                String email = customerEmailField.Text;
                String membershipType = membershipTypeComboBox.Text;
                Boolean confirm = cdc.updateCustomerData(customerImage, customerId, customerName, customerBirthday, cellphoneNumber, email, membershipType);
                if (confirm)
                {
                    MessageBox.Show("Customer information successfully edited!");
                }
                else
                {
                    MessageBox.Show("Customer info was not edited!");
                }
            }
        }

        private Boolean AreAnyFieldsEmpty()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("One or more fields is empty!");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private void customerPictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
                dialog.Title = "Select Product Picture";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    customerPictureBox.ImageLocation = dialog.FileName.ToString();
                    imageLocation = customerPictureBox.ImageLocation;
                }
            }
            catch (Exception openFileDialogException)
            {
                MessageBox.Show(openFileDialogException.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

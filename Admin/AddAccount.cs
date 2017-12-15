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
using Admin.ImageClass;
namespace Admin
{
    public partial class AddAccount : Form
    {
        CustomerDatabaseController cdc = new CustomerDatabaseController();
        AccountTableDatabaseController adc = new AccountTableDatabaseController();
        LoginCookie cookie = new LoginCookie();
        ImageLibrary imgLib = new ImageLibrary();
        BindingSource comboBoxBs = new BindingSource();
        String imageLocation = "";
        byte[] customerImage;
        int userId;
        public AddAccount()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (imageLocation == "")
                {
                    MessageBox.Show("You must provide a profile picture!");
                }
                else
                {
                    customerImage = (byte[])imgLib.addImage(imageLocation);
                    Random rnd = new Random();
                    userId = rnd.Next(111111, 999999);
                    Boolean confirm = cdc.addCustomerData(customerImage, userId, fullNameField.Text, usernameField.Text, birthdayField.Text, phoneNumberField.Text, emailField.Text, accountTypeComboBox.Text);

                    if (confirm)
                    {
                        if (adminCheckBox.Checked)
                        {
                            String userType = "ADMIN";
                            adc.adminAddUser(userId, usernameField.Text, passwordField.Text, userType);
                        }
                        MessageBox.Show("User information successfully updated!");
                    }

                    else
                    {
                        MessageBox.Show("User information was not updated!");
                    }
                }
               
            }
            catch (Exception MissingFileException)
            {
                MessageBox.Show(MissingFileException.Message);
            }
        }

        private void loadCustomerType()
        {
            comboBoxBs.DataSource = cdc.viewAllData("SP_CUSTOMERTYPE").Tables[0];
            accountTypeComboBox.DisplayMember = "CustomerType";
            accountTypeComboBox.DataSource = comboBoxBs;
        }

        
        private void customerPictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
                dialog.Title = "Select Profile Picture";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    customerPictureBox.ImageLocation = imageLocation;
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

        private void AddAccount_Load(object sender, EventArgs e)
        {
            loadCustomerType();
        }
    }
}

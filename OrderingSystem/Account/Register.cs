using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using DatabaseController;
using OrderingSystem.ImageClass;
namespace OrderingSystem.Account
{
    public partial class Register : Form
    {
        CustomerDatabaseController cdc = new CustomerDatabaseController();
        AccountTableDatabaseController adc = new AccountTableDatabaseController();
        ImageLibrary imgLib = new ImageLibrary();
        String imageLocation = "";
        public Register()
        {
            InitializeComponent();
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
                    imageLocation = dialog.FileName.ToString();
                    customerPictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception openFileDialogException)
            {
                MessageBox.Show(openFileDialogException.Message);
            }   
        }
        //TODO: Add error-checking.
        private void registerBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            String fullName = fullnameTextBox.Text;
            String customerType = customerTypeComboBox.Text;
            int confirm = adc.checkIfUsernameExists(username);
            if (confirm > 0)
            {
                MessageBox.Show("Username already exists!");
                usernameTextBox.Text = "";
            }
            else
            {
                byte[] image = imgLib.addImage(imageLocation);
                adc.addUser(username, password);
                cdc.addUserInfo(image, fullName, customerType);
                MessageBox.Show("Successfully Registered!");
            }            
        }
       
    }
}

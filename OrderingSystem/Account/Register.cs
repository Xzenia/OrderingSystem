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
using Admin.ImageClass;

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

        public static void LoginProcess()
        {
            Application.Run(new Login());
        }

        //TODO: Add error-checking.
        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = generateCustomerId();
                String username = usernameTextBox.Text;
                String password = passwordTextBox.Text;
                String fullName = fullnameTextBox.Text;
                int confirm = adc.checkIfUsernameExists(username);
                if (confirm > 0)
                {
                    MessageBox.Show("Username already exists!");
                    usernameTextBox.Text = "";
                }
                else
                {
                    byte[] customerImage;
                    //This is temporary. A default image will be added and this message will not be needed.
                    if (imageLocation == "")
                    {
                        MessageBox.Show("Please add a profile picture!");
                    }
                    else
                    {
                        customerImage = imgLib.addImage(imageLocation);
                        adc.addUser(userId, username, password);
                        cdc.addUserInfo(userId, customerImage, fullName, username);
                        MessageBox.Show("Successfully Registered!");
                        System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(LoginProcess));
                        thread.Start();
                        this.Close();
                    }
                }
            }

            catch (Exception registrationException)
            {
                MessageBox.Show(registrationException.Message);
            }
        }
        
        private int generateCustomerId()
        {
            Random rnd = new Random();
            return rnd.Next(111111, 999999);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Login goToLogin = new Login();
            goToLogin.Show();
            this.Hide();
        }
    }
}

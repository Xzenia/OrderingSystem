﻿using System;
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

namespace Admin
{
    public partial class AddAccount : Form
    {
        CustomerDatabaseController cdc = new CustomerDatabaseController();
        AccountTableDatabaseController adc = new AccountTableDatabaseController();
        ImageLibrary imgLib = new ImageLibrary();
        String imageLocation = "";
        
        public AddAccount()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            customerTypeComboBox.SelectedIndex = 0;
        }

        private void customerPictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
                dialog.Title = "Select Account Picture";
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
            try
            {
                int userId = generateCustomerId();
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
                    byte[] customerImage;
                    if (imageLocation == "")
                    {
                        MessageBox.Show("Please add a profile picture!");
                    }
                    else
                    {
                        customerImage = imgLib.addImage(imageLocation);
                        adc.addUser(userId, username, password);
                        //cdc.adminAddUserInfo(userId, customerImage, fullName, username, customerType);
                        MessageBox.Show("Account Added!");
                            
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
            this.Close();
        }
    }
}

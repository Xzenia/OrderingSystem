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
using User.ImageClass;
namespace User
{
    public partial class ChangeAccountInformation : Form
    {
        CustomerDatabaseController cdc = new CustomerDatabaseController();
        LoginCookie cookie = new LoginCookie();
        ImageLibrary imgLib = new ImageLibrary();
        String imageLocation = "";
        int userId;
        byte[] tempImg;
        byte[] customerImage;
        public ChangeAccountInformation()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            customerImage = tempImg;
            if (imageLocation != "")
            {
                customerImage = (byte[])imgLib.addImage(imageLocation);
            }
            Boolean confirm = cdc.updateCustomerData(customerImage, userId, fullNameField.Text, birthdayField.Text, phoneNumberField.Text, emailField.Text, accountTypeLabel.Text);

            if (confirm)
            {
                MessageBox.Show("User information successfully updated!");
                loadData();
            }
            else
            {
                MessageBox.Show("User information was not updated!");
            }
        }

        private void ChangeAccountInformation_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            cookie.readFile();
            string username = cookie.CustomerUsername;
            userId = cookie.UserId;
            DataTable dt = cdc.getData(username);
            DataRow row = dt.Rows[0];
            tempImg = (byte[])row["CustomerImage"];
            MemoryStream ms = new MemoryStream(tempImg);
            customerPictureBox.Image = Image.FromStream(ms);
            fullNameField.Text = row["CustomerName"].ToString();
            usernameField.Text = row["CustomerUsername"].ToString();
            birthdayField.Text = row["CustomerBirthday"].ToString();
            emailField.Text = row["CustomerEmail"].ToString();
            phoneNumberField.Text = row["CustomerCellphoneNumber"].ToString();
            accountTypeLabel.Text = row["CustomerType"].ToString();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DatabaseController;
using Admin.ImageClass;
using ProgramLibrary.Data;

namespace Admin
{
    public partial class AddProduct : Form
    {
        ProductDatabaseController pdc = new ProductDatabaseController();
        ProductManagement pm = new ProductManagement();
        ImageLibrary imgLib = new ImageLibrary();
        DataCheck dataChk = new DataCheck();
        BindingSource bs = new BindingSource();
        String imageLocation = "";

        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            productCategoryComboBox.SelectedIndex = 0;
        }

        private void productPictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
                dialog.Title = "Select Product Picture";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    productPictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception openFileDialogException)
            {
                MessageBox.Show(openFileDialogException.Message);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            byte[] productImage;
            if (!AreAnyFieldsEmpty())
            {
                try
                {
                    if (imageLocation == "")
                    {
                        MessageBox.Show("Please add an image of the product.");
                    }
                    else
                    {
                        productImage = imgLib.addImage(imageLocation);
                        string productName = productNameField.Text;
                        double price = Convert.ToDouble(productPriceField.Text);
                        string productCategory = productCategoryComboBox.Text;
                        Boolean confirm = pdc.addProduct(productImage, productName, price, productCategory);

                        if (confirm)
                        {
                            MessageBox.Show("Data added to database successfully!");
                            productNameField.Text = "";
                            productPriceField.Text = "";
                            productPictureBox.Image = Admin.Properties.Resources.defaultImage;
                            pm.loadDatabase();
                        }
                        else
                        {
                            MessageBox.Show("Data was not sent to database!");
                        }
                    }

                }
                catch (Exception dataException)
                {
                    MessageBox.Show(dataException.Message);
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
                }
            }
            return false;
        }
    }
}

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
using OrderingSystem.ImageClass;
namespace OrderingSystem.Admin
{
    public partial class AddProduct : Form
    {
        ProductDatabaseController pdc = new ProductDatabaseController();
        ProductManagement pm = new ProductManagement();
        ImageLibrary imgLib = new ImageLibrary();
        BindingSource bs = new BindingSource();
        String imageLocation = "";

        public AddProduct()
        {
            InitializeComponent();
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
            if (checkInputs() == false)
            {
                MessageBox.Show("One or more textfields contain an invalid character!");
            }
            else
            {
                byte[] img = imgLib.addImage(imageLocation);
                string productName = productNameField.Text;
                double price = Convert.ToDouble(productPriceField.Text);
                int stock = Convert.ToInt32(productStockField.Text);
                string productCategory = productCategoryComboBox.Text;
                Boolean confirm = pdc.addProduct(img, productName, price, stock, productCategory);

                if (confirm)
                {
                    MessageBox.Show("Data added to database successfully!");
                    productNameField.Text = "";
                    productPriceField.Text = "";
                    productStockField.Text = "";
                    pm.loadDatabase();
                }
                else
                {
                    MessageBox.Show("Data was not sent to database!");
                }
                
            }
        }

        private Boolean checkInputs()
        {
            double testValue;
            int anotherTestValue;
            if (!double.TryParse(productPriceField.Text, out testValue))
            {
                return false;
            }
            else if (!int.TryParse(productStockField.Text, out anotherTestValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
 

    }

}

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
    public partial class ProductManagement : Form
    {
        ProductDatabaseController pdc = new ProductDatabaseController();
        BindingSource bs = new BindingSource();
        ImageLibrary imgLib = new ImageLibrary();
        DataCheck dataChk = new DataCheck();
        String imageLocation = "";
        byte[] tempImg;

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            loadDatabase();
            productCategoryComboBox.SelectedIndex = 0;
        }

        private Boolean checkInputs()
        {
            double testValue;
            if (!double.TryParse(productPriceField.Text, out testValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void loadDatabase()
        {
            bs.DataSource = pdc.viewAllData("SP_VIEWALLPRODUCTDATA").Tables[0];
            productListGridView.DataSource = bs;
        }

        private void productListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.productListGridView.Rows[e.RowIndex];
                    productIdField.Text = row.Cells[0].Value.ToString();
                    tempImg = (byte[])row.Cells[1].Value;
                    MemoryStream ms = new MemoryStream(tempImg);
                    productPictureBox.Image = Image.FromStream(ms);
                    productNameField.Text = row.Cells[2].Value.ToString();
                    productPriceField.Text = row.Cells[3].Value.ToString();
                    productCategoryComboBox.Text = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception cellClickException)
            {
                MessageBox.Show(cellClickException.Message);
            }    
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
                    productPictureBox.ImageLocation = dialog.FileName.ToString();
                    imageLocation = productPictureBox.ImageLocation;
                }
            }
            catch (Exception openFileDialogException)
            {
                MessageBox.Show(openFileDialogException.Message);
            }
        }
        //Add delete and refresh buttons
        private void btnClick(object sender, EventArgs e) 
        {
            Button btn = sender as Button;
            string sbtn = btn.Name;
            switch (sbtn)
            {
                case "editBtn":
                    editProduct();
                    break;
                
                case "addBtn":
                    cbxProductManager.Text = "Add a New Product";
                    AddProduct goToAddProduct = new AddProduct();
                    goToAddProduct.Show();
                    break;
                
                case "deleteBtn":
                    pdc.deleteProduct(Convert.ToInt32(productIdField.Text));
                    loadDatabase();
                    break;

                case "refreshBtn":
                    loadDatabase();
                    break;
                
                default:
                    MessageBox.Show("The event is : " + e.GetType().ToString());
                    break;
            }
        }

        private void editProduct()
        {
            AreAnyFieldsEmpty();
            byte[] productImage = tempImg;
            if (!AreAnyFieldsEmpty())
            {
                if (imageLocation != null)
                {
                    productImage = (byte[])imgLib.addImage(imageLocation);
                }

                int productId = Convert.ToInt32(productIdField.Text);
                string productName = productNameField.Text;
                double productPrice = Convert.ToDouble(productPriceField.Text);
                string productCategory = productCategoryComboBox.Text;
                Boolean confirm = pdc.updateProductData(productId, productImage, productName, productPrice, productCategory);

                if (confirm)
                {
                    MessageBox.Show("Product information successfully updated!");
                    loadDatabase();
                }
                else
                {
                    MessageBox.Show("Product information was not successfully updated!");
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

            if (dataChk.checkInputs(productPriceField.Text))
            {
                MessageBox.Show("The price textfield contains an invalid character(s)");
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}

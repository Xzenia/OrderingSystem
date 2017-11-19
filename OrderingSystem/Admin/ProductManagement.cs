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
using OrderingSystem.Global;
using OrderingSystem.Data;
using OrderingSystem.ImageClass;
namespace OrderingSystem.Admin
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

        public void loadDatabase()
        {
            bs.DataSource = pdc.viewAllData("SP_VIEWALLPRODUCTDATA").Tables[0];
            productListGridView.DataSource = bs;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            byte[] productImage;
            if (dataChk.checkInputs(productPriceField.Text, productStockField.Text))
            {
                if (imageLocation == "")
                {
                    productImage = tempImg;
                }
                else
                {
                    productImage = (byte[])imgLib.addImage(imageLocation);
                }

                int productId = Convert.ToInt32(productIdField.Text);
                string productName = productNameField.Text;
                double productPrice = Convert.ToDouble(productPriceField.Text);
                int productStock = Convert.ToInt32(productStockField.Text);
                string productCategory = productCategoryComboBox.Text;
                Boolean confirm = pdc.updateProductData(productId, productImage, productName, productPrice, productStock, productCategory);
                
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
            else
            {
                MessageBox.Show("One or multiple fields contain invalid characters!");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddProduct goToAddProduct = new AddProduct();
            GlobalClass.CheckMdiChildren(goToAddProduct);
            loadDatabase();
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
                    productStockField.Text = row.Cells[4].Value.ToString();
                    productCategoryComboBox.Text = row.Cells[5].Value.ToString();
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
                    imageLocation = dialog.FileName.ToString();
                    productPictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception openFileDialogException)
            {
                MessageBox.Show(openFileDialogException.Message);
            }
        }
    }
}
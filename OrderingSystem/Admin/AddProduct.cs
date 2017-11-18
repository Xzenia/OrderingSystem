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
using System.Drawing;
using System.Drawing.Drawing2D;
using DatabaseController;

namespace OrderingSystem.Admin
{
    public partial class AddProduct : Form
    {
        ProductDatabaseController pdc = new ProductDatabaseController();
        ProductManagement pm = new ProductManagement();
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
                byte[] img = addImage();
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
        //TODO: Fix crash when user did not choose any image.
        private byte[] addImage()
        {
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Bitmap bmp;
            byte[] temp = br.ReadBytes((int)fs.Length);
            using (var ms = new MemoryStream(temp))
            {
                bmp = new Bitmap(ms);
            }
            byte[] val = resizeImage(bmp);
            return val;
        }

        private byte[] resizeImage(Bitmap bmp)
        {
            int originalWidth = bmp.Width;
            int originalHeight = bmp.Height;

            float maxWidth = 150;
            float maxHeight = 150;

            //Preserving the aspect ratio
            float ratioX = (float)maxWidth / (float) originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            //Making the image more high quality
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(bmp, 0, 0, newWidth, newHeight);
            }

            //Convert the Bitmap image into byte[]
            using (var ms = new MemoryStream())
            {
                resizedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }

        }

    }

}

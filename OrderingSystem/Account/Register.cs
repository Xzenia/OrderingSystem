using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem.Account
{
    public partial class Register : Form
    {
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
                    customerPictureBox.ImageLocation = dialog.FileName.ToString();
                }
            }
            catch (Exception openFileDialogException)
            {
                MessageBox.Show(openFileDialogException.Message);
            }   
        }

    }
}

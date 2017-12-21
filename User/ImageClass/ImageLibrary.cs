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

namespace User.ImageClass
{
    public class ImageLibrary
    {
        //TODO: Fix crash when user did not choose any image.
        public byte[] addImage(string imageLocation)
        {
            try
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
            catch (Exception imageFileException)
            {
                MessageBox.Show(imageFileException.Message);
                return null;
            }
        }

        public byte[] resizeImage(Bitmap bmp)
        {
            int originalWidth = bmp.Width;
            int originalHeight = bmp.Height;

            float maxWidth = 100;
            float maxHeight = 100;

            //Preserving the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
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

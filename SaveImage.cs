using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public static class SaveImage
    {
        public static void Save(Image imgQRCode, string formato)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();

            if (formato.Equals("png"))
            {
                sfDialog.Filter = "PNG Image| *.png";
            }
            else if (formato.Equals("gif"))
            {
                sfDialog.Filter = "GIF Image| *.gif";
            }
            else if (formato.Equals("jpeg"))
            {
                sfDialog.Filter = "JPEG Image| *.jpeg";
            }
            else
            {
                sfDialog.Filter = "JPG Image| *.jpg";
            }

            sfDialog.Title = "Save QRCode";
            sfDialog.FileName = "QRCode";
            sfDialog.InitialDirectory = @"C:\Users\lacsa\Desktop\QRCodes";

            sfDialog.ShowDialog();

            if (!sfDialog.FileName.Equals(string.Empty))
            {
                FileStream fs = (FileStream)sfDialog.OpenFile();
                if (formato.Equals("png"))
                {
                    imgQRCode.Save(fs, ImageFormat.Png);
                }
                else if (formato.Equals("gif"))
                {
                    imgQRCode.Save(fs, ImageFormat.Gif);
                }
                else
                {
                    imgQRCode.Save(fs, ImageFormat.Jpeg);
                }

                fs.Close();
            }
        }
    }
}

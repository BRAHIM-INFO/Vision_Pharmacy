using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Code
{
    public static class ImageHelper
    {
        // تحويل صورة من PictureBox إلى byte[]

        public static byte[] ImageToByteArray(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
                return null;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // لحل مشكلة GDI+ استخدم صيغة معروفة مثل PNG
                    pictureBox.Image.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تحويل الصورة: " + ex.Message);
                return null;
            }
        }

        // تحويل byte[] إلى صورة ووضعها في PictureBox
        public static void ByteArrayToImage(byte[] imageData, PictureBox pictureBox)
        {
            if (imageData == null || imageData.Length == 0)
            {
                pictureBox.Image = null;
                return;
            }

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                pictureBox.Image = Image.FromStream(ms);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Qr.Net.Imaging
{
    public class QrImage
    {
        protected int qrCodeScale = 4;
        protected Color qrCodeBackgroundColor = Color.White;
        protected Color qrCodeForegroundColor = Color.Black;

        public Bitmap CreateImage(bool[][] matrix)
        {
            SolidBrush brush = new SolidBrush(qrCodeBackgroundColor);
            Bitmap image = new Bitmap((matrix.Length * qrCodeScale) + 1, (matrix.Length * qrCodeScale) + 1);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(brush, new Rectangle(0, 0, image.Width, image.Height));
            brush.Color = qrCodeForegroundColor;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[j][i])
                    {
                        g.FillRectangle(brush, j * qrCodeScale, i * qrCodeScale, qrCodeScale, qrCodeScale);
                    }
                }
            }

            return image;
        }
    }
}
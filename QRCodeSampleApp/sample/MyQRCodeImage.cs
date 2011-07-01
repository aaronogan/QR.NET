using System;
using System.Collections.Generic;
using System.Text;

namespace example
{

    class MyQRCodeImage : QRCodeImage
    {
        virtual public int Width
        {
            get
            {
                return image.Width;
            }

        }
        virtual public int Height
        {
            get
            {
                return image.Height;
            }

        }
        internal System.Drawing.Bitmap image;

        public MyQRCodeImage(System.Drawing.Bitmap image)
        {
            this.image = image;
        }

        public virtual int getPixel(int x, int y)
        {
            return image.GetPixel(x, y).ToArgb();
        }
    }
}

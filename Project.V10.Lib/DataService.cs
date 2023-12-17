using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Project.V10.Lib
{
    public class DataService
    {
        public bool IsDefaultImage(Image image, int defaultImageWidth, int defaultImageHeight)
        {
            return (image.Width == defaultImageWidth && image.Height == defaultImageHeight);
        }

        public struct KVRowsImage
        {
            public string Key { get; set; }
            public string Value { get; set; }

            public Bitmap Bitmap { get; set; }

            public KVRowsImage(string key, string value)
            {
                Key = key;
                Value = value;
                Bitmap = null;
            }
            public KVRowsImage(string key, Bitmap bitmap)
            {
                Key = key;
                Value = null;
                Bitmap = bitmap;
            }
        }
    }
}

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
            public KVRowsImage(string key, string value, Bitmap bitmap)
            {
                Key = key;
                Value = value;
                Bitmap = bitmap;
            }
            public static string[] Keys(KVRowsImage[] array)
            {
                return Array.ConvertAll(array, x => x.Key);
            }
        }
        public List<KVRowsImage> AddBitmapFromPath(List<KVRowsImage> imageList, string imageKey, string imagePath)
        {
            using (Bitmap image = new Bitmap(imagePath))
            {
                imageList.Add(new KVRowsImage(imageKey, imagePath, image));
            }
            return imageList;
        }
    }
}

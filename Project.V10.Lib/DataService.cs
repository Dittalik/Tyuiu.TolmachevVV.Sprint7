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
        public bool IsDefaultImage(Image image, Image defaultImage)
        {
            return image == defaultImage;
        }

        public struct KVRowsImage
        {
            public int Key { get; set; }
            public string Path { get; set; }

            public Bitmap Bitmap { get; set; }

            public KVRowsImage(int key, string path)
            {
                Key = key;
                Path = path;
                using(Bitmap bitmap = new Bitmap(path))
                {
                    Bitmap = bitmap;
                } 
            }
            public KVRowsImage(int key, Bitmap bitmap)
            {
                Key = key;
                Path = null;
                Bitmap = bitmap;
            }
            public static int[] Keys(IEnumerable<KVRowsImage> images)
            {
                return images.Select(x => x.Key).ToArray();
            }
        }
    }
}

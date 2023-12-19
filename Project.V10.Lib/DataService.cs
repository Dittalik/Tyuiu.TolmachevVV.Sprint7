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
        public static string GetPath(List<KVRowsImage> imageList, int key)
        {
            int[] keys = KVRowsImage.Keys(imageList);
            if (keys.Contains(key))
            {
                return imageList[Array.IndexOf(keys, key)].Path;
            }
            else return null;
        }
        public struct KVRowsImage
        {
            public int Key { get; set; }

            public string Path { get; set; }

            public Bitmap Bitmap { get; set; }
 
            public static int[] Keys(IEnumerable<KVRowsImage> images)
            {
                return images.Select(x => x.Key).ToArray();
            }
        }
    }
    public class TableElement
    {
        public int Key { get; set; }

        public string ClientName { get; set; }

        public string OrderName { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }

        public int Summ => Price * Count;


        public double Luxary => Price * (0.00000001 * Summ);

        public string Path { get; set; }

        public Image Image { get; set; }
        
    }
    public static class TableElementExtensions
    {
        public static TableElement GetElementByKey(this List<TableElement> list, int key)
        {
            return list.FirstOrDefault(e => e.Key == key);
        }
    }
}

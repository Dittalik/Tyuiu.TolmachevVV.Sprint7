using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Project.V10.Lib
{
    public class DataService
    {
        public bool IsDefaultImage(Image image, Image defaultImage)
        {
            return image == defaultImage;
        }
    }
    public class TableElement
    {
        public int Key { get; set; }

        public string Path { get; set; }

    }
    public static class TableElementExtensions
    {
        public static TableElement GetElementByKey(this List<TableElement> list, int key)
        {
            return list.FirstOrDefault(e => e.Key == key);
        }
        public static int[] Keys(this List<TableElement> list)
        {
            return Array.ConvertAll(list.ToArray(), e => e.Key);
        }
    }
}

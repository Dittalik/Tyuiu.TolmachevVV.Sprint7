using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace Project.V10.Lib
{
    public static class DataService
    {
        public static TableElement GetElementByKey(this List<TableElement> list, int key)
        {
            return list.FirstOrDefault(e => e.Key == key);
        }
        public static int[] Keys(this List<TableElement> list)
        {
            return Array.ConvertAll(list.ToArray(), e => e.Key);
        }
        public static DataGridViewRowCollection RowsSumm(this DataGridViewRowCollection rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                bool parse = int.TryParse(row.Cells[3].Value.ToString(), out int priceValue) & int.TryParse(row.Cells[4].Value.ToString(), out int countValue);
                if (parse)
                {
                    row.Cells[5].Value = priceValue * countValue;
                    row.Cells[6].Value = priceValue * (0.00000001 * countValue);
                }
            }
            return rows;
        }
    }
    public class TableElement
    {
        public int Key { get; set; }

        public string Path { get; set; }

    }
}

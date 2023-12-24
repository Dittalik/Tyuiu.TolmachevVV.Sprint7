using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms.VisualStyles;

namespace Project.V10.Lib
{
    public static class DataService
    {
        public static int KeyIndex(this List<TableElement> tableElements, int key)
        {
           return Array.IndexOf(tableElements.Keys(), key);
        }
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
                bool parse = int.TryParse(row.Cells[3].Value?.ToString(), out int priceValue) & int.TryParse(row.Cells[4].Value?.ToString(), out int countValue);
                if (parse)
                {
                    row.Cells[5].Value = priceValue * countValue;
                    row.Cells[6].Value = priceValue * (0.000001 * countValue);
                }
            }
            return rows;
        }
        public static DataGridViewRowCollection ApplyFilter(this DataGridViewRowCollection rows, int filter, int cellIndex, char comparisonMode, Func<object, int, char, bool> comparison)
        {
            foreach (DataGridViewRow row in rows)
            {
                bool isVisible = comparison(row.Cells[cellIndex].Value, filter, comparisonMode);
                row.Visible = isVisible;
            }
            return rows;
        }
        public static DataGridViewRowCollection Search(this DataGridViewRowCollection rows, string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                foreach (DataGridViewRow row in rows)
                {
                    List<string> cellsValues = new List<string>();
                    for (int i = 1; i < row.Cells.Count; i++)
                    {
                        string cellValue = row.Cells[i].Value?.ToString().ToLower();
                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            cellsValues.Add(cellValue);
                        }
                    }
                    bool isVisible = cellsValues.Any(x => x.Contains(search));
                    row.Visible = isVisible;
                }
            }
            else
            {
                foreach (DataGridViewRow row in rows)
                {
                    row.Visible = true;
                }
            }
            return rows;
        }

        public static bool CompareStringLength(object value, int filter, char comparisonMode)
        {
            if (value is string stringValue)
            {
                switch (comparisonMode)
                {
                    case '>':
                        return stringValue.Length > filter;
                    case '<':
                        return stringValue.Length < filter;
                    default:
                        return false;
                }
            }
            return false;
        }

        public static bool CompareNumberValue(object value, int filter, char comparisonMode)
        {
            if (value is int intValue)
            {
                switch (comparisonMode)
                {
                    case '>':
                        return intValue > filter;
                    case '<':
                        return intValue < filter;
                    default:
                        return false;
                }
            }
            return false;
        }
        public static bool CompareDoubleValue(object value, int filter, char comparisonMode)
        {
            if (value is double doubleValue)
            {
                switch (comparisonMode)
                {
                    case '>':
                        return doubleValue > filter;
                    case '<':
                        return doubleValue < filter;
                    default:
                        return false;
                }
            }
            return false;
        }
        public static double CalculateCells(DataGridViewSelectedCellCollection selectedCells, int calculationMode)
        {
            switch(calculationMode)
            {
                case 0:
                    {
                        double result = 0;
                        foreach(DataGridViewCell cell in selectedCells)
                        {
                            result += Convert.ToDouble(cell.Value);
                        }
                        return result;
                    }
                case 1:
                    {
                        return selectedCells.Count;
                    }
                case 2:
                    {
                        double min = double.MaxValue;
                        foreach(DataGridViewCell cell in selectedCells)
                        {
                            if (Convert.ToDouble(cell.Value) < min)
                            {
                                min = Convert.ToDouble(cell.Value);
                            }
                        }
                        return min;
                    }
                case 3:
                    {
                        double max = double.MinValue;
                        foreach(DataGridViewCell cell in selectedCells)
                        {
                            if(Convert.ToDouble(cell.Value)  > max)
                            {
                                max = Convert.ToDouble(cell.Value);
                            }
                        }
                        return max;
                    }
                case 4:
                    {
                        return CalculateCells(selectedCells, 0) / CalculateCells(selectedCells, 1);
                    }
                default: { return double.NaN; }
            }    
        }
        public static bool IsEntireColumnSelectedAndIsDigits(this DataGridView dataGridView)
        {
            if (dataGridView.SelectedCells.Count == 0)
            {
                return false;
            }

            int selectedColumnIndex = dataGridView.SelectedCells[0].ColumnIndex;

            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                if (cell.ColumnIndex != selectedColumnIndex)
                {
                    return false;
                }
                if(!(cell.Value is double || cell.Value is int))
                {
                    return false;
                }
            }
            return true;
        }
        public static DataGridViewRowCollection GetTable(this DataGridViewRowCollection rows, string filepath)
        {
            string[] content = File.ReadAllLines(filepath);
            string[,] table = new string[content.Length, content[0].Split(';').Length];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = content[i].Split(';')[j];
                }
            }
            for (int i = 0; i <  rows.Count; i++)
            {
                for (int j = 0; j < content[0].Split(';').Length; j++)
                {
                    if (j == 0)
                    {
                        rows[i].Cells[j].Value = i + 5;
                    }
                    else
                    {
                        rows[i].Cells[j].Value = table[i, j - 1];
                    }
                }
            }
            return rows;
        }
        public static void SaveTable(this  DataGridViewRowCollection rows, string filepath)
        {
            string[] content = new string[rows.Count];
            for (int i = 0; i < rows.Count; i++)
            {
                for (int j = 1; j < rows[i].Cells.Count; j++)
                {
                    if (j != rows[i].Cells.Count - 1)
                    {
                        content[i] += rows[i].Cells[j].Value?.ToString() + ';';
                    }
                    else
                    {
                        content[i] += rows[i].Cells[j].Value?.ToString();
                    }
                }
            }
            File.WriteAllLines(filepath, content, Encoding.UTF8);
        }
    }
    public class TableElement
    {
        public int Key { get; set; }

        public string Path { get; set; }

    }
}

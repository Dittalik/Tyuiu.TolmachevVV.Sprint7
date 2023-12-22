using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project.V10.Lib;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading;

namespace Project.V10
{
    public partial class FormMain : Form
    {
        private BindingSource bindingSource = new BindingSource();

        private Bitmap defaultBitmap = Properties.Resources.picture_add;
        private static Bitmap[] defaultBitmaps = new Bitmap[]
        {
            Properties.Resources.PoezdY,
            Properties.Resources.Poezd8,
            Properties.Resources.GoogeRA,
            Properties.Resources.PanelH,
            Properties.Resources.Rocket
        };

        List<TableElement> tableElements = new List<TableElement>();
        public FormMain()
        {
            InitializeComponent();
            InitializeFormData();

            bindingSource.DataSource = dataGridViewOrders.Rows;
            bindingNavigatorTable.BindingSource = bindingSource;

            openFileDialogTable.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialogPicture.Filter = "Файлы изображений(*.png,*.jpg, *.gif)|*.png;*.jpg;*.gif|Все файлы(*.*)|*.*";
            saveFileDialogTable.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        private void InitializeFormData()
        {
            dataGridViewOrders.RowCount = 5;
            pictureBoxProducts.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProducts.Image = Properties.Resources.PoezdY;

            dataGridViewOrders.Rows[0].Cells[1].Value = "ООО \"Метрополитен\"";
            dataGridViewOrders.Rows[0].Cells[2].Value = "Локомотив \"Яуза\"";
            dataGridViewOrders.Rows[0].Cells[3].Value = 28_710;
            dataGridViewOrders.Rows[0].Cells[4].Value = 6;

            dataGridViewOrders.Rows[1].Cells[1].Value = "ООО \"Метрополитен\"";
            dataGridViewOrders.Rows[1].Cells[2].Value = "Локомотив 81-717";
            dataGridViewOrders.Rows[1].Cells[3].Value = 19_320;
            dataGridViewOrders.Rows[1].Cells[4].Value = 8;


            dataGridViewOrders.Rows[2].Cells[1].Value = "Гугера Б. А.";
            dataGridViewOrders.Rows[2].Cells[2].Value = "ВАЗ 2107";
            dataGridViewOrders.Rows[2].Cells[3].Value = 250;
            dataGridViewOrders.Rows[2].Cells[4].Value = 1;

            dataGridViewOrders.Rows[3].Cells[1].Value = "ООО КВПЕ_ДОМСТРОЙ";
            dataGridViewOrders.Rows[3].Cells[2].Value = "Панельный Дом Люкс Класса";
            dataGridViewOrders.Rows[3].Cells[3].Value = 200_000;
            dataGridViewOrders.Rows[3].Cells[4].Value = 2;

            dataGridViewOrders.Rows[4].Cells[1].Value = "ООО КОСМОС_ПЕ";
            dataGridViewOrders.Rows[4].Cells[2].Value = "Космический Шатл Межпланетных Полётов";
            dataGridViewOrders.Rows[4].Cells[3].Value = 200_000_000;
            dataGridViewOrders.Rows[4].Cells[4].Value = 2;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewOrders.Rows[i].Cells[0].Value = i;
                tableElements.Add(new TableElement
                {
                    Key = i
                });
            }
        }
        
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {        
            
        }

        private void buttonPictureNotVisible_Click(object sender, EventArgs e)
        {
            pictureBoxProducts.Visible = false;
            buttonChartAddLine.Enabled = true;
            buttonChartDeleteLine.Enabled = true;
        }

        private void buttonPictureVisible_Click(object sender, EventArgs e)
        {
            pictureBoxProducts.Visible = true;
            buttonChartAddLine.Enabled = false;
            buttonChartDeleteLine.Enabled = false;
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewOrders.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewOrders.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewOrders.Rows[selectedRowIndex];
                bindingSource.Position = selectedRowIndex;
                int rowKeyValue = Convert.ToInt32(selectedRow.Cells[0].Value);
                TableElement element = tableElements.GetElementByKey(rowKeyValue);
                if (element.Path != null)
                {
                    pictureBoxProducts.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxProducts.ImageLocation = element.Path;
                }
                else if (element.Key < 5)
                {
                    pictureBoxProducts.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxProducts.Image = defaultBitmaps[element.Key];
                }
                else
                {
                    pictureBoxProducts.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBoxProducts.Image = defaultBitmap;
                }
            }
        }

        private void pictureBoxProducts_Click(object sender, EventArgs e)
        {
            if (pictureBoxProducts.Image == defaultBitmap)
            {
                int selectedRowIndex = dataGridViewOrders.SelectedCells[0].RowIndex;
                
                DataGridViewRow selectedRow = dataGridViewOrders.Rows[selectedRowIndex];
                int rowKeyValue = Convert.ToInt32(selectedRow.Cells[0].Value);
                TableElement element = tableElements.GetElementByKey(rowKeyValue);

                if (openFileDialogPicture.ShowDialog() != DialogResult.Cancel)
                {
                    string filepath = openFileDialogPicture.FileName;
                    try
                    {
                        using (Bitmap bitmap = new Bitmap(filepath))
                        {
                            tableElements[element.Key].Path = filepath;
                        }
                        selectedRow.Cells[7].Value = filepath;
                        pictureBoxProducts.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBoxProducts.ImageLocation = element.Path;
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка загрузки картинки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void bindingNavigatorAddNewRow_Click(object sender, EventArgs e)
        {
            int mostKey = int.MinValue;
            for (int i = 0; i < dataGridViewOrders.RowCount; i++)
            {
                int rowKey = Convert.ToInt32(dataGridViewOrders.Rows[i].Cells[0].Value);
                if (mostKey < rowKey)
                {
                    mostKey = rowKey;
                }
            }
            tableElements.Add(new TableElement
            {
                Key = mostKey + 1
            });
            dataGridViewOrders.Rows.Add((mostKey + 1).ToString());
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

            dataGridViewOrders.ClearSelection();
            dataGridViewOrders.Rows[bindingSource.Position].Selected = true;

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.ClearSelection();
            dataGridViewOrders.Rows[bindingSource.Position].Selected = true;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.ClearSelection();
            dataGridViewOrders.Rows[bindingSource.Position].Selected = true;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.ClearSelection();
            dataGridViewOrders.Rows[bindingSource.Position].Selected = true;
        }

        private void dataGridViewOrders_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            dataGridViewOrders.ClearSelection();

            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                if (row.Cells.Count > columnIndex)
                {
                    row.Cells[columnIndex].Selected = true;
                }
            }
        }

        private void bindingNavigatorDeleteRow_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewOrders.Rows[dataGridViewOrders.SelectedCells[0].RowIndex];
            dataGridViewOrders.Rows.Remove(selectedRow);
            int rowKey = Convert.ToInt32(selectedRow.Cells[0].Value);
            tableElements.RemoveAt(Array.IndexOf(tableElements.Keys(), rowKey));
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = textBoxSearch.Text?.ToLower();
            if (!string.IsNullOrEmpty(text))
            {
                DataGridViewRowCollection rows = dataGridViewOrders.Rows;
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
                    if (cellsValues.Any(x => x.Contains(text)))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                DataGridViewRowCollection rows = dataGridViewOrders.Rows;
                foreach (DataGridViewRow row in rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void bindingNavigatorButtonSum_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.Rows.RowsSumm();
        }

        private void pictureBoxMagnifier_Click(object sender, EventArgs e)
        {
            pictureBoxMagnifier.Visible = false;
            pictureBoxMagnifier.Enabled = false;
            textBoxSearch.Visible = false;
            textBoxSearch.Enabled = false;

            pictureBoxFilter.Visible = true;
            pictureBoxFilter.Enabled = true;

            comboBoxFilter.Visible = true;
            comboBoxFilter.Enabled = true;
            textBoxFilter.Visible = true;
            textBoxFilter.Enabled = true;
        }

        private void pictureBoxFilter_Click(object sender, EventArgs e)
        {
            pictureBoxFilter.Visible = false;
            pictureBoxFilter.Enabled = false;

            comboBoxFilter.Visible = false;
            comboBoxFilter.Enabled = false;
            textBoxFilter.Visible = false;
            textBoxFilter.Enabled = false;

            pictureBoxMagnifier.Visible = true;
            pictureBoxMagnifier.Enabled = true;
            textBoxSearch.Visible = true;
            textBoxSearch.Enabled = true;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxFilter.SelectedIndex;
            if (selectedIndex > -1 && selectedIndex < 2)
            {
                textBoxFilter.Text = "Длина: ";
            }
            else if (selectedIndex >= 2 && selectedIndex < 5)
            {
                textBoxFilter.Text = "Величина: ";
            }
            else
            {
                textBoxFilter.Text = "Значение: ";
            }
        }
    }
}

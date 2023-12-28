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
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading;

namespace Project.V10
{
    public partial class FormMain : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private int compMode = 0;

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
            saveFileDialogTable.FileName = "OrdersTable";
            saveFileDialogTable.InitialDirectory = Directory.GetCurrentDirectory();
            if (saveFileDialogTable.ShowDialog() != DialogResult.Cancel)
            {
                string filepath = saveFileDialogTable.FileName;
                dataGridViewOrders.Rows.SaveTable(filepath);
            }
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
                            tableElements[tableElements.KeyIndex(element.Key)].Path = filepath;
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
            dataGridViewOrders.Rows[bindingSource.Position--].Selected = true;
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
            tableElements.RemoveAt(tableElements.KeyIndex(rowKey));
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
            textBoxFilter.Visible = true;
            buttonFilterMode.Visible = true;
            buttonFilterMode.Enabled = true;

            comboBoxFilter.Visible = true;
            comboBoxFilter.Enabled = true;
        }

        private void pictureBoxFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilter.Text = string.Empty;
            pictureBoxFilter.Visible = false;
            pictureBoxFilter.Enabled = false;

            comboBoxFilter.Visible = false;
            comboBoxFilter.Enabled = false;
            textBoxFilter.Visible = false;
            textBoxFilter.Enabled = false;
            buttonFilterMode.Visible = false;
            buttonFilterMode.Enabled = false;


            pictureBoxMagnifier.Visible = true;
            pictureBoxMagnifier.Enabled = true;
            textBoxSearch.Visible = true;
            textBoxSearch.Enabled = true;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilter.Enabled = true;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogTable.ShowDialog() != DialogResult.Cancel)
            {
                string filepath = openFileDialogTable.FileName;
                tableElements.Clear();
                dataGridViewOrders.GetTable(filepath);
                for (int i = 0;  i < dataGridViewOrders.Rows.Count; i++)
                {
                    if (dataGridViewOrders.Rows[i].Cells[7].Value == null)
                    {
                        tableElements.Add(new TableElement
                        {
                            Key = i + 5
                        });
                    }
                    else
                    {
                        tableElements.Add(new TableElement
                        {
                            Key = i + 5,
                            Path = dataGridViewOrders.Rows[i].Cells[7].Value?.ToString()
                        });
                    }
                }
            }
        }

        private void textBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxFilter.Text.Contains('>') || textBoxFilter.Text.Contains('<'))
            {
                if(!(e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Left && (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if(!(e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Left && (e.KeyChar == '>' || e.KeyChar == '<')))
                {
                    e.Handled = true;
                }
            }
        }

        private void pictureBoxFilterExecute_Click(object sender, EventArgs e)
        {
            if (textBoxFilter.Text.Length > 1)
            {
                string filter = textBoxFilter.Text;
                char comparisonMode = textBoxFilter.Text[0];
                int.TryParse(filter.Trim('>', '<'), out int filterNumber);

                if (comboBoxFilter.SelectedIndex < 2)
                {
                    dataGridViewOrders.Rows.ApplyFilter(filterNumber, comboBoxFilter.SelectedIndex + 1, comparisonMode, DataService.CompareStringLength);
                }
                else if (comboBoxFilter.SelectedIndex >= 2 && comboBoxFilter.SelectedIndex < 5)
                {
                    dataGridViewOrders.Rows.ApplyFilter(filterNumber, comboBoxFilter.SelectedIndex + 1, comparisonMode, DataService.CompareNumberValue);
                }
                else
                {
                    dataGridViewOrders.Rows.ApplyFilter(filterNumber, comboBoxFilter.SelectedIndex + 1, comparisonMode, DataService.CompareDoubleValue);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewOrders.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void comboBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonChartAddLine_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.IsEntireColumnSelectedAndIsDigits())
            {
                int columnIndex = dataGridViewOrders.SelectedCells[0].ColumnIndex;
                var cells = dataGridViewOrders.SelectedCells;
                try
                {
                    chartProducts.Series.Add(dataGridViewOrders.Columns[columnIndex].HeaderText);
                }
                catch
                {
                    MessageBox.Show("Функция с таким названием уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                chartProducts.Series.Last().ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chartProducts.Series.Last().IsVisibleInLegend = true;
                for (int i = 0; i < dataGridViewOrders.SelectedCells.Count; i++)
                {
                    int rowIndex = cells[i].RowIndex;
                    var orderName = dataGridViewOrders.Rows[rowIndex].Cells[2].Value.ToString();
                    chartProducts.Series.Last().Points.AddXY(orderName, cells[i].Value);
                }
            }
            else
            {
                MessageBox.Show("Выделите ячейки с числовыми значениями в одном столбце", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChartDeleteLine_Click(object sender, EventArgs e)
        {
            if (chartProducts.Series.Count != 0)
            {
                chartProducts.Series.RemoveAt(chartProducts.Series.Count - 1);
            }
        }
        
        public DataGridViewSelectedCellCollection GetSelectedCellsValues()
        {
            var cells = dataGridViewOrders.SelectedCells;
            if (cells.Count != 0)
            {
                return cells;
            }
            else { return null; }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text?.ToLower().Trim();
            dataGridViewOrders.Rows.Search(text);
        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            CalculationForm calculationForm = new CalculationForm(this);
            calculationForm.Show();
        }

        private void buttonDescription_Click(object sender, EventArgs e)
        {
            FormDescription formDescription = new FormDescription();
            formDescription.ShowDialog();
        }

        private void buttonFilterMode_Click(object sender, EventArgs e)
        {
            if (compMode == 0)
            {
                compMode = 1;
                buttonFilterMode.Text = "<";
            }
            else
            {
                compMode = 0;
                buttonFilterMode.Text = ">";
            }
            textBoxFilter.Text += " ";
            textBoxFilter.Text = textBoxFilter.Text.Trim();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxFilter.Text;
            if (!string.IsNullOrEmpty(text))
            {
                if (int.TryParse(text, out int filter))
                {
                    int columnIndex = 0;
                    switch (comboBoxFilter.SelectedIndex)
                    {
                        case 0: { columnIndex = 3; } break;
                        case 1: { columnIndex = 4; } break;
                        case 2: { columnIndex = 5; } break;
                        case 3: { columnIndex = 6; } break;
                    }
                    foreach (DataGridViewRow row in dataGridViewOrders.Rows)
                    {
                        string cellValue = row.Cells[columnIndex].Value?.ToString().Replace('.', ',');
                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            bool isVisible = DataService.Comparison(Convert.ToDouble(cellValue), filter, compMode);
                            row.Visible = isVisible;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewOrders.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void textBoxFilter_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}

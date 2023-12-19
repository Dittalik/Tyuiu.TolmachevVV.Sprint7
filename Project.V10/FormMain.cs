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

namespace Project.V10
{
    public partial class FormMain : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private DataService service = new DataService();

        private Bitmap defaultPicture = Properties.Resources.picture_add;


        //private DataService.KVRowsImage[] imageList = new DataService.KVRowsImage[];
        List<TableElement> tableElements = new List<TableElement>();
        List<DataService.KVRowsImage> imageList = new List<DataService.KVRowsImage>();
        public FormMain()
        {
            InitializeComponent();
            InitializeFormData();

            openFileDialogTable.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialogPicture.Filter = "Файлы изображений(*.png,*.jpg, *.gif)|*.png;*.jpg;*.gif|Все файлы(*.*)|*.*";
            saveFileDialogTable.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";

            bindingSource.DataSource = dataGridViewOrders;
            bindingNavigatorTable.BindingSource = bindingSource;
        }
        private void InitializeFormData()
        {
            dataGridViewOrders.RowCount = 5;
            //pictureBoxProducts.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProducts.Image = Properties.Resources.Poezd_Yauza;

            tableElements.Add(new TableElement
            {
                Key = -1,
                ClientName = "ООО \"Метрополитен\"",
                OrderName = "Локомотив \"Яуза\"",
                Price = 28_710,
                Count = 6,
                Image = Properties.Resources.Poezd_Yauza
            });

            tableElements.Add(new TableElement
            {
                Key = -2,
                ClientName = "ООО \"Метрополитен\"",
                OrderName = "Локомотив 81-717",
                Price = 19_320,
                Count = 8,
                Image = Properties.Resources.Poezd8
            });

            tableElements.Add(new TableElement
            {
                Key = -3,
                ClientName = "Гугера Б. А.",
                OrderName = "ВАЗ 2107",
                Price = 250,
                Count = 1,
                Image = Properties.Resources.GoogeRA
            });

            tableElements.Add(new TableElement
            {
                Key = -4,
                ClientName = "ООО КВПЕ_ДОМСТРОЙ",
                OrderName = "Панельный Дом Люкс Класса",
                Price = 200_000,
                Count = 2,
                Image = Properties.Resources.PanelH
            });

            tableElements.Add(new TableElement
            {
                Key = -5,
                ClientName = "ООО КОСМОС_ПЕ",
                OrderName = "Космический Шатл Межпланетных Полётов",
                Price = 200_000_000,
                Count = 2,
                Image = Properties.Resources.Rocket
            });

            for (int i = 0; i < 5; i++)
            {
                dataGridViewOrders.Rows[i].Cells[0].Value = tableElements[i].Key;
                dataGridViewOrders.Rows[i].Cells[1].Value = tableElements[i].ClientName;
                dataGridViewOrders.Rows[i].Cells[2].Value = tableElements[i].OrderName;
                dataGridViewOrders.Rows[i].Cells[3].Value = tableElements[i].Price;
                dataGridViewOrders.Rows[i].Cells[4].Value = tableElements[i].Count;
                dataGridViewOrders.Rows[i].Cells[5].Value = tableElements[i].Summ;
                dataGridViewOrders.Rows[i].Cells[6].Value = tableElements[i].Luxary;
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
            buttonChart.Enabled = true;
        }

        private void buttonPictureVisible_Click(object sender, EventArgs e)
        {
            pictureBoxProducts.Visible = true;
            buttonChart.Enabled = false;
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewOrders.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOrders.Rows[dataGridViewOrders.SelectedCells[0].RowIndex];

                int cellKeyValue = Convert.ToInt32(selectedRow.Cells[0].Value);
                TableElement element = tableElements.GetElementByKey(cellKeyValue);
                if (element != null)
                {
                    pictureBoxProducts.Image.Dispose();
                    using(Image image = element.Image)
                    {
                        pictureBoxProducts.Image = image;
                    }
                }
                else
                {
                    pictureBoxProducts.Image = defaultPicture;
                }
            }
            /*
            // Handle the selection changed event to update the pictureBoxProducts with the selected row's image
            if (dataGridViewOrders.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOrders.Rows[dataGridViewOrders.SelectedCells[0].RowIndex];

                object cellKeyValue = selectedRow.Cells[7].Value;
                // Get the image path from the selected row
                if (int.TryParse(cellKeyValue.ToString(), out int rowKeyValue))
                {

                    // If the image path is not null or empty, update the pictureBoxProducts with the selected image
                    if (rowKeyValue > -1)
                    {
                        string path = DataService.GetPath(imageList, rowKeyValue);
                        if (path != null)
                        {
                            pictureBoxProducts.ImageLocation = path;
                        }
                        else
                        {
                            pictureBoxProducts.Image = defaultPicture;
                        }
                    }
                    else
                    {
                        pictureBoxProducts.Image = defaultImages[Array.IndexOf(defaultKeys, rowKeyValue)].Bitmap;
                    }

                    if (service.IsDefaultImage(pictureBoxProducts.Image, defaultPicture))
                    {
                        pictureBoxProducts.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    else
                    {
                        pictureBoxProducts.SizeMode = PictureBoxSizeMode.Zoom;
                    } 
                }
            } */
        }

        private void pictureBoxProducts_Click(object sender, EventArgs e)
        {
            /*
            if (service.IsDefaultImage(pictureBoxProducts.Image, defaultPicture))
            {
                int selectedRowIndex = dataGridViewOrders.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewOrders.Rows[selectedRowIndex];

                if (openFileDialogPicture.ShowDialog() != DialogResult.Cancel)
                {
                    int rowKeyValue = Convert.ToInt32(selectedRow.Cells[7].Value);
                    string filepath = openFileDialogPicture.FileName;
                    selectedRow.Cells[6].Value = filepath;
                    try
                    {
                        int keyIndex = Array.IndexOf(DataService.KVRowsImage.Keys(imageList), rowKeyValue);
                        using (Bitmap bitmap = new Bitmap(filepath))
                        {
                            imageList.Add(new DataService.KVRowsImage
                            {
                                Key = rowKeyValue,
                                Path = filepath,
                            }) ;
                        }
                        dataGridViewOrders.ClearSelection();
                        dataGridViewOrders.Select();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка загрузки картинки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } */
        }

        private void bindingNavigatorAddNewRow_Click(object sender, EventArgs e)
        { 
            /*
            int mostKey = int.MinValue;
            for (int i = 0; i < dataGridViewOrders.RowCount; i++)
            {
                int rowKey = Convert.ToInt32(dataGridViewOrders.Rows[i].Cells[7].Value);
                if (mostKey < rowKey)
                {
                    mostKey = rowKey;
                }
            }
            dataGridViewOrders.Rows.Add();
            dataGridViewOrders.Rows[dataGridViewOrders.RowCount - 1].Cells[7].Value = mostKey + 1; */
        }

        private void bindingNavigatorDeleteRow_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewOrders.Rows[selectedRowIndex];
            dataGridViewOrders.Rows.Remove(selectedRow);
        }
    }
}

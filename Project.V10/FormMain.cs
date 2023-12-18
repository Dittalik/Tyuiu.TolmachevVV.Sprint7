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

        private DataService.KVRowsImage[] defaultImages = new DataService.KVRowsImage[5];
        private Bitmap defaultPicture = Properties.Resources.picture_add;
        private int[] defaultKeys;

        private List<DataService.KVRowsImage> imageList = new List<DataService.KVRowsImage>();
        public FormMain()
        {
            InitializeComponent();
            InitializeFormData();
            InitializdeDefaultImages();

            openFileDialogTable.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialogPicture.Filter = "Файлы изображений(*.png,*.jpg, *.gif)|*.png;*.jpg;*.gif|Все файлы(*.*)|*.*";
            saveFileDialogTable.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";

            bindingSource.DataSource = dataGridViewOrders;
            bindingNavigatorTable.BindingSource = bindingSource;
        }
        private void InitializeFormData()
        {
            dataGridViewOrders.RowCount = 5;
            pictureBoxProducts.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProducts.Image = Properties.Resources.Poezd_Yauza;


            dataGridViewOrders.Rows[0].Cells[0].Value = "ООО \"Метрополитен\"";
            dataGridViewOrders.Rows[0].Cells[1].Value = "Локомотив \"Яуза\"";
            dataGridViewOrders.Rows[0].Cells[2].Value = 28_710;
            dataGridViewOrders.Rows[0].Cells[3].Value = 6;
            dataGridViewOrders.Rows[0].Cells[7].Value = -1;

            dataGridViewOrders.Rows[1].Cells[0].Value = "ООО \"Метрополитен\"";
            dataGridViewOrders.Rows[1].Cells[1].Value = "Локомотив 81-717";
            dataGridViewOrders.Rows[1].Cells[2].Value = 19_320;
            dataGridViewOrders.Rows[1].Cells[3].Value = 8;
            dataGridViewOrders.Rows[1].Cells[7].Value = -2;


            dataGridViewOrders.Rows[2].Cells[0].Value = "Гугера Б. А.";
            dataGridViewOrders.Rows[2].Cells[1].Value = "ВАЗ 2107";
            dataGridViewOrders.Rows[2].Cells[2].Value = 250;
            dataGridViewOrders.Rows[2].Cells[3].Value = 1;
            dataGridViewOrders.Rows[2].Cells[7].Value = -3;

            dataGridViewOrders.Rows[3].Cells[0].Value = "ООО КВПЕ_ДОМСТРОЙ";
            dataGridViewOrders.Rows[3].Cells[1].Value = "Панельный Дом Люкс Класса";
            dataGridViewOrders.Rows[3].Cells[2].Value = 200_000;
            dataGridViewOrders.Rows[3].Cells[3].Value = 2;
            dataGridViewOrders.Rows[3].Cells[7].Value = -4;

            dataGridViewOrders.Rows[4].Cells[0].Value = "ООО КОСМОС_ПЕ";
            dataGridViewOrders.Rows[4].Cells[1].Value = "Космический Шатл Межпланетных Полётов";
            dataGridViewOrders.Rows[4].Cells[2].Value = 200_000_000;
            dataGridViewOrders.Rows[4].Cells[3].Value = 2;
            dataGridViewOrders.Rows[4].Cells[7].Value = -5;
        }
        private void InitializdeDefaultImages()
        {
            defaultImages[0] = new DataService.KVRowsImage
            {
                Key = Convert.ToInt32(dataGridViewOrders.Rows[0].Cells[7].Value),
                Bitmap = Properties.Resources.Poezd_Yauza
            };

            defaultImages[1] = new DataService.KVRowsImage
            {
                Key = Convert.ToInt32(dataGridViewOrders.Rows[1].Cells[7].Value),
                Bitmap = Properties.Resources.Poezd8
            };


            defaultImages[2] = new DataService.KVRowsImage
            {
                Key = Convert.ToInt32(dataGridViewOrders.Rows[2].Cells[7].Value.ToString()),
                Bitmap = Properties.Resources.GoogeRA
            };


            defaultImages[3] = new DataService.KVRowsImage
            {
                Key = Convert.ToInt32(dataGridViewOrders.Rows[3].Cells[7].Value.ToString()),
                Bitmap = Properties.Resources.PanelH
            };


            defaultImages[4] = new DataService.KVRowsImage
            {
                Key = Convert.ToInt32(dataGridViewOrders.Rows[4].Cells[7].Value.ToString()),
                Bitmap = Properties.Resources.Rocket
            };

            defaultKeys = DataService.KVRowsImage.Keys(defaultImages);
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
            // Handle the selection changed event to update the pictureBoxProducts with the selected row's image
            if (dataGridViewOrders.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOrders.Rows[dataGridViewOrders.SelectedCells[0].RowIndex];

                object cellValue = selectedRow.Cells[7].Value;
                // Get the image path from the selected row
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int rowKeyValue))
                {

                    // If the image path is not null or empty, update the pictureBoxProducts with the selected image
                    if (rowKeyValue > -1)
                    {
                        int[] keys = DataService.KVRowsImage.Keys(imageList);
                        int keyIndex = Array.IndexOf(keys, rowKeyValue);
                        using (Bitmap bitmap = imageList[keyIndex].Bitmap)
                        {
                            pictureBoxProducts.Image = bitmap;
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
            }
        }

        private void pictureBoxProducts_Click(object sender, EventArgs e)
        {

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
                        imageList.Add(new DataService.KVRowsImage(rowKeyValue, filepath));
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
                int rowKey = Convert.ToInt32(dataGridViewOrders.Rows[i].Cells[7].Value);
                if (mostKey < rowKey)
                {
                    mostKey = rowKey;
                }
            }
            dataGridViewOrders.Rows.Add();
            dataGridViewOrders.Rows[dataGridViewOrders.RowCount - 1].Cells[7].Value = mostKey + 1;
            imageList.Add(new DataService.KVRowsImage(mostKey + 1, defaultPicture));
        }
    }
}

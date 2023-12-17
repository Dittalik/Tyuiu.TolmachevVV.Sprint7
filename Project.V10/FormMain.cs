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
        static private int defaultWidth = Properties.Resources.picture_add.Width;
        static private int defaultHeight = Properties.Resources.picture_add.Height;
        private string[] defaultKeys;

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
            dataGridViewOrders.RowCount = 6;
            pictureBoxProducts.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProducts.Image = Properties.Resources.Poezd_Yauza;

            dataGridViewOrders.Rows[0].Cells[0].Value = "ООО \"Метрополитен\"";
            dataGridViewOrders.Rows[0].Cells[1].Value = "Локомотив \"Яуза\"";
            dataGridViewOrders.Rows[0].Cells[2].Value = 28_710;
            dataGridViewOrders.Rows[0].Cells[3].Value = 6;

            dataGridViewOrders.Rows[1].Cells[0].Value = "ООО \"Метрополитен\"";
            dataGridViewOrders.Rows[1].Cells[1].Value = "Локомотив 81-717";
            dataGridViewOrders.Rows[1].Cells[2].Value = 19_320;
            dataGridViewOrders.Rows[1].Cells[3].Value = 8;


            dataGridViewOrders.Rows[2].Cells[0].Value = "Гугера Б. А.";
            dataGridViewOrders.Rows[2].Cells[1].Value = "ВАЗ 2107";
            dataGridViewOrders.Rows[2].Cells[2].Value = 250;
            dataGridViewOrders.Rows[2].Cells[3].Value = 1;

            dataGridViewOrders.Rows[3].Cells[0].Value = "ООО КВПЕ_ДОМСТРОЙ";
            dataGridViewOrders.Rows[3].Cells[1].Value = "Панельный Дом Люкс Класса";
            dataGridViewOrders.Rows[3].Cells[2].Value = 200_000;
            dataGridViewOrders.Rows[3].Cells[3].Value = 2;

            dataGridViewOrders.Rows[4].Cells[0].Value = "ООО КОСМОС_ПЕ";
            dataGridViewOrders.Rows[4].Cells[1].Value = "Космический Шатл Межпланетных Полётов";
            dataGridViewOrders.Rows[4].Cells[2].Value = 200_000_000;
            dataGridViewOrders.Rows[4].Cells[3].Value = 2;
        }
        private void InitializdeDefaultImages()
        {
            defaultImages[0] = new DataService.KVRowsImage
            {
                Key = dataGridViewOrders.Rows[0].Cells[1].Value.ToString(),
                Bitmap = Properties.Resources.Poezd_Yauza
            };


            defaultImages[1] = new DataService.KVRowsImage
            {
                Key = dataGridViewOrders.Rows[1].Cells[1].Value.ToString(),
                Bitmap = Properties.Resources.Poezd8
            };


            defaultImages[2] = new DataService.KVRowsImage
            {
                Key = dataGridViewOrders.Rows[2].Cells[1].Value.ToString(),
                Bitmap = Properties.Resources.GoogeRA
            };


            defaultImages[3] = new DataService.KVRowsImage
            {
                Key = dataGridViewOrders.Rows[3].Cells[1].Value.ToString(),
                Bitmap = Properties.Resources.PanelH
            };


            defaultImages[4] = new DataService.KVRowsImage
            {
                Key = dataGridViewOrders.Rows[4].Cells[1].Value.ToString(),
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
                int selectedRowIndex = dataGridViewOrders.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewOrders.Rows[selectedRowIndex];

                // Get the image path from the selected row
                string imagePath = selectedRow.Cells[6].Value?.ToString();
                string CellKeyValue = dataGridViewOrders.Rows[selectedRowIndex].Cells[1].Value?.ToString();
                
                // If the image path is not null or empty, update the pictureBoxProducts with the selected image
                if (!string.IsNullOrEmpty(imagePath))
                {
                    pictureBoxProducts.ImageLocation = imagePath;
                }
                else if (defaultKeys.Contains(CellKeyValue))
                {
                    pictureBoxProducts.Image = defaultImages[Array.IndexOf(defaultKeys, CellKeyValue)].Bitmap;
                }
                else
                {
                    pictureBoxProducts.Image = Properties.Resources.picture_add;
                }

                if (service.IsDefaultImage(pictureBoxProducts.Image, defaultWidth, defaultHeight))
                {
                    pictureBoxProducts.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    pictureBoxProducts.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void pictureBoxProducts_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewOrders.Rows[selectedRowIndex];
            if (service.IsDefaultImage(pictureBoxProducts.Image, defaultWidth, defaultHeight))
            {
                if (!string.IsNullOrEmpty(selectedRow.Cells[1].Value?.ToString()))
                {
                    openFileDialogPicture.ShowDialog();
                    string filepath = openFileDialogPicture.FileName;
                    selectedRow.Cells[6].Value = filepath;
                    try
                    {
                        service.AddBitmapFromPath(imageList, selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[6].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка загрузки картинки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //тут надо разобраться почему в картинку записывается крестик и удалить его значение из листа картинок
                    }
                }
                else
                {
                    MessageBox.Show("Чтобы присвоить строке картинку, нужно указать название заказа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bindingNavigatorAddNewRow_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.Rows.Add();
        }
    }
}

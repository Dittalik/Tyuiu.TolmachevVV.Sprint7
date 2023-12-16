﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTable.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTable.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        private void FormMain_Load(object sender, EventArgs e)
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

                // If the image path is not null or empty, update the pictureBoxProducts with the selected image
                if (!string.IsNullOrEmpty(imagePath))
                {
                    pictureBoxProducts.ImageLocation = imagePath;
                }
                else
                {
                    if (dataGridViewOrders.Rows[selectedRowIndex].Cells[1].Value?.ToString() == "Локомотив \"Яуза\"")
                    {
                        pictureBoxProducts.Image = Properties.Resources.Poezd_Yauza;
                    }
                    else if (dataGridViewOrders.Rows[selectedRowIndex].Cells[1].Value?.ToString() == "Локомотив 81-717")
                    {
                        pictureBoxProducts.Image = Properties.Resources.Poezd8;
                    }
                    else if (dataGridViewOrders.Rows[selectedRowIndex].Cells[1].Value?.ToString() == "ВАЗ 2107")
                    {
                        pictureBoxProducts.Image = Properties.Resources.GoogeRA;
                    }
                    else if (dataGridViewOrders.Rows[selectedRowIndex].Cells[1].Value?.ToString() == "Панельный Дом Люкс Класса")
                    {
                        pictureBoxProducts.Image = Properties.Resources.PanelH;
                    }
                    else if (dataGridViewOrders.Rows[selectedRowIndex].Cells[1].Value?.ToString() == "Космический Шатл Межпланетных Полётов")
                    {
                        pictureBoxProducts.Image = Properties.Resources.Rocket;
                    }
                    else
                    {
                        pictureBoxProducts.Image = Properties.Resources.picture_add;
                    }


                    if (IsDefaultImage(pictureBoxProducts.Image))
                    {
                        pictureBoxProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                    }
                    else
                    {
                        pictureBoxProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    }

                }
            }
        }

        private bool IsDefaultImage(Image image)
        {
            // Assuming defaultImageWidth and defaultImageHeight are the dimensions of your default image
            int defaultImageWidth = Properties.Resources.picture_add.Width;
            int defaultImageHeight = Properties.Resources.picture_add.Height;

            return (image.Width == defaultImageWidth && image.Height == defaultImageHeight);
        }
    }
}
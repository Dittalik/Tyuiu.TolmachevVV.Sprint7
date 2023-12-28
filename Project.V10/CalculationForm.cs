using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.V10.Lib;

namespace Project.V10
{
    public partial class CalculationForm : Form
    {
        private FormMain mainForm;
        public CalculationForm(FormMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        

        private void buttonSum_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = mainForm?.GetSelectedCellsValues();
            if (cells != null)
            {
                textBoxResult.Text = DataService.CalculateCells(cells, 0).ToString();
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = mainForm?.GetSelectedCellsValues();
            if (cells != null)
            {
                textBoxResult.Text = DataService.CalculateCells(cells, 1).ToString();
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = mainForm?.GetSelectedCellsValues();
            if (cells != null)
            {
                textBoxResult.Text = DataService.CalculateCells(cells, 2).ToString();
            }
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = mainForm?.GetSelectedCellsValues();
            if (cells != null)
            {
                textBoxResult.Text = DataService.CalculateCells(cells, 3).ToString();
            }
        }

        private void buttonMid_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = mainForm?.GetSelectedCellsValues();
            if (cells != null)
            {
                textBoxResult.Text = DataService.CalculateCells(cells, 4).ToString();
            }
        }
    }
}

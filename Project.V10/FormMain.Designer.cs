
namespace Project.V10
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxGridAndPic = new System.Windows.Forms.GroupBox();
            this.splitContainerGridAndPic = new System.Windows.Forms.SplitContainer();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuxaryPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialogTable = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTable = new System.Windows.Forms.SaveFileDialog();
            this.bindingNavigatorTable = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.directorySearcherTable = new System.DirectoryServices.DirectorySearcher();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonPictureVisible = new System.Windows.Forms.Button();
            this.buttonPictureNotVisible = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewRow = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxMagnifier = new System.Windows.Forms.PictureBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.pictureBoxProducts = new System.Windows.Forms.PictureBox();
            this.groupBoxGridAndPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGridAndPic)).BeginInit();
            this.splitContainerGridAndPic.Panel1.SuspendLayout();
            this.splitContainerGridAndPic.Panel2.SuspendLayout();
            this.splitContainerGridAndPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTable)).BeginInit();
            this.bindingNavigatorTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGridAndPic
            // 
            this.groupBoxGridAndPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGridAndPic.Controls.Add(this.splitContainerGridAndPic);
            this.groupBoxGridAndPic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxGridAndPic.Location = new System.Drawing.Point(12, 79);
            this.groupBoxGridAndPic.Name = "groupBoxGridAndPic";
            this.groupBoxGridAndPic.Size = new System.Drawing.Size(904, 369);
            this.groupBoxGridAndPic.TabIndex = 3;
            this.groupBoxGridAndPic.TabStop = false;
            // 
            // splitContainerGridAndPic
            // 
            this.splitContainerGridAndPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGridAndPic.IsSplitterFixed = true;
            this.splitContainerGridAndPic.Location = new System.Drawing.Point(3, 16);
            this.splitContainerGridAndPic.Name = "splitContainerGridAndPic";
            // 
            // splitContainerGridAndPic.Panel1
            // 
            this.splitContainerGridAndPic.Panel1.Controls.Add(this.dataGridViewOrders);
            this.splitContainerGridAndPic.Panel1MinSize = 520;
            // 
            // splitContainerGridAndPic.Panel2
            // 
            this.splitContainerGridAndPic.Panel2.Controls.Add(this.pictureBoxProducts);
            this.splitContainerGridAndPic.Panel2.Controls.Add(this.chart1);
            this.splitContainerGridAndPic.Panel2MinSize = 350;
            this.splitContainerGridAndPic.Size = new System.Drawing.Size(898, 350);
            this.splitContainerGridAndPic.SplitterDistance = 540;
            this.splitContainerGridAndPic.SplitterWidth = 8;
            this.splitContainerGridAndPic.TabIndex = 0;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Product,
            this.Price,
            this.ProductCount,
            this.Summ,
            this.LuxaryPoints,
            this.PictureAddress});
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(540, 350);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
            // 
            // Client
            // 
            this.Client.HeaderText = "Заказчик:";
            this.Client.Name = "Client";
            this.Client.Width = 83;
            // 
            // Product
            // 
            this.Product.HeaderText = "Заказ:";
            this.Product.Name = "Product";
            this.Product.Width = 66;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена (т. руб):";
            this.Price.Name = "Price";
            this.Price.Width = 98;
            // 
            // ProductCount
            // 
            this.ProductCount.HeaderText = "Количество:";
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Width = 94;
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Стоимость";
            this.Summ.Name = "Summ";
            this.Summ.ReadOnly = true;
            this.Summ.Width = 87;
            // 
            // LuxaryPoints
            // 
            this.LuxaryPoints.HeaderText = "Лакшери:";
            this.LuxaryPoints.Name = "LuxaryPoints";
            this.LuxaryPoints.ReadOnly = true;
            this.LuxaryPoints.Width = 81;
            // 
            // PictureAddress
            // 
            this.PictureAddress.HeaderText = "PictureAddress";
            this.PictureAddress.Name = "PictureAddress";
            this.PictureAddress.ReadOnly = true;
            this.PictureAddress.Visible = false;
            this.PictureAddress.Width = 103;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(350, 350);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // openFileDialogTable
            // 
            this.openFileDialogTable.FileName = "openFileDialog1";
            // 
            // bindingNavigatorTable
            // 
            this.bindingNavigatorTable.AddNewItem = this.bindingNavigatorAddNewRow;
            this.bindingNavigatorTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bindingNavigatorTable.AutoSize = false;
            this.bindingNavigatorTable.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorTable.DeleteItem = this.bindingNavigatorDeleteRow;
            this.bindingNavigatorTable.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewRow,
            this.bindingNavigatorDeleteRow});
            this.bindingNavigatorTable.Location = new System.Drawing.Point(15, 451);
            this.bindingNavigatorTable.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorTable.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorTable.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorTable.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorTable.Name = "bindingNavigatorTable";
            this.bindingNavigatorTable.Padding = new System.Windows.Forms.Padding(0);
            this.bindingNavigatorTable.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorTable.Size = new System.Drawing.Size(263, 20);
            this.bindingNavigatorTable.TabIndex = 1;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 17);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 20);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 20);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 20);
            // 
            // directorySearcherTable
            // 
            this.directorySearcherTable.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcherTable.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcherTable.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Location = new System.Drawing.Point(302, 451);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(253, 20);
            this.textBoxSearch.TabIndex = 6;
            // 
            // buttonPictureVisible
            // 
            this.buttonPictureVisible.Location = new System.Drawing.Point(563, 451);
            this.buttonPictureVisible.Name = "buttonPictureVisible";
            this.buttonPictureVisible.Size = new System.Drawing.Size(75, 23);
            this.buttonPictureVisible.TabIndex = 7;
            this.buttonPictureVisible.Text = "Картинка";
            this.buttonPictureVisible.UseVisualStyleBackColor = true;
            this.buttonPictureVisible.Click += new System.EventHandler(this.buttonPictureVisible_Click);
            // 
            // buttonPictureNotVisible
            // 
            this.buttonPictureNotVisible.Location = new System.Drawing.Point(644, 451);
            this.buttonPictureNotVisible.Name = "buttonPictureNotVisible";
            this.buttonPictureNotVisible.Size = new System.Drawing.Size(75, 23);
            this.buttonPictureNotVisible.TabIndex = 7;
            this.buttonPictureNotVisible.Text = "График";
            this.buttonPictureNotVisible.UseVisualStyleBackColor = true;
            this.buttonPictureNotVisible.Click += new System.EventHandler(this.buttonPictureNotVisible_Click);
            // 
            // buttonChart
            // 
            this.buttonChart.Enabled = false;
            this.buttonChart.Location = new System.Drawing.Point(725, 451);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(188, 23);
            this.buttonChart.TabIndex = 7;
            this.buttonChart.Text = "Нарисовать график";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonPictureNotVisible_Click);
            // 
            // bindingNavigatorAddNewRow
            // 
            this.bindingNavigatorAddNewRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewRow.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewRow.Image")));
            this.bindingNavigatorAddNewRow.Name = "bindingNavigatorAddNewRow";
            this.bindingNavigatorAddNewRow.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewRow.Size = new System.Drawing.Size(23, 17);
            this.bindingNavigatorAddNewRow.Text = "Добавить Строку";
            // 
            // bindingNavigatorDeleteRow
            // 
            this.bindingNavigatorDeleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteRow.Image")));
            this.bindingNavigatorDeleteRow.Name = "bindingNavigatorDeleteRow";
            this.bindingNavigatorDeleteRow.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteRow.Size = new System.Drawing.Size(23, 17);
            this.bindingNavigatorDeleteRow.Text = "Удалить Строку";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 17);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 17);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 17);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 17);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // pictureBoxMagnifier
            // 
            this.pictureBoxMagnifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxMagnifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMagnifier.Image = global::Project.V10.Properties.Resources.magnifier;
            this.pictureBoxMagnifier.Location = new System.Drawing.Point(281, 451);
            this.pictureBoxMagnifier.Name = "pictureBoxMagnifier";
            this.pictureBoxMagnifier.Size = new System.Drawing.Size(22, 20);
            this.pictureBoxMagnifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMagnifier.TabIndex = 5;
            this.pictureBoxMagnifier.TabStop = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Image = global::Project.V10.Properties.Resources.Kassadin_button;
            this.buttonHelp.Location = new System.Drawing.Point(843, 13);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(70, 60);
            this.buttonHelp.TabIndex = 0;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Image = global::Project.V10.Properties.Resources.table_save;
            this.buttonSaveFile.Location = new System.Drawing.Point(91, 13);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(70, 60);
            this.buttonSaveFile.TabIndex = 0;
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = global::Project.V10.Properties.Resources.table_add;
            this.buttonOpenFile.Location = new System.Drawing.Point(15, 13);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(70, 60);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProducts
            // 
            this.pictureBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProducts.Image = global::Project.V10.Properties.Resources.picture_add;
            this.pictureBoxProducts.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProducts.Name = "pictureBoxProducts";
            this.pictureBoxProducts.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProducts.TabIndex = 0;
            this.pictureBoxProducts.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 483);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.buttonPictureNotVisible);
            this.Controls.Add(this.buttonPictureVisible);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.bindingNavigatorTable);
            this.Controls.Add(this.pictureBoxMagnifier);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.groupBoxGridAndPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 7 | V10 | Tolmachev V. V.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxGridAndPic.ResumeLayout(false);
            this.splitContainerGridAndPic.Panel1.ResumeLayout(false);
            this.splitContainerGridAndPic.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGridAndPic)).EndInit();
            this.splitContainerGridAndPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTable)).EndInit();
            this.bindingNavigatorTable.ResumeLayout(false);
            this.bindingNavigatorTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxGridAndPic;
        private System.Windows.Forms.SplitContainer splitContainerGridAndPic;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.PictureBox pictureBoxProducts;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable;
        private System.Windows.Forms.BindingNavigator bindingNavigatorTable;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewRow;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteRow;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.DirectoryServices.DirectorySearcher directorySearcherTable;
        private System.Windows.Forms.PictureBox pictureBoxMagnifier;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonPictureVisible;
        private System.Windows.Forms.Button buttonPictureNotVisible;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuxaryPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureAddress;
    }
}


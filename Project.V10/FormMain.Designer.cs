
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.groupBoxGridAndPic = new System.Windows.Forms.GroupBox();
            this.splitContainerGridAndPic = new System.Windows.Forms.SplitContainer();
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.pictureBoxProducts = new System.Windows.Forms.PictureBox();
            this.chartProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialogTable = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTable = new System.Windows.Forms.SaveFileDialog();
            this.bindingNavigatorTable = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewRow = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorButtonSum = new System.Windows.Forms.ToolStripButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonPictureVisible = new System.Windows.Forms.Button();
            this.buttonPictureNotVisible = new System.Windows.Forms.Button();
            this.buttonChartAddLine = new System.Windows.Forms.Button();
            this.pictureBoxMagnifier = new System.Windows.Forms.PictureBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogPicture = new System.Windows.Forms.OpenFileDialog();
            this.directorySearcher = new System.DirectoryServices.DirectorySearcher();
            this.pictureBoxFilter = new System.Windows.Forms.PictureBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFilter = new System.Windows.Forms.ToolTip(this.components);
            this.buttonChartDeleteLine = new System.Windows.Forms.Button();
            this.toolTipChart = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.pictureBoxFilterExecute = new System.Windows.Forms.PictureBox();
            this.rowKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuxaryPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxGridAndPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGridAndPic)).BeginInit();
            this.splitContainerGridAndPic.Panel1.SuspendLayout();
            this.splitContainerGridAndPic.Panel2.SuspendLayout();
            this.splitContainerGridAndPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTable)).BeginInit();
            this.bindingNavigatorTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilterExecute)).BeginInit();
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
            this.splitContainerGridAndPic.Panel1.Controls.Add(this.buttonCalculation);
            this.splitContainerGridAndPic.Panel1.Controls.Add(this.dataGridViewOrders);
            this.splitContainerGridAndPic.Panel1MinSize = 520;
            // 
            // splitContainerGridAndPic.Panel2
            // 
            this.splitContainerGridAndPic.Panel2.Controls.Add(this.pictureBoxProducts);
            this.splitContainerGridAndPic.Panel2.Controls.Add(this.chartProducts);
            this.splitContainerGridAndPic.Panel2MinSize = 350;
            this.splitContainerGridAndPic.Size = new System.Drawing.Size(898, 350);
            this.splitContainerGridAndPic.SplitterDistance = 540;
            this.splitContainerGridAndPic.SplitterWidth = 8;
            this.splitContainerGridAndPic.TabIndex = 0;
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculation.Image = ((System.Drawing.Image)(resources.GetObject("buttonCalculation.Image")));
            this.buttonCalculation.Location = new System.Drawing.Point(477, 272);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(60, 60);
            this.buttonCalculation.TabIndex = 0;
            this.buttonCalculation.UseVisualStyleBackColor = true;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeColumns = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowKey,
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
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.Size = new System.Drawing.Size(540, 350);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrders_ColumnHeaderMouseClick);
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
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
            this.pictureBoxProducts.Click += new System.EventHandler(this.pictureBoxProducts_Click);
            // 
            // chartProducts
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProducts.ChartAreas.Add(chartArea2);
            this.chartProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartProducts.Location = new System.Drawing.Point(0, 0);
            this.chartProducts.Name = "chartProducts";
            this.chartProducts.Size = new System.Drawing.Size(350, 350);
            this.chartProducts.TabIndex = 1;
            // 
            // openFileDialogTable
            // 
            this.openFileDialogTable.FileName = "openFileDialog1";
            // 
            // bindingNavigatorTable
            // 
            this.bindingNavigatorTable.AddNewItem = null;
            this.bindingNavigatorTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bindingNavigatorTable.AutoSize = false;
            this.bindingNavigatorTable.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorTable.DeleteItem = null;
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
            this.bindingNavigatorDeleteRow,
            this.bindingNavigatorButtonSum});
            this.bindingNavigatorTable.Location = new System.Drawing.Point(15, 451);
            this.bindingNavigatorTable.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorTable.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorTable.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorTable.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorTable.Name = "bindingNavigatorTable";
            this.bindingNavigatorTable.Padding = new System.Windows.Forms.Padding(0);
            this.bindingNavigatorTable.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorTable.Size = new System.Drawing.Size(263, 21);
            this.bindingNavigatorTable.TabIndex = 1;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 18);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 18);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 18);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 21);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(25, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 21);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 18);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 18);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 21);
            // 
            // bindingNavigatorAddNewRow
            // 
            this.bindingNavigatorAddNewRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewRow.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewRow.Image")));
            this.bindingNavigatorAddNewRow.Name = "bindingNavigatorAddNewRow";
            this.bindingNavigatorAddNewRow.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewRow.Size = new System.Drawing.Size(23, 18);
            this.bindingNavigatorAddNewRow.Text = "Добавить Строку";
            this.bindingNavigatorAddNewRow.Click += new System.EventHandler(this.bindingNavigatorAddNewRow_Click);
            // 
            // bindingNavigatorDeleteRow
            // 
            this.bindingNavigatorDeleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteRow.Image")));
            this.bindingNavigatorDeleteRow.Name = "bindingNavigatorDeleteRow";
            this.bindingNavigatorDeleteRow.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteRow.Size = new System.Drawing.Size(23, 18);
            this.bindingNavigatorDeleteRow.Text = "Удалить Строку";
            this.bindingNavigatorDeleteRow.Click += new System.EventHandler(this.bindingNavigatorDeleteRow_Click);
            // 
            // bindingNavigatorButtonSum
            // 
            this.bindingNavigatorButtonSum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorButtonSum.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorButtonSum.Image")));
            this.bindingNavigatorButtonSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorButtonSum.Name = "bindingNavigatorButtonSum";
            this.bindingNavigatorButtonSum.Size = new System.Drawing.Size(23, 18);
            this.bindingNavigatorButtonSum.ToolTipText = "Вычислить стоимость";
            this.bindingNavigatorButtonSum.Click += new System.EventHandler(this.bindingNavigatorButtonSum_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(302, 451);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(253, 21);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonPictureVisible
            // 
            this.buttonPictureVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPictureVisible.Location = new System.Drawing.Point(563, 451);
            this.buttonPictureVisible.Name = "buttonPictureVisible";
            this.buttonPictureVisible.Size = new System.Drawing.Size(75, 30);
            this.buttonPictureVisible.TabIndex = 7;
            this.buttonPictureVisible.Text = "Картинка";
            this.buttonPictureVisible.UseVisualStyleBackColor = true;
            this.buttonPictureVisible.Click += new System.EventHandler(this.buttonPictureVisible_Click);
            // 
            // buttonPictureNotVisible
            // 
            this.buttonPictureNotVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPictureNotVisible.Location = new System.Drawing.Point(644, 451);
            this.buttonPictureNotVisible.Name = "buttonPictureNotVisible";
            this.buttonPictureNotVisible.Size = new System.Drawing.Size(75, 30);
            this.buttonPictureNotVisible.TabIndex = 7;
            this.buttonPictureNotVisible.Text = "График";
            this.buttonPictureNotVisible.UseVisualStyleBackColor = true;
            this.buttonPictureNotVisible.Click += new System.EventHandler(this.buttonPictureNotVisible_Click);
            // 
            // buttonChartAddLine
            // 
            this.buttonChartAddLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChartAddLine.Enabled = false;
            this.buttonChartAddLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonChartAddLine.Image")));
            this.buttonChartAddLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChartAddLine.Location = new System.Drawing.Point(725, 451);
            this.buttonChartAddLine.Name = "buttonChartAddLine";
            this.buttonChartAddLine.Size = new System.Drawing.Size(91, 30);
            this.buttonChartAddLine.TabIndex = 7;
            this.buttonChartAddLine.Text = "       Добавить";
            this.toolTipChart.SetToolTip(this.buttonChartAddLine, "Добавить.\r\nВыделите числовые значения, которые хотите добавить");
            this.buttonChartAddLine.UseVisualStyleBackColor = true;
            this.buttonChartAddLine.Click += new System.EventHandler(this.buttonChartAddLine_Click);
            // 
            // pictureBoxMagnifier
            // 
            this.pictureBoxMagnifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxMagnifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMagnifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMagnifier.Image = global::Project.V10.Properties.Resources.magnifier;
            this.pictureBoxMagnifier.Location = new System.Drawing.Point(281, 451);
            this.pictureBoxMagnifier.Name = "pictureBoxMagnifier";
            this.pictureBoxMagnifier.Size = new System.Drawing.Size(22, 21);
            this.pictureBoxMagnifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMagnifier.TabIndex = 5;
            this.pictureBoxMagnifier.TabStop = false;
            this.toolTipSearch.SetToolTip(this.pictureBoxMagnifier, "Режим поиска.");
            this.pictureBoxMagnifier.Click += new System.EventHandler(this.pictureBoxMagnifier_Click);
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
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialogPicture
            // 
            this.openFileDialogPicture.FileName = "openFileDialog1";
            // 
            // directorySearcher
            // 
            this.directorySearcher.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBoxFilter
            // 
            this.pictureBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilter.Enabled = false;
            this.pictureBoxFilter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFilter.Image")));
            this.pictureBoxFilter.Location = new System.Drawing.Point(281, 451);
            this.pictureBoxFilter.Name = "pictureBoxFilter";
            this.pictureBoxFilter.Size = new System.Drawing.Size(22, 21);
            this.pictureBoxFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFilter.TabIndex = 5;
            this.pictureBoxFilter.TabStop = false;
            this.toolTipFilter.SetToolTip(this.pictureBoxFilter, "Режим фильтра.");
            this.pictureBoxFilter.Visible = false;
            this.pictureBoxFilter.Click += new System.EventHandler(this.pictureBoxFilter_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFilter.Enabled = false;
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxFilter.ItemHeight = 13;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Заказчик, Длина:",
            "Заказ, Длина:",
            "Цена, Величина:",
            "Количество, Величина:",
            "Стоимость, Величина:",
            "Лакшери, Значение:"});
            this.comboBoxFilter.Location = new System.Drawing.Point(302, 451);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(130, 21);
            this.comboBoxFilter.TabIndex = 8;
            this.comboBoxFilter.Visible = false;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            this.comboBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFilter_KeyPress);
            // 
            // toolTipSearch
            // 
            this.toolTipSearch.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSearch.ToolTipTitle = "Поиск";
            // 
            // toolTipFilter
            // 
            this.toolTipFilter.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipFilter.ToolTipTitle = "Фильтр";
            // 
            // buttonChartDeleteLine
            // 
            this.buttonChartDeleteLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChartDeleteLine.Enabled = false;
            this.buttonChartDeleteLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonChartDeleteLine.Image")));
            this.buttonChartDeleteLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChartDeleteLine.Location = new System.Drawing.Point(822, 451);
            this.buttonChartDeleteLine.Name = "buttonChartDeleteLine";
            this.buttonChartDeleteLine.Size = new System.Drawing.Size(91, 30);
            this.buttonChartDeleteLine.TabIndex = 7;
            this.buttonChartDeleteLine.Text = "      Удалить";
            this.toolTipChart.SetToolTip(this.buttonChartDeleteLine, "Удалить последнюю линию.");
            this.buttonChartDeleteLine.UseVisualStyleBackColor = true;
            this.buttonChartDeleteLine.Click += new System.EventHandler(this.buttonChartDeleteLine_Click);
            // 
            // toolTipChart
            // 
            this.toolTipChart.ToolTipTitle = "Линия графика";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Enabled = false;
            this.textBoxFilter.Location = new System.Drawing.Point(432, 451);
            this.textBoxFilter.Multiline = true;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(123, 21);
            this.textBoxFilter.TabIndex = 9;
            this.textBoxFilter.Visible = false;
            this.textBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilter_KeyPress);
            // 
            // pictureBoxFilterExecute
            // 
            this.pictureBoxFilterExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxFilterExecute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFilterExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilterExecute.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFilterExecute.Image")));
            this.pictureBoxFilterExecute.Location = new System.Drawing.Point(533, 451);
            this.pictureBoxFilterExecute.Name = "pictureBoxFilterExecute";
            this.pictureBoxFilterExecute.Size = new System.Drawing.Size(22, 21);
            this.pictureBoxFilterExecute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFilterExecute.TabIndex = 5;
            this.pictureBoxFilterExecute.TabStop = false;
            this.pictureBoxFilterExecute.Click += new System.EventHandler(this.pictureBoxFilterExecute_Click);
            // 
            // rowKey
            // 
            this.rowKey.HeaderText = "rowKey";
            this.rowKey.Name = "rowKey";
            this.rowKey.ReadOnly = true;
            this.rowKey.Visible = false;
            this.rowKey.Width = 48;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 483);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBoxFilterExecute);
            this.Controls.Add(this.buttonChartDeleteLine);
            this.Controls.Add(this.buttonChartAddLine);
            this.Controls.Add(this.buttonPictureNotVisible);
            this.Controls.Add(this.buttonPictureVisible);
            this.Controls.Add(this.bindingNavigatorTable);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.groupBoxGridAndPic);
            this.Controls.Add(this.pictureBoxMagnifier);
            this.Controls.Add(this.pictureBoxFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.comboBoxFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 7 | V10 | Tolmachev V. V.";
            this.groupBoxGridAndPic.ResumeLayout(false);
            this.splitContainerGridAndPic.Panel1.ResumeLayout(false);
            this.splitContainerGridAndPic.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGridAndPic)).EndInit();
            this.splitContainerGridAndPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTable)).EndInit();
            this.bindingNavigatorTable.ResumeLayout(false);
            this.bindingNavigatorTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilterExecute)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxMagnifier;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProducts;
        private System.Windows.Forms.Button buttonPictureVisible;
        private System.Windows.Forms.Button buttonPictureNotVisible;
        private System.Windows.Forms.Button buttonChartAddLine;
        private System.Windows.Forms.OpenFileDialog openFileDialogPicture;
        private System.DirectoryServices.DirectorySearcher directorySearcher;
        private System.Windows.Forms.ToolStripButton bindingNavigatorButtonSum;
        private System.Windows.Forms.PictureBox pictureBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.ToolTip toolTipFilter;
        private System.Windows.Forms.Button buttonChartDeleteLine;
        private System.Windows.Forms.ToolTip toolTipChart;
        private System.Windows.Forms.Button buttonCalculation;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.PictureBox pictureBoxFilterExecute;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuxaryPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureAddress;
    }
}


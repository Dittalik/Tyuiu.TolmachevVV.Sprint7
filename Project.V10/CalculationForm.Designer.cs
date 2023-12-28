namespace Project.V10
{
    partial class CalculationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationForm));
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMid = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(78, 45);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(59, 28);
            this.buttonMin.TabIndex = 2;
            this.buttonMin.Text = "Min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(78, 11);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(59, 28);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "Кол-во";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(12, 11);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(59, 28);
            this.buttonSum.TabIndex = 2;
            this.buttonSum.Text = "Сумма";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(78, 79);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(59, 28);
            this.buttonMax.TabIndex = 2;
            this.buttonMax.Text = "Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMid
            // 
            this.buttonMid.Location = new System.Drawing.Point(12, 79);
            this.buttonMid.Name = "buttonMid";
            this.buttonMid.Size = new System.Drawing.Size(59, 28);
            this.buttonMid.TabIndex = 2;
            this.buttonMid.Text = "Среднее";
            this.buttonMid.UseVisualStyleBackColor = true;
            this.buttonMid.Click += new System.EventHandler(this.buttonMid_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Location = new System.Drawing.Point(12, 45);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(59, 28);
            this.textBoxResult.TabIndex = 3;
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 117);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonMid);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonMin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(167, 156);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(167, 156);
            this.Name = "CalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMid;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}
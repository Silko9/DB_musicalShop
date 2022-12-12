namespace DB_musicalShop.FormTable
{
    partial class FormTopSell
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
            this.dataTopRecord = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTopRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTopRecord
            // 
            this.dataTopRecord.AllowUserToAddRows = false;
            this.dataTopRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTopRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataTopRecord.Location = new System.Drawing.Point(11, 36);
            this.dataTopRecord.Margin = new System.Windows.Forms.Padding(2);
            this.dataTopRecord.MultiSelect = false;
            this.dataTopRecord.Name = "dataTopRecord";
            this.dataTopRecord.ReadOnly = true;
            this.dataTopRecord.RowHeadersVisible = false;
            this.dataTopRecord.RowHeadersWidth = 51;
            this.dataTopRecord.RowTemplate.Height = 24;
            this.dataTopRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTopRecord.Size = new System.Drawing.Size(251, 295);
            this.dataTopRecord.TabIndex = 84;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер пластинки";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Продано";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(57, 12);
            this.numericYear.Margin = new System.Windows.Forms.Padding(2);
            this.numericYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(205, 20);
            this.numericYear.TabIndex = 82;
            this.numericYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericYear.ValueChanged += new System.EventHandler(this.numericYear_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Год";
            // 
            // FormTopSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 341);
            this.Controls.Add(this.dataTopRecord);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.label5);
            this.Name = "FormTopSell";
            this.Text = "Лидеры продаж";
            ((System.ComponentModel.ISupportInitialize)(this.dataTopRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTopRecord;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
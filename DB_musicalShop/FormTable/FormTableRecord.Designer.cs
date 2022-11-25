namespace DB_musicalShop
{
    partial class FormTableRecord
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataRecord = new System.Windows.Forms.DataGridView();
            this.boxNumberRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericRetailPrice = new System.Windows.Forms.NumericUpDown();
            this.numericWholesalePrice = new System.Windows.Forms.NumericUpDown();
            this.boxComposition = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTopRecord = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataPerformance = new System.Windows.Forms.DataGridView();
            this.boxPerformance = new System.Windows.Forms.ComboBox();
            this.buttonAddPerformance = new System.Windows.Forms.Button();
            this.buttonDeletePerformance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetailPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWholesalePrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTopRecord)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Номер пластинки";
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(198, 560);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(182, 44);
            this.buttonUpdateTable.TabIndex = 69;
            this.buttonUpdateTable.Text = "Обновить таблицу";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(198, 416);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 44);
            this.buttonAdd.TabIndex = 68;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(198, 464);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(182, 44);
            this.buttonChange.TabIndex = 67;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(198, 512);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 44);
            this.buttonDelete.TabIndex = 66;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataRecord
            // 
            this.dataRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecord.Location = new System.Drawing.Point(9, 9);
            this.dataRecord.Margin = new System.Windows.Forms.Padding(2);
            this.dataRecord.Name = "dataRecord";
            this.dataRecord.ReadOnly = true;
            this.dataRecord.RowHeadersWidth = 51;
            this.dataRecord.RowTemplate.Height = 24;
            this.dataRecord.Size = new System.Drawing.Size(453, 400);
            this.dataRecord.TabIndex = 65;
            this.dataRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // boxNumberRecord
            // 
            this.boxNumberRecord.Location = new System.Drawing.Point(11, 429);
            this.boxNumberRecord.Margin = new System.Windows.Forms.Padding(2);
            this.boxNumberRecord.MaxLength = 10;
            this.boxNumberRecord.Name = "boxNumberRecord";
            this.boxNumberRecord.Size = new System.Drawing.Size(183, 20);
            this.boxNumberRecord.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 457);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Оптовая цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 501);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Розничная цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 546);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Произведение";
            // 
            // numericRetailPrice
            // 
            this.numericRetailPrice.DecimalPlaces = 2;
            this.numericRetailPrice.Location = new System.Drawing.Point(11, 472);
            this.numericRetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.numericRetailPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericRetailPrice.Name = "numericRetailPrice";
            this.numericRetailPrice.Size = new System.Drawing.Size(182, 20);
            this.numericRetailPrice.TabIndex = 77;
            // 
            // numericWholesalePrice
            // 
            this.numericWholesalePrice.DecimalPlaces = 2;
            this.numericWholesalePrice.Location = new System.Drawing.Point(11, 516);
            this.numericWholesalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.numericWholesalePrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericWholesalePrice.Name = "numericWholesalePrice";
            this.numericWholesalePrice.Size = new System.Drawing.Size(182, 20);
            this.numericWholesalePrice.TabIndex = 78;
            // 
            // boxComposition
            // 
            this.boxComposition.FormattingEnabled = true;
            this.boxComposition.Location = new System.Drawing.Point(11, 561);
            this.boxComposition.Margin = new System.Windows.Forms.Padding(2);
            this.boxComposition.Name = "boxComposition";
            this.boxComposition.Size = new System.Drawing.Size(183, 21);
            this.boxComposition.TabIndex = 79;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.numericYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(466, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(263, 400);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лидер продаж";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(4, 42);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(182, 44);
            this.buttonSearch.TabIndex = 81;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(50, 20);
            this.numericYear.Margin = new System.Windows.Forms.Padding(2);
            this.numericYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(133, 20);
            this.numericYear.TabIndex = 66;
            this.numericYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Год";
            // 
            // dataTopRecord
            // 
            this.dataTopRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTopRecord.Location = new System.Drawing.Point(473, 110);
            this.dataTopRecord.Margin = new System.Windows.Forms.Padding(2);
            this.dataTopRecord.Name = "dataTopRecord";
            this.dataTopRecord.ReadOnly = true;
            this.dataTopRecord.RowHeadersWidth = 51;
            this.dataTopRecord.RowTemplate.Height = 24;
            this.dataTopRecord.Size = new System.Drawing.Size(251, 295);
            this.dataTopRecord.TabIndex = 81;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataPerformance);
            this.groupBox2.Controls.Add(this.boxPerformance);
            this.groupBox2.Controls.Add(this.buttonAddPerformance);
            this.groupBox2.Controls.Add(this.buttonDeletePerformance);
            this.groupBox2.Location = new System.Drawing.Point(385, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 273);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исполнения";
            // 
            // dataPerformance
            // 
            this.dataPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerformance.Location = new System.Drawing.Point(5, 15);
            this.dataPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.dataPerformance.Name = "dataPerformance";
            this.dataPerformance.ReadOnly = true;
            this.dataPerformance.RowHeadersWidth = 51;
            this.dataPerformance.RowTemplate.Height = 24;
            this.dataPerformance.Size = new System.Drawing.Size(329, 131);
            this.dataPerformance.TabIndex = 18;
            // 
            // boxPerformance
            // 
            this.boxPerformance.FormattingEnabled = true;
            this.boxPerformance.Location = new System.Drawing.Point(152, 151);
            this.boxPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.boxPerformance.Name = "boxPerformance";
            this.boxPerformance.Size = new System.Drawing.Size(182, 21);
            this.boxPerformance.TabIndex = 20;
            // 
            // buttonAddPerformance
            // 
            this.buttonAddPerformance.Location = new System.Drawing.Point(152, 176);
            this.buttonAddPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPerformance.Name = "buttonAddPerformance";
            this.buttonAddPerformance.Size = new System.Drawing.Size(182, 44);
            this.buttonAddPerformance.TabIndex = 24;
            this.buttonAddPerformance.Text = "Добавить";
            this.buttonAddPerformance.UseVisualStyleBackColor = true;
            this.buttonAddPerformance.Click += new System.EventHandler(this.buttonAddPerformance_Click);
            // 
            // buttonDeletePerformance
            // 
            this.buttonDeletePerformance.Location = new System.Drawing.Point(152, 224);
            this.buttonDeletePerformance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeletePerformance.Name = "buttonDeletePerformance";
            this.buttonDeletePerformance.Size = new System.Drawing.Size(182, 44);
            this.buttonDeletePerformance.TabIndex = 26;
            this.buttonDeletePerformance.Text = "Удалить";
            this.buttonDeletePerformance.UseVisualStyleBackColor = true;
            this.buttonDeletePerformance.Click += new System.EventHandler(this.buttonDeletePerformance_Click);
            // 
            // FormTableRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 689);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataTopRecord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxComposition);
            this.Controls.Add(this.numericWholesalePrice);
            this.Controls.Add(this.numericRetailPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxNumberRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataRecord);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTableRecord";
            this.Text = "Таблица пластинки";
            ((System.ComponentModel.ISupportInitialize)(this.dataRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetailPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWholesalePrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTopRecord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataRecord;
        private System.Windows.Forms.TextBox boxNumberRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericRetailPrice;
        private System.Windows.Forms.NumericUpDown numericWholesalePrice;
        private System.Windows.Forms.ComboBox boxComposition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataTopRecord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataPerformance;
        private System.Windows.Forms.ComboBox boxPerformance;
        private System.Windows.Forms.Button buttonAddPerformance;
        private System.Windows.Forms.Button buttonDeletePerformance;
    }
}
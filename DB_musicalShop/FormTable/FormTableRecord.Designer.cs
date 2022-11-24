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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTopRecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetailPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWholesalePrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTopRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Номер пластинки";
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(621, 449);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(243, 54);
            this.buttonUpdateTable.TabIndex = 69;
            this.buttonUpdateTable.Text = "Обновить таблицу";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(621, 228);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(243, 54);
            this.buttonAdd.TabIndex = 68;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(621, 287);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(243, 54);
            this.buttonChange.TabIndex = 67;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(621, 346);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(243, 54);
            this.buttonDelete.TabIndex = 66;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataRecord
            // 
            this.dataRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecord.Location = new System.Drawing.Point(12, 11);
            this.dataRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRecord.Name = "dataRecord";
            this.dataRecord.ReadOnly = true;
            this.dataRecord.RowHeadersWidth = 51;
            this.dataRecord.RowTemplate.Height = 24;
            this.dataRecord.Size = new System.Drawing.Size(604, 492);
            this.dataRecord.TabIndex = 65;
            this.dataRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // boxNumberRecord
            // 
            this.boxNumberRecord.Location = new System.Drawing.Point(621, 30);
            this.boxNumberRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxNumberRecord.MaxLength = 10;
            this.boxNumberRecord.Name = "boxNumberRecord";
            this.boxNumberRecord.Size = new System.Drawing.Size(243, 22);
            this.boxNumberRecord.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Оптовая цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Розничная цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Произведение";
            // 
            // numericRetailPrice
            // 
            this.numericRetailPrice.DecimalPlaces = 2;
            this.numericRetailPrice.Location = new System.Drawing.Point(621, 82);
            this.numericRetailPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericRetailPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericRetailPrice.Name = "numericRetailPrice";
            this.numericRetailPrice.Size = new System.Drawing.Size(243, 22);
            this.numericRetailPrice.TabIndex = 77;
            // 
            // numericWholesalePrice
            // 
            this.numericWholesalePrice.DecimalPlaces = 2;
            this.numericWholesalePrice.Location = new System.Drawing.Point(621, 137);
            this.numericWholesalePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericWholesalePrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericWholesalePrice.Name = "numericWholesalePrice";
            this.numericWholesalePrice.Size = new System.Drawing.Size(243, 22);
            this.numericWholesalePrice.TabIndex = 78;
            // 
            // boxComposition
            // 
            this.boxComposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxComposition.FormattingEnabled = true;
            this.boxComposition.Location = new System.Drawing.Point(621, 192);
            this.boxComposition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxComposition.Name = "boxComposition";
            this.boxComposition.Size = new System.Drawing.Size(243, 24);
            this.boxComposition.TabIndex = 79;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(879, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 486);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лидер продаж";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(6, 52);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(243, 54);
            this.buttonSearch.TabIndex = 81;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(67, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(177, 22);
            this.numericUpDown1.TabIndex = 66;
            this.numericUpDown1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Год";
            // 
            // dataTopRecord
            // 
            this.dataTopRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTopRecord.Location = new System.Drawing.Point(885, 137);
            this.dataTopRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTopRecord.Name = "dataTopRecord";
            this.dataTopRecord.ReadOnly = true;
            this.dataTopRecord.RowHeadersWidth = 51;
            this.dataTopRecord.RowTemplate.Height = 24;
            this.dataTopRecord.Size = new System.Drawing.Size(243, 356);
            this.dataTopRecord.TabIndex = 81;
            // 
            // FormTableRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 510);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTableRecord";
            this.Text = "Таблица пластинки";
            ((System.ComponentModel.ISupportInitialize)(this.dataRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetailPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWholesalePrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTopRecord)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataTopRecord;
    }
}
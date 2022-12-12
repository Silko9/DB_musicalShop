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
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataRecord = new System.Windows.Forms.DataGridView();
            this.number_record = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retail_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wholesale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sell_last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sell_current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataPerformance = new System.Windows.Forms.DataGridView();
            this.buttonAddPerformance = new System.Windows.Forms.Button();
            this.buttonDeletePerformance = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecord)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(11, 557);
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
            this.buttonAdd.Location = new System.Drawing.Point(11, 413);
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
            this.buttonChange.Location = new System.Drawing.Point(11, 461);
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
            this.buttonDelete.Location = new System.Drawing.Point(11, 509);
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
            this.dataRecord.AllowUserToAddRows = false;
            this.dataRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number_record,
            this.retail_price,
            this.wholesale_price,
            this.composition,
            this.sell_last,
            this.sell_current,
            this.count});
            this.dataRecord.Location = new System.Drawing.Point(9, 9);
            this.dataRecord.Margin = new System.Windows.Forms.Padding(2);
            this.dataRecord.MultiSelect = false;
            this.dataRecord.Name = "dataRecord";
            this.dataRecord.ReadOnly = true;
            this.dataRecord.RowHeadersVisible = false;
            this.dataRecord.RowHeadersWidth = 51;
            this.dataRecord.RowTemplate.Height = 24;
            this.dataRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRecord.Size = new System.Drawing.Size(727, 400);
            this.dataRecord.TabIndex = 65;
            this.dataRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // number_record
            // 
            this.number_record.HeaderText = "Номер пластинки";
            this.number_record.Name = "number_record";
            this.number_record.ReadOnly = true;
            this.number_record.Width = 90;
            // 
            // retail_price
            // 
            this.retail_price.HeaderText = "Розничная цена";
            this.retail_price.Name = "retail_price";
            this.retail_price.ReadOnly = true;
            this.retail_price.Width = 70;
            // 
            // wholesale_price
            // 
            this.wholesale_price.HeaderText = "Оптовая цена";
            this.wholesale_price.Name = "wholesale_price";
            this.wholesale_price.ReadOnly = true;
            this.wholesale_price.Width = 70;
            // 
            // composition
            // 
            this.composition.HeaderText = "Произведение";
            this.composition.Name = "composition";
            this.composition.ReadOnly = true;
            this.composition.Width = 200;
            // 
            // sell_last
            // 
            this.sell_last.HeaderText = "Продано за прошлый год";
            this.sell_last.Name = "sell_last";
            this.sell_last.ReadOnly = true;
            // 
            // sell_current
            // 
            this.sell_current.HeaderText = "Продано за текущий год";
            this.sell_current.Name = "sell_current";
            this.sell_current.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "Кол-во в наличие";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataPerformance);
            this.groupBox2.Controls.Add(this.buttonAddPerformance);
            this.groupBox2.Controls.Add(this.buttonDeletePerformance);
            this.groupBox2.Location = new System.Drawing.Point(198, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 187);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исполнения";
            // 
            // dataPerformance
            // 
            this.dataPerformance.AllowUserToAddRows = false;
            this.dataPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataPerformance.Location = new System.Drawing.Point(5, 15);
            this.dataPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.dataPerformance.MultiSelect = false;
            this.dataPerformance.Name = "dataPerformance";
            this.dataPerformance.ReadOnly = true;
            this.dataPerformance.RowHeadersVisible = false;
            this.dataPerformance.RowHeadersWidth = 51;
            this.dataPerformance.RowTemplate.Height = 24;
            this.dataPerformance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPerformance.Size = new System.Drawing.Size(329, 167);
            this.dataPerformance.TabIndex = 18;
            // 
            // buttonAddPerformance
            // 
            this.buttonAddPerformance.Location = new System.Drawing.Point(338, 15);
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
            this.buttonDeletePerformance.Location = new System.Drawing.Point(339, 63);
            this.buttonDeletePerformance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeletePerformance.Name = "buttonDeletePerformance";
            this.buttonDeletePerformance.Size = new System.Drawing.Size(182, 44);
            this.buttonDeletePerformance.TabIndex = 26;
            this.buttonDeletePerformance.Text = "Удалить";
            this.buttonDeletePerformance.UseVisualStyleBackColor = true;
            this.buttonDeletePerformance.Click += new System.EventHandler(this.buttonDeletePerformance_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ансамбль";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата исполнения";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // FormTableRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataRecord);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTableRecord";
            this.Text = "Таблица пластинки";
            this.Shown += new System.EventHandler(this.FormTableRecord_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataRecord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataRecord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataPerformance;
        private System.Windows.Forms.Button buttonAddPerformance;
        private System.Windows.Forms.Button buttonDeletePerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_record;
        private System.Windows.Forms.DataGridViewTextBoxColumn retail_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholesale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn composition;
        private System.Windows.Forms.DataGridViewTextBoxColumn sell_last;
        private System.Windows.Forms.DataGridViewTextBoxColumn sell_current;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
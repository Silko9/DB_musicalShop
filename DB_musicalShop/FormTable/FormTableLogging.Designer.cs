namespace DB_musicalShop
{
    partial class FormTableLogging
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
            this.boxNumberRecord = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boxTypeOfAction = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // boxNumberRecord
            // 
            this.boxNumberRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxNumberRecord.FormattingEnabled = true;
            this.boxNumberRecord.Location = new System.Drawing.Point(609, 31);
            this.boxNumberRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxNumberRecord.Name = "boxNumberRecord";
            this.boxNumberRecord.Size = new System.Drawing.Size(237, 24);
            this.boxNumberRecord.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Номер пластинки";
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(609, 449);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(243, 54);
            this.buttonUpdateTable.TabIndex = 49;
            this.buttonUpdateTable.Text = "Обновить таблицу";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(609, 226);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(243, 54);
            this.buttonAdd.TabIndex = 48;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(609, 286);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(243, 54);
            this.buttonChange.TabIndex = 47;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(609, 345);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(243, 54);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Кол-во";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 492);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // boxTypeOfAction
            // 
            this.boxTypeOfAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTypeOfAction.FormattingEnabled = true;
            this.boxTypeOfAction.Location = new System.Drawing.Point(609, 79);
            this.boxTypeOfAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxTypeOfAction.Name = "boxTypeOfAction";
            this.boxTypeOfAction.Size = new System.Drawing.Size(237, 24);
            this.boxTypeOfAction.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Тип действия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Дата";
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(609, 130);
            this.dateCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(237, 22);
            this.dateCreate.TabIndex = 63;
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(609, 183);
            this.numericAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(236, 22);
            this.numericAmount.TabIndex = 65;
            // 
            // FormTableLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 511);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.boxTypeOfAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxNumberRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTableLogging";
            this.Text = "Таблица учета";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxNumberRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox boxTypeOfAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.NumericUpDown numericAmount;
    }
}
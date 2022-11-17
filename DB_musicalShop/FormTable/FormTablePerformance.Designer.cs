namespace DB_musicalShop
{
    partial class FormTablePerformance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxEnsemble = new System.Windows.Forms.ComboBox();
            this.boxComposition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCircumstances_execution = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(9, 413);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(182, 44);
            this.buttonUpdateTable.TabIndex = 54;
            this.buttonUpdateTable.Text = "Обновить таблицу";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(738, 317);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 44);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(738, 365);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(182, 44);
            this.buttonChange.TabIndex = 52;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(738, 412);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 44);
            this.buttonDelete.TabIndex = 51;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 400);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(736, 118);
            this.dateCreate.Margin = new System.Windows.Forms.Padding(2);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(183, 20);
            this.dateCreate.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Дата исполнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Ансамбль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Произведение";
            // 
            // boxEnsemble
            // 
            this.boxEnsemble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEnsemble.FormattingEnabled = true;
            this.boxEnsemble.Location = new System.Drawing.Point(737, 25);
            this.boxEnsemble.Margin = new System.Windows.Forms.Padding(2);
            this.boxEnsemble.Name = "boxEnsemble";
            this.boxEnsemble.Size = new System.Drawing.Size(182, 21);
            this.boxEnsemble.TabIndex = 63;
            // 
            // boxComposition
            // 
            this.boxComposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxComposition.FormattingEnabled = true;
            this.boxComposition.Location = new System.Drawing.Point(736, 72);
            this.boxComposition.Margin = new System.Windows.Forms.Padding(2);
            this.boxComposition.Name = "boxComposition";
            this.boxComposition.Size = new System.Drawing.Size(184, 21);
            this.boxComposition.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Обстоятельства исполнения";
            // 
            // boxCircumstances_execution
            // 
            this.boxCircumstances_execution.Location = new System.Drawing.Point(736, 170);
            this.boxCircumstances_execution.MaxLength = 200;
            this.boxCircumstances_execution.Name = "boxCircumstances_execution";
            this.boxCircumstances_execution.Size = new System.Drawing.Size(182, 133);
            this.boxCircumstances_execution.TabIndex = 66;
            this.boxCircumstances_execution.Text = "";
            // 
            // FormTablePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 467);
            this.Controls.Add(this.boxCircumstances_execution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxComposition);
            this.Controls.Add(this.boxEnsemble);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTablePerformance";
            this.Text = "Таблица исполнений";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxEnsemble;
        private System.Windows.Forms.ComboBox boxComposition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox boxCircumstances_execution;
    }
}
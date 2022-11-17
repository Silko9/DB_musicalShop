namespace DB_musicalShop
{
    partial class FormTableComposition
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
            this.label5 = new System.Windows.Forms.Label();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.boxPatronymic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxNameAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.boxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(798, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Дата создания";
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(799, 193);
            this.dateCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(180, 20);
            this.dateCreate.TabIndex = 76;
            // 
            // boxPatronymic
            // 
            this.boxPatronymic.Location = new System.Drawing.Point(798, 150);
            this.boxPatronymic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxPatronymic.MaxLength = 15;
            this.boxPatronymic.Name = "boxPatronymic";
            this.boxPatronymic.Size = new System.Drawing.Size(181, 20);
            this.boxPatronymic.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Отчество автора";
            // 
            // boxNameAuthor
            // 
            this.boxNameAuthor.Location = new System.Drawing.Point(798, 64);
            this.boxNameAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxNameAuthor.MaxLength = 15;
            this.boxNameAuthor.Name = "boxNameAuthor";
            this.boxNameAuthor.Size = new System.Drawing.Size(180, 20);
            this.boxNameAuthor.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(798, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Имя автора";
            // 
            // boxSurname
            // 
            this.boxSurname.Location = new System.Drawing.Point(798, 108);
            this.boxSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxSurname.MaxLength = 15;
            this.boxSurname.Name = "boxSurname";
            this.boxSurname.Size = new System.Drawing.Size(180, 20);
            this.boxSurname.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Фамилия автора";
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(796, 367);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(182, 44);
            this.buttonUpdateTable.TabIndex = 69;
            this.buttonUpdateTable.Text = "Обновить таблицу";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(796, 223);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 44);
            this.buttonAdd.TabIndex = 68;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(796, 271);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(182, 44);
            this.buttonChange.TabIndex = 67;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(796, 319);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 44);
            this.buttonDelete.TabIndex = 66;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(798, 22);
            this.boxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxName.MaxLength = 20;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(179, 20);
            this.boxName.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(798, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Название произведение";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 400);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormTableComposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 417);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.boxPatronymic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxNameAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTableComposition";
            this.Text = "Произведения";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.TextBox boxPatronymic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxNameAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
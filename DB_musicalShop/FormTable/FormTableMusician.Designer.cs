namespace DB_musicalShop
{
    partial class FormTableMusician
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
            this.dataMusician = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxPatronymic = new System.Windows.Forms.TextBox();
            this.boxSurname = new System.Windows.Forms.TextBox();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataRole = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMusician
            // 
            this.dataMusician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMusician.Location = new System.Drawing.Point(9, 10);
            this.dataMusician.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataMusician.Name = "dataMusician";
            this.dataMusician.ReadOnly = true;
            this.dataMusician.RowHeadersWidth = 51;
            this.dataMusician.RowTemplate.Height = 24;
            this.dataMusician.Size = new System.Drawing.Size(482, 321);
            this.dataMusician.TabIndex = 0;
            this.dataMusician.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_musicalShop.Properties.Resources.noname;
            this.pictureBox1.Location = new System.Drawing.Point(9, 336);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 427);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(202, 357);
            this.boxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxName.MaxLength = 15;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(182, 20);
            this.boxName.TabIndex = 7;
            // 
            // boxPatronymic
            // 
            this.boxPatronymic.Location = new System.Drawing.Point(202, 443);
            this.boxPatronymic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxPatronymic.MaxLength = 15;
            this.boxPatronymic.Name = "boxPatronymic";
            this.boxPatronymic.Size = new System.Drawing.Size(182, 20);
            this.boxPatronymic.TabIndex = 8;
            // 
            // boxSurname
            // 
            this.boxSurname.Location = new System.Drawing.Point(202, 400);
            this.boxSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxSurname.MaxLength = 15;
            this.boxSurname.Name = "boxSurname";
            this.boxSurname.Size = new System.Drawing.Size(182, 20);
            this.boxSurname.TabIndex = 9;
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(9, 521);
            this.buttonOpenImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(182, 47);
            this.buttonOpenImage.TabIndex = 12;
            this.buttonOpenImage.Text = "Открыть картинку";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(397, 433);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 44);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(397, 384);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(182, 44);
            this.buttonChange.TabIndex = 14;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(397, 336);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 44);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(397, 482);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(182, 47);
            this.buttonUpdateTable.TabIndex = 16;
            this.buttonUpdateTable.Text = "Обновить таблицу";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(397, 534);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(182, 47);
            this.buttonSort.TabIndex = 17;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dataRole
            // 
            this.dataRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRole.Location = new System.Drawing.Point(495, 10);
            this.dataRole.Margin = new System.Windows.Forms.Padding(2);
            this.dataRole.Name = "dataRole";
            this.dataRole.ReadOnly = true;
            this.dataRole.RowHeadersWidth = 51;
            this.dataRole.RowTemplate.Height = 24;
            this.dataRole.Size = new System.Drawing.Size(482, 321);
            this.dataRole.TabIndex = 18;
            // 
            // FormTableMusician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 592);
            this.Controls.Add(this.dataRole);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonOpenImage);
            this.Controls.Add(this.boxSurname);
            this.Controls.Add(this.boxPatronymic);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataMusician);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTableMusician";
            this.Text = "Таблица музыканты";
            ((System.ComponentModel.ISupportInitialize)(this.dataMusician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMusician;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxPatronymic;
        private System.Windows.Forms.TextBox boxSurname;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataRole;
    }
}
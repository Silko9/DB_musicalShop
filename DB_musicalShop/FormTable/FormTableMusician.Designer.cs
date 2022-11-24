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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataRole = new System.Windows.Forms.DataGridView();
            this.dataEnsemble = new System.Windows.Forms.DataGridView();
            this.boxRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxEnsemble = new System.Windows.Forms.ComboBox();
            this.buttonAddRole = new System.Windows.Forms.Button();
            this.buttonAddEnsemble = new System.Windows.Forms.Button();
            this.buttonDeleteRole = new System.Windows.Forms.Button();
            this.buttonDeleteEnsemble = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnsemble)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMusician
            // 
            this.dataMusician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMusician.Location = new System.Drawing.Point(12, 12);
            this.dataMusician.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataMusician.Name = "dataMusician";
            this.dataMusician.ReadOnly = true;
            this.dataMusician.RowHeadersWidth = 51;
            this.dataMusician.RowTemplate.Height = 24;
            this.dataMusician.Size = new System.Drawing.Size(643, 395);
            this.dataMusician.TabIndex = 0;
            this.dataMusician.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_musicalShop.Properties.Resources.noname;
            this.pictureBox1.Location = new System.Drawing.Point(12, 430);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(261, 479);
            this.boxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxName.MaxLength = 15;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(241, 22);
            this.boxName.TabIndex = 7;
            // 
            // boxPatronymic
            // 
            this.boxPatronymic.Location = new System.Drawing.Point(261, 590);
            this.boxPatronymic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxPatronymic.MaxLength = 15;
            this.boxPatronymic.Name = "boxPatronymic";
            this.boxPatronymic.Size = new System.Drawing.Size(241, 22);
            this.boxPatronymic.TabIndex = 8;
            // 
            // boxSurname
            // 
            this.boxSurname.Location = new System.Drawing.Point(261, 535);
            this.boxSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxSurname.MaxLength = 15;
            this.boxSurname.Name = "boxSurname";
            this.boxSurname.Size = new System.Drawing.Size(241, 22);
            this.boxSurname.TabIndex = 9;
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(12, 656);
            this.buttonOpenImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(243, 54);
            this.buttonOpenImage.TabIndex = 12;
            this.buttonOpenImage.Text = "Открыть картинку";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(508, 586);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(243, 54);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(508, 517);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(243, 54);
            this.buttonChange.TabIndex = 14;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(508, 447);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(243, 54);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dataRole
            // 
            this.dataRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRole.Location = new System.Drawing.Point(661, 11);
            this.dataRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRole.Name = "dataRole";
            this.dataRole.ReadOnly = true;
            this.dataRole.RowHeadersWidth = 51;
            this.dataRole.RowTemplate.Height = 24;
            this.dataRole.Size = new System.Drawing.Size(204, 196);
            this.dataRole.TabIndex = 18;
            // 
            // dataEnsemble
            // 
            this.dataEnsemble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEnsemble.Location = new System.Drawing.Point(661, 211);
            this.dataEnsemble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataEnsemble.Name = "dataEnsemble";
            this.dataEnsemble.ReadOnly = true;
            this.dataEnsemble.RowHeadersWidth = 51;
            this.dataEnsemble.RowTemplate.Height = 24;
            this.dataEnsemble.Size = new System.Drawing.Size(204, 196);
            this.dataEnsemble.TabIndex = 19;
            // 
            // boxRole
            // 
            this.boxRole.FormattingEnabled = true;
            this.boxRole.Location = new System.Drawing.Point(871, 31);
            this.boxRole.Name = "boxRole";
            this.boxRole.Size = new System.Drawing.Size(241, 24);
            this.boxRole.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(871, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ансамбль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(871, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Роль";
            // 
            // boxEnsemble
            // 
            this.boxEnsemble.FormattingEnabled = true;
            this.boxEnsemble.Location = new System.Drawing.Point(871, 230);
            this.boxEnsemble.Name = "boxEnsemble";
            this.boxEnsemble.Size = new System.Drawing.Size(241, 24);
            this.boxEnsemble.TabIndex = 23;
            // 
            // buttonAddRole
            // 
            this.buttonAddRole.Location = new System.Drawing.Point(871, 60);
            this.buttonAddRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddRole.Name = "buttonAddRole";
            this.buttonAddRole.Size = new System.Drawing.Size(243, 54);
            this.buttonAddRole.TabIndex = 24;
            this.buttonAddRole.Text = "Добавить";
            this.buttonAddRole.UseVisualStyleBackColor = true;
            this.buttonAddRole.Click += new System.EventHandler(this.buttonAddRole_Click);
            // 
            // buttonAddEnsemble
            // 
            this.buttonAddEnsemble.Location = new System.Drawing.Point(871, 259);
            this.buttonAddEnsemble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddEnsemble.Name = "buttonAddEnsemble";
            this.buttonAddEnsemble.Size = new System.Drawing.Size(243, 54);
            this.buttonAddEnsemble.TabIndex = 25;
            this.buttonAddEnsemble.Text = "Добавить";
            this.buttonAddEnsemble.UseVisualStyleBackColor = true;
            this.buttonAddEnsemble.Click += new System.EventHandler(this.buttonAddEnsemble_Click);
            // 
            // buttonDeleteRole
            // 
            this.buttonDeleteRole.Location = new System.Drawing.Point(871, 118);
            this.buttonDeleteRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteRole.Name = "buttonDeleteRole";
            this.buttonDeleteRole.Size = new System.Drawing.Size(243, 54);
            this.buttonDeleteRole.TabIndex = 26;
            this.buttonDeleteRole.Text = "Удалить";
            this.buttonDeleteRole.UseVisualStyleBackColor = true;
            this.buttonDeleteRole.Click += new System.EventHandler(this.buttonDeleteRole_Click);
            // 
            // buttonDeleteEnsemble
            // 
            this.buttonDeleteEnsemble.Location = new System.Drawing.Point(871, 317);
            this.buttonDeleteEnsemble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteEnsemble.Name = "buttonDeleteEnsemble";
            this.buttonDeleteEnsemble.Size = new System.Drawing.Size(243, 54);
            this.buttonDeleteEnsemble.TabIndex = 27;
            this.buttonDeleteEnsemble.Text = "Удалить";
            this.buttonDeleteEnsemble.UseVisualStyleBackColor = true;
            this.buttonDeleteEnsemble.Click += new System.EventHandler(this.buttonDeleteEnsemble_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(261, 656);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(243, 54);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "Обновить таблицу";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(508, 656);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(243, 54);
            this.buttonSort.TabIndex = 29;
            this.buttonSort.Text = "Сортировка";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // FormTableMusician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 725);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeleteEnsemble);
            this.Controls.Add(this.buttonDeleteRole);
            this.Controls.Add(this.buttonAddEnsemble);
            this.Controls.Add(this.buttonAddRole);
            this.Controls.Add(this.boxEnsemble);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxRole);
            this.Controls.Add(this.dataEnsemble);
            this.Controls.Add(this.dataRole);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTableMusician";
            this.Text = "Таблица музыканты";
            ((System.ComponentModel.ISupportInitialize)(this.dataMusician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnsemble)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataRole;
        private System.Windows.Forms.DataGridView dataEnsemble;
        private System.Windows.Forms.ComboBox boxRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxEnsemble;
        private System.Windows.Forms.Button buttonAddRole;
        private System.Windows.Forms.Button buttonAddEnsemble;
        private System.Windows.Forms.Button buttonDeleteRole;
        private System.Windows.Forms.Button buttonDeleteEnsemble;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSort;
    }
}
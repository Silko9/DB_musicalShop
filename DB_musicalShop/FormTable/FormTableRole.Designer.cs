namespace DB_musicalShop
{
    partial class FormTableRole
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
            this.boxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataRole = new System.Windows.Forms.DataGridView();
            this.buttonDeleteMusician = new System.Windows.Forms.Button();
            this.buttonAddMusician = new System.Windows.Forms.Button();
            this.boxMusician = new System.Windows.Forms.ComboBox();
            this.dataMusician = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusician)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(9, 414);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(182, 44);
            this.buttonUpdateTable.TabIndex = 33;
            this.buttonUpdateTable.Text = "Обновить таблицу";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(242, 271);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 44);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(242, 319);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(182, 44);
            this.buttonChange.TabIndex = 31;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(242, 367);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 44);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(242, 231);
            this.boxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxName.MaxLength = 15;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(182, 20);
            this.boxName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Название роли";
            // 
            // dataRole
            // 
            this.dataRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRole.Location = new System.Drawing.Point(9, 10);
            this.dataRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataRole.Name = "dataRole";
            this.dataRole.ReadOnly = true;
            this.dataRole.RowHeadersWidth = 51;
            this.dataRole.RowTemplate.Height = 24;
            this.dataRole.Size = new System.Drawing.Size(223, 400);
            this.dataRole.TabIndex = 17;
            this.dataRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonDeleteMusician
            // 
            this.buttonDeleteMusician.Location = new System.Drawing.Point(162, 89);
            this.buttonDeleteMusician.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteMusician.Name = "buttonDeleteMusician";
            this.buttonDeleteMusician.Size = new System.Drawing.Size(182, 44);
            this.buttonDeleteMusician.TabIndex = 38;
            this.buttonDeleteMusician.Text = "Удалить";
            this.buttonDeleteMusician.UseVisualStyleBackColor = true;
            this.buttonDeleteMusician.Click += new System.EventHandler(this.buttonDeleteMusician_Click);
            // 
            // buttonAddMusician
            // 
            this.buttonAddMusician.Location = new System.Drawing.Point(162, 42);
            this.buttonAddMusician.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddMusician.Name = "buttonAddMusician";
            this.buttonAddMusician.Size = new System.Drawing.Size(182, 44);
            this.buttonAddMusician.TabIndex = 37;
            this.buttonAddMusician.Text = "Добавить";
            this.buttonAddMusician.UseVisualStyleBackColor = true;
            this.buttonAddMusician.Click += new System.EventHandler(this.buttonAddMusician_Click);
            // 
            // boxMusician
            // 
            this.boxMusician.FormattingEnabled = true;
            this.boxMusician.Location = new System.Drawing.Point(162, 18);
            this.boxMusician.Margin = new System.Windows.Forms.Padding(2);
            this.boxMusician.Name = "boxMusician";
            this.boxMusician.Size = new System.Drawing.Size(182, 21);
            this.boxMusician.TabIndex = 35;
            // 
            // dataMusician
            // 
            this.dataMusician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMusician.Location = new System.Drawing.Point(5, 18);
            this.dataMusician.Margin = new System.Windows.Forms.Padding(2);
            this.dataMusician.Name = "dataMusician";
            this.dataMusician.ReadOnly = true;
            this.dataMusician.RowHeadersWidth = 51;
            this.dataMusician.RowTemplate.Height = 24;
            this.dataMusician.Size = new System.Drawing.Size(153, 131);
            this.dataMusician.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataMusician);
            this.groupBox1.Controls.Add(this.buttonDeleteMusician);
            this.groupBox1.Controls.Add(this.boxMusician);
            this.groupBox1.Controls.Add(this.buttonAddMusician);
            this.groupBox1.Location = new System.Drawing.Point(237, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 164);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Музыканты";
            // 
            // FormTableRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataRole);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTableRole";
            this.Text = "Таблица ролей";
            ((System.ComponentModel.ISupportInitialize)(this.dataRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusician)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataRole;
        private System.Windows.Forms.Button buttonDeleteMusician;
        private System.Windows.Forms.Button buttonAddMusician;
        private System.Windows.Forms.ComboBox boxMusician;
        private System.Windows.Forms.DataGridView dataMusician;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
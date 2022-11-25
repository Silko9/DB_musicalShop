namespace DB_musicalShop
{
    partial class FormTableTypeEnseble
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
            this.dataTypeEnsemble = new System.Windows.Forms.DataGridView();
            this.dataEnsemble = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataTypeEnsemble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnsemble)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(234, 343);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(182, 44);
            this.buttonUpdateTable.TabIndex = 40;
            this.buttonUpdateTable.Text = "Обновить таблицу";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(234, 200);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 44);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(234, 248);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(182, 44);
            this.buttonChange.TabIndex = 38;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(234, 295);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 44);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(234, 175);
            this.boxName.Margin = new System.Windows.Forms.Padding(2);
            this.boxName.MaxLength = 15;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(182, 20);
            this.boxName.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Тип ансамбля";
            // 
            // dataTypeEnsemble
            // 
            this.dataTypeEnsemble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTypeEnsemble.Location = new System.Drawing.Point(9, 11);
            this.dataTypeEnsemble.Margin = new System.Windows.Forms.Padding(2);
            this.dataTypeEnsemble.Name = "dataTypeEnsemble";
            this.dataTypeEnsemble.ReadOnly = true;
            this.dataTypeEnsemble.RowHeadersWidth = 51;
            this.dataTypeEnsemble.RowTemplate.Height = 24;
            this.dataTypeEnsemble.Size = new System.Drawing.Size(220, 400);
            this.dataTypeEnsemble.TabIndex = 34;
            this.dataTypeEnsemble.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataEnsemble
            // 
            this.dataEnsemble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEnsemble.Location = new System.Drawing.Point(234, 11);
            this.dataEnsemble.Margin = new System.Windows.Forms.Padding(2);
            this.dataEnsemble.Name = "dataEnsemble";
            this.dataEnsemble.ReadOnly = true;
            this.dataEnsemble.RowHeadersWidth = 51;
            this.dataEnsemble.RowTemplate.Height = 24;
            this.dataEnsemble.Size = new System.Drawing.Size(182, 131);
            this.dataEnsemble.TabIndex = 34;
            // 
            // FormTableTypeEnseble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 418);
            this.Controls.Add(this.dataEnsemble);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTypeEnsemble);
            this.Name = "FormTableTypeEnseble";
            this.Text = "Таблица типы ансамблей";
            ((System.ComponentModel.ISupportInitialize)(this.dataTypeEnsemble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnsemble)).EndInit();
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
        private System.Windows.Forms.DataGridView dataTypeEnsemble;
        private System.Windows.Forms.DataGridView dataEnsemble;
    }
}
namespace DB_musicalShop
{
    partial class FormTableEnsemble
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
            this.dataEnsemble = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.boxTypeEnsemble = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataMusician = new System.Windows.Forms.DataGridView();
            this.buttonDeleteMusician = new System.Windows.Forms.Button();
            this.boxMusician = new System.Windows.Forms.ComboBox();
            this.buttonAddMusician = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataPerformance = new System.Windows.Forms.DataGridView();
            this.buttonDeletePerformance = new System.Windows.Forms.Button();
            this.boxComposition = new System.Windows.Forms.ComboBox();
            this.buttonAddPerformance = new System.Windows.Forms.Button();
            this.datePerformance = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnsemble)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusician)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(425, 363);
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
            this.buttonAdd.Location = new System.Drawing.Point(423, 104);
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
            this.buttonChange.Location = new System.Drawing.Point(423, 152);
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
            this.buttonDelete.Location = new System.Drawing.Point(423, 200);
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
            this.boxName.Location = new System.Drawing.Point(424, 24);
            this.boxName.Margin = new System.Windows.Forms.Padding(2);
            this.boxName.MaxLength = 20;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(181, 20);
            this.boxName.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Название ансамбля";
            // 
            // dataEnsemble
            // 
            this.dataEnsemble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEnsemble.Location = new System.Drawing.Point(9, 9);
            this.dataEnsemble.Margin = new System.Windows.Forms.Padding(2);
            this.dataEnsemble.Name = "dataEnsemble";
            this.dataEnsemble.ReadOnly = true;
            this.dataEnsemble.RowHeadersWidth = 51;
            this.dataEnsemble.RowTemplate.Height = 24;
            this.dataEnsemble.Size = new System.Drawing.Size(410, 400);
            this.dataEnsemble.TabIndex = 34;
            this.dataEnsemble.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Тип ансамбля";
            // 
            // boxTypeEnsemble
            // 
            this.boxTypeEnsemble.FormattingEnabled = true;
            this.boxTypeEnsemble.Location = new System.Drawing.Point(424, 71);
            this.boxTypeEnsemble.Name = "boxTypeEnsemble";
            this.boxTypeEnsemble.Size = new System.Drawing.Size(180, 21);
            this.boxTypeEnsemble.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataMusician);
            this.groupBox1.Controls.Add(this.buttonDeleteMusician);
            this.groupBox1.Controls.Add(this.boxMusician);
            this.groupBox1.Controls.Add(this.buttonAddMusician);
            this.groupBox1.Location = new System.Drawing.Point(610, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 164);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Музыканты";
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
            this.dataMusician.Size = new System.Drawing.Size(234, 131);
            this.dataMusician.TabIndex = 34;
            // 
            // buttonDeleteMusician
            // 
            this.buttonDeleteMusician.Location = new System.Drawing.Point(243, 89);
            this.buttonDeleteMusician.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteMusician.Name = "buttonDeleteMusician";
            this.buttonDeleteMusician.Size = new System.Drawing.Size(182, 44);
            this.buttonDeleteMusician.TabIndex = 38;
            this.buttonDeleteMusician.Text = "Удалить";
            this.buttonDeleteMusician.UseVisualStyleBackColor = true;
            this.buttonDeleteMusician.Click += new System.EventHandler(this.buttonDeleteMusician_Click);
            // 
            // boxMusician
            // 
            this.boxMusician.FormattingEnabled = true;
            this.boxMusician.Location = new System.Drawing.Point(243, 18);
            this.boxMusician.Margin = new System.Windows.Forms.Padding(2);
            this.boxMusician.Name = "boxMusician";
            this.boxMusician.Size = new System.Drawing.Size(182, 21);
            this.boxMusician.TabIndex = 35;
            // 
            // buttonAddMusician
            // 
            this.buttonAddMusician.Location = new System.Drawing.Point(243, 42);
            this.buttonAddMusician.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddMusician.Name = "buttonAddMusician";
            this.buttonAddMusician.Size = new System.Drawing.Size(182, 44);
            this.buttonAddMusician.TabIndex = 37;
            this.buttonAddMusician.Text = "Добавить";
            this.buttonAddMusician.UseVisualStyleBackColor = true;
            this.buttonAddMusician.Click += new System.EventHandler(this.buttonAddMusician_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datePerformance);
            this.groupBox2.Controls.Add(this.dataPerformance);
            this.groupBox2.Controls.Add(this.buttonDeletePerformance);
            this.groupBox2.Controls.Add(this.boxComposition);
            this.groupBox2.Controls.Add(this.buttonAddPerformance);
            this.groupBox2.Location = new System.Drawing.Point(610, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 170);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исполнения";
            // 
            // dataPerformance
            // 
            this.dataPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerformance.Location = new System.Drawing.Point(5, 18);
            this.dataPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.dataPerformance.Name = "dataPerformance";
            this.dataPerformance.ReadOnly = true;
            this.dataPerformance.RowHeadersWidth = 51;
            this.dataPerformance.RowTemplate.Height = 24;
            this.dataPerformance.Size = new System.Drawing.Size(234, 131);
            this.dataPerformance.TabIndex = 34;
            // 
            // buttonDeletePerformance
            // 
            this.buttonDeletePerformance.Location = new System.Drawing.Point(243, 116);
            this.buttonDeletePerformance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeletePerformance.Name = "buttonDeletePerformance";
            this.buttonDeletePerformance.Size = new System.Drawing.Size(182, 44);
            this.buttonDeletePerformance.TabIndex = 38;
            this.buttonDeletePerformance.Text = "Удалить";
            this.buttonDeletePerformance.UseVisualStyleBackColor = true;
            this.buttonDeletePerformance.Click += new System.EventHandler(this.buttonDeletePerformance_Click);
            // 
            // boxComposition
            // 
            this.boxComposition.FormattingEnabled = true;
            this.boxComposition.Location = new System.Drawing.Point(243, 18);
            this.boxComposition.Margin = new System.Windows.Forms.Padding(2);
            this.boxComposition.Name = "boxComposition";
            this.boxComposition.Size = new System.Drawing.Size(182, 21);
            this.boxComposition.TabIndex = 35;
            // 
            // buttonAddPerformance
            // 
            this.buttonAddPerformance.Location = new System.Drawing.Point(243, 69);
            this.buttonAddPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPerformance.Name = "buttonAddPerformance";
            this.buttonAddPerformance.Size = new System.Drawing.Size(182, 44);
            this.buttonAddPerformance.TabIndex = 37;
            this.buttonAddPerformance.Text = "Добавить";
            this.buttonAddPerformance.UseVisualStyleBackColor = true;
            this.buttonAddPerformance.Click += new System.EventHandler(this.buttonAddPerformance_Click);
            // 
            // datePerformance
            // 
            this.datePerformance.Location = new System.Drawing.Point(244, 44);
            this.datePerformance.Name = "datePerformance";
            this.datePerformance.Size = new System.Drawing.Size(181, 20);
            this.datePerformance.TabIndex = 39;
            // 
            // FormTableEnsemble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxTypeEnsemble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataEnsemble);
            this.Name = "FormTableEnsemble";
            this.Text = "Таблица ансамблей";
            ((System.ComponentModel.ISupportInitialize)(this.dataEnsemble)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMusician)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).EndInit();
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
        private System.Windows.Forms.DataGridView dataEnsemble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxTypeEnsemble;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataMusician;
        private System.Windows.Forms.Button buttonDeleteMusician;
        private System.Windows.Forms.ComboBox boxMusician;
        private System.Windows.Forms.Button buttonAddMusician;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataPerformance;
        private System.Windows.Forms.Button buttonDeletePerformance;
        private System.Windows.Forms.ComboBox boxComposition;
        private System.Windows.Forms.Button buttonAddPerformance;
        private System.Windows.Forms.DateTimePicker datePerformance;
    }
}
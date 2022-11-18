namespace DB_musicalShop
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenDB = new System.Windows.Forms.Button();
            this.buttonCreateNewDB = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonTypeEnseble = new System.Windows.Forms.Button();
            this.buttonViewTableLogging = new System.Windows.Forms.Button();
            this.buttonViewTableRelationRecordAndPerformance = new System.Windows.Forms.Button();
            this.buttonViewTableRecord = new System.Windows.Forms.Button();
            this.buttonViewTablePerformance = new System.Windows.Forms.Button();
            this.buttonViewTableComposition = new System.Windows.Forms.Button();
            this.buttonViewTableEnsemble = new System.Windows.Forms.Button();
            this.buttonViewTableMusicialInstrument = new System.Windows.Forms.Button();
            this.buttonViewTableRelationRoleAndMusician = new System.Windows.Forms.Button();
            this.buttonViewTableRole = new System.Windows.Forms.Button();
            this.buttonViewTableMusician = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenDB
            // 
            this.buttonOpenDB.Location = new System.Drawing.Point(12, 220);
            this.buttonOpenDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenDB.Name = "buttonOpenDB";
            this.buttonOpenDB.Size = new System.Drawing.Size(125, 58);
            this.buttonOpenDB.TabIndex = 14;
            this.buttonOpenDB.Text = "Открыть файл базы данных";
            this.buttonOpenDB.UseVisualStyleBackColor = true;
            this.buttonOpenDB.Click += new System.EventHandler(this.buttonOpenDB_Click);
            // 
            // buttonCreateNewDB
            // 
            this.buttonCreateNewDB.Location = new System.Drawing.Point(143, 220);
            this.buttonCreateNewDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateNewDB.Name = "buttonCreateNewDB";
            this.buttonCreateNewDB.Size = new System.Drawing.Size(125, 58);
            this.buttonCreateNewDB.TabIndex = 15;
            this.buttonCreateNewDB.Text = "Создать новую базу данных";
            this.buttonCreateNewDB.UseVisualStyleBackColor = true;
            this.buttonCreateNewDB.Click += new System.EventHandler(this.buttonCreateNewDB_Click);
            // 
            // buttonTypeEnseble
            // 
            this.buttonTypeEnseble.Location = new System.Drawing.Point(6, 97);
            this.buttonTypeEnseble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTypeEnseble.Name = "buttonTypeEnseble";
            this.buttonTypeEnseble.Size = new System.Drawing.Size(138, 73);
            this.buttonTypeEnseble.TabIndex = 36;
            this.buttonTypeEnseble.Text = "Таблица тип ансамблей";
            this.buttonTypeEnseble.UseVisualStyleBackColor = true;
            this.buttonTypeEnseble.Click += new System.EventHandler(this.buttonTypeEnseble_Click);
            // 
            // buttonViewTableLogging
            // 
            this.buttonViewTableLogging.Location = new System.Drawing.Point(656, 220);
            this.buttonViewTableLogging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTableLogging.Name = "buttonViewTableLogging";
            this.buttonViewTableLogging.Size = new System.Drawing.Size(125, 58);
            this.buttonViewTableLogging.TabIndex = 34;
            this.buttonViewTableLogging.Text = "Таблица учет";
            this.buttonViewTableLogging.UseVisualStyleBackColor = true;
            this.buttonViewTableLogging.Click += new System.EventHandler(this.buttonViewTableLogging_Click);
            // 
            // buttonViewTableRelationRecordAndPerformance
            // 
            this.buttonViewTableRelationRecordAndPerformance.Location = new System.Drawing.Point(6, 97);
            this.buttonViewTableRelationRecordAndPerformance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTableRelationRecordAndPerformance.Name = "buttonViewTableRelationRecordAndPerformance";
            this.buttonViewTableRelationRecordAndPerformance.Size = new System.Drawing.Size(138, 73);
            this.buttonViewTableRelationRecordAndPerformance.TabIndex = 33;
            this.buttonViewTableRelationRecordAndPerformance.Text = "Таблица отношений пластинки и исполнений";
            this.buttonViewTableRelationRecordAndPerformance.UseVisualStyleBackColor = true;
            this.buttonViewTableRelationRecordAndPerformance.Click += new System.EventHandler(this.buttonViewTableRelationRecordAndPerformance_Click);
            // 
            // buttonViewTableRecord
            // 
            this.buttonViewTableRecord.Location = new System.Drawing.Point(6, 20);
            this.buttonViewTableRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTableRecord.Name = "buttonViewTableRecord";
            this.buttonViewTableRecord.Size = new System.Drawing.Size(138, 73);
            this.buttonViewTableRecord.TabIndex = 32;
            this.buttonViewTableRecord.Text = "Таблица пластинок";
            this.buttonViewTableRecord.UseVisualStyleBackColor = true;
            this.buttonViewTableRecord.Click += new System.EventHandler(this.buttonViewTableRecord_Click);
            // 
            // buttonViewTablePerformance
            // 
            this.buttonViewTablePerformance.Location = new System.Drawing.Point(150, 97);
            this.buttonViewTablePerformance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTablePerformance.Name = "buttonViewTablePerformance";
            this.buttonViewTablePerformance.Size = new System.Drawing.Size(138, 73);
            this.buttonViewTablePerformance.TabIndex = 31;
            this.buttonViewTablePerformance.Text = "Таблица исполнений";
            this.buttonViewTablePerformance.UseVisualStyleBackColor = true;
            this.buttonViewTablePerformance.Click += new System.EventHandler(this.buttonViewTablePerformance_Click);
            // 
            // buttonViewTableComposition
            // 
            this.buttonViewTableComposition.Location = new System.Drawing.Point(150, 20);
            this.buttonViewTableComposition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTableComposition.Name = "buttonViewTableComposition";
            this.buttonViewTableComposition.Size = new System.Drawing.Size(138, 73);
            this.buttonViewTableComposition.TabIndex = 30;
            this.buttonViewTableComposition.Text = "Таблица произведения";
            this.buttonViewTableComposition.UseVisualStyleBackColor = true;
            this.buttonViewTableComposition.Click += new System.EventHandler(this.buttonViewTableComposition_Click);
            // 
            // buttonViewTableEnsemble
            // 
            this.buttonViewTableEnsemble.Location = new System.Drawing.Point(6, 20);
            this.buttonViewTableEnsemble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTableEnsemble.Name = "buttonViewTableEnsemble";
            this.buttonViewTableEnsemble.Size = new System.Drawing.Size(138, 73);
            this.buttonViewTableEnsemble.TabIndex = 29;
            this.buttonViewTableEnsemble.Text = "Таблица ансамбли";
            this.buttonViewTableEnsemble.UseVisualStyleBackColor = true;
            this.buttonViewTableEnsemble.Click += new System.EventHandler(this.buttonViewTableEnsemble_Click);
            // 
            // buttonViewTableMusicialInstrument
            // 
            this.buttonViewTableMusicialInstrument.Location = new System.Drawing.Point(150, 20);
            this.buttonViewTableMusicialInstrument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTableMusicialInstrument.Name = "buttonViewTableMusicialInstrument";
            this.buttonViewTableMusicialInstrument.Size = new System.Drawing.Size(138, 73);
            this.buttonViewTableMusicialInstrument.TabIndex = 28;
            this.buttonViewTableMusicialInstrument.Text = "Таблица инструменты";
            this.buttonViewTableMusicialInstrument.UseVisualStyleBackColor = true;
            this.buttonViewTableMusicialInstrument.Click += new System.EventHandler(this.buttonViewTableMusicialInstrument_Click);
            // 
            // buttonViewTableRelationRoleAndMusician
            // 
            this.buttonViewTableRelationRoleAndMusician.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.buttonViewTableRelationRoleAndMusician.Location = new System.Drawing.Point(150, 97);
            this.buttonViewTableRelationRoleAndMusician.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTableRelationRoleAndMusician.Name = "buttonViewTableRelationRoleAndMusician";
            this.buttonViewTableRelationRoleAndMusician.Size = new System.Drawing.Size(138, 73);
            this.buttonViewTableRelationRoleAndMusician.TabIndex = 27;
            this.buttonViewTableRelationRoleAndMusician.Text = "Таблица отношений музыканты и роли";
            this.buttonViewTableRelationRoleAndMusician.UseVisualStyleBackColor = true;
            this.buttonViewTableRelationRoleAndMusician.Click += new System.EventHandler(this.buttonViewTableRelationRoleAndMusician_Click);
            // 
            // buttonViewTableRole
            // 
            this.buttonViewTableRole.Location = new System.Drawing.Point(6, 97);
            this.buttonViewTableRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTableRole.Name = "buttonViewTableRole";
            this.buttonViewTableRole.Size = new System.Drawing.Size(138, 73);
            this.buttonViewTableRole.TabIndex = 26;
            this.buttonViewTableRole.Text = "Таблица роли";
            this.buttonViewTableRole.UseVisualStyleBackColor = true;
            this.buttonViewTableRole.Click += new System.EventHandler(this.buttonViewTableRole_Click);
            // 
            // buttonViewTableMusician
            // 
            this.buttonViewTableMusician.Location = new System.Drawing.Point(6, 20);
            this.buttonViewTableMusician.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewTableMusician.Name = "buttonViewTableMusician";
            this.buttonViewTableMusician.Size = new System.Drawing.Size(138, 73);
            this.buttonViewTableMusician.TabIndex = 25;
            this.buttonViewTableMusician.Text = "Таблица музыканты";
            this.buttonViewTableMusician.UseVisualStyleBackColor = true;
            this.buttonViewTableMusician.Click += new System.EventHandler(this.buttonViewTableMusician_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Путь базы данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonViewTableMusician);
            this.groupBox1.Controls.Add(this.buttonViewTableRelationRoleAndMusician);
            this.groupBox1.Controls.Add(this.buttonViewTableRole);
            this.groupBox1.Controls.Add(this.buttonViewTableMusicialInstrument);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 175);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Музыканты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonViewTableEnsemble);
            this.groupBox2.Controls.Add(this.buttonTypeEnseble);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 175);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ансамбли";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonViewTableRecord);
            this.groupBox3.Controls.Add(this.buttonViewTableRelationRecordAndPerformance);
            this.groupBox3.Controls.Add(this.buttonViewTablePerformance);
            this.groupBox3.Controls.Add(this.buttonViewTableComposition);
            this.groupBox3.Location = new System.Drawing.Point(493, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 175);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пластинки";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 293);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonViewTableLogging);
            this.Controls.Add(this.buttonCreateNewDB);
            this.Controls.Add(this.buttonOpenDB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenDB;
        private System.Windows.Forms.Button buttonCreateNewDB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonTypeEnseble;
        private System.Windows.Forms.Button buttonViewTableLogging;
        private System.Windows.Forms.Button buttonViewTableRelationRecordAndPerformance;
        private System.Windows.Forms.Button buttonViewTableRecord;
        private System.Windows.Forms.Button buttonViewTablePerformance;
        private System.Windows.Forms.Button buttonViewTableComposition;
        private System.Windows.Forms.Button buttonViewTableEnsemble;
        private System.Windows.Forms.Button buttonViewTableMusicialInstrument;
        private System.Windows.Forms.Button buttonViewTableRelationRoleAndMusician;
        private System.Windows.Forms.Button buttonViewTableRole;
        private System.Windows.Forms.Button buttonViewTableMusician;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}


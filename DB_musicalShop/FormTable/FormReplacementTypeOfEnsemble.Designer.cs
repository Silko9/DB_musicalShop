namespace DB_musicalShop.FormTable
{
    partial class FormReplacementTypeOfEnsemble
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.BOX = new System.Windows.Forms.GroupBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.boxTypeOfEnsemble = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BOX.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поле \"тип ансамбля\" используется как минимум";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Замените другим типом или создайте новый.";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(16, 329);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(392, 54);
            this.buttonCancel.TabIndex = 41;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // BOX
            // 
            this.BOX.Controls.Add(this.buttonReplace);
            this.BOX.Controls.Add(this.boxTypeOfEnsemble);
            this.BOX.Location = new System.Drawing.Point(16, 130);
            this.BOX.Name = "BOX";
            this.BOX.Size = new System.Drawing.Size(183, 152);
            this.BOX.TabIndex = 42;
            this.BOX.TabStop = false;
            this.BOX.Text = "Заменить на другой тип";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(8, 76);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(169, 54);
            this.buttonReplace.TabIndex = 43;
            this.buttonReplace.Text = "Заменить";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // boxTypeOfEnsemble
            // 
            this.boxTypeOfEnsemble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTypeOfEnsemble.FormattingEnabled = true;
            this.boxTypeOfEnsemble.Location = new System.Drawing.Point(6, 31);
            this.boxTypeOfEnsemble.Name = "boxTypeOfEnsemble";
            this.boxTypeOfEnsemble.Size = new System.Drawing.Size(169, 24);
            this.boxTypeOfEnsemble.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxName);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Location = new System.Drawing.Point(225, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 152);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новый тип";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(6, 31);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(169, 22);
            this.boxName.TabIndex = 45;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 76);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(169, 54);
            this.buttonAdd.TabIndex = 43;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "в одной записи в таблице \"ансамбли\".";
            // 
            // FormReplacementTypeOfEnsemble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 394);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BOX);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReplacementTypeOfEnsemble";
            this.Text = "Замена типа ансамбля";
            this.Load += new System.EventHandler(this.FormReplacementTypeOfEnsemble_Load);
            this.BOX.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox BOX;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.ComboBox boxTypeOfEnsemble;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
    }
}
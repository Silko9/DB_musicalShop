namespace DB_musicalShop.FormTable.FormAddOrUpdate
{
    partial class FormQueryComposition
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
            this.button = new System.Windows.Forms.Button();
            this.boxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 88;
            this.label5.Text = "Дата создания";
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(19, 240);
            this.dateCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(239, 22);
            this.dateCreate.TabIndex = 87;
            // 
            // boxPatronymic
            // 
            this.boxPatronymic.Location = new System.Drawing.Point(17, 187);
            this.boxPatronymic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxPatronymic.MaxLength = 15;
            this.boxPatronymic.Name = "boxPatronymic";
            this.boxPatronymic.Size = new System.Drawing.Size(240, 22);
            this.boxPatronymic.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 85;
            this.label4.Text = "Отчество автора";
            // 
            // boxNameAuthor
            // 
            this.boxNameAuthor.Location = new System.Drawing.Point(17, 81);
            this.boxNameAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxNameAuthor.MaxLength = 15;
            this.boxNameAuthor.Name = "boxNameAuthor";
            this.boxNameAuthor.Size = new System.Drawing.Size(239, 22);
            this.boxNameAuthor.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "Имя автора";
            // 
            // boxSurname
            // 
            this.boxSurname.Location = new System.Drawing.Point(17, 135);
            this.boxSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxSurname.MaxLength = 15;
            this.boxSurname.Name = "boxSurname";
            this.boxSurname.Size = new System.Drawing.Size(239, 22);
            this.boxSurname.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Фамилия автора";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(15, 277);
            this.button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(243, 54);
            this.button.TabIndex = 80;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(17, 30);
            this.boxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxName.MaxLength = 20;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(237, 22);
            this.boxName.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Название произведение";
            // 
            // FormQueryComposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 347);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.boxPatronymic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxNameAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQueryComposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQueryComposition";
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
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label label1;
    }
}
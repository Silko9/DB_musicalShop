namespace DB_musicalShop.FormTable.FormQuery
{
    partial class FormЙQueryRelationRecordPerformance
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
            this.boxRecord = new System.Windows.Forms.ComboBox();
            this.boxPerformance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxRecord
            // 
            this.boxRecord.FormattingEnabled = true;
            this.boxRecord.Location = new System.Drawing.Point(11, 24);
            this.boxRecord.Margin = new System.Windows.Forms.Padding(2);
            this.boxRecord.Name = "boxRecord";
            this.boxRecord.Size = new System.Drawing.Size(182, 21);
            this.boxRecord.TabIndex = 21;
            // 
            // boxPerformance
            // 
            this.boxPerformance.FormattingEnabled = true;
            this.boxPerformance.Location = new System.Drawing.Point(11, 70);
            this.boxPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.boxPerformance.Name = "boxPerformance";
            this.boxPerformance.Size = new System.Drawing.Size(182, 21);
            this.boxPerformance.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Пластинка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Исполнение";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(11, 95);
            this.button.Margin = new System.Windows.Forms.Padding(2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(182, 44);
            this.button.TabIndex = 54;
            this.button.Text = "Добавить связь";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // FormЙQueryRelationRecordPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 151);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPerformance);
            this.Controls.Add(this.boxRecord);
            this.Name = "FormЙQueryRelationRecordPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление связи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxRecord;
        private System.Windows.Forms.ComboBox boxPerformance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button;
    }
}
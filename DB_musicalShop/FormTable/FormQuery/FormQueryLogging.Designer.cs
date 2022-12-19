namespace DB_musicalShop.FormTable.FormQuery
{
    partial class FormQueryLogging
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
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.boxTypeOfAction = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxNumberRecord = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(16, 178);
            this.numericAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(236, 22);
            this.numericAmount.TabIndex = 74;
            this.numericAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Дата";
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(16, 126);
            this.dateCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(237, 22);
            this.dateCreate.TabIndex = 72;
            // 
            // boxTypeOfAction
            // 
            this.boxTypeOfAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTypeOfAction.FormattingEnabled = true;
            this.boxTypeOfAction.Location = new System.Drawing.Point(16, 74);
            this.boxTypeOfAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxTypeOfAction.Name = "boxTypeOfAction";
            this.boxTypeOfAction.Size = new System.Drawing.Size(237, 24);
            this.boxTypeOfAction.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Тип действия";
            // 
            // boxNumberRecord
            // 
            this.boxNumberRecord.FormattingEnabled = true;
            this.boxNumberRecord.Location = new System.Drawing.Point(16, 26);
            this.boxNumberRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxNumberRecord.Name = "boxNumberRecord";
            this.boxNumberRecord.Size = new System.Drawing.Size(237, 24);
            this.boxNumberRecord.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Номер пластинки";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(16, 222);
            this.button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(243, 54);
            this.button.TabIndex = 67;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Кол-во";
            // 
            // FormQueryLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 288);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.boxTypeOfAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxNumberRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQueryLogging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQueryLogging";
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.ComboBox boxTypeOfAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxNumberRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
    }
}
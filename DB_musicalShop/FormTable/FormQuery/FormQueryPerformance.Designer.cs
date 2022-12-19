namespace DB_musicalShop.FormTable.FormQuery
{
    partial class FormQueryPerformance
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
            this.boxCircumstances_execution = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxComposition = new System.Windows.Forms.ComboBox();
            this.boxEnsemble = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxCircumstances_execution
            // 
            this.boxCircumstances_execution.Location = new System.Drawing.Point(16, 206);
            this.boxCircumstances_execution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCircumstances_execution.MaxLength = 200;
            this.boxCircumstances_execution.Name = "boxCircumstances_execution";
            this.boxCircumstances_execution.Size = new System.Drawing.Size(241, 163);
            this.boxCircumstances_execution.TabIndex = 75;
            this.boxCircumstances_execution.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Обстоятельства исполнения";
            // 
            // boxComposition
            // 
            this.boxComposition.FormattingEnabled = true;
            this.boxComposition.Location = new System.Drawing.Point(16, 85);
            this.boxComposition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxComposition.Name = "boxComposition";
            this.boxComposition.Size = new System.Drawing.Size(244, 24);
            this.boxComposition.TabIndex = 73;
            // 
            // boxEnsemble
            // 
            this.boxEnsemble.FormattingEnabled = true;
            this.boxEnsemble.Location = new System.Drawing.Point(17, 27);
            this.boxEnsemble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxEnsemble.Name = "boxEnsemble";
            this.boxEnsemble.Size = new System.Drawing.Size(241, 24);
            this.boxEnsemble.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Дата исполнения";
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(16, 142);
            this.dateCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(243, 22);
            this.dateCreate.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Произведение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ансамбль";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(19, 386);
            this.button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(243, 54);
            this.button.TabIndex = 67;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // FormQueryPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 449);
            this.Controls.Add(this.boxCircumstances_execution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxComposition);
            this.Controls.Add(this.boxEnsemble);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQueryPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQueryPerformance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox boxCircumstances_execution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxComposition;
        private System.Windows.Forms.ComboBox boxEnsemble;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button;
    }
}
namespace lockitPuller
{
    partial class Form1
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
            this.sheetIDTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.allSheetsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sheetIDTextBox
            // 
            this.sheetIDTextBox.Location = new System.Drawing.Point(12, 12);
            this.sheetIDTextBox.Name = "sheetIDTextBox";
            this.sheetIDTextBox.Size = new System.Drawing.Size(447, 22);
            this.sheetIDTextBox.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(466, 13);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // allSheetsComboBox
            // 
            this.allSheetsComboBox.FormattingEnabled = true;
            this.allSheetsComboBox.Location = new System.Drawing.Point(12, 41);
            this.allSheetsComboBox.Name = "allSheetsComboBox";
            this.allSheetsComboBox.Size = new System.Drawing.Size(447, 24);
            this.allSheetsComboBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allSheetsComboBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.sheetIDTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sheetIDTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox allSheetsComboBox;
    }
}


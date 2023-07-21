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
            this.createLanguagesButton = new System.Windows.Forms.Button();
            this.listIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sheetIDTextBox
            // 
            this.sheetIDTextBox.Location = new System.Drawing.Point(12, 12);
            this.sheetIDTextBox.Name = "sheetIDTextBox";
            this.sheetIDTextBox.Size = new System.Drawing.Size(447, 22);
            this.sheetIDTextBox.TabIndex = 0;
            // 
            // createLanguagesButton
            // 
            this.createLanguagesButton.Location = new System.Drawing.Point(466, 41);
            this.createLanguagesButton.Name = "createLanguagesButton";
            this.createLanguagesButton.Size = new System.Drawing.Size(117, 23);
            this.createLanguagesButton.TabIndex = 3;
            this.createLanguagesButton.Text = "Формировать";
            this.createLanguagesButton.UseVisualStyleBackColor = true;
            this.createLanguagesButton.Click += new System.EventHandler(this.createLanguagesButton_Click);
            // 
            // listIDTextBox
            // 
            this.listIDTextBox.Location = new System.Drawing.Point(13, 41);
            this.listIDTextBox.Name = "listIDTextBox";
            this.listIDTextBox.Size = new System.Drawing.Size(447, 22);
            this.listIDTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listIDTextBox);
            this.Controls.Add(this.createLanguagesButton);
            this.Controls.Add(this.sheetIDTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sheetIDTextBox;
        private System.Windows.Forms.Button createLanguagesButton;
        private System.Windows.Forms.TextBox listIDTextBox;
    }
}


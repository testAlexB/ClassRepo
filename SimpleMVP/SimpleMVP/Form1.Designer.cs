namespace SimpleMVP
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
            this.StringList = new System.Windows.Forms.ListBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StringList
            // 
            this.StringList.FormattingEnabled = true;
            this.StringList.ItemHeight = 16;
            this.StringList.Location = new System.Drawing.Point(145, -1);
            this.StringList.Name = "StringList";
            this.StringList.Size = new System.Drawing.Size(285, 228);
            this.StringList.TabIndex = 0;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(202, 255);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(133, 23);
            this.SortButton.TabIndex = 1;
            this.SortButton.Text = "Отсортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.StringList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StringList;
        private System.Windows.Forms.Button SortButton;
    }
}


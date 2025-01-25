namespace FirstWinFormsApp
{
    partial class MainForm
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
            this.Peoples = new System.Windows.Forms.ListBox();
            this.AddPeople = new System.Windows.Forms.Button();
            this.PeopleTextBox = new System.Windows.Forms.TextBox();
            this.PictureArea = new System.Windows.Forms.PictureBox();
            this.SelectedImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // Peoples
            // 
            this.Peoples.FormattingEnabled = true;
            this.Peoples.ItemHeight = 16;
            this.Peoples.Location = new System.Drawing.Point(95, 15);
            this.Peoples.Margin = new System.Windows.Forms.Padding(4);
            this.Peoples.Name = "Peoples";
            this.Peoples.Size = new System.Drawing.Size(232, 228);
            this.Peoples.TabIndex = 0;
            this.Peoples.SelectedIndexChanged += new System.EventHandler(this.Peoples_SelectedIndexChanged);
            this.Peoples.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Peoples_PreviewKeyDown);
            // 
            // AddPeople
            // 
            this.AddPeople.Location = new System.Drawing.Point(228, 277);
            this.AddPeople.Margin = new System.Windows.Forms.Padding(4);
            this.AddPeople.Name = "AddPeople";
            this.AddPeople.Size = new System.Drawing.Size(100, 28);
            this.AddPeople.TabIndex = 1;
            this.AddPeople.Text = "Добавить";
            this.AddPeople.UseVisualStyleBackColor = true;
            this.AddPeople.Click += new System.EventHandler(this.AddPeople_Click);
            // 
            // PeopleTextBox
            // 
            this.PeopleTextBox.Location = new System.Drawing.Point(87, 279);
            this.PeopleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PeopleTextBox.Name = "PeopleTextBox";
            this.PeopleTextBox.Size = new System.Drawing.Size(132, 22);
            this.PeopleTextBox.TabIndex = 2;
            // 
            // PictureArea
            // 
            this.PictureArea.Location = new System.Drawing.Point(335, 15);
            this.PictureArea.Name = "PictureArea";
            this.PictureArea.Size = new System.Drawing.Size(621, 423);
            this.PictureArea.TabIndex = 3;
            this.PictureArea.TabStop = false;
            // 
            // SelectedImageFileDialog
            // 
            this.SelectedImageFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Image files (*.jpg)|*.jpg";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.PictureArea);
            this.Controls.Add(this.PeopleTextBox);
            this.Controls.Add(this.AddPeople);
            this.Controls.Add(this.Peoples);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Заголовок главной формы";
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Peoples;
        private System.Windows.Forms.Button AddPeople;
        private System.Windows.Forms.TextBox PeopleTextBox;
        private System.Windows.Forms.PictureBox PictureArea;
        private System.Windows.Forms.OpenFileDialog SelectedImageFileDialog;
    }
}


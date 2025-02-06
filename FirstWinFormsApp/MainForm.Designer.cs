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
            this.Images = new System.Windows.Forms.ListBox();
            this.AddPeople = new System.Windows.Forms.Button();
            this.PictureArea = new System.Windows.Forms.PictureBox();
            this.SelectedImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Images
            // 
            this.Images.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Images.FormattingEnabled = true;
            this.Images.Location = new System.Drawing.Point(0, -4);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(265, 329);
            this.Images.TabIndex = 0;
            this.Images.SelectedIndexChanged += new System.EventHandler(this.Images_SelectedIndexChanged);
            this.Images.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Peoples_PreviewKeyDown);
            // 
            // AddPeople
            // 
            this.AddPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPeople.Location = new System.Drawing.Point(12, 331);
            this.AddPeople.Name = "AddPeople";
            this.AddPeople.Size = new System.Drawing.Size(75, 23);
            this.AddPeople.TabIndex = 1;
            this.AddPeople.Text = "Добавить";
            this.AddPeople.UseVisualStyleBackColor = true;
            this.AddPeople.Click += new System.EventHandler(this.AddPeople_Click);
            // 
            // PictureArea
            // 
            this.PictureArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureArea.Location = new System.Drawing.Point(0, 0);
            this.PictureArea.Margin = new System.Windows.Forms.Padding(2);
            this.PictureArea.Name = "PictureArea";
            this.PictureArea.Size = new System.Drawing.Size(461, 359);
            this.PictureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureArea.TabIndex = 3;
            this.PictureArea.TabStop = false;
            // 
            // SelectedImageFileDialog
            // 
            this.SelectedImageFileDialog.Filter = "Image files|*.jpg;*.bmp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Images);
            this.panel1.Controls.Add(this.AddPeople);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 359);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PictureArea);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(265, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 359);
            this.panel2.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(726, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Заголовок главной формы";
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Images;
        private System.Windows.Forms.Button AddPeople;
        private System.Windows.Forms.PictureBox PictureArea;
        private System.Windows.Forms.OpenFileDialog SelectedImageFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}


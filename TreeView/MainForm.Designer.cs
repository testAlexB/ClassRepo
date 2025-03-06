namespace TreeView
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
            this.MyTreeView = new System.Windows.Forms.TreeView();
            this.Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // MyTreeView
            // 
            this.MyTreeView.Location = new System.Drawing.Point(12, 12);
            this.MyTreeView.Name = "MyTreeView";
            this.MyTreeView.Size = new System.Drawing.Size(232, 302);
            this.MyTreeView.TabIndex = 0;
            this.MyTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.MyTreeView_BeforeCollapse);
            this.MyTreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.MyTreeView_AfterCollapse);
            this.MyTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.MyTreeView_BeforeExpand);
            this.MyTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.MyTreeView_AfterExpand);
            this.MyTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MyTreeView_NodeMouseDoubleClick);
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(264, 12);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(734, 302);
            this.Table.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.MyTreeView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView MyTreeView;
        private System.Windows.Forms.DataGridView Table;
    }
}


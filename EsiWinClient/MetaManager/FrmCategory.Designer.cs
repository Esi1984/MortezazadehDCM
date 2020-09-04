namespace EsiWinClient.MetaManager
{
    partial class FrmCategory
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EsiGateGridView = new System.Windows.Forms.DataGridView();
            this.cateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esiCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EsiGateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCategoryToolStripMenuItem,
            this.newCateToolStripMenuItem,
            this.updateCateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newCategoryToolStripMenuItem
            // 
            this.newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            this.newCategoryToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.newCategoryToolStripMenuItem.Text = "مشاهده دسته ها";
            this.newCategoryToolStripMenuItem.Click += new System.EventHandler(this.newCategoryToolStripMenuItem_Click);
            // 
            // newCateToolStripMenuItem
            // 
            this.newCateToolStripMenuItem.Name = "newCateToolStripMenuItem";
            this.newCateToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.newCateToolStripMenuItem.Text = "جدید";
            this.newCateToolStripMenuItem.Click += new System.EventHandler(this.newCateToolStripMenuItem_Click);
            // 
            // updateCateToolStripMenuItem
            // 
            this.updateCateToolStripMenuItem.Name = "updateCateToolStripMenuItem";
            this.updateCateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.updateCateToolStripMenuItem.Text = "بروزرسانی";
            // 
            // EsiGateGridView
            // 
            this.EsiGateGridView.AllowUserToDeleteRows = false;
            this.EsiGateGridView.AutoGenerateColumns = false;
            this.EsiGateGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.EsiGateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EsiGateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cateIDDataGridViewTextBoxColumn,
            this.cateLabelDataGridViewTextBoxColumn,
            this.cateDescDataGridViewTextBoxColumn});
            this.EsiGateGridView.DataSource = this.esiCategoryBindingSource;
            this.EsiGateGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EsiGateGridView.EnableHeadersVisualStyles = false;
            this.EsiGateGridView.Location = new System.Drawing.Point(0, 24);
            this.EsiGateGridView.Name = "EsiGateGridView";
            this.EsiGateGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EsiGateGridView.Size = new System.Drawing.Size(784, 357);
            this.EsiGateGridView.TabIndex = 1;
            this.EsiGateGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EsiGateGridView_CellContentClick);
            this.EsiGateGridView.DoubleClick += new System.EventHandler(this.EsiGateGridView_DoubleClick);
            // 
            // cateIDDataGridViewTextBoxColumn
            // 
            this.cateIDDataGridViewTextBoxColumn.DataPropertyName = "CateID";
            this.cateIDDataGridViewTextBoxColumn.HeaderText = "CateID";
            this.cateIDDataGridViewTextBoxColumn.Name = "cateIDDataGridViewTextBoxColumn";
            // 
            // cateLabelDataGridViewTextBoxColumn
            // 
            this.cateLabelDataGridViewTextBoxColumn.DataPropertyName = "CateLabel";
            this.cateLabelDataGridViewTextBoxColumn.HeaderText = "CateLabel";
            this.cateLabelDataGridViewTextBoxColumn.Name = "cateLabelDataGridViewTextBoxColumn";
            // 
            // cateDescDataGridViewTextBoxColumn
            // 
            this.cateDescDataGridViewTextBoxColumn.DataPropertyName = "CateDesc";
            this.cateDescDataGridViewTextBoxColumn.HeaderText = "CateDesc";
            this.cateDescDataGridViewTextBoxColumn.Name = "cateDescDataGridViewTextBoxColumn";
            // 
            // esiCategoryBindingSource
            // 
            this.esiCategoryBindingSource.DataSource = typeof(MortezazadehDCM.EsiToCategory);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.EsiGateGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.Shown += new System.EventHandler(this.FrmCategory_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EsiGateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCateToolStripMenuItem;
        private System.Windows.Forms.DataGridView EsiGateGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource esiCategoryBindingSource;
    }
}
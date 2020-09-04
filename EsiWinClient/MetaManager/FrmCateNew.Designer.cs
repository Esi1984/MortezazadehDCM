namespace EsiWinClient.MetaManager
{
    partial class FrmCateNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOK = new System.Windows.Forms.Button();
            this.EsiGV = new System.Windows.Forms.DataGridView();
            this.ucCateNew1 = new EsiWinClient.MetaManager.ucCateNew();
            this.esiFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.esiToMetaTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldAutoDescStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldPerfixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldPostfixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldHisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldAllowNullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esiToCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esiMetaTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EsiGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiFieldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiToMetaTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(250, 39);
            this.btnOK.Name = "btnOK";
            this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "تایید";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // EsiGV
            // 
            this.EsiGV.AutoGenerateColumns = false;
            this.EsiGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.EsiGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EsiGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldIDDataGridViewTextBoxColumn,
            this.fieldLabelDataGridViewTextBoxColumn,
            this.fieldOrderDataGridViewTextBoxColumn,
            this.fieldAutoDescStateDataGridViewTextBoxColumn,
            this.fieldPerfixDataGridViewTextBoxColumn,
            this.fieldPostfixDataGridViewTextBoxColumn,
            this.fieldHisDataGridViewTextBoxColumn,
            this.fieldAllowNullDataGridViewTextBoxColumn,
            this.fieldStateDataGridViewTextBoxColumn,
            this.fieldDescDataGridViewTextBoxColumn,
            this.fieldSizeDataGridViewTextBoxColumn,
            this.esiToCategoryDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.esiMetaTypeDataGridViewTextBoxColumn});
            this.EsiGV.DataSource = this.esiFieldBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EsiGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.EsiGV.Location = new System.Drawing.Point(32, 94);
            this.EsiGV.MultiSelect = false;
            this.EsiGV.Name = "EsiGV";
            this.EsiGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EsiGV.Size = new System.Drawing.Size(940, 280);
            this.EsiGV.TabIndex = 4;
            this.EsiGV.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.EsiGV_UserAddedRow);
            // 
            // ucCateNew1
            // 
            this.ucCateNew1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.ucCateNew1.Location = new System.Drawing.Point(375, 12);
            this.ucCateNew1.Name = "ucCateNew1";
            this.ucCateNew1.Size = new System.Drawing.Size(597, 69);
            this.ucCateNew1.TabIndex = 5;
            // 
            // esiFieldBindingSource
            // 
            this.esiFieldBindingSource.DataSource = typeof(MagicManager.MagicMeta.EsiField);
            // 
            // esiToMetaTypeBindingSource
            // 
            this.esiToMetaTypeBindingSource.DataSource = typeof(MortezazadehDCM.EsiToMetaType);
            // 
            // fieldIDDataGridViewTextBoxColumn
            // 
            this.fieldIDDataGridViewTextBoxColumn.DataPropertyName = "FieldID";
            this.fieldIDDataGridViewTextBoxColumn.HeaderText = "FieldID";
            this.fieldIDDataGridViewTextBoxColumn.Name = "fieldIDDataGridViewTextBoxColumn";
            // 
            // fieldLabelDataGridViewTextBoxColumn
            // 
            this.fieldLabelDataGridViewTextBoxColumn.DataPropertyName = "FieldLabel";
            this.fieldLabelDataGridViewTextBoxColumn.HeaderText = "FieldLabel";
            this.fieldLabelDataGridViewTextBoxColumn.Name = "fieldLabelDataGridViewTextBoxColumn";
            // 
            // fieldOrderDataGridViewTextBoxColumn
            // 
            this.fieldOrderDataGridViewTextBoxColumn.DataPropertyName = "FieldOrder";
            this.fieldOrderDataGridViewTextBoxColumn.HeaderText = "FieldOrder";
            this.fieldOrderDataGridViewTextBoxColumn.Name = "fieldOrderDataGridViewTextBoxColumn";
            // 
            // fieldAutoDescStateDataGridViewTextBoxColumn
            // 
            this.fieldAutoDescStateDataGridViewTextBoxColumn.DataPropertyName = "FieldAutoDescState";
            this.fieldAutoDescStateDataGridViewTextBoxColumn.HeaderText = "FieldAutoDescState";
            this.fieldAutoDescStateDataGridViewTextBoxColumn.Name = "fieldAutoDescStateDataGridViewTextBoxColumn";
            // 
            // fieldPerfixDataGridViewTextBoxColumn
            // 
            this.fieldPerfixDataGridViewTextBoxColumn.DataPropertyName = "FieldPerfix";
            this.fieldPerfixDataGridViewTextBoxColumn.HeaderText = "FieldPerfix";
            this.fieldPerfixDataGridViewTextBoxColumn.Name = "fieldPerfixDataGridViewTextBoxColumn";
            // 
            // fieldPostfixDataGridViewTextBoxColumn
            // 
            this.fieldPostfixDataGridViewTextBoxColumn.DataPropertyName = "FieldPostfix";
            this.fieldPostfixDataGridViewTextBoxColumn.HeaderText = "FieldPostfix";
            this.fieldPostfixDataGridViewTextBoxColumn.Name = "fieldPostfixDataGridViewTextBoxColumn";
            // 
            // fieldHisDataGridViewTextBoxColumn
            // 
            this.fieldHisDataGridViewTextBoxColumn.DataPropertyName = "FieldHis";
            this.fieldHisDataGridViewTextBoxColumn.HeaderText = "FieldHis";
            this.fieldHisDataGridViewTextBoxColumn.Name = "fieldHisDataGridViewTextBoxColumn";
            // 
            // fieldAllowNullDataGridViewTextBoxColumn
            // 
            this.fieldAllowNullDataGridViewTextBoxColumn.DataPropertyName = "FieldAllowNull";
            this.fieldAllowNullDataGridViewTextBoxColumn.HeaderText = "FieldAllowNull";
            this.fieldAllowNullDataGridViewTextBoxColumn.Name = "fieldAllowNullDataGridViewTextBoxColumn";
            // 
            // fieldStateDataGridViewTextBoxColumn
            // 
            this.fieldStateDataGridViewTextBoxColumn.DataPropertyName = "FieldState";
            this.fieldStateDataGridViewTextBoxColumn.HeaderText = "FieldState";
            this.fieldStateDataGridViewTextBoxColumn.Name = "fieldStateDataGridViewTextBoxColumn";
            // 
            // fieldDescDataGridViewTextBoxColumn
            // 
            this.fieldDescDataGridViewTextBoxColumn.DataPropertyName = "FieldDesc";
            this.fieldDescDataGridViewTextBoxColumn.HeaderText = "FieldDesc";
            this.fieldDescDataGridViewTextBoxColumn.Name = "fieldDescDataGridViewTextBoxColumn";
            // 
            // fieldSizeDataGridViewTextBoxColumn
            // 
            this.fieldSizeDataGridViewTextBoxColumn.DataPropertyName = "FieldSize";
            this.fieldSizeDataGridViewTextBoxColumn.HeaderText = "FieldSize";
            this.fieldSizeDataGridViewTextBoxColumn.Name = "fieldSizeDataGridViewTextBoxColumn";
            // 
            // esiToCategoryDataGridViewTextBoxColumn
            // 
            this.esiToCategoryDataGridViewTextBoxColumn.DataPropertyName = "EsiToCategory";
            this.esiToCategoryDataGridViewTextBoxColumn.HeaderText = "EsiToCategory";
            this.esiToCategoryDataGridViewTextBoxColumn.Name = "esiToCategoryDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EsiItems";
            this.dataGridViewTextBoxColumn1.HeaderText = "EsiItems";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // esiMetaTypeDataGridViewTextBoxColumn
            // 
            this.esiMetaTypeDataGridViewTextBoxColumn.DataPropertyName = "EsiMetaType";
            this.esiMetaTypeDataGridViewTextBoxColumn.DataSource = this.esiToMetaTypeBindingSource;
            this.esiMetaTypeDataGridViewTextBoxColumn.DisplayMember = "EsiMetaTypelabel";
            this.esiMetaTypeDataGridViewTextBoxColumn.HeaderText = "EsiMetaType";
            this.esiMetaTypeDataGridViewTextBoxColumn.Name = "esiMetaTypeDataGridViewTextBoxColumn";
            this.esiMetaTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.esiMetaTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.esiMetaTypeDataGridViewTextBoxColumn.ValueMember = "This";
            // 
            // FrmCateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 386);
            this.Controls.Add(this.ucCateNew1);
            this.Controls.Add(this.EsiGV);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmCateNew";
            this.Text = "ساخت یک دسته بندی جدید";
            this.Load += new System.EventHandler(this.FrmCateNew_Load);
            this.Shown += new System.EventHandler(this.FrmCateNew_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.EsiGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiFieldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiToMetaTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.DataGridView EsiGV;
        private ucCateNew ucCateNew1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esiCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esiItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource esiToMetaTypeBindingSource;
        private System.Windows.Forms.BindingSource esiFieldBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldAutoDescStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldPerfixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldPostfixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldHisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldAllowNullDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esiToCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn esiMetaTypeDataGridViewTextBoxColumn;
    }
}
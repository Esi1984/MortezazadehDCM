namespace EsiWinClient
{
    partial class PGMortezazadeh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EsiPG = new System.Windows.Forms.PropertyGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EsiPG
            // 
            this.EsiPG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EsiPG.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.EsiPG.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.EsiPG.LineColor = System.Drawing.SystemColors.ControlDark;
            this.EsiPG.Location = new System.Drawing.Point(135, 3);
            this.EsiPG.Name = "EsiPG";
            this.EsiPG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EsiPG.Size = new System.Drawing.Size(369, 501);
            this.EsiPG.TabIndex = 0;
            this.EsiPG.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PGMortezazadeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EsiPG);
            this.Name = "PGMortezazadeh";
            this.Size = new System.Drawing.Size(507, 507);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid EsiPG;
        private System.Windows.Forms.Button button1;
    }
}

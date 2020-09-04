namespace EsiWinClient.UCD
{
    partial class UCI
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
            this.ilbl = new System.Windows.Forms.Label();
            this.inup = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inup)).BeginInit();
            this.SuspendLayout();
            // 
            // ilbl
            // 
            this.ilbl.AutoSize = true;
            this.ilbl.Location = new System.Drawing.Point(236, 6);
            this.ilbl.Name = "ilbl";
            this.ilbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ilbl.Size = new System.Drawing.Size(109, 13);
            this.ilbl.TabIndex = 2;
            this.ilbl.Text = "ooooooooooooooooo";
            // 
            // inup
            // 
            this.inup.InterceptArrowKeys = false;
            this.inup.Location = new System.Drawing.Point(3, 3);
            this.inup.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.inup.Name = "inup";
            this.inup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inup.Size = new System.Drawing.Size(227, 20);
            this.inup.TabIndex = 3;
            this.inup.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // UCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.inup);
            this.Controls.Add(this.ilbl);
            this.Name = "UCI";
            this.Size = new System.Drawing.Size(353, 26);
            ((System.ComponentModel.ISupportInitialize)(this.inup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ilbl;
        private System.Windows.Forms.NumericUpDown inup;
    }
}

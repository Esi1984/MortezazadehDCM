namespace EsiWinClient.UCD
{
    partial class UCT
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
            this.itb = new System.Windows.Forms.TextBox();
            this.ilbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itb
            // 
            this.itb.Location = new System.Drawing.Point(3, 3);
            this.itb.Name = "itb";
            this.itb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itb.Size = new System.Drawing.Size(227, 20);
            this.itb.TabIndex = 0;
            // 
            // ilbl
            // 
            this.ilbl.AutoSize = true;
            this.ilbl.Location = new System.Drawing.Point(236, 6);
            this.ilbl.Name = "ilbl";
            this.ilbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ilbl.Size = new System.Drawing.Size(109, 13);
            this.ilbl.TabIndex = 1;
            this.ilbl.Text = "ooooooooooooooooo";
            // 
            // UCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.ilbl);
            this.Controls.Add(this.itb);
            this.Name = "UCT";
            this.Size = new System.Drawing.Size(353, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itb;
        private System.Windows.Forms.Label ilbl;
    }
}

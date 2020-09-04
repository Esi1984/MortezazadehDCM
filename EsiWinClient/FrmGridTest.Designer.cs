namespace EsiWinClient
{
    partial class FrmGridTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.ucd1 = new EsiWinClient.UCD.UCD();
            this.esiToFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.esiToFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucd1
            // 
            this.ucd1.AutoScroll = true;
            this.ucd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.ucd1.Location = new System.Drawing.Point(316, 18);
            this.ucd1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucd1.Name = "ucd1";
            this.ucd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucd1.Size = new System.Drawing.Size(690, 275);
            this.ucd1.TabIndex = 2;
            // 
            // esiToFieldBindingSource
            // 
            this.esiToFieldBindingSource.DataSource = typeof(MortezazadehDCM.EsiToField);
            // 
            // FrmGridTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1066, 389);
            this.Controls.Add(this.ucd1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmGridTest";
            this.Text = "FrmGridTest";
            this.Load += new System.EventHandler(this.FrmGridTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.esiToFieldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private UCD.UCD ucd1;
        private System.Windows.Forms.BindingSource esiToFieldBindingSource;
    }
}
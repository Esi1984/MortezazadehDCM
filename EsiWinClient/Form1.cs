using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiWinClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public  void CreateGridView()
        {
            System.Windows.Forms.DataGridViewTextBoxColumn IdGoalUnit;
            System.Windows.Forms.DataGridViewTextBoxColumn IdGoalUnit2;

            IdGoalUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdGoalUnit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();

            EsiGateGridView.AllowUserToDeleteRows = false;
            EsiGateGridView.AutoGenerateColumns = false;
            EsiGateGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            EsiGateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EsiGateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            IdGoalUnit,IdGoalUnit2});
            // EsiGateGridView.DataSource = this.goalUnitBindingSource;
            EsiGateGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            EsiGateGridView.EnableHeadersVisualStyles = false;
            EsiGateGridView.Location = new System.Drawing.Point(0, 0);
            EsiGateGridView.Name = "EsiGateGridView";
            EsiGateGridView.Size = new System.Drawing.Size(668, 178);
            EsiGateGridView.TabIndex = 12;
            //EsiGateGridView.SelectionChanged += new System.EventHandler(this.EsiGateGridView_SelectionChanged);
            //   EsiGateGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.EsiGateGridView_UserAddedRow);
            //  EsiGateGridView.BindingContextChanged += new System.EventHandler(this.EsiGateGridView_BindingContextChanged);


            IdGoalUnit.DataPropertyName = "IdGoalUnit";
            IdGoalUnit.HeaderText = "IdGoalUnit";
            IdGoalUnit.Name = "IdGoalUnit";
            IdGoalUnit.Visible = false;

            IdGoalUnit2.DataPropertyName = "IdGoalUnit2";
            IdGoalUnit2.HeaderText = "IdGoalUnit2";
            IdGoalUnit2.Name = "IdGoalUnit2";
            IdGoalUnit2.Visible = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            CreateGridView();

            Type tt = typeof(string);
            DataTable dt = new DataTable();
            dt.Columns.Add("IdGoalUnit2", typeof(string));
            dt.Columns.Add("IdGoalUnit1", typeof(string));
            EsiGateGridView.DataSource = dt;
        }

        private void ijijjToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

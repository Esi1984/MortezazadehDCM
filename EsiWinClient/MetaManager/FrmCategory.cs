using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicManager;
using MortezazadehDCM;

namespace EsiWinClient.MetaManager
{
    public partial class FrmCategory : EsiWinClient.FrmEsiBase
    {
        MagicMeta MM;
        public FrmCategory()
        {
             MM = new MagicMeta();
            InitializeComponent();
        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {           

            //var lol = MM.LoadGates("kkkkkkk");
            EsiToCategory[] kkk =MM.CatesView().Result;

            // MagicManagerClient mmc = new MagicManagerClient(
            ///  MagicManager.EsiCategories mme = new MagicManager.EsiCategories(client)


          
            esiCategoryBindingSource.DataSource = kkk;
           // EsiGateGridView.DataSource = ;

        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            //menuStrip1.Renderer = new ToolStripProfessionalRenderer(new EsiColor());
        }

        private void FrmCategory_Shown(object sender, EventArgs e)
        {
            //EsiGateGridView.DataSource = 
        }

        private void newCateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCateNew();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {



            }
            else
            {

            }
        }

        private void EsiGateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EsiGateGridView_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EsiToCategory) esiCategoryBindingSource.Current;


            //var kkk =  MM.GetGateItems(obj.CateID);


            var frm = new FrmItemMode(ref obj);
            
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {

            

            }
            else
            {



            }



        }
    }
}

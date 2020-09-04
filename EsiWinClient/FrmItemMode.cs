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


namespace EsiWinClient
{
    public partial class FrmItemMode : FrmEsiBase
    {
        public IQueryable<MagicMeta.EsiItem> EM;
        public ICollection<MagicMeta.EsiField> ff;
        public EsiToCategory cate;
        public FrmItemMode(ref EsiToCategory cateIn)
        {
            cate = cateIn;
            InitializeComponent();
        }

        private void FrmItemMode_Load(object sender, EventArgs e)
        {

            //menuStrip1.Renderer = new ToolStripProfessionalRenderer(new EsiColor());

            // load meta

        
        }

        private void FrmItemMode_Shown(object sender, EventArgs e)
        {


            EsiToField[] Meta = MM.GetCateMeta(cate.CateID).Result;
            if (Meta.Count() >0)
            {
                ucGridView1.SetSchema(Meta, MM.STM);

                var dddd = Meta[0].FieldType;
            
            EsiToItem[] items = MM.GetGateItems(cate.CateID).Result;

           DataTable pivotArray = items.ToPivotTable(
               item => item.EsiFieldId,
              item => item.EsiObjId,
              item =>  item.First().EsiStrVal );

              ucGridView1.EsiGV.DataSource = pivotArray;
         


            }

        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

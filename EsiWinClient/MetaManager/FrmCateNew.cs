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
    public partial class FrmCateNew : FrmEsiBase
    {
        public string ObjCate { get; private set; }

        public FrmCateNew()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ucCateNew1.tbCateLabel.Text))
            {
                MessageBox.Show("نامی وارد نشده است");
            }
            else
            {

                //  DTH.DataTableToList<>((DataTable)EsiGV.DataSource);

                //DataView dv = (DataView)EsiGV.DataSource;
                //DataTable dt = ((DataView)EsiGV.DataSource).Table;

                //var bindingSource = (BindingSource)EsiGV.DataSource;
                // var dt = (MagicMeta.EsiField[])bindingSource.DataSource;

                //List<MagicMeta.EsiField> IFields = (List< EsiField>)esiFieldBindingSource.DataSource;
                //  List<MagicMeta.EsiField> IFields = ((List<MagicMeta.EsiField>)esiFieldBindingSource.DataSource).Cast<MagicMeta.EsiField>().ToList();



                //   List<MagicMeta.EsiField> IFields = DTH.DataTableToList<MagicMeta.EsiField>(dt);

                this.EsiGV.EndEdit();
                //this.sourfe.EndEdit();
                EsiGV.AllowUserToAddRows = false;

                MagicMeta.EsiCategory CateObj = new MagicMeta.EsiCategory();
                CateObj.CateName = ucCateNew1.tbCateLabel.Text;
                CateObj.CateLabel = ucCateNew1.tbCateLabel.Text;
                CateObj.CateDesc = ucCateNew1.tbCateDesc.Text;
                CateObj.CateName = ucCateNew1.tbCateLabel.Text;
                CateObj.CateOrder = 0;
                CateObj.CateState = 1;
                CateObj.CateTname = ucCateNew1.tbCateLabel.Text;
                CateObj.CateParent = null;


                var checkedItems = this.EsiGV.Rows.Cast<DataGridViewRow>()                           
                            .Select(x => x.DataBoundItem)
                            .Cast<MagicMeta.EsiField>().ToList();

                                
              //  esiFieldBindingSource.
                //   CateObj.EsiFields = (List<MagicMeta.EsiField>) esiFieldBindingSource.DataSource;

                
                CateObj.EsiFields = checkedItems;

                var res = MM.CateNew(CateObj).Result;

                if (res)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("ناموفق");
                }
            }
        }

        private void FrmCateNew_Load(object sender, EventArgs e)
        {

        }

        private void FrmCateNew_Shown(object sender, EventArgs e)
        {
            esiToMetaTypeBindingSource.DataSource = MM.STM;
            
            //viewMetaBindingSource.DataSource = MM.GetMt().Result;
        }

        private void EsiGV_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //var obj = (MagicMeta.EsiField)esiFieldBindingSource.Current;
            //obj.EsiCategory = null;
            //obj.EsiItems = null;            
        }
    }
}

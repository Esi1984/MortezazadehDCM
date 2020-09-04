using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicManager;
using MortezazadehDCM;

namespace EsiWinClient.MetaManager
{
    public partial class ucGridView : UserControl
    {
        public ucGridView()
        {
            InitializeComponent();
        }

        //  column.SortMode = DataGridViewColumnSortMode.Automatic;

        private DataGridViewColumn[] EsiCols;

        private EsiToMetaType[] typs;


      //  public System.Windows.Forms.BindingSource EsiGVBindingSource;

        public void SetSchema(EsiToField[] ConfigList, EsiToMetaType[] Intypes)
        {
            typs = Intypes;
            //DTH.DataTableToList<MagicMeta.EsiField>((DataTable)EsiGV.DataSource);
            EsiCols = new DataGridViewColumn[ConfigList.Count()+1];
            //for (int x = 0; x < ConfigList.Count(); x++)

            EsiCols[0] = new DataGridViewTextBoxColumn();
            EsiCols[0].DataPropertyName = "ID";
            EsiCols[0].Frozen = true;
            EsiCols[0].HeaderText = "شماره";
            EsiCols[0].Name = EsiCols[0].DataPropertyName;
            EsiCols[0].ReadOnly = true;
            EsiCols[0].Visible = true;


            int x = 0;
            foreach (var col in ConfigList)
            {
                x++;
             //   EsiCols[x] = new DataGridViewTextBoxColumn();
               
                switch (col.FieldType)
                {
                    case 1:
                        EsiCols[x] = new DataGridViewTextBoxColumn();                        
                        break;
                    case 2:
                        EsiCols[x] = new DataGridViewTextBoxColumn();
                        break;
                    case 3:
                        EsiCols[x] = new DataGridViewTextBoxColumn();
                        break;
                    case 4:
                        EsiCols[x] = new DataGridViewTextBoxColumn();
                        break;
                    case 5:
                        EsiCols[x] = new DataGridViewTextBoxColumn();
                        break;
                    case 6:
                        EsiCols[x] = new DataGridViewTextBoxColumn();
                        break;
                    case 7:
                        EsiCols[x] = new DataGridViewTextBoxColumn();
                        break;
                    default:
                        throw new Exception("ERROOR: 3110");
                }
                EsiCols[x].DataPropertyName = "Esi"+col.FieldID.ToString();
                EsiCols[x].Frozen = true;
                EsiCols[x].HeaderText = col.FieldLabel;
                EsiCols[x].Name = EsiCols[x].DataPropertyName;
                EsiCols[x].ReadOnly = true;               
            }
            EsiGV.Columns.AddRange(EsiCols);            

            //timeLine.Columns.Add(AllDays[x]);


            //    System.Windows.Forms.DataGridViewTextBoxColumn ColName;

            //    ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();


            //    System.Windows.Forms.DataGridViewComboBoxColumn colCombo;
            //    colCombo = new System.Windows.Forms.DataGridViewComboBoxColumn();

            //    // ColName
            //    // 
            //    ColName.DataPropertyName = "ColProperName";
            //    ColName.Frozen = true;
            //    ColName.HeaderText = "ColeLabel";
            //    ColName.Name = "ColName";
            //    ColName.ReadOnly = true;
            //    // 
            //    // colCombo
            //    // 
            //    colCombo.DataPropertyName = "probNarmConfo";
            //    colCombo.DataSource = this.esiMetaTypeBindingSource;
            //    colCombo.Frozen = true;
            //    colCombo.HeaderText = "ColComboLbl";
            //    colCombo.Name = "colCombo";
            //    colCombo.ReadOnly = true;

            //    this.EsiGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //        this.ColName,
            //        this.colCombo});



            //    public decimal FieldID { get; set; }
            //public string FieldLabel { get; set; }
            //public int FieldOrder { get; set; }
            //public int FieldAutoDescState { get; set; }
            //public string FieldPerfix { get; set; }
            //public string FieldPostfix { get; set; }
            //public int FieldHis { get; set; }
            //public int FieldAllowNull { get; set; }
            //public int FieldState { get; set; }
            //public string FieldDesc { get; set; }
            //public Nullable<int> FieldSize { get; set; }

            //public virtual EsiCategory EsiCategory { get; set; }
            //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            //public virtual ICollection<EsiItem> EsiItems { get; set; }
            //public virtual EsiMetaType EsiMetaType { get; set; }


            //EsiGVBindingSource = new System.Windows.Forms.BindingSource(this.components);


           // ((System.ComponentModel.ISupportInitialize)(EsiGVBindingSource)).BeginInit();



           // EsiGV.DataSource = EsiGVBindingSource;


            //     ((System.ComponentModel.ISupportInitialize)(this.esiMetaTypeBindingSource)).BeginInit();


            // esiMetaTypeBindingSource
            // 
            //  this.esiMetaTypeBindingSource.DataSource = typeof( EsiMetaType);


            //   ((System.ComponentModel.ISupportInitialize)(this.esiMetaTypeBindingSource)).EndInit();





        }

        public void FieldsSchema()
        {

            //    System.Windows.Forms.DataGridViewTextBoxColumn ColName;

            //    ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();


            //    System.Windows.Forms.DataGridViewComboBoxColumn colCombo;
            //    colCombo = new System.Windows.Forms.DataGridViewComboBoxColumn();

            //    // ColName
            //    // 
            //    ColName.DataPropertyName = "ColProperName";
            //    ColName.Frozen = true;
            //    ColName.HeaderText = "ColeLabel";
            //    ColName.Name = "ColName";
            //    ColName.ReadOnly = true;
            //    // 
            //    // colCombo
            //    // 
            //    colCombo.DataPropertyName = "probNarmConfo";
            //    colCombo.DataSource = this.esiMetaTypeBindingSource;
            //    colCombo.Frozen = true;
            //    colCombo.HeaderText = "ColComboLbl";
            //    colCombo.Name = "colCombo";
            //    colCombo.ReadOnly = true;

            //    this.EsiGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //    this.ColName,
            //    this.colCombo});



            //public decimal FieldID { get; set; }
            //public string FieldLabel { get; set; }
            //public int FieldOrder { get; set; }
            //public int FieldAutoDescState { get; set; }
            //public string FieldPerfix { get; set; }
            //public string FieldPostfix { get; set; }
            //public int FieldHis { get; set; }
            //public int FieldAllowNull { get; set; }
            //public int FieldState { get; set; }
            //public string FieldDesc { get; set; }
            //public Nullable<int> FieldSize { get; set; }

            //public virtual EsiCategory EsiCategory { get; set; }
            //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            //public virtual ICollection<EsiItem> EsiItems { get; set; }
            //public virtual EsiMetaType EsiMetaType { get; set; }


            //this.esiMetaTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);

            //((System.ComponentModel.ISupportInitialize)(this.esiMetaTypeBindingSource)).BeginInit();


            //// esiMetaTypeBindingSource
            //// 
            //this.esiMetaTypeBindingSource.DataSource = typeof( EsiMetaType);


            //((System.ComponentModel.ISupportInitialize)(this.esiMetaTypeBindingSource)).EndInit();



        }

    }
}

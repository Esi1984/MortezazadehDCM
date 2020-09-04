using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MortezazadehDCM;

namespace EsiWinClient.UCD
{
    public partial class UCI : UserControl
    {

       
        private decimal _TypeID;
      //  private string _LBL;
      //  private decimal _Value;
        private string _CName;

        private decimal _ID;
        public decimal ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public decimal TypeID
        {
            get { return _TypeID; }
            set { _TypeID = value; }
        }
        public string LBL
        {
            get { return ilbl.Text; }
            set { ilbl.Text = value; }
        }
        public decimal Value
        {
            get { return inup.Value; }
            set { inup.Value = value; }
        }


        public string CName
        {
            get { return _CName; }
            set { _CName = value; }
        }


        public UCI()
        {
            InitializeComponent();
        }

        public void ConFig(string cName, ref EsiToField obj)
        {
            LBL = obj.FieldLabel;
            TypeID = obj.FieldID;
            CName = cName; 
        }

        //public void SetVal(decimal val)
        //{
        //    inup.Value = val;        
        //}

        //public void empt()
        //{
        //    inup.Value = 0;
        //}

    }
}

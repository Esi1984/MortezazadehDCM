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
    public partial class UCD : UserControl
    {
        public UCD()
        {
            InitializeComponent();
        }

        private List<Control> ucds;
        private List<UCT> ucts;
        private List<UCI> ucis;

        private decimal _ID;
        public decimal ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
 
        private void UCD_Load(object sender, EventArgs e)
        {

        }
  
        public bool Config(EsiToField[] list)
        {
            int length = list.Count();
            ucds = new List<Control>();

            ucts = new List<UCT>();
            ucis = new List<UCI>();

            for (int i = 0; i < length; i++)
            {
                switch (list[i].FieldType)
                {
                    case 1:
                        //UCT nuc = new UCT()
                           ucts.Add(new UCT());
                        ucts.Last().Location = new System.Drawing.Point(85, 3 + (32 * i));
                        ucts.Last().Name = "ucd" + i;
                        ucts.Last().Size = new System.Drawing.Size(353, 26);
                        ucts.Last().TabIndex = i;
                        ucts.Last().ConFig(ucts.Last().Name, ref list[i]);
                        ucds.Add(ucts.Last());
                        this.Controls.Add(ucds.Last());
                        break;
                            case 2:
                        ucis.Add(new UCI());
                        ucis.Last().Location = new System.Drawing.Point(85, 3 + (32 * i));
                        ucis.Last().Name = "ucd" + i;
                        ucis.Last().Size = new System.Drawing.Size(353, 26);
                        ucis.Last().TabIndex = i;
                        ucis.Last().ConFig(ucis.Last().Name, ref list[i]);
                        ucds.Add(ucis.Last());
                        this.Controls.Add(ucds.Last());
                        break;
                    case 6:
                        break;                    default:
                        throw new Exception("Type Error");
                    //  this.Controls.Add(new UCT());
                    
                }               
            }
            return true;
        }
  
        private void CC(int length)
        {
          
            
            //{
                 
            //    ucds.Last().BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192))))
            //        , ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            
            //}          
        }
    }
}

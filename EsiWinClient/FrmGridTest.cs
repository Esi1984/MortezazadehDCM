using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MortezazadehDCM;

namespace EsiWinClient
{
    public partial class FrmGridTest : FrmEsiBase
    {
        public FrmGridTest()
        {
            InitializeComponent();
        }

        private void FrmGridTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal kk = 1;
            EsiToField[] Meta = MM.GetCateMeta(kk).Result;
            ucd1.Config(Meta);
          
        }
    }
}

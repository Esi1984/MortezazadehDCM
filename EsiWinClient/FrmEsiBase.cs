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
using System.Net.Http.Formatting;

namespace EsiWinClient
{
    public partial class FrmEsiBase : Form
    {
        public   MagicManager.MagicMeta MM ;

        public FrmEsiBase()
        {
            MM = new MagicMeta();
            InitializeComponent();
        }

        

    }
}

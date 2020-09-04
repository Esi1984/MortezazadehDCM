using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiWinClient.FormModels
{
    public partial class FrmItemMode : FrmEsiBase
    {
        public FrmItemMode()
        {
            InitializeComponent();
        }

        private void FrmItemMode_Load(object sender, EventArgs e)
        {
            //menuStrip1.Renderer = new ToolStripProfessionalRenderer(new EsiColor());
        }
    }
}

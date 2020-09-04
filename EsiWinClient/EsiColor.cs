using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiWinClient
{
        public class EsiColor : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.Red; }
        }

        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.Green; }
        }

    }
}




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

namespace EsiWinClient
{
    public partial class PGMortezazadeh : UserControl
    {
        public PGMortezazadeh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MagicManager.MagicMeta.EsiField ff = new MagicManager.MagicMeta.EsiField();
            ff.FieldLabel = "DFDDF";
            //var ff = new AppSettings();
            //ff.GreetingText = "اسماغیل";
            EsiPG.SelectedObject = ff;
        }
    }


    public class AppSettings
    {
        private bool saveOnClose = true;
        private string greetingText = "Welcome to your application!";
        private int itemsInMRU = 4;
        private int maxRepeatRate = 10;
        private bool settingsChanged = false;
        private string appVersion = "1.0";


//        [Browsable(bool)] – to show property or not
//[ReadOnly(bool)] – possibility to edit property
//[Category(string)] – groups of property
//[Description(string)] – property description.It is something like a hint.
//[DisplayName(string)] – display property



[DisplayName("Esameil")]
        public bool SaveOnClose
        {
            get { return saveOnClose; }
            set { saveOnClose = value; }
        }
        public string GreetingText
        {
            get { return greetingText; }
            set { greetingText = value; }
        }
        public int MaxRepeatRate
        {
            get { return maxRepeatRate; }
            set { maxRepeatRate = value; }
        }
        public int ItemsInMRUList
        {
            get { return itemsInMRU; }
            set { itemsInMRU = value; }
        }
        public bool SettingsChanged
        {
            get { return settingsChanged; }
            set { settingsChanged = value; }
        }
        public string AppVersion
        {
            get { return appVersion; }
            set { appVersion = value; }
        }
    }


}

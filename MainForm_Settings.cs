using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF_Communicator
{
    public partial class MainForm_Settings : Form
    {
        public string fullPath = Application.StartupPath.ToString();
        public Logger logApp;
        public Dp dp;

        public MainForm_Settings()
        {
            InitializeComponent();
        }

        private void MainForm_Settings_Load(object sender, EventArgs e)
        {
            dp = new Dp();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open file dialog
            ofdConfigFile.InitialDirectory = fullPath;
            ofdConfigFile.Title = "SET CONFIGURATION FILE";
            ofdConfigFile.Filter = "CONFIGURATION|*.cfg.xml";
            if (ofdConfigFile.ShowDialog() != DialogResult.OK) return;
            this.lbl_SettingsMainFile.Text = ofdConfigFile.FileName;

            //Read Item From XML
            dp.nameFile = ofdConfigFile.FileName;
            dp.ReadItemFromXML(0); lbl_COM.Text = dp.txtString;
            dp.ReadItemFromXML(1); ComSpeed = dp.txtString;
            dp.ReadItemFromXML(4); if (dp.txtString == "0") f_AutoTx = false; else f_AutoTx = true;
            dp.ReadItemFromXML(5); AutoTxTimer = dp.txtString;
            dp.ReadItemFromXML(6); if (dp.txtString == "0") rbtn_SendText.Checked = true; if (dp.txtString == "1") rbtn_SendASCII.Checked = true; if (dp.txtString == "2") rbtn_SendHEX.Checked = true;
            dp.ReadItemFromXML(7); if(dp.txtString == "0") f_AutoRx = false; else f_AutoRx = true;
            dp.ReadItemFromXML(8); AutoRxTimer = dp.txtString;

            DataSet ds = new DataSet("main.cfg");
            ds.ReadXml(ofdConfigFile.FileName);
            dgv_CfgData.DataSource = ds.Tables[0];

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save file dialog
            sfdConfigFile.InitialDirectory = fullPath;
            sfdConfigFile.Title = "SET CONFIGURATION FILE";
            sfdConfigFile.Filter = "CONFIGURATION|*.cfg.xml";
            if (sfdConfigFile.ShowDialog() != DialogResult.OK) return;
            this.lbl_SettingsMainFile.Text = sfdConfigFile.FileName;

            //Save Item to XML
            DataTable dt2 = new DataTable();
            dt2 = (DataTable)dgv_CfgData.DataSource;
            dt2.WriteXml(sfdConfigFile.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible) this.Hide();
        }


    }
}

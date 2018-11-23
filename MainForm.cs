using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace SF_Communicator
{
    public partial class MainForm : Form
    {
        #region Declare variables
        SerialPort      Port;
        SerialPort      Serial;
        byte[]          MsgBufferTx;
        byte[]          MsgBufferRx;
        bool            f_ComExists = false;
        bool            f_ComOpen = false;
        bool            f_AutoTx = false;
        bool            f_AutoRx = false;
        bool            f_CfgReadOnly = true;
        bool            f_MsgModeText = false;
        Logger          logApp;
        public Dp       dp;
        public DataSet  ds;
        string          ComN = "COM1";
        string          ComSpeed = "9600";
        string          AutoTxTimer, AutoRxTimer;
        public string   fullPath = Application.StartupPath.ToString();
        string strHelp = @"
            1. Find COM ports;
            2.Choose one of COM ports;
            3.Set communication speed;
            4.Open chosen COM-port;
            5.Read / Write data;
            6.Close opened port;
            7.Open other port.

            If you see errors then no ports are available for communication
             a. no port is chosen
             b. port is occupied by some other process
            ";
        string strAbout = @"
            COMMUNICATOR

            SF Tester (c)2018
            sf.tester@mail.ru
            ";
        #endregion
        
        public MainForm()
        {
            InitializeComponent();
            tmr_AutoRXCOM.Tick += new EventHandler(Tmr_AutoRXCOM_Tick);
            tmr_AutoTXCOM.Tick += new EventHandler(Tmr_AutoTXCOM_Tick);
            logApp = new Logger(fullPath+@"\_log\", "Communicator.log");
            dp = new Dp();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Fill_List_Com_Port();
            Fill_List_Msg();
            Fill_List_Cfg();
            Fill_List_Dir();
            Btn_MsgSave.Enabled = false;
            Btn_MsgSaveAs.Enabled = false;
            Output("Program started");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Serial.IsOpen)
                {
                    Output(List_Ports.SelectedItem.ToString() + @"@" + ComSpeed + " Closed");
                    Serial.Close();
                    Serial = null;
                }
            }
            catch (Exception ex)
            { }
            Output("Program closed");
        }

        private void Btn_FindComs_Click(object sender, EventArgs e)
        {
            List_Ports.Items.Clear();
            if (Fill_List_Com_Port())
                MessageBox.Show("Found COM-ports!",
                    "COM ports scanner",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                MessageBox.Show("No COM-ports found!",
                    "COM ports scanner",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void Btn_ReadCOMData_Click(object sender, EventArgs e)
        {
            if (!f_ComExists) return;
            if (f_AutoRx)
            {
                if (tmr_AutoRXCOM.Enabled)
                {
                    tmr_AutoRXCOM.Enabled = false;
                    btn_ReadCOMData.Text = "RX: Auto OFF";
                }
                else
                {
                    tmr_AutoRXCOM.Enabled = true;
                    tmr_AutoRXCOM.Interval = Convert.ToInt32(AutoRxTimer);
                    btn_ReadCOMData.Text = "RX: Auto ON";
                }
            }
            else
            {
                tmr_AutoRXCOM.Enabled = false;
                RX_COM_Data();
                btn_ReadCOMData.Text = "RX: On Click";
            }
        }

        private void Btn_WriteCOMData_Click(object sender, EventArgs e)
        {
            if (!f_ComExists) return;
            if (f_AutoTx)
            {
                if (tmr_AutoTXCOM.Enabled)
                {
                    tmr_AutoTXCOM.Enabled = false;
                    btn_WriteCOMData.Text = "TX: Auto OFF";
                }
                else
                {
                    tmr_AutoTXCOM.Enabled = true;
                    tmr_AutoTXCOM.Interval = Convert.ToInt32(AutoTxTimer);
                    btn_WriteCOMData.Text = "TX: Auto ON";
                }
            }
            else
            {
                tmr_AutoTXCOM.Enabled = false;
                TX_COM_Data();
                btn_WriteCOMData.Text = "TX: On Click";
            }
        }

        private void Btn_CfgEdit_Click(object sender, EventArgs e)
        {
            
            if (f_CfgReadOnly)
            {
                f_CfgReadOnly = false;
                btn_CfgMode.Text = "Mode: R/W";
                btn_CfgSave.Enabled = true;
                btn_CfgSaveAs.Enabled = true;
            }
            else
            {
                f_CfgReadOnly = true;
                btn_CfgMode.Text = "Mode: R";
                btn_CfgSave.Enabled = false;
                btn_CfgSaveAs.Enabled = false;
            }
            Fill_List_Cfg();
            dgv_CfgData.DataSource = null;
            ds = null;
        }

        private void Btn_CfgSave_Click(object sender, EventArgs e)
        {
            if (List_ConfigurationsEdit.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgv_CfgData.DataSource;
                dt.WriteXml(List_ConfigurationsEdit.SelectedItem.ToString());
                Fill_List_Cfg();
            }
        }

        private void Btn_CfgSaveAs_Click(object sender, EventArgs e)
        {
            if (List_ConfigurationsEdit.SelectedIndex != -1)
            {
                //Save file dialog
                sfdConfigFile.InitialDirectory = fullPath + @"\_cfg\";
                sfdConfigFile.Title = "SET CONFIGURATION FILE";
                sfdConfigFile.Filter = "CONFIGURATION|*.cfg";
                if (sfdConfigFile.ShowDialog() != DialogResult.OK) return;

                //Save Item to XML
                DataTable dt = new DataTable();
                dt = (DataTable)dgv_CfgData.DataSource;
                dt.WriteXml(sfdConfigFile.FileName);
                Fill_List_Cfg();
            }
        }

        private void Btn_MsgMode_Click(object sender, EventArgs e)
        {
            Rtb_FileContent.Clear();
            Fill_List_Msg();
            if (f_MsgModeText)
            {
                f_MsgModeText = false;
                Btn_MsgMode.Text = "Mode: Bytes";
                Btn_MsgSave.Enabled = true;
                Btn_MsgSaveAs.Enabled = true;
            }
            else
            {
                f_MsgModeText = true;
                Btn_MsgMode.Text = "Mode: Text";
                Btn_MsgSave.Enabled = false;
                Btn_MsgSaveAs.Enabled = false;
            }
        }

        private void Btn_MsgSave_Click(object sender, EventArgs e)
        {
            if (List_MessagesEdit.SelectedIndex == -1) return;
            MsgSave_Bytes(List_MessagesEdit.SelectedItem.ToString());
            Fill_List_Msg();
        }

        private void Btn_MsgSaveAs_Click(object sender, EventArgs e)
        {
            if (List_MessagesEdit.SelectedIndex == -1) return;
            sfdConfigFile.InitialDirectory = fullPath + @"\_msg\";
            sfdConfigFile.Title = "SET MESSAGE FILE";
            sfdConfigFile.Filter = "MESSAGE|*.msg.sf";
            if (sfdConfigFile.ShowDialog() != DialogResult.OK) return;
            MsgSave_Bytes(sfdConfigFile.FileName);
            Fill_List_Msg();
        }

        private void List_Ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List_Ports.SelectedIndex == -1) return;                     // nothing is selected
            try
            {
                if (Serial.IsOpen)
                {
                    Serial.Close();
                    Serial = null;
                }
            }
            catch (Exception ex)
            { }
            try
            { 
                Serial = new SerialPort(List_Ports.SelectedItem.ToString(), Convert.ToInt32(ComSpeed), Parity.None, 8, StopBits.One);
                Serial.Open();
                Output(List_Ports.SelectedItem.ToString() + @"@"+ ComSpeed + " Opened");
            }
            catch (Exception ex)
            {
                Output(List_Ports.SelectedItem.ToString() + @"-Open: Error!" + "\r\n" + ex.ToString());
            }
        }

        private void List_MessagesEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rtb_FileContent.Clear();
            if (List_MessagesEdit.SelectedIndex != -1)
            {
                if (!f_MsgModeText)
                {
                    Btn_MsgSave.Enabled = true;
                    Btn_MsgSaveAs.Enabled = true;
                }
            }
            else
            {
                Btn_MsgSave.Enabled = false;
                Btn_MsgSaveAs.Enabled = false;
                return;
            }
           
            //reading to msg buffer
            FileInfo info = new FileInfo(List_MessagesEdit.SelectedItem.ToString());
            MsgBufferTx = new byte[info.Length];
            FileStream fs = new FileStream(List_MessagesEdit.SelectedItem.ToString(), FileMode.Open, FileAccess.Read);
            fs.Read(MsgBufferTx, 0, Convert.ToInt32(info.Length));
            fs.Close(); fs = null;

            // reading to msg for rtb
            string MsgRtb = "";
            if (f_MsgModeText)
            {
                for (int i = 0; i < MsgBufferTx.Length; i++)
                {
                    byte Byte = MsgBufferTx[i];
                    if (Byte < 32) Byte = 46;
                    MsgRtb += Convert.ToChar(Byte);
                }
            }
            else
            {
                foreach (byte Byte in MsgBufferTx) MsgRtb += (Byte.ToString() + " ");
            }
            Rtb_FileContent.Text = MsgRtb.TrimEnd() + "\r\n";
        }

        private void List_ConfigurationsEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List_ConfigurationsEdit.SelectedIndex == -1) return;                     // nothing is selected
            dp.nameFile = List_ConfigurationsEdit.SelectedItem.ToString();
            dp.ReadItemFromXML(0); ComN = dp.txtString;
            dp.ReadItemFromXML(1); ComSpeed = dp.txtString;
            dp.ReadItemFromXML(4); if (dp.txtString == "1") f_AutoTx = true; else f_AutoTx = false;
            dp.ReadItemFromXML(5); AutoTxTimer = dp.txtString;
            //dp.ReadItemFromXML(6); if (dp.txtString == "0") rbtn_SendText.Checked = true; if (dp.txtString == "1") rbtn_SendASCII.Checked = true; if (dp.txtString == "2") rbtn_SendHEX.Checked = true;
            dp.ReadItemFromXML(7); if (dp.txtString == "0") f_AutoRx = false; else f_AutoRx = true;
            dp.ReadItemFromXML(8); AutoRxTimer = dp.txtString;

            if (f_AutoTx)
            {
                btn_WriteCOMData.Text = "TX: Auto";
            }
            else
            {
                tmr_AutoTXCOM.Enabled = false;
                btn_WriteCOMData.Text = "TX: On Click";
            }
            if (f_AutoRx)
            {
                btn_ReadCOMData.Text = "RX: Auto";
            }
            else
            {
                tmr_AutoRXCOM.Enabled = false;
                btn_ReadCOMData.Text = "RX: On Click";
            }

            dgv_CfgData.DataSource = null;
            ds = null;
            //dgv_CfgData.Rows.Clear();
            ds = new DataSet("main.cfg");
            ds.ReadXml(List_ConfigurationsEdit.SelectedItem.ToString());

            DataGridViewRow row = dgv_CfgData.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            //row.Height = 35;
            //row.MinimumHeight = 20;
            row.ReadOnly = f_CfgReadOnly;
            dgv_CfgData.DataSource = ds.Tables[0];
        }

        private void Tmr_AutoRXCOM_Tick(object sender, EventArgs e)
        {
            RX_COM_Data();
        }

        private void Tmr_AutoTXCOM_Tick(object sender, EventArgs e)
        {
            TX_COM_Data();
        }

        private void TX_COM_Data()
        {
            if (List_Ports.SelectedIndex == -1 || !f_ComExists) return;                     // nothing is selected
            if (Serial.IsOpen) try
            {
                if (Rb_SourceInput.Checked)
                {
                    if (String.IsNullOrEmpty(rtb_COMDataWrite.Text)) return;
                        if (Rb_LogViewText.Checked)
                        {
                            MsgBufferTx = Encoding.Default.GetBytes(rtb_COMDataWrite.Text);
                        }
                        if (Rb_LogViewBytes.Checked)
                        {
                            string[] bytes = rtb_COMDataWrite.Text.Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                            MsgBufferTx = new byte[bytes.Length];
                            for (int i = 0; i< bytes.Length; i++)
                            {
                                MsgBufferTx[i] += byte.Parse(bytes[i]);
                            }
                        }
                }

                if (Rb_SourceFile.Checked)
                {
                    if (List_Messages.SelectedIndex == -1) return;

                    //reading to msg buffer
                    FileInfo info = new FileInfo(List_Messages.SelectedItem.ToString());
                    MsgBufferTx = new byte[info.Length];
                    FileStream fs = new FileStream(List_Messages.SelectedItem.ToString(), FileMode.Open, FileAccess.Read);
                    fs.Read(MsgBufferTx, 0, Convert.ToInt32(info.Length));//Считываем 'info.length' байт в buffer
                    fs.Close(); fs = null;
                }

                if (Rb_SourceDir.Checked)
                {

                    if (List_Dir.Items.Count == 0)
                    {
                        Fill_List_Dir();
                        if (List_Dir.Items.Count == 0) return;
                    }

                    //reading to msg buffer
                    string nameFile = "";
                    if (List_Dir.SelectedIndex == -1) nameFile = List_Dir.Items[0].ToString();
                    else nameFile = List_Dir.SelectedItem.ToString();
                    FileInfo info = new FileInfo(nameFile);
                    MsgBufferTx = new byte[info.Length];
                    FileStream fs = new FileStream(nameFile, FileMode.Open, FileAccess.Read);
                    fs.Read(MsgBufferTx, 0, Convert.ToInt32(info.Length));//Считываем 'info.length' байт в buffer
                    fs.Close(); fs = null;
                    if (System.IO.File.Exists(nameFile)) System.IO.File.Delete(nameFile.Substring(fullPath.Length + 1));
                    Fill_List_Dir();
                }


                Serial.Write(MsgBufferTx, 0, MsgBufferTx.Length);


                // reading to msg for rtb

                if (Rb_LogViewText.Checked)
                {
                    string MsgRtb = "";
                    for (int i = 0; i < MsgBufferTx.Length; i++)
                    {
                        byte Byte = MsgBufferTx[i];
                        if (Byte < 32) Byte = 46;
                        MsgRtb += Convert.ToChar(Byte);
                    }
                    if (!String.IsNullOrEmpty(MsgRtb)) Output(List_Ports.SelectedItem.ToString() + @"-TX: " + MsgRtb);
                }
                else
                {
                    string MsgRtb = "";
                    foreach (byte Byte in MsgBufferTx) MsgRtb += (Byte.ToString() + " ");
                    if (!String.IsNullOrEmpty(MsgRtb)) Output(List_Ports.SelectedItem.ToString() + @"-TX: " + MsgRtb);
                }
            }
            catch (Exception ex)
            {
                Output(List_Ports.SelectedItem.ToString() + @"-TX: " + ex.ToString());
            }
        }

        private void RX_COM_Data()
        {
            if (List_Ports.SelectedIndex == -1 || !f_ComExists) return;                     // nothing is selected
            if (Serial.IsOpen) try
                {
                string Prefix = "";
                if (f_AutoRx) Prefix = " CADR> "; else Prefix = " CMDR> "; // COM Auto Manual Data Read

                //Thread.Sleep(500);

                //Serial = new SerialPort(List_Ports.SelectedItem.ToString(), Convert.ToInt32(ComSpeed), Parity.None, 8, StopBits.One);
                //Serial.Open();

                MsgBufferRx = null;
                    int MsgBufferSize = Serial.BytesToRead;
                MsgBufferRx = new byte[MsgBufferSize];
                Serial.Read(MsgBufferRx, 0, MsgBufferSize);
                    
                //Output(@"cp1-RX: " + Serial.BytesToRead.ToString());
                //Serial.Close(); Serial = null;

                // reading to msg for rtb
                if (Rb_LogViewText.Checked)
                {
                    string MsgRtb = "";
                    for (int i = 0; i < MsgBufferRx.Length; i++)
                    {
                        byte Byte = MsgBufferRx[i];
                        if (Byte < 32) Byte = 46;
                        MsgRtb += Convert.ToChar(Byte);
                    }
                    if (!String.IsNullOrEmpty(MsgRtb)) Output(List_Ports.SelectedItem.ToString() + @"-RX: " + MsgRtb);
                }
                else
                {
                    string MsgRtb = "";
                    foreach (byte Byte in MsgBufferRx) MsgRtb += (Byte.ToString() + " ");
                    if (!String.IsNullOrEmpty(MsgRtb)) Output(List_Ports.SelectedItem.ToString() + @"-RX: " + MsgRtb);
                }
            }
            catch (Exception ex)
            {
                Output(List_Ports.SelectedItem.ToString() + @"-RX: " + ex.ToString());
            }
        }

        private void MsgSave_Bytes(string nameFile)
        {
            try
            {
            string[] MsgTxt = Rtb_FileContent.Text.TrimEnd().Split(new char[] { ' ' });
            byte[] MsgByte = new byte[MsgTxt.Length];

            for (int i = 0; i < MsgTxt.Length; i++)
            {
                MsgByte[i] = byte.Parse(MsgTxt[i]);
            }

            if(System.IO.File.Exists(nameFile)) System.IO.File.Delete(List_MessagesEdit.SelectedItem.ToString().Substring(fullPath.Length + 1));
            FileStream fs = new FileStream(nameFile, FileMode.Create, FileAccess.Write);
            fs.Write(MsgByte, 0, Convert.ToInt32(MsgByte.Length));
            fs.Close(); fs = null;
            MsgTxt = null; MsgByte = null;
            }
            catch (Exception ex)
            {
                Rtb_FileContent.Text = "File saving error!\r\nFile is not saved.\r\nMake sure that text contains only:\r\n  - digits not bigger then 255;\r\n  - single blanks.\r\n\r\nCorrect format: 000 128 064\r\nIncorrect format: 348,z;#64 -1";
            }
        }

        public bool Fill_List_Com_Port()
        {
            f_ComExists = false;

            try
            {
                if (Serial.IsOpen)
                {
                    Serial.Close();
                    Serial = null;
                }
            }
            catch (Exception ex)
            { }

            List_Ports.Items.Clear();
            foreach (string str in System.IO.Ports.SerialPort.GetPortNames())
            {
                try
                {
                    Port = new SerialPort(str);
                    Port.Open();

                    if (Port.IsOpen)
                    {
                        List_Ports.Items.Add(str);
                        Port.Close();
                        f_ComExists = true;
                    }
                }
                catch (Exception ex)
                {
                    List_Ports.Items.Add("Error");
                }
            }
            return f_ComExists;
        }

        public void Fill_List_Msg()
        {
            List_Messages.Items.Clear();
            List_MessagesEdit.Items.Clear();
            foreach (string str in System.IO.Directory.GetFiles(fullPath + @"\_msg\", "*.msg.sf"))
            {
                try
                {
                    List_Messages.Items.Add(str);
                    List_MessagesEdit.Items.Add(str);
                }
                catch (Exception ex)
                {
                    List_Messages.Items.Add("Error");
                    List_MessagesEdit.Items.Add("Error");
                }
            }
        }

        public void Fill_List_Dir()
        {
            List_Dir.Items.Clear();
            foreach (string str in System.IO.Directory.GetFiles(fullPath + @"\_msgIn\", "*.msg.sf"))
            {
                try
                {
                    List_Dir.Items.Add(str);
                }
                catch (Exception ex)
                {
                    List_Dir.Items.Add("Error");
                }
            }
        }

        public void Fill_List_Cfg()
        {
            List_ConfigurationsEdit.Items.Clear();
            foreach (string str in System.IO.Directory.GetFiles(fullPath + @"\_cfg\", "*.cfg"))
            {
                try
                {
                    List_ConfigurationsEdit.Items.Add(str);
                }
                catch (Exception ex)
                {
                    List_ConfigurationsEdit.Items.Add("Error");
                }
            }
        }

        private void Rb_SourceInput_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_SourceInput.Checked)
            {
                rtb_COMDataWrite.Visible = true;
                List_Messages.Visible = false;
                List_Dir.Visible = false;
            }
        }

        private void Rb_SourceFile_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_SourceFile.Checked)
            {
                rtb_COMDataWrite.Visible = false;
                List_Messages.Visible = true;
                List_Dir.Visible = false;
            }
        }

        private void Rb_SourceDir_CheckedChanged(object sender, EventArgs e)
        {
            rtb_COMDataWrite.Visible = false;
            List_Messages.Visible = false;
            List_Dir.Visible = true;
            Fill_List_Dir();
        }

        private void Output(string Msg)
        {
            logApp.writeMsg(Msg);
            string LogBuffer = rtb_Log.Text + Msg + "\r\n";
            //MessageBox.Show(LogBuffer);

            string[] MsgTxt = LogBuffer.Split(new char[] { '\n' });
            if (MsgTxt.Length < 33)
            {
                rtb_Log.Text = LogBuffer;
            }
            else
            {
                rtb_Log.Clear();
                rtb_Log.Text = LogBuffer.Substring(MsgTxt[0].Length + 1, LogBuffer.Length - MsgTxt[0].Length - 1);                
            }
            //rtb_Log.Select(rtb_Log.Text.Length, 0);
            //rtb_Log.ScrollToCaret();
        }

        private void Help_Requested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show(
            strHelp,
            "Help",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void HelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            strHelp,
            "Help",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void PictureSF_Click(object sender, EventArgs e)
        {
            rtb_Log.Text = "Slava Filatov!";
        }

        private void Rtb_Log_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(fullPath);
        }

     }
}

// https://msdn.microsoft.com/ru-ru/library/system.io.ports.serialport(v=vs.110).aspx
// http://mkprog.ru/avr/com-port-windows-serialport-c.html
// http://www.csharpcoderr.com/2012/07/serial-port-com.html
// http://ivanp.ru/%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0-%D1%81-com-%D0%BF%D0%BE%D1%80%D1%82%D0%B0%D0%BC%D0%B8-%D0%B2-net-c/
// https://toster.ru/q/199341
// http://www.cyberforum.ru/windows-forms/thread110436.html - Windows forms
// https://metanit.com/sharp/windowsforms/4.6.php - Listbox
// https://metanit.com/sharp/tutorial/7.2.php - strings operations
// http://mkprog.ru/avr/com-port-windows-serialport-c.html - com port


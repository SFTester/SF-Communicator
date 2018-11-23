namespace SF_Communicator
{
    partial class MainForm_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_Settings));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_COM = new System.Windows.Forms.Label();
            this.cbb_COMSpeed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_SendHEX = new System.Windows.Forms.RadioButton();
            this.rbtn_SendASCII = new System.Windows.Forms.RadioButton();
            this.rbtn_SendText = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_AutoTXCOMTimer = new System.Windows.Forms.TextBox();
            this.cb_AutoTXCOM = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAutoreadms = new System.Windows.Forms.Label();
            this.tb_AutoRXCOMTimer = new System.Windows.Forms.TextBox();
            this.cb_AutoRXCOM = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_SettingsMainFile = new System.Windows.Forms.Label();
            this.ofdConfigFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdConfigFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_COM);
            this.groupBox2.Controls.Add(this.cbb_COMSpeed);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 135);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM Port Settings";
            // 
            // lbl_COM
            // 
            this.lbl_COM.AutoSize = true;
            this.lbl_COM.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_COM.Location = new System.Drawing.Point(6, 19);
            this.lbl_COM.Name = "lbl_COM";
            this.lbl_COM.Size = new System.Drawing.Size(41, 16);
            this.lbl_COM.TabIndex = 21;
            this.lbl_COM.Text = "COM";
            // 
            // cbb_COMSpeed
            // 
            this.cbb_COMSpeed.FormattingEnabled = true;
            this.cbb_COMSpeed.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000"});
            this.cbb_COMSpeed.Location = new System.Drawing.Point(48, 37);
            this.cbb_COMSpeed.Name = "cbb_COMSpeed";
            this.cbb_COMSpeed.Size = new System.Drawing.Size(97, 21);
            this.cbb_COMSpeed.TabIndex = 20;
            this.cbb_COMSpeed.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "stop bits:  1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "parity:       None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "speed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_SendHEX);
            this.groupBox1.Controls.Add(this.rbtn_SendASCII);
            this.groupBox1.Controls.Add(this.rbtn_SendText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_AutoTXCOMTimer);
            this.groupBox1.Controls.Add(this.cb_AutoTXCOM);
            this.groupBox1.Location = new System.Drawing.Point(171, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 138);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write Settings";
            // 
            // rbtn_SendHEX
            // 
            this.rbtn_SendHEX.AutoSize = true;
            this.rbtn_SendHEX.Enabled = false;
            this.rbtn_SendHEX.Location = new System.Drawing.Point(5, 87);
            this.rbtn_SendHEX.Name = "rbtn_SendHEX";
            this.rbtn_SendHEX.Size = new System.Drawing.Size(89, 17);
            this.rbtn_SendHEX.TabIndex = 25;
            this.rbtn_SendHEX.Text = "Send as HEX";
            this.rbtn_SendHEX.UseVisualStyleBackColor = true;
            // 
            // rbtn_SendASCII
            // 
            this.rbtn_SendASCII.AutoSize = true;
            this.rbtn_SendASCII.Enabled = false;
            this.rbtn_SendASCII.Location = new System.Drawing.Point(5, 64);
            this.rbtn_SendASCII.Name = "rbtn_SendASCII";
            this.rbtn_SendASCII.Size = new System.Drawing.Size(126, 17);
            this.rbtn_SendASCII.TabIndex = 24;
            this.rbtn_SendASCII.Text = "Send as ASCII codes";
            this.rbtn_SendASCII.UseVisualStyleBackColor = true;
            // 
            // rbtn_SendText
            // 
            this.rbtn_SendText.AutoSize = true;
            this.rbtn_SendText.Checked = true;
            this.rbtn_SendText.Location = new System.Drawing.Point(5, 41);
            this.rbtn_SendText.Name = "rbtn_SendText";
            this.rbtn_SendText.Size = new System.Drawing.Size(84, 17);
            this.rbtn_SendText.TabIndex = 23;
            this.rbtn_SendText.TabStop = true;
            this.rbtn_SendText.Text = "Send as text";
            this.rbtn_SendText.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ms";
            // 
            // tb_AutoTXCOMTimer
            // 
            this.tb_AutoTXCOMTimer.Location = new System.Drawing.Point(76, 17);
            this.tb_AutoTXCOMTimer.Name = "tb_AutoTXCOMTimer";
            this.tb_AutoTXCOMTimer.Size = new System.Drawing.Size(47, 20);
            this.tb_AutoTXCOMTimer.TabIndex = 21;
            this.AutoTxTimer = "1000";
            // 
            // cb_AutoTXCOM
            // 
            this.cb_AutoTXCOM.AutoSize = true;
            this.cb_AutoTXCOM.Location = new System.Drawing.Point(6, 18);
            this.cb_AutoTXCOM.Name = "cb_AutoTXCOM";
            this.cb_AutoTXCOM.Size = new System.Drawing.Size(61, 17);
            this.cb_AutoTXCOM.TabIndex = 20;
            this.cb_AutoTXCOM.Text = "autoTX";
            this.cb_AutoTXCOM.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAutoreadms);
            this.groupBox3.Controls.Add(this.tb_AutoRXCOMTimer);
            this.groupBox3.Controls.Add(this.cb_AutoRXCOM);
            this.groupBox3.Location = new System.Drawing.Point(329, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 135);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Read Settings";
            // 
            // lblAutoreadms
            // 
            this.lblAutoreadms.AutoSize = true;
            this.lblAutoreadms.Location = new System.Drawing.Point(128, 19);
            this.lblAutoreadms.Name = "lblAutoreadms";
            this.lblAutoreadms.Size = new System.Drawing.Size(20, 13);
            this.lblAutoreadms.TabIndex = 18;
            this.lblAutoreadms.Text = "ms";
            // 
            // tb_AutoRXCOMTimer
            // 
            this.tb_AutoRXCOMTimer.Location = new System.Drawing.Point(75, 15);
            this.tb_AutoRXCOMTimer.Name = "tb_AutoRXCOMTimer";
            this.tb_AutoRXCOMTimer.Size = new System.Drawing.Size(47, 20);
            this.tb_AutoRXCOMTimer.TabIndex = 17;
            this.AutoRxTimer = "1000";
            // 
            // cb_AutoRXCOM
            // 
            this.cb_AutoRXCOM.AutoSize = true;
            this.cb_AutoRXCOM.Location = new System.Drawing.Point(6, 19);
            this.cb_AutoRXCOM.Name = "cb_AutoRXCOM";
            this.cb_AutoRXCOM.Size = new System.Drawing.Size(62, 17);
            this.cb_AutoRXCOM.TabIndex = 16;
            this.cb_AutoRXCOM.Text = "autoRX";
            this.cb_AutoRXCOM.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.openToolStripMenuItem.Text = "Configuration";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lbl_SettingsMainFile
            // 
            this.lbl_SettingsMainFile.AutoEllipsis = true;
            this.lbl_SettingsMainFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SettingsMainFile.Location = new System.Drawing.Point(12, 245);
            this.lbl_SettingsMainFile.Name = "lbl_SettingsMainFile";
            this.lbl_SettingsMainFile.Size = new System.Drawing.Size(477, 50);
            this.lbl_SettingsMainFile.TabIndex = 29;
            this.lbl_SettingsMainFile.Text = "main.cfg.xml";
            this.lbl_SettingsMainFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdConfigFile
            // 
            this.ofdConfigFile.FileName = "settings.main.cfg";
            // 
            // MainForm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 307);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_SettingsMainFile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm_Settings";
            this.Text = "Program Settings";
            this.Load += new System.EventHandler(this.MainForm_Settings_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_COMSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_SendHEX;
        private System.Windows.Forms.RadioButton rbtn_SendASCII;
        private System.Windows.Forms.RadioButton rbtn_SendText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_AutoTXCOMTimer;
        private System.Windows.Forms.CheckBox cb_AutoTXCOM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAutoreadms;
        private System.Windows.Forms.TextBox tb_AutoRXCOMTimer;
        private System.Windows.Forms.CheckBox cb_AutoRXCOM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_SettingsMainFile;
        private System.Windows.Forms.OpenFileDialog ofdConfigFile;
        private System.Windows.Forms.Label lbl_COM;
        private System.Windows.Forms.SaveFileDialog sfdConfigFile;
    }
}
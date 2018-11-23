namespace SF_Communicator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_Contacts = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmr_AutoRXCOM = new System.Windows.Forms.Timer(this.components);
            this.tmr_AutoTXCOM = new System.Windows.Forms.Timer(this.components);
            this.ofd_FileMsg = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.btn_FindComNs = new System.Windows.Forms.Button();
            this.List_Ports = new System.Windows.Forms.ListBox();
            this.btn_CfgSave = new System.Windows.Forms.Button();
            this.btn_CfgSaveAs = new System.Windows.Forms.Button();
            this.btn_CfgMode = new System.Windows.Forms.Button();
            this.Picture_SF = new System.Windows.Forms.PictureBox();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.List_Messages = new System.Windows.Forms.ListBox();
            this.Rb_SourceFile = new System.Windows.Forms.RadioButton();
            this.Rb_SourceInput = new System.Windows.Forms.RadioButton();
            this.rtb_COMDataWrite = new System.Windows.Forms.RichTextBox();
            this.btn_WriteCOMData = new System.Windows.Forms.Button();
            this.btn_ReadCOMData = new System.Windows.Forms.Button();
            this.dgv_CfgData = new System.Windows.Forms.DataGridView();
            this.List_ConfigurationsEdit = new System.Windows.Forms.ListBox();
            this.List_MessagesEdit = new System.Windows.Forms.ListBox();
            this.Rtb_FileContent = new System.Windows.Forms.RichTextBox();
            this.Btn_MsgMode = new System.Windows.Forms.Button();
            this.Btn_MsgSaveAs = new System.Windows.Forms.Button();
            this.Btn_MsgSave = new System.Windows.Forms.Button();
            this.Rb_SourceDir = new System.Windows.Forms.RadioButton();
            this.List_Dir = new System.Windows.Forms.ListBox();
            this.tc_Control = new System.Windows.Forms.TabControl();
            this.tab_Control = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Panel_LogView = new System.Windows.Forms.Panel();
            this.Rb_LogViewBytes = new System.Windows.Forms.RadioButton();
            this.Rb_LogViewText = new System.Windows.Forms.RadioButton();
            this.tab_Settings = new System.Windows.Forms.TabPage();
            this.tab_Messages = new System.Windows.Forms.TabPage();
            this.sfdConfigFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_SF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CfgData)).BeginInit();
            this.tc_Control.SuspendLayout();
            this.tab_Control.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Panel_LogView.SuspendLayout();
            this.tab_Settings.SuspendLayout();
            this.tab_Messages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Contacts
            // 
            this.lbl_Contacts.BackColor = System.Drawing.Color.Black;
            this.lbl_Contacts.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Contacts.Location = new System.Drawing.Point(57, 504);
            this.lbl_Contacts.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbl_Contacts.Name = "lbl_Contacts";
            this.lbl_Contacts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_Contacts.Size = new System.Drawing.Size(711, 50);
            this.lbl_Contacts.TabIndex = 11;
            this.lbl_Contacts.Text = "(c) SF, 2018\r\nsf.tester@mail.ru\r\nwww.sfserver.ru";
            this.lbl_Contacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipHelp.SetToolTip(this.lbl_Contacts, "Author, contacts");
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(230, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "COM-port Communicator";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofd_FileLog";
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp.ToolTipTitle = "Help & Hints";
            // 
            // btn_FindComNs
            // 
            this.btn_FindComNs.Location = new System.Drawing.Point(6, 6);
            this.btn_FindComNs.Name = "btn_FindComNs";
            this.btn_FindComNs.Size = new System.Drawing.Size(100, 20);
            this.btn_FindComNs.TabIndex = 29;
            this.btn_FindComNs.Text = "Find COM Ports";
            this.toolTipHelp.SetToolTip(this.btn_FindComNs, "find COM ports first. If no ports found then possibly you do not have COM devices" +
        " at all");
            this.btn_FindComNs.UseVisualStyleBackColor = true;
            this.btn_FindComNs.Click += new System.EventHandler(this.Btn_FindComs_Click);
            // 
            // List_Ports
            // 
            this.List_Ports.BackColor = System.Drawing.Color.DarkSlateGray;
            this.List_Ports.ForeColor = System.Drawing.Color.White;
            this.List_Ports.FormattingEnabled = true;
            this.List_Ports.Location = new System.Drawing.Point(6, 26);
            this.List_Ports.Name = "List_Ports";
            this.List_Ports.Size = new System.Drawing.Size(100, 433);
            this.List_Ports.TabIndex = 30;
            this.toolTipHelp.SetToolTip(this.List_Ports, "First choose ports here before opening");
            this.List_Ports.SelectedIndexChanged += new System.EventHandler(this.List_Ports_SelectedIndexChanged);
            // 
            // btn_CfgSave
            // 
            this.btn_CfgSave.Enabled = false;
            this.btn_CfgSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CfgSave.Location = new System.Drawing.Point(667, 37);
            this.btn_CfgSave.Name = "btn_CfgSave";
            this.btn_CfgSave.Size = new System.Drawing.Size(80, 20);
            this.btn_CfgSave.TabIndex = 46;
            this.btn_CfgSave.Text = "Save";
            this.toolTipHelp.SetToolTip(this.btn_CfgSave, "Save settings with the same file name");
            this.btn_CfgSave.UseVisualStyleBackColor = true;
            this.btn_CfgSave.Click += new System.EventHandler(this.Btn_CfgSave_Click);
            // 
            // btn_CfgSaveAs
            // 
            this.btn_CfgSaveAs.Enabled = false;
            this.btn_CfgSaveAs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CfgSaveAs.Location = new System.Drawing.Point(667, 63);
            this.btn_CfgSaveAs.Name = "btn_CfgSaveAs";
            this.btn_CfgSaveAs.Size = new System.Drawing.Size(80, 20);
            this.btn_CfgSaveAs.TabIndex = 47;
            this.btn_CfgSaveAs.Text = "Save As";
            this.toolTipHelp.SetToolTip(this.btn_CfgSaveAs, "Save settings with different file name");
            this.btn_CfgSaveAs.UseVisualStyleBackColor = true;
            this.btn_CfgSaveAs.Click += new System.EventHandler(this.Btn_CfgSaveAs_Click);
            // 
            // btn_CfgMode
            // 
            this.btn_CfgMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_CfgMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CfgMode.Location = new System.Drawing.Point(667, 11);
            this.btn_CfgMode.Name = "btn_CfgMode";
            this.btn_CfgMode.Size = new System.Drawing.Size(80, 20);
            this.btn_CfgMode.TabIndex = 49;
            this.btn_CfgMode.Text = "Mode: R";
            this.toolTipHelp.SetToolTip(this.btn_CfgMode, "Change  mode:\r\nR - settings are read only;\r\nR/W - read and write settings.");
            this.btn_CfgMode.UseVisualStyleBackColor = true;
            this.btn_CfgMode.Click += new System.EventHandler(this.Btn_CfgEdit_Click);
            // 
            // Picture_SF
            // 
            this.Picture_SF.Image = global::SF_Communicator.Properties.Resources.SF_small;
            this.Picture_SF.Location = new System.Drawing.Point(8, 507);
            this.Picture_SF.Name = "Picture_SF";
            this.Picture_SF.Size = new System.Drawing.Size(50, 47);
            this.Picture_SF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_SF.TabIndex = 2;
            this.Picture_SF.TabStop = false;
            this.toolTipHelp.SetToolTip(this.Picture_SF, "Author, photo");
            this.Picture_SF.Click += new System.EventHandler(this.PictureSF_Click);
            // 
            // rtb_Log
            // 
            this.rtb_Log.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rtb_Log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtb_Log.ForeColor = System.Drawing.Color.White;
            this.rtb_Log.Location = new System.Drawing.Point(330, 26);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.Size = new System.Drawing.Size(416, 433);
            this.rtb_Log.TabIndex = 40;
            this.rtb_Log.Text = "";
            this.toolTipHelp.SetToolTip(this.rtb_Log, "Log file, last messages");
            this.rtb_Log.WordWrap = false;
            this.rtb_Log.DoubleClick += new System.EventHandler(this.Rtb_Log_DoubleClick);
            // 
            // List_Messages
            // 
            this.List_Messages.BackColor = System.Drawing.Color.DarkSlateGray;
            this.List_Messages.ForeColor = System.Drawing.Color.White;
            this.List_Messages.FormattingEnabled = true;
            this.List_Messages.Location = new System.Drawing.Point(6, 43);
            this.List_Messages.Name = "List_Messages";
            this.List_Messages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.List_Messages.Size = new System.Drawing.Size(200, 368);
            this.List_Messages.TabIndex = 30;
            this.toolTipHelp.SetToolTip(this.List_Messages, "Source is the msg-file");
            this.List_Messages.Visible = false;
            // 
            // Rb_SourceFile
            // 
            this.Rb_SourceFile.AutoSize = true;
            this.Rb_SourceFile.Location = new System.Drawing.Point(34, 19);
            this.Rb_SourceFile.Name = "Rb_SourceFile";
            this.Rb_SourceFile.Size = new System.Drawing.Size(34, 17);
            this.Rb_SourceFile.TabIndex = 29;
            this.Rb_SourceFile.Text = "M";
            this.toolTipHelp.SetToolTip(this.Rb_SourceFile, "Choose input from msg-file (to be selected down below)");
            this.Rb_SourceFile.UseVisualStyleBackColor = true;
            this.Rb_SourceFile.CheckedChanged += new System.EventHandler(this.Rb_SourceFile_CheckedChanged);
            // 
            // Rb_SourceInput
            // 
            this.Rb_SourceInput.AutoSize = true;
            this.Rb_SourceInput.Checked = true;
            this.Rb_SourceInput.Location = new System.Drawing.Point(6, 19);
            this.Rb_SourceInput.Name = "Rb_SourceInput";
            this.Rb_SourceInput.Size = new System.Drawing.Size(28, 17);
            this.Rb_SourceInput.TabIndex = 28;
            this.Rb_SourceInput.TabStop = true;
            this.Rb_SourceInput.Text = "I";
            this.toolTipHelp.SetToolTip(this.Rb_SourceInput, "Choose manual input");
            this.Rb_SourceInput.UseVisualStyleBackColor = true;
            this.Rb_SourceInput.CheckedChanged += new System.EventHandler(this.Rb_SourceInput_CheckedChanged);
            // 
            // rtb_COMDataWrite
            // 
            this.rtb_COMDataWrite.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rtb_COMDataWrite.ForeColor = System.Drawing.Color.White;
            this.rtb_COMDataWrite.Location = new System.Drawing.Point(6, 43);
            this.rtb_COMDataWrite.Name = "rtb_COMDataWrite";
            this.rtb_COMDataWrite.Size = new System.Drawing.Size(200, 378);
            this.rtb_COMDataWrite.TabIndex = 10;
            this.rtb_COMDataWrite.Text = "";
            this.toolTipHelp.SetToolTip(this.rtb_COMDataWrite, "Source of manual input data");
            // 
            // btn_WriteCOMData
            // 
            this.btn_WriteCOMData.Location = new System.Drawing.Point(112, 6);
            this.btn_WriteCOMData.Name = "btn_WriteCOMData";
            this.btn_WriteCOMData.Size = new System.Drawing.Size(100, 20);
            this.btn_WriteCOMData.TabIndex = 34;
            this.btn_WriteCOMData.Text = "TX: On Click";
            this.toolTipHelp.SetToolTip(this.btn_WriteCOMData, "Start writing data to opened COM port");
            this.btn_WriteCOMData.UseVisualStyleBackColor = true;
            this.btn_WriteCOMData.Click += new System.EventHandler(this.Btn_WriteCOMData_Click);
            // 
            // btn_ReadCOMData
            // 
            this.btn_ReadCOMData.Location = new System.Drawing.Point(330, 6);
            this.btn_ReadCOMData.Name = "btn_ReadCOMData";
            this.btn_ReadCOMData.Size = new System.Drawing.Size(100, 20);
            this.btn_ReadCOMData.TabIndex = 32;
            this.btn_ReadCOMData.Text = "RX: On Click";
            this.toolTipHelp.SetToolTip(this.btn_ReadCOMData, "Start reading data from opened COM port");
            this.btn_ReadCOMData.UseVisualStyleBackColor = true;
            this.btn_ReadCOMData.Click += new System.EventHandler(this.Btn_ReadCOMData_Click);
            // 
            // dgv_CfgData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CfgData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CfgData.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_CfgData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_CfgData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_CfgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CfgData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CfgData.GridColor = System.Drawing.Color.White;
            this.dgv_CfgData.Location = new System.Drawing.Point(230, 11);
            this.dgv_CfgData.Name = "dgv_CfgData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CfgData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CfgData.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgv_CfgData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_CfgData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_CfgData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_CfgData.RowTemplate.Height = 16;
            this.dgv_CfgData.RowTemplate.ReadOnly = true;
            this.dgv_CfgData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CfgData.Size = new System.Drawing.Size(431, 446);
            this.dgv_CfgData.TabIndex = 48;
            this.toolTipHelp.SetToolTip(this.dgv_CfgData, "Review or change settings.\r\nMake sure you press \'Enter\' to confirm cell modified." +
        "");
            // 
            // List_ConfigurationsEdit
            // 
            this.List_ConfigurationsEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.List_ConfigurationsEdit.ForeColor = System.Drawing.Color.White;
            this.List_ConfigurationsEdit.FormattingEnabled = true;
            this.List_ConfigurationsEdit.Location = new System.Drawing.Point(6, 11);
            this.List_ConfigurationsEdit.Name = "List_ConfigurationsEdit";
            this.List_ConfigurationsEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.List_ConfigurationsEdit.Size = new System.Drawing.Size(218, 446);
            this.List_ConfigurationsEdit.TabIndex = 45;
            this.toolTipHelp.SetToolTip(this.List_ConfigurationsEdit, "Choose settings profile.\r\nSettings will be applied immediately.");
            this.List_ConfigurationsEdit.SelectedIndexChanged += new System.EventHandler(this.List_ConfigurationsEdit_SelectedIndexChanged);
            // 
            // List_MessagesEdit
            // 
            this.List_MessagesEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.List_MessagesEdit.ForeColor = System.Drawing.Color.White;
            this.List_MessagesEdit.FormattingEnabled = true;
            this.List_MessagesEdit.Location = new System.Drawing.Point(6, 11);
            this.List_MessagesEdit.Name = "List_MessagesEdit";
            this.List_MessagesEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.List_MessagesEdit.Size = new System.Drawing.Size(218, 446);
            this.List_MessagesEdit.TabIndex = 31;
            this.toolTipHelp.SetToolTip(this.List_MessagesEdit, "Source is the msg-file");
            this.List_MessagesEdit.SelectedIndexChanged += new System.EventHandler(this.List_MessagesEdit_SelectedIndexChanged);
            // 
            // Rtb_FileContent
            // 
            this.Rtb_FileContent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Rtb_FileContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rtb_FileContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rtb_FileContent.ForeColor = System.Drawing.Color.White;
            this.Rtb_FileContent.Location = new System.Drawing.Point(230, 11);
            this.Rtb_FileContent.Name = "Rtb_FileContent";
            this.Rtb_FileContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rtb_FileContent.Size = new System.Drawing.Size(431, 446);
            this.Rtb_FileContent.TabIndex = 41;
            this.Rtb_FileContent.Text = "";
            this.toolTipHelp.SetToolTip(this.Rtb_FileContent, "Log file, last messages");
            // 
            // Btn_MsgMode
            // 
            this.Btn_MsgMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_MsgMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_MsgMode.Location = new System.Drawing.Point(667, 11);
            this.Btn_MsgMode.Name = "Btn_MsgMode";
            this.Btn_MsgMode.Size = new System.Drawing.Size(80, 20);
            this.Btn_MsgMode.TabIndex = 50;
            this.Btn_MsgMode.Text = "Mode: Bytes";
            this.toolTipHelp.SetToolTip(this.Btn_MsgMode, "Change  mode:\r\nR - settings are read only;\r\nR/W - read and write settings.");
            this.Btn_MsgMode.UseVisualStyleBackColor = true;
            this.Btn_MsgMode.Click += new System.EventHandler(this.Btn_MsgMode_Click);
            // 
            // Btn_MsgSaveAs
            // 
            this.Btn_MsgSaveAs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_MsgSaveAs.Location = new System.Drawing.Point(667, 63);
            this.Btn_MsgSaveAs.Name = "Btn_MsgSaveAs";
            this.Btn_MsgSaveAs.Size = new System.Drawing.Size(80, 20);
            this.Btn_MsgSaveAs.TabIndex = 52;
            this.Btn_MsgSaveAs.Text = "Save As";
            this.toolTipHelp.SetToolTip(this.Btn_MsgSaveAs, "Save settings with different file name");
            this.Btn_MsgSaveAs.UseVisualStyleBackColor = true;
            this.Btn_MsgSaveAs.Click += new System.EventHandler(this.Btn_MsgSaveAs_Click);
            // 
            // Btn_MsgSave
            // 
            this.Btn_MsgSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_MsgSave.Location = new System.Drawing.Point(667, 37);
            this.Btn_MsgSave.Name = "Btn_MsgSave";
            this.Btn_MsgSave.Size = new System.Drawing.Size(80, 20);
            this.Btn_MsgSave.TabIndex = 51;
            this.Btn_MsgSave.Text = "Save";
            this.toolTipHelp.SetToolTip(this.Btn_MsgSave, "Save settings with the same file name");
            this.Btn_MsgSave.UseVisualStyleBackColor = true;
            this.Btn_MsgSave.Click += new System.EventHandler(this.Btn_MsgSave_Click);
            // 
            // Rb_SourceDir
            // 
            this.Rb_SourceDir.AutoSize = true;
            this.Rb_SourceDir.Location = new System.Drawing.Point(65, 19);
            this.Rb_SourceDir.Name = "Rb_SourceDir";
            this.Rb_SourceDir.Size = new System.Drawing.Size(33, 17);
            this.Rb_SourceDir.TabIndex = 31;
            this.Rb_SourceDir.Text = "D";
            this.toolTipHelp.SetToolTip(this.Rb_SourceDir, "Choose input from msg-file (to be selected down below)");
            this.Rb_SourceDir.UseVisualStyleBackColor = true;
            this.Rb_SourceDir.CheckedChanged += new System.EventHandler(this.Rb_SourceDir_CheckedChanged);
            // 
            // List_Dir
            // 
            this.List_Dir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.List_Dir.ForeColor = System.Drawing.Color.White;
            this.List_Dir.FormattingEnabled = true;
            this.List_Dir.Location = new System.Drawing.Point(6, 43);
            this.List_Dir.Name = "List_Dir";
            this.List_Dir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.List_Dir.Size = new System.Drawing.Size(200, 368);
            this.List_Dir.TabIndex = 32;
            this.toolTipHelp.SetToolTip(this.List_Dir, "Source is the msg-file");
            this.List_Dir.Visible = false;
            // 
            // tc_Control
            // 
            this.tc_Control.Controls.Add(this.tab_Control);
            this.tc_Control.Controls.Add(this.tab_Settings);
            this.tc_Control.Controls.Add(this.tab_Messages);
            this.tc_Control.Location = new System.Drawing.Point(8, 9);
            this.tc_Control.Name = "tc_Control";
            this.tc_Control.SelectedIndex = 0;
            this.tc_Control.Size = new System.Drawing.Size(760, 492);
            this.tc_Control.TabIndex = 30;
            // 
            // tab_Control
            // 
            this.tab_Control.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tab_Control.Controls.Add(this.groupBox4);
            this.tab_Control.Controls.Add(this.rtb_Log);
            this.tab_Control.Controls.Add(this.Panel_LogView);
            this.tab_Control.Controls.Add(this.btn_WriteCOMData);
            this.tab_Control.Controls.Add(this.btn_ReadCOMData);
            this.tab_Control.Controls.Add(this.List_Ports);
            this.tab_Control.Controls.Add(this.btn_FindComNs);
            this.tab_Control.Location = new System.Drawing.Point(4, 22);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Control.Size = new System.Drawing.Size(752, 466);
            this.tab_Control.TabIndex = 0;
            this.tab_Control.Text = "Control";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.Controls.Add(this.Rb_SourceDir);
            this.groupBox4.Controls.Add(this.rtb_COMDataWrite);
            this.groupBox4.Controls.Add(this.List_Messages);
            this.groupBox4.Controls.Add(this.Rb_SourceFile);
            this.groupBox4.Controls.Add(this.Rb_SourceInput);
            this.groupBox4.Controls.Add(this.List_Dir);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(112, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 433);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Source";
            // 
            // Panel_LogView
            // 
            this.Panel_LogView.Controls.Add(this.Rb_LogViewBytes);
            this.Panel_LogView.Controls.Add(this.Rb_LogViewText);
            this.Panel_LogView.Location = new System.Drawing.Point(630, 0);
            this.Panel_LogView.Name = "Panel_LogView";
            this.Panel_LogView.Size = new System.Drawing.Size(116, 32);
            this.Panel_LogView.TabIndex = 41;
            // 
            // Rb_LogViewBytes
            // 
            this.Rb_LogViewBytes.AutoSize = true;
            this.Rb_LogViewBytes.ForeColor = System.Drawing.Color.White;
            this.Rb_LogViewBytes.Location = new System.Drawing.Point(56, 6);
            this.Rb_LogViewBytes.Name = "Rb_LogViewBytes";
            this.Rb_LogViewBytes.Size = new System.Drawing.Size(51, 17);
            this.Rb_LogViewBytes.TabIndex = 1;
            this.Rb_LogViewBytes.Text = "Bytes";
            this.Rb_LogViewBytes.UseVisualStyleBackColor = true;
            // 
            // Rb_LogViewText
            // 
            this.Rb_LogViewText.AutoSize = true;
            this.Rb_LogViewText.Checked = true;
            this.Rb_LogViewText.ForeColor = System.Drawing.Color.White;
            this.Rb_LogViewText.Location = new System.Drawing.Point(4, 6);
            this.Rb_LogViewText.Name = "Rb_LogViewText";
            this.Rb_LogViewText.Size = new System.Drawing.Size(46, 17);
            this.Rb_LogViewText.TabIndex = 0;
            this.Rb_LogViewText.TabStop = true;
            this.Rb_LogViewText.Text = "Text";
            this.Rb_LogViewText.UseVisualStyleBackColor = true;
            // 
            // tab_Settings
            // 
            this.tab_Settings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tab_Settings.Controls.Add(this.btn_CfgMode);
            this.tab_Settings.Controls.Add(this.dgv_CfgData);
            this.tab_Settings.Controls.Add(this.btn_CfgSaveAs);
            this.tab_Settings.Controls.Add(this.btn_CfgSave);
            this.tab_Settings.Controls.Add(this.List_ConfigurationsEdit);
            this.tab_Settings.ForeColor = System.Drawing.Color.White;
            this.tab_Settings.Location = new System.Drawing.Point(4, 22);
            this.tab_Settings.Name = "tab_Settings";
            this.tab_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Settings.Size = new System.Drawing.Size(752, 466);
            this.tab_Settings.TabIndex = 1;
            this.tab_Settings.Text = "Settings";
            // 
            // tab_Messages
            // 
            this.tab_Messages.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tab_Messages.Controls.Add(this.Btn_MsgSaveAs);
            this.tab_Messages.Controls.Add(this.Btn_MsgSave);
            this.tab_Messages.Controls.Add(this.Btn_MsgMode);
            this.tab_Messages.Controls.Add(this.Rtb_FileContent);
            this.tab_Messages.Controls.Add(this.List_MessagesEdit);
            this.tab_Messages.ForeColor = System.Drawing.Color.White;
            this.tab_Messages.Location = new System.Drawing.Point(4, 22);
            this.tab_Messages.Name = "tab_Messages";
            this.tab_Messages.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Messages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tab_Messages.Size = new System.Drawing.Size(752, 466);
            this.tab_Messages.TabIndex = 2;
            this.tab_Messages.Text = "Messages";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tc_Control);
            this.Controls.Add(this.Picture_SF);
            this.Controls.Add(this.lbl_Contacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "SF Communicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Help_Requested);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_SF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CfgData)).EndInit();
            this.tc_Control.ResumeLayout(false);
            this.tab_Control.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Panel_LogView.ResumeLayout(false);
            this.Panel_LogView.PerformLayout();
            this.tab_Settings.ResumeLayout(false);
            this.tab_Messages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Picture_SF;
        private System.Windows.Forms.Label lbl_Contacts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmr_AutoRXCOM;
        private System.Windows.Forms.Timer tmr_AutoTXCOM;
        private System.Windows.Forms.OpenFileDialog ofd_FileMsg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.TabControl tc_Control;
        private System.Windows.Forms.TabPage tab_Control;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox List_Messages;
        private System.Windows.Forms.RadioButton Rb_SourceFile;
        private System.Windows.Forms.RadioButton Rb_SourceInput;
        private System.Windows.Forms.RichTextBox rtb_COMDataWrite;
        private System.Windows.Forms.Button btn_WriteCOMData;
        private System.Windows.Forms.Button btn_ReadCOMData;
        private System.Windows.Forms.ListBox List_Ports;
        private System.Windows.Forms.Button btn_FindComNs;
        private System.Windows.Forms.TabPage tab_Settings;
        private System.Windows.Forms.ListBox List_ConfigurationsEdit;
        private System.Windows.Forms.Button btn_CfgSave;
        private System.Windows.Forms.Button btn_CfgSaveAs;
        private System.Windows.Forms.DataGridView dgv_CfgData;
        private System.Windows.Forms.Button btn_CfgMode;
        private System.Windows.Forms.SaveFileDialog sfdConfigFile;
        private System.Windows.Forms.TabPage tab_Messages;
        private System.Windows.Forms.ListBox List_MessagesEdit;
        private System.Windows.Forms.RichTextBox Rtb_FileContent;
        private System.Windows.Forms.Button Btn_MsgMode;
        private System.Windows.Forms.Button Btn_MsgSaveAs;
        private System.Windows.Forms.Button Btn_MsgSave;
        private System.Windows.Forms.Panel Panel_LogView;
        private System.Windows.Forms.RadioButton Rb_LogViewText;
        private System.Windows.Forms.RadioButton Rb_LogViewBytes;
        private System.Windows.Forms.ListBox List_Dir;
        private System.Windows.Forms.RadioButton Rb_SourceDir;
    }
}


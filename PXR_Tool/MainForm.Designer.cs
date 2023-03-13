
namespace PXR_Tool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainTL = new System.Windows.Forms.TableLayoutPanel();
            this.comsLog = new StasaLibrary.ComsLog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.rtdTab = new System.Windows.Forms.TabPage();
            this.rtD_Frame = new PXR_Tool.RTD_Frame();
            this.spTab = new System.Windows.Forms.TabPage();
            this.setpointFrame = new PXR_Tool.SetpointFrame();
            this.configurationTab = new System.Windows.Forms.TabPage();
            this.masterConfigurationFrame = new PXR_Tool.Configuration.MasterConfigurationFrame();
            this.remoteControlTab = new System.Windows.Forms.TabPage();
            this.remoteControlMaster = new PXR_Tool.RemoteControl.RemoteControlMaster();
            this.siTab = new System.Windows.Forms.TabPage();
            this.secondaryInjectionFrame1 = new PXR_Tool.SecondaryInjectionFrame();
            this.eventsTab = new System.Windows.Forms.TabPage();
            this.eventsFrame1 = new PXR_Tool.EventsFrame();
            this.messageParseTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.byteParseRTB = new System.Windows.Forms.RichTextBox();
            this.byteParseDGV = new System.Windows.Forms.DataGridView();
            this.indexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectedDeviceInfoTL = new System.Windows.Forms.TableLayoutPanel();
            this.typeLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.frameLabel = new System.Windows.Forms.Label();
            this.connPanel = new System.Windows.Forms.Panel();
            this.autoConnectCheckbox = new System.Windows.Forms.CheckBox();
            this.connMenu = new StasaLibrary.EtuConnFrames.ConnectionPortSelectFrame();
            this.passwordGroupbox = new System.Windows.Forms.GroupBox();
            this.autoPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.setPasswordButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.inputPasswordButton = new System.Windows.Forms.Button();
            this.toggleManMoButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calFactorsTab = new System.Windows.Forms.TabPage();
            this.masterCalFactorFrame = new PXR_Tool.Calibration.MasterCalFactorFrame();
            this.mainTL.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.rtdTab.SuspendLayout();
            this.spTab.SuspendLayout();
            this.configurationTab.SuspendLayout();
            this.remoteControlTab.SuspendLayout();
            this.siTab.SuspendLayout();
            this.eventsTab.SuspendLayout();
            this.messageParseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byteParseDGV)).BeginInit();
            this.connectedDeviceInfoTL.SuspendLayout();
            this.connPanel.SuspendLayout();
            this.passwordGroupbox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.calFactorsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTL
            // 
            this.mainTL.ColumnCount = 2;
            this.mainTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.mainTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTL.Controls.Add(this.comsLog, 0, 4);
            this.mainTL.Controls.Add(this.mainTabControl, 1, 0);
            this.mainTL.Controls.Add(this.connectedDeviceInfoTL, 0, 1);
            this.mainTL.Controls.Add(this.connPanel, 0, 0);
            this.mainTL.Controls.Add(this.passwordGroupbox, 0, 3);
            this.mainTL.Controls.Add(this.toggleManMoButton, 0, 2);
            this.mainTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTL.Location = new System.Drawing.Point(0, 24);
            this.mainTL.Name = "mainTL";
            this.mainTL.RowCount = 5;
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTL.Size = new System.Drawing.Size(1584, 787);
            this.mainTL.TabIndex = 1;
            // 
            // comsLog
            // 
            this.comsLog.DetailSize = 20F;
            this.comsLog.Location = new System.Drawing.Point(3, 203);
            this.comsLog.MaxLength = 100000;
            this.comsLog.Name = "comsLog";
            this.comsLog.PeviousRecString = null;
            this.comsLog.PreviousSentString = null;
            this.comsLog.Size = new System.Drawing.Size(246, 571);
            this.comsLog.TabIndex = 1;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.rtdTab);
            this.mainTabControl.Controls.Add(this.spTab);
            this.mainTabControl.Controls.Add(this.configurationTab);
            this.mainTabControl.Controls.Add(this.remoteControlTab);
            this.mainTabControl.Controls.Add(this.siTab);
            this.mainTabControl.Controls.Add(this.eventsTab);
            this.mainTabControl.Controls.Add(this.calFactorsTab);
            this.mainTabControl.Controls.Add(this.messageParseTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.ItemSize = new System.Drawing.Size(115, 18);
            this.mainTabControl.Location = new System.Drawing.Point(255, 3);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTL.SetRowSpan(this.mainTabControl, 5);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1326, 781);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 3;
            // 
            // rtdTab
            // 
            this.rtdTab.BackColor = System.Drawing.Color.Silver;
            this.rtdTab.Controls.Add(this.rtD_Frame);
            this.rtdTab.Location = new System.Drawing.Point(4, 22);
            this.rtdTab.Name = "rtdTab";
            this.rtdTab.Padding = new System.Windows.Forms.Padding(3);
            this.rtdTab.Size = new System.Drawing.Size(1318, 755);
            this.rtdTab.TabIndex = 0;
            this.rtdTab.Text = "Real Time Data";
            // 
            // rtD_Frame
            // 
            this.rtD_Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtD_Frame.Location = new System.Drawing.Point(3, 3);
            this.rtD_Frame.Name = "rtD_Frame";
            this.rtD_Frame.Size = new System.Drawing.Size(1312, 749);
            this.rtD_Frame.TabIndex = 0;
            // 
            // spTab
            // 
            this.spTab.BackColor = System.Drawing.Color.Silver;
            this.spTab.Controls.Add(this.setpointFrame);
            this.spTab.Location = new System.Drawing.Point(4, 22);
            this.spTab.Name = "spTab";
            this.spTab.Padding = new System.Windows.Forms.Padding(3);
            this.spTab.Size = new System.Drawing.Size(1318, 755);
            this.spTab.TabIndex = 1;
            this.spTab.Text = "Setpoints";
            // 
            // setpointFrame
            // 
            this.setpointFrame.BackColor = System.Drawing.Color.Silver;
            this.setpointFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setpointFrame.Location = new System.Drawing.Point(3, 3);
            this.setpointFrame.Name = "setpointFrame";
            this.setpointFrame.Size = new System.Drawing.Size(1312, 749);
            this.setpointFrame.TabIndex = 0;
            // 
            // configurationTab
            // 
            this.configurationTab.BackColor = System.Drawing.Color.Silver;
            this.configurationTab.Controls.Add(this.masterConfigurationFrame);
            this.configurationTab.Location = new System.Drawing.Point(4, 22);
            this.configurationTab.Name = "configurationTab";
            this.configurationTab.Size = new System.Drawing.Size(1318, 755);
            this.configurationTab.TabIndex = 6;
            this.configurationTab.Text = "Configuration";
            // 
            // masterConfigurationFrame
            // 
            this.masterConfigurationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterConfigurationFrame.Location = new System.Drawing.Point(0, 0);
            this.masterConfigurationFrame.Name = "masterConfigurationFrame";
            this.masterConfigurationFrame.Size = new System.Drawing.Size(1318, 755);
            this.masterConfigurationFrame.TabIndex = 0;
            // 
            // remoteControlTab
            // 
            this.remoteControlTab.BackColor = System.Drawing.Color.Silver;
            this.remoteControlTab.Controls.Add(this.remoteControlMaster);
            this.remoteControlTab.Location = new System.Drawing.Point(4, 22);
            this.remoteControlTab.Name = "remoteControlTab";
            this.remoteControlTab.Size = new System.Drawing.Size(1318, 755);
            this.remoteControlTab.TabIndex = 2;
            this.remoteControlTab.Text = "Remote Control";
            // 
            // remoteControlMaster
            // 
            this.remoteControlMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteControlMaster.Location = new System.Drawing.Point(0, 0);
            this.remoteControlMaster.Name = "remoteControlMaster";
            this.remoteControlMaster.Size = new System.Drawing.Size(1318, 755);
            this.remoteControlMaster.TabIndex = 0;
            // 
            // siTab
            // 
            this.siTab.BackColor = System.Drawing.Color.Silver;
            this.siTab.Controls.Add(this.secondaryInjectionFrame1);
            this.siTab.Location = new System.Drawing.Point(4, 22);
            this.siTab.Name = "siTab";
            this.siTab.Size = new System.Drawing.Size(1318, 755);
            this.siTab.TabIndex = 4;
            this.siTab.Text = "Secondary Injection";
            // 
            // secondaryInjectionFrame1
            // 
            this.secondaryInjectionFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondaryInjectionFrame1.Location = new System.Drawing.Point(0, 0);
            this.secondaryInjectionFrame1.Name = "secondaryInjectionFrame1";
            this.secondaryInjectionFrame1.Size = new System.Drawing.Size(1318, 755);
            this.secondaryInjectionFrame1.TabIndex = 0;
            // 
            // eventsTab
            // 
            this.eventsTab.BackColor = System.Drawing.Color.Silver;
            this.eventsTab.Controls.Add(this.eventsFrame1);
            this.eventsTab.Location = new System.Drawing.Point(4, 22);
            this.eventsTab.Name = "eventsTab";
            this.eventsTab.Size = new System.Drawing.Size(1318, 755);
            this.eventsTab.TabIndex = 5;
            this.eventsTab.Text = "Events";
            // 
            // eventsFrame1
            // 
            this.eventsFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsFrame1.Location = new System.Drawing.Point(0, 0);
            this.eventsFrame1.Name = "eventsFrame1";
            this.eventsFrame1.Size = new System.Drawing.Size(1318, 755);
            this.eventsFrame1.TabIndex = 0;
            // 
            // messageParseTab
            // 
            this.messageParseTab.AutoScroll = true;
            this.messageParseTab.BackColor = System.Drawing.Color.Silver;
            this.messageParseTab.Controls.Add(this.label4);
            this.messageParseTab.Controls.Add(this.byteParseRTB);
            this.messageParseTab.Controls.Add(this.byteParseDGV);
            this.messageParseTab.Location = new System.Drawing.Point(4, 22);
            this.messageParseTab.Name = "messageParseTab";
            this.messageParseTab.Size = new System.Drawing.Size(1318, 755);
            this.messageParseTab.TabIndex = 3;
            this.messageParseTab.Text = "Message Analyser";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "Copy and paste the transaction bytes from the coms log to parse the message. Only" +
    " include bytes";
            // 
            // byteParseRTB
            // 
            this.byteParseRTB.Location = new System.Drawing.Point(14, 51);
            this.byteParseRTB.Name = "byteParseRTB";
            this.byteParseRTB.Size = new System.Drawing.Size(254, 290);
            this.byteParseRTB.TabIndex = 1;
            this.byteParseRTB.Text = "80 01 01 00 00 01 01 06 02 08 3E 00 55 16 17 27 FD ";
            this.byteParseRTB.TextChanged += new System.EventHandler(this.byteParseRTB_TextChanged);
            // 
            // byteParseDGV
            // 
            this.byteParseDGV.AllowUserToAddRows = false;
            this.byteParseDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(205)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.byteParseDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.byteParseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.byteParseDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexCol,
            this.hexCol,
            this.intCol,
            this.desCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.byteParseDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.byteParseDGV.Location = new System.Drawing.Point(307, 3);
            this.byteParseDGV.Name = "byteParseDGV";
            this.byteParseDGV.RowHeadersVisible = false;
            this.byteParseDGV.Size = new System.Drawing.Size(453, 747);
            this.byteParseDGV.TabIndex = 0;
            // 
            // indexCol
            // 
            this.indexCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.indexCol.HeaderText = "Index";
            this.indexCol.Name = "indexCol";
            this.indexCol.ReadOnly = true;
            this.indexCol.Width = 50;
            // 
            // hexCol
            // 
            this.hexCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hexCol.HeaderText = "Hex Value";
            this.hexCol.Name = "hexCol";
            this.hexCol.ReadOnly = true;
            this.hexCol.Width = 80;
            // 
            // intCol
            // 
            this.intCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.intCol.HeaderText = "Int Value";
            this.intCol.Name = "intCol";
            this.intCol.ReadOnly = true;
            this.intCol.Width = 80;
            // 
            // desCol
            // 
            this.desCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desCol.HeaderText = "Description";
            this.desCol.Name = "desCol";
            this.desCol.ReadOnly = true;
            // 
            // connectedDeviceInfoTL
            // 
            this.connectedDeviceInfoTL.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.connectedDeviceInfoTL.ColumnCount = 3;
            this.connectedDeviceInfoTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.connectedDeviceInfoTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.connectedDeviceInfoTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.connectedDeviceInfoTL.Controls.Add(this.typeLabel, 2, 1);
            this.connectedDeviceInfoTL.Controls.Add(this.ratingLabel, 1, 1);
            this.connectedDeviceInfoTL.Controls.Add(this.label3, 2, 0);
            this.connectedDeviceInfoTL.Controls.Add(this.label2, 1, 0);
            this.connectedDeviceInfoTL.Controls.Add(this.label1, 0, 0);
            this.connectedDeviceInfoTL.Controls.Add(this.frameLabel, 0, 1);
            this.connectedDeviceInfoTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectedDeviceInfoTL.Location = new System.Drawing.Point(3, 53);
            this.connectedDeviceInfoTL.Name = "connectedDeviceInfoTL";
            this.connectedDeviceInfoTL.RowCount = 2;
            this.connectedDeviceInfoTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectedDeviceInfoTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectedDeviceInfoTL.Size = new System.Drawing.Size(246, 44);
            this.connectedDeviceInfoTL.TabIndex = 5;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(181, 26);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(10, 13);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "-";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ratingLabel
            // 
            this.ratingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(97, 26);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(10, 13);
            this.ratingLabel.TabIndex = 4;
            this.ratingLabel.Text = "-";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(128, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(77, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rating";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frame";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frameLabel
            // 
            this.frameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frameLabel.AutoSize = true;
            this.frameLabel.Location = new System.Drawing.Point(33, 26);
            this.frameLabel.Name = "frameLabel";
            this.frameLabel.Size = new System.Drawing.Size(10, 13);
            this.frameLabel.TabIndex = 3;
            this.frameLabel.Text = "-";
            this.frameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connPanel
            // 
            this.connPanel.Controls.Add(this.autoConnectCheckbox);
            this.connPanel.Controls.Add(this.connMenu);
            this.connPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connPanel.Location = new System.Drawing.Point(0, 0);
            this.connPanel.Margin = new System.Windows.Forms.Padding(0);
            this.connPanel.Name = "connPanel";
            this.connPanel.Size = new System.Drawing.Size(252, 50);
            this.connPanel.TabIndex = 6;
            // 
            // autoConnectCheckbox
            // 
            this.autoConnectCheckbox.AutoSize = true;
            this.autoConnectCheckbox.Location = new System.Drawing.Point(169, 7);
            this.autoConnectCheckbox.Name = "autoConnectCheckbox";
            this.autoConnectCheckbox.Size = new System.Drawing.Size(66, 30);
            this.autoConnectCheckbox.TabIndex = 5;
            this.autoConnectCheckbox.Text = "Auto\r\nConnect";
            this.autoConnectCheckbox.UseVisualStyleBackColor = true;
            this.autoConnectCheckbox.CheckedChanged += new System.EventHandler(this.autoConnectCheckbox_CheckedChanged);
            // 
            // connMenu
            // 
            this.connMenu.AutoConnect = false;
            this.connMenu.ConnColor = System.Drawing.Color.LightGreen;
            this.connMenu.DisconnColor = System.Drawing.SystemColors.ButtonFace;
            this.connMenu.FailColor = System.Drawing.Color.LightSalmon;
            this.connMenu.Location = new System.Drawing.Point(3, 3);
            this.connMenu.Name = "connMenu";
            this.connMenu.Size = new System.Drawing.Size(167, 44);
            this.connMenu.TabIndex = 4;
            this.connMenu.ValidDescriptions = new string[] {
        "Eaton PXR 20/25",
        "Eaton PXR Trip Unit",
        "USB Serial Device"};
            this.connMenu.RowClickedEvent += new System.EventHandler<StasaLibrary.SelectConnection.RowClickedEventArgs>(this.selectPortConnectFrame_RowClickedEvent);
            // 
            // passwordGroupbox
            // 
            this.passwordGroupbox.Controls.Add(this.autoPasswordCheckbox);
            this.passwordGroupbox.Controls.Add(this.setPasswordButton);
            this.passwordGroupbox.Controls.Add(this.passwordTextbox);
            this.passwordGroupbox.Controls.Add(this.inputPasswordButton);
            this.passwordGroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordGroupbox.Location = new System.Drawing.Point(3, 153);
            this.passwordGroupbox.Name = "passwordGroupbox";
            this.passwordGroupbox.Size = new System.Drawing.Size(246, 44);
            this.passwordGroupbox.TabIndex = 7;
            this.passwordGroupbox.TabStop = false;
            this.passwordGroupbox.Text = "Password";
            // 
            // autoPasswordCheckbox
            // 
            this.autoPasswordCheckbox.AutoSize = true;
            this.autoPasswordCheckbox.Enabled = false;
            this.autoPasswordCheckbox.Location = new System.Drawing.Point(59, 11);
            this.autoPasswordCheckbox.Name = "autoPasswordCheckbox";
            this.autoPasswordCheckbox.Size = new System.Drawing.Size(50, 30);
            this.autoPasswordCheckbox.TabIndex = 3;
            this.autoPasswordCheckbox.Text = "Auto\r\nInput";
            this.autoPasswordCheckbox.UseVisualStyleBackColor = true;
            // 
            // setPasswordButton
            // 
            this.setPasswordButton.Location = new System.Drawing.Point(9, 13);
            this.setPasswordButton.Name = "setPasswordButton";
            this.setPasswordButton.Size = new System.Drawing.Size(44, 25);
            this.setPasswordButton.TabIndex = 2;
            this.setPasswordButton.Text = "Set";
            this.setPasswordButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(112, 13);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(47, 26);
            this.passwordTextbox.TabIndex = 0;
            this.passwordTextbox.Text = "0000";
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputPasswordButton
            // 
            this.inputPasswordButton.Location = new System.Drawing.Point(165, 13);
            this.inputPasswordButton.Name = "inputPasswordButton";
            this.inputPasswordButton.Size = new System.Drawing.Size(75, 25);
            this.inputPasswordButton.TabIndex = 1;
            this.inputPasswordButton.Text = "Input";
            this.inputPasswordButton.UseVisualStyleBackColor = true;
            this.inputPasswordButton.Click += new System.EventHandler(this.inputPasswordButton_Click);
            // 
            // toggleManMoButton
            // 
            this.toggleManMoButton.BackColor = System.Drawing.Color.LightCyan;
            this.toggleManMoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleManMoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleManMoButton.Location = new System.Drawing.Point(6, 106);
            this.toggleManMoButton.Margin = new System.Windows.Forms.Padding(6);
            this.toggleManMoButton.Name = "toggleManMoButton";
            this.toggleManMoButton.Size = new System.Drawing.Size(240, 38);
            this.toggleManMoButton.TabIndex = 8;
            this.toggleManMoButton.Text = "Enter Manufacturing Mode";
            this.toggleManMoButton.UseVisualStyleBackColor = false;
            this.toggleManMoButton.Click += new System.EventHandler(this.toggleManMoButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clearLogsToolStripMenuItem.Text = "Clear Logs";
            this.clearLogsToolStripMenuItem.Click += new System.EventHandler(this.clearLogsToolStripMenuItem_Click);
            // 
            // calFactorsTab
            // 
            this.calFactorsTab.BackColor = System.Drawing.Color.Silver;
            this.calFactorsTab.Controls.Add(this.masterCalFactorFrame);
            this.calFactorsTab.Location = new System.Drawing.Point(4, 22);
            this.calFactorsTab.Name = "calFactorsTab";
            this.calFactorsTab.Size = new System.Drawing.Size(1318, 755);
            this.calFactorsTab.TabIndex = 7;
            this.calFactorsTab.Text = "Calibration Factors";
            // 
            // masterCalFactorFrame
            // 
            this.masterCalFactorFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterCalFactorFrame.Location = new System.Drawing.Point(0, 0);
            this.masterCalFactorFrame.Name = "masterCalFactorFrame";
            this.masterCalFactorFrame.Size = new System.Drawing.Size(1318, 755);
            this.masterCalFactorFrame.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 811);
            this.Controls.Add(this.mainTL);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "PXR Tool - USB Communications";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTL.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.rtdTab.ResumeLayout(false);
            this.spTab.ResumeLayout(false);
            this.configurationTab.ResumeLayout(false);
            this.remoteControlTab.ResumeLayout(false);
            this.siTab.ResumeLayout(false);
            this.eventsTab.ResumeLayout(false);
            this.messageParseTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.byteParseDGV)).EndInit();
            this.connectedDeviceInfoTL.ResumeLayout(false);
            this.connectedDeviceInfoTL.PerformLayout();
            this.connPanel.ResumeLayout(false);
            this.connPanel.PerformLayout();
            this.passwordGroupbox.ResumeLayout(false);
            this.passwordGroupbox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.calFactorsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainTL;
        private StasaLibrary.ComsLog comsLog;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage rtdTab;
        private System.Windows.Forms.TabPage spTab;
        private StasaLibrary.EtuConnFrames.ConnectionPortSelectFrame connMenu;
        private System.Windows.Forms.TableLayoutPanel connectedDeviceInfoTL;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frameLabel;
        private System.Windows.Forms.Panel connPanel;
        private RTD_Frame rtD_Frame;
        private SetpointFrame setpointFrame;
        private System.Windows.Forms.GroupBox passwordGroupbox;
        private System.Windows.Forms.Button setPasswordButton;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button inputPasswordButton;
        private System.Windows.Forms.CheckBox autoPasswordCheckbox;
        private System.Windows.Forms.CheckBox autoConnectCheckbox;
        private System.Windows.Forms.TabPage remoteControlTab;
        private RemoteControl.RemoteControlMaster remoteControlMaster;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.TabPage messageParseTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox byteParseRTB;
        private System.Windows.Forms.DataGridView byteParseDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hexCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn desCol;
        private System.Windows.Forms.TabPage siTab;
        private SecondaryInjectionFrame secondaryInjectionFrame1;
        private System.Windows.Forms.TabPage eventsTab;
        private EventsFrame eventsFrame1;
        private System.Windows.Forms.TabPage configurationTab;
        private Configuration.MasterConfigurationFrame masterConfigurationFrame;
        private System.Windows.Forms.Button toggleManMoButton;
        private System.Windows.Forms.TabPage calFactorsTab;
        private Calibration.MasterCalFactorFrame masterCalFactorFrame;
    }
}


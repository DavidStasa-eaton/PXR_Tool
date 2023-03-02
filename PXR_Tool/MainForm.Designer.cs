
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
            this.mainTL = new System.Windows.Forms.TableLayoutPanel();
            this.comsLog = new StasaLibrary.ComsLog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.rtdTab = new System.Windows.Forms.TabPage();
            this.spTab = new System.Windows.Forms.TabPage();
            this.remoteControlTab = new System.Windows.Forms.TabPage();
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
            this.rtD_Frame = new PXR_Tool.RTD_Frame();
            this.setpointFrame = new PXR_Tool.SetpointFrame();
            this.remoteControlMaster = new PXR_Tool.RemoteControl.RemoteControlMaster();
            this.mainTL.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.rtdTab.SuspendLayout();
            this.spTab.SuspendLayout();
            this.remoteControlTab.SuspendLayout();
            this.connectedDeviceInfoTL.SuspendLayout();
            this.connPanel.SuspendLayout();
            this.passwordGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTL
            // 
            this.mainTL.ColumnCount = 2;
            this.mainTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.mainTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTL.Controls.Add(this.comsLog, 0, 3);
            this.mainTL.Controls.Add(this.mainTabControl, 1, 0);
            this.mainTL.Controls.Add(this.connectedDeviceInfoTL, 0, 1);
            this.mainTL.Controls.Add(this.connPanel, 0, 0);
            this.mainTL.Controls.Add(this.passwordGroupbox, 0, 2);
            this.mainTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTL.Location = new System.Drawing.Point(0, 0);
            this.mainTL.Name = "mainTL";
            this.mainTL.RowCount = 4;
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTL.Size = new System.Drawing.Size(1584, 811);
            this.mainTL.TabIndex = 1;
            // 
            // comsLog
            // 
            this.comsLog.DetailSize = 20F;
            this.comsLog.Location = new System.Drawing.Point(3, 153);
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
            this.mainTabControl.Controls.Add(this.remoteControlTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.Location = new System.Drawing.Point(255, 3);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTL.SetRowSpan(this.mainTabControl, 4);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1326, 805);
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
            this.rtdTab.Size = new System.Drawing.Size(1318, 779);
            this.rtdTab.TabIndex = 0;
            this.rtdTab.Text = "Real Time Data";
            // 
            // spTab
            // 
            this.spTab.BackColor = System.Drawing.Color.Silver;
            this.spTab.Controls.Add(this.setpointFrame);
            this.spTab.Location = new System.Drawing.Point(4, 22);
            this.spTab.Name = "spTab";
            this.spTab.Padding = new System.Windows.Forms.Padding(3);
            this.spTab.Size = new System.Drawing.Size(1191, 779);
            this.spTab.TabIndex = 1;
            this.spTab.Text = "Setpoints";
            // 
            // remoteControlTab
            // 
            this.remoteControlTab.BackColor = System.Drawing.Color.Silver;
            this.remoteControlTab.Controls.Add(this.remoteControlMaster);
            this.remoteControlTab.Location = new System.Drawing.Point(4, 22);
            this.remoteControlTab.Name = "remoteControlTab";
            this.remoteControlTab.Size = new System.Drawing.Size(1318, 779);
            this.remoteControlTab.TabIndex = 2;
            this.remoteControlTab.Text = "Remote Control";
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
            this.passwordGroupbox.Location = new System.Drawing.Point(3, 103);
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
            // rtD_Frame
            // 
            this.rtD_Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtD_Frame.Location = new System.Drawing.Point(3, 3);
            this.rtD_Frame.Name = "rtD_Frame";
            this.rtD_Frame.Size = new System.Drawing.Size(1312, 773);
            this.rtD_Frame.TabIndex = 0;
            // 
            // setpointFrame
            // 
            this.setpointFrame.BackColor = System.Drawing.Color.Silver;
            this.setpointFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setpointFrame.Location = new System.Drawing.Point(3, 3);
            this.setpointFrame.Name = "setpointFrame";
            this.setpointFrame.Size = new System.Drawing.Size(1185, 773);
            this.setpointFrame.TabIndex = 0;
            // 
            // remoteControlMaster
            // 
            this.remoteControlMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteControlMaster.Location = new System.Drawing.Point(0, 0);
            this.remoteControlMaster.Name = "remoteControlMaster";
            this.remoteControlMaster.Size = new System.Drawing.Size(1318, 779);
            this.remoteControlMaster.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 811);
            this.Controls.Add(this.mainTL);
            this.Name = "MainForm";
            this.Text = "PXR Tool - USB Communications";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTL.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.rtdTab.ResumeLayout(false);
            this.spTab.ResumeLayout(false);
            this.remoteControlTab.ResumeLayout(false);
            this.connectedDeviceInfoTL.ResumeLayout(false);
            this.connectedDeviceInfoTL.PerformLayout();
            this.connPanel.ResumeLayout(false);
            this.connPanel.PerformLayout();
            this.passwordGroupbox.ResumeLayout(false);
            this.passwordGroupbox.PerformLayout();
            this.ResumeLayout(false);

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
    }
}


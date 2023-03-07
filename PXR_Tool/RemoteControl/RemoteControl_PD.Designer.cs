
namespace PXR_Tool.RemoteControl
{
    partial class RemoteControl_PD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resetFunctionGroupbox = new System.Windows.Forms.GroupBox();
            this.resetPeakCurrentDemandButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetPeakPowerDemandButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetPowerUpButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetEnergyButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetMinMaxLnVoltageButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetMinMaxLlVoltageButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetMinMaxCurrentButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetAllMinMaxButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetEtuButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetIntGroupBox = new System.Windows.Forms.GroupBox();
            this.intResetRunTimeButton = new StasaLibrary.DataFrames.ControlButton();
            this.intResetMaxTemperatureButton = new StasaLibrary.DataFrames.ControlButton();
            this.intResetOperationsButton = new StasaLibrary.DataFrames.ControlButton();
            this.intResetTripCountersButton = new StasaLibrary.DataFrames.ControlButton();
            this.intResetAllButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetExtGroupBox = new System.Windows.Forms.GroupBox();
            this.extResetRunTimeButton = new StasaLibrary.DataFrames.ControlButton();
            this.extResetMaxTemperatureButton = new StasaLibrary.DataFrames.ControlButton();
            this.extResetOperationsButton = new StasaLibrary.DataFrames.ControlButton();
            this.extResetTripCountersButton = new StasaLibrary.DataFrames.ControlButton();
            this.extResetAllButton = new StasaLibrary.DataFrames.ControlButton();
            this.armsGroupBox = new System.Windows.Forms.GroupBox();
            this.disableArmsButton = new StasaLibrary.DataFrames.ControlButton();
            this.enableArmsButton = new StasaLibrary.DataFrames.ControlButton();
            this.relayGroupBox = new System.Windows.Forms.GroupBox();
            this.closeRelayThreeButton = new System.Windows.Forms.Button();
            this.openRelayThreeButton = new System.Windows.Forms.Button();
            this.closeRelayTwoButton = new System.Windows.Forms.Button();
            this.openRelayTwoButton = new System.Windows.Forms.Button();
            this.closeRelayOneButton = new System.Windows.Forms.Button();
            this.openRelayOneButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firmwareVersionGroupBox = new System.Windows.Forms.GroupBox();
            this.readFirmwareButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usbVersionLabel = new System.Windows.Forms.Label();
            this.mcu2Label = new System.Windows.Forms.Label();
            this.mcu1Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openCoilBitParameterFrame = new StasaLibrary.DataFrames.BitParameterGroupFrame();
            this.openCoilDetectionButton = new System.Windows.Forms.Button();
            this.lcdPasswordButton = new StasaLibrary.DataFrames.ControlButton();
            this.dateTimeFrame = new StasaLibrary.DataFrames.DateTimeFrame();
            this.openBreakerButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetFunctionGroupbox.SuspendLayout();
            this.resetIntGroupBox.SuspendLayout();
            this.resetExtGroupBox.SuspendLayout();
            this.armsGroupBox.SuspendLayout();
            this.relayGroupBox.SuspendLayout();
            this.firmwareVersionGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetFunctionGroupbox
            // 
            this.resetFunctionGroupbox.Controls.Add(this.resetPeakCurrentDemandButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetPeakPowerDemandButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetPowerUpButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetEnergyButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetMinMaxLnVoltageButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetMinMaxLlVoltageButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetMinMaxCurrentButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetAllMinMaxButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetEtuButton);
            this.resetFunctionGroupbox.Location = new System.Drawing.Point(3, 3);
            this.resetFunctionGroupbox.Name = "resetFunctionGroupbox";
            this.resetFunctionGroupbox.Size = new System.Drawing.Size(289, 268);
            this.resetFunctionGroupbox.TabIndex = 0;
            this.resetFunctionGroupbox.TabStop = false;
            this.resetFunctionGroupbox.Text = "Reset Functions";
            // 
            // resetPeakCurrentDemandButton
            // 
            this.resetPeakCurrentDemandButton.Location = new System.Drawing.Point(141, 220);
            this.resetPeakCurrentDemandButton.Name = "resetPeakCurrentDemandButton";
            this.resetPeakCurrentDemandButton.paramGroup = null;
            this.resetPeakCurrentDemandButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetPeakCurrentDemandButton.Size = new System.Drawing.Size(125, 40);
            this.resetPeakCurrentDemandButton.TabIndex = 8;
            this.resetPeakCurrentDemandButton.Text = "Reset Peak\r\nCurrent Demand";
            this.resetPeakCurrentDemandButton.UseVisualStyleBackColor = true;
            // 
            // resetPeakPowerDemandButton
            // 
            this.resetPeakPowerDemandButton.Location = new System.Drawing.Point(6, 220);
            this.resetPeakPowerDemandButton.Name = "resetPeakPowerDemandButton";
            this.resetPeakPowerDemandButton.paramGroup = null;
            this.resetPeakPowerDemandButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetPeakPowerDemandButton.Size = new System.Drawing.Size(125, 40);
            this.resetPeakPowerDemandButton.TabIndex = 7;
            this.resetPeakPowerDemandButton.Text = "Reset Peak \r\nPower Demand";
            this.resetPeakPowerDemandButton.UseVisualStyleBackColor = true;
            // 
            // resetPowerUpButton
            // 
            this.resetPowerUpButton.Location = new System.Drawing.Point(141, 174);
            this.resetPowerUpButton.Name = "resetPowerUpButton";
            this.resetPowerUpButton.paramGroup = null;
            this.resetPowerUpButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetPowerUpButton.Size = new System.Drawing.Size(125, 40);
            this.resetPowerUpButton.TabIndex = 6;
            this.resetPowerUpButton.Text = "Reset Power Up";
            this.resetPowerUpButton.UseVisualStyleBackColor = true;
            // 
            // resetEnergyButton
            // 
            this.resetEnergyButton.Location = new System.Drawing.Point(6, 174);
            this.resetEnergyButton.Name = "resetEnergyButton";
            this.resetEnergyButton.paramGroup = null;
            this.resetEnergyButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetEnergyButton.Size = new System.Drawing.Size(125, 40);
            this.resetEnergyButton.TabIndex = 5;
            this.resetEnergyButton.Text = "Reset Energy";
            this.resetEnergyButton.UseVisualStyleBackColor = true;
            // 
            // resetMinMaxLnVoltageButton
            // 
            this.resetMinMaxLnVoltageButton.Location = new System.Drawing.Point(141, 128);
            this.resetMinMaxLnVoltageButton.Name = "resetMinMaxLnVoltageButton";
            this.resetMinMaxLnVoltageButton.paramGroup = null;
            this.resetMinMaxLnVoltageButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetMinMaxLnVoltageButton.Size = new System.Drawing.Size(125, 40);
            this.resetMinMaxLnVoltageButton.TabIndex = 4;
            this.resetMinMaxLnVoltageButton.Text = "Reset Min/Max\r\nLN Voltage";
            this.resetMinMaxLnVoltageButton.UseVisualStyleBackColor = true;
            // 
            // resetMinMaxLlVoltageButton
            // 
            this.resetMinMaxLlVoltageButton.Location = new System.Drawing.Point(6, 128);
            this.resetMinMaxLlVoltageButton.Name = "resetMinMaxLlVoltageButton";
            this.resetMinMaxLlVoltageButton.paramGroup = null;
            this.resetMinMaxLlVoltageButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetMinMaxLlVoltageButton.Size = new System.Drawing.Size(125, 40);
            this.resetMinMaxLlVoltageButton.TabIndex = 3;
            this.resetMinMaxLlVoltageButton.Text = "Reset Min/Max\r\nLL Voltage";
            this.resetMinMaxLlVoltageButton.UseVisualStyleBackColor = true;
            // 
            // resetMinMaxCurrentButton
            // 
            this.resetMinMaxCurrentButton.Location = new System.Drawing.Point(141, 82);
            this.resetMinMaxCurrentButton.Name = "resetMinMaxCurrentButton";
            this.resetMinMaxCurrentButton.paramGroup = null;
            this.resetMinMaxCurrentButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetMinMaxCurrentButton.Size = new System.Drawing.Size(125, 40);
            this.resetMinMaxCurrentButton.TabIndex = 2;
            this.resetMinMaxCurrentButton.Text = "Reset Min/Max\r\nCurrent";
            this.resetMinMaxCurrentButton.UseVisualStyleBackColor = true;
            // 
            // resetAllMinMaxButton
            // 
            this.resetAllMinMaxButton.Location = new System.Drawing.Point(6, 82);
            this.resetAllMinMaxButton.Name = "resetAllMinMaxButton";
            this.resetAllMinMaxButton.paramGroup = null;
            this.resetAllMinMaxButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetAllMinMaxButton.Size = new System.Drawing.Size(125, 40);
            this.resetAllMinMaxButton.TabIndex = 1;
            this.resetAllMinMaxButton.Text = "Reset All Min/Max Data";
            this.resetAllMinMaxButton.UseVisualStyleBackColor = true;
            // 
            // resetEtuButton
            // 
            this.resetEtuButton.Location = new System.Drawing.Point(6, 26);
            this.resetEtuButton.Name = "resetEtuButton";
            this.resetEtuButton.paramGroup = null;
            this.resetEtuButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetEtuButton.Size = new System.Drawing.Size(260, 40);
            this.resetEtuButton.TabIndex = 0;
            this.resetEtuButton.Text = "Reset Trip Unit";
            this.resetEtuButton.UseVisualStyleBackColor = true;
            // 
            // resetIntGroupBox
            // 
            this.resetIntGroupBox.Controls.Add(this.intResetRunTimeButton);
            this.resetIntGroupBox.Controls.Add(this.intResetMaxTemperatureButton);
            this.resetIntGroupBox.Controls.Add(this.intResetOperationsButton);
            this.resetIntGroupBox.Controls.Add(this.intResetTripCountersButton);
            this.resetIntGroupBox.Controls.Add(this.intResetAllButton);
            this.resetIntGroupBox.Location = new System.Drawing.Point(3, 288);
            this.resetIntGroupBox.Name = "resetIntGroupBox";
            this.resetIntGroupBox.Size = new System.Drawing.Size(266, 166);
            this.resetIntGroupBox.TabIndex = 1;
            this.resetIntGroupBox.TabStop = false;
            this.resetIntGroupBox.Text = "Reset Internal Diagnostics";
            // 
            // intResetRunTimeButton
            // 
            this.intResetRunTimeButton.Location = new System.Drawing.Point(140, 111);
            this.intResetRunTimeButton.Name = "intResetRunTimeButton";
            this.intResetRunTimeButton.paramGroup = null;
            this.intResetRunTimeButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.intResetRunTimeButton.Size = new System.Drawing.Size(120, 40);
            this.intResetRunTimeButton.TabIndex = 5;
            this.intResetRunTimeButton.Text = "Reset Run Time";
            this.intResetRunTimeButton.UseVisualStyleBackColor = true;
            // 
            // intResetMaxTemperatureButton
            // 
            this.intResetMaxTemperatureButton.Location = new System.Drawing.Point(6, 111);
            this.intResetMaxTemperatureButton.Name = "intResetMaxTemperatureButton";
            this.intResetMaxTemperatureButton.paramGroup = null;
            this.intResetMaxTemperatureButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.intResetMaxTemperatureButton.Size = new System.Drawing.Size(120, 40);
            this.intResetMaxTemperatureButton.TabIndex = 4;
            this.intResetMaxTemperatureButton.Text = "Reset Max Temperature";
            this.intResetMaxTemperatureButton.UseVisualStyleBackColor = true;
            // 
            // intResetOperationsButton
            // 
            this.intResetOperationsButton.Location = new System.Drawing.Point(140, 65);
            this.intResetOperationsButton.Name = "intResetOperationsButton";
            this.intResetOperationsButton.paramGroup = null;
            this.intResetOperationsButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.intResetOperationsButton.Size = new System.Drawing.Size(120, 40);
            this.intResetOperationsButton.TabIndex = 3;
            this.intResetOperationsButton.Text = "Reset Operations";
            this.intResetOperationsButton.UseVisualStyleBackColor = true;
            // 
            // intResetTripCountersButton
            // 
            this.intResetTripCountersButton.Location = new System.Drawing.Point(6, 65);
            this.intResetTripCountersButton.Name = "intResetTripCountersButton";
            this.intResetTripCountersButton.paramGroup = null;
            this.intResetTripCountersButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.intResetTripCountersButton.Size = new System.Drawing.Size(120, 40);
            this.intResetTripCountersButton.TabIndex = 2;
            this.intResetTripCountersButton.Text = "Reset Trip Counters";
            this.intResetTripCountersButton.UseVisualStyleBackColor = true;
            // 
            // intResetAllButton
            // 
            this.intResetAllButton.Location = new System.Drawing.Point(6, 19);
            this.intResetAllButton.Name = "intResetAllButton";
            this.intResetAllButton.paramGroup = null;
            this.intResetAllButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.intResetAllButton.Size = new System.Drawing.Size(254, 40);
            this.intResetAllButton.TabIndex = 1;
            this.intResetAllButton.Text = "Reset All Internal";
            this.intResetAllButton.UseVisualStyleBackColor = true;
            // 
            // resetExtGroupBox
            // 
            this.resetExtGroupBox.Controls.Add(this.extResetRunTimeButton);
            this.resetExtGroupBox.Controls.Add(this.extResetMaxTemperatureButton);
            this.resetExtGroupBox.Controls.Add(this.extResetOperationsButton);
            this.resetExtGroupBox.Controls.Add(this.extResetTripCountersButton);
            this.resetExtGroupBox.Controls.Add(this.extResetAllButton);
            this.resetExtGroupBox.Location = new System.Drawing.Point(275, 288);
            this.resetExtGroupBox.Name = "resetExtGroupBox";
            this.resetExtGroupBox.Size = new System.Drawing.Size(266, 166);
            this.resetExtGroupBox.TabIndex = 2;
            this.resetExtGroupBox.TabStop = false;
            this.resetExtGroupBox.Text = "Reset External Diagnostics";
            // 
            // extResetRunTimeButton
            // 
            this.extResetRunTimeButton.Location = new System.Drawing.Point(140, 111);
            this.extResetRunTimeButton.Name = "extResetRunTimeButton";
            this.extResetRunTimeButton.paramGroup = null;
            this.extResetRunTimeButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.extResetRunTimeButton.Size = new System.Drawing.Size(120, 40);
            this.extResetRunTimeButton.TabIndex = 5;
            this.extResetRunTimeButton.Text = "Reset Run Time";
            this.extResetRunTimeButton.UseVisualStyleBackColor = true;
            // 
            // extResetMaxTemperatureButton
            // 
            this.extResetMaxTemperatureButton.Location = new System.Drawing.Point(6, 111);
            this.extResetMaxTemperatureButton.Name = "extResetMaxTemperatureButton";
            this.extResetMaxTemperatureButton.paramGroup = null;
            this.extResetMaxTemperatureButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.extResetMaxTemperatureButton.Size = new System.Drawing.Size(120, 40);
            this.extResetMaxTemperatureButton.TabIndex = 4;
            this.extResetMaxTemperatureButton.Text = "Reset Max Temperature";
            this.extResetMaxTemperatureButton.UseVisualStyleBackColor = true;
            // 
            // extResetOperationsButton
            // 
            this.extResetOperationsButton.Location = new System.Drawing.Point(140, 65);
            this.extResetOperationsButton.Name = "extResetOperationsButton";
            this.extResetOperationsButton.paramGroup = null;
            this.extResetOperationsButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.extResetOperationsButton.Size = new System.Drawing.Size(120, 40);
            this.extResetOperationsButton.TabIndex = 3;
            this.extResetOperationsButton.Text = "Reset Operations";
            this.extResetOperationsButton.UseVisualStyleBackColor = true;
            // 
            // extResetTripCountersButton
            // 
            this.extResetTripCountersButton.Location = new System.Drawing.Point(6, 65);
            this.extResetTripCountersButton.Name = "extResetTripCountersButton";
            this.extResetTripCountersButton.paramGroup = null;
            this.extResetTripCountersButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.extResetTripCountersButton.Size = new System.Drawing.Size(120, 40);
            this.extResetTripCountersButton.TabIndex = 2;
            this.extResetTripCountersButton.Text = "Reset Trip Counters";
            this.extResetTripCountersButton.UseVisualStyleBackColor = true;
            // 
            // extResetAllButton
            // 
            this.extResetAllButton.Location = new System.Drawing.Point(6, 19);
            this.extResetAllButton.Name = "extResetAllButton";
            this.extResetAllButton.paramGroup = null;
            this.extResetAllButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.extResetAllButton.Size = new System.Drawing.Size(254, 40);
            this.extResetAllButton.TabIndex = 1;
            this.extResetAllButton.Text = "Reset All External";
            this.extResetAllButton.UseVisualStyleBackColor = true;
            // 
            // armsGroupBox
            // 
            this.armsGroupBox.Controls.Add(this.disableArmsButton);
            this.armsGroupBox.Controls.Add(this.enableArmsButton);
            this.armsGroupBox.Location = new System.Drawing.Point(319, 153);
            this.armsGroupBox.Name = "armsGroupBox";
            this.armsGroupBox.Size = new System.Drawing.Size(172, 72);
            this.armsGroupBox.TabIndex = 3;
            this.armsGroupBox.TabStop = false;
            this.armsGroupBox.Text = "ARMs";
            // 
            // disableArmsButton
            // 
            this.disableArmsButton.Location = new System.Drawing.Point(87, 19);
            this.disableArmsButton.Name = "disableArmsButton";
            this.disableArmsButton.paramGroup = null;
            this.disableArmsButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.disableArmsButton.Size = new System.Drawing.Size(75, 40);
            this.disableArmsButton.TabIndex = 4;
            this.disableArmsButton.Text = "Disable ARMs";
            this.disableArmsButton.UseVisualStyleBackColor = true;
            // 
            // enableArmsButton
            // 
            this.enableArmsButton.Location = new System.Drawing.Point(6, 19);
            this.enableArmsButton.Name = "enableArmsButton";
            this.enableArmsButton.paramGroup = null;
            this.enableArmsButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.enableArmsButton.Size = new System.Drawing.Size(75, 40);
            this.enableArmsButton.TabIndex = 3;
            this.enableArmsButton.Text = "Enable ARMs";
            this.enableArmsButton.UseVisualStyleBackColor = true;
            // 
            // relayGroupBox
            // 
            this.relayGroupBox.Controls.Add(this.closeRelayThreeButton);
            this.relayGroupBox.Controls.Add(this.openRelayThreeButton);
            this.relayGroupBox.Controls.Add(this.closeRelayTwoButton);
            this.relayGroupBox.Controls.Add(this.openRelayTwoButton);
            this.relayGroupBox.Controls.Add(this.closeRelayOneButton);
            this.relayGroupBox.Controls.Add(this.openRelayOneButton);
            this.relayGroupBox.Controls.Add(this.label3);
            this.relayGroupBox.Controls.Add(this.label2);
            this.relayGroupBox.Controls.Add(this.label1);
            this.relayGroupBox.Location = new System.Drawing.Point(604, 8);
            this.relayGroupBox.Name = "relayGroupBox";
            this.relayGroupBox.Size = new System.Drawing.Size(221, 163);
            this.relayGroupBox.TabIndex = 6;
            this.relayGroupBox.TabStop = false;
            this.relayGroupBox.Text = "Relays";
            // 
            // closeRelayThreeButton
            // 
            this.closeRelayThreeButton.Location = new System.Drawing.Point(136, 113);
            this.closeRelayThreeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.closeRelayThreeButton.Name = "closeRelayThreeButton";
            this.closeRelayThreeButton.Size = new System.Drawing.Size(75, 36);
            this.closeRelayThreeButton.TabIndex = 8;
            this.closeRelayThreeButton.Text = "Close";
            this.closeRelayThreeButton.UseVisualStyleBackColor = true;
            this.closeRelayThreeButton.Click += new System.EventHandler(this.closeRelayThreeButton_Click);
            // 
            // openRelayThreeButton
            // 
            this.openRelayThreeButton.Location = new System.Drawing.Point(55, 113);
            this.openRelayThreeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openRelayThreeButton.Name = "openRelayThreeButton";
            this.openRelayThreeButton.Size = new System.Drawing.Size(75, 36);
            this.openRelayThreeButton.TabIndex = 7;
            this.openRelayThreeButton.Text = "Open";
            this.openRelayThreeButton.UseVisualStyleBackColor = true;
            this.openRelayThreeButton.Click += new System.EventHandler(this.openRelayThreeButton_Click);
            // 
            // closeRelayTwoButton
            // 
            this.closeRelayTwoButton.Location = new System.Drawing.Point(136, 68);
            this.closeRelayTwoButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.closeRelayTwoButton.Name = "closeRelayTwoButton";
            this.closeRelayTwoButton.Size = new System.Drawing.Size(75, 36);
            this.closeRelayTwoButton.TabIndex = 6;
            this.closeRelayTwoButton.Text = "Close";
            this.closeRelayTwoButton.UseVisualStyleBackColor = true;
            this.closeRelayTwoButton.Click += new System.EventHandler(this.closeRelayTwoButton_Click);
            // 
            // openRelayTwoButton
            // 
            this.openRelayTwoButton.Location = new System.Drawing.Point(55, 69);
            this.openRelayTwoButton.Name = "openRelayTwoButton";
            this.openRelayTwoButton.Size = new System.Drawing.Size(75, 36);
            this.openRelayTwoButton.TabIndex = 5;
            this.openRelayTwoButton.Text = "Open";
            this.openRelayTwoButton.UseVisualStyleBackColor = true;
            this.openRelayTwoButton.Click += new System.EventHandler(this.openRelayTwoButton_Click);
            // 
            // closeRelayOneButton
            // 
            this.closeRelayOneButton.Location = new System.Drawing.Point(136, 25);
            this.closeRelayOneButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.closeRelayOneButton.Name = "closeRelayOneButton";
            this.closeRelayOneButton.Size = new System.Drawing.Size(75, 36);
            this.closeRelayOneButton.TabIndex = 4;
            this.closeRelayOneButton.Text = "Close";
            this.closeRelayOneButton.UseVisualStyleBackColor = true;
            this.closeRelayOneButton.Click += new System.EventHandler(this.closeRelayOneButton_Click);
            // 
            // openRelayOneButton
            // 
            this.openRelayOneButton.Location = new System.Drawing.Point(55, 25);
            this.openRelayOneButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openRelayOneButton.Name = "openRelayOneButton";
            this.openRelayOneButton.Size = new System.Drawing.Size(75, 36);
            this.openRelayOneButton.TabIndex = 3;
            this.openRelayOneButton.Text = "Open";
            this.openRelayOneButton.UseVisualStyleBackColor = true;
            this.openRelayOneButton.Click += new System.EventHandler(this.openRelayOneButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Relay 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Relay 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relay 1";
            // 
            // firmwareVersionGroupBox
            // 
            this.firmwareVersionGroupBox.Controls.Add(this.readFirmwareButton);
            this.firmwareVersionGroupBox.Controls.Add(this.label6);
            this.firmwareVersionGroupBox.Controls.Add(this.label5);
            this.firmwareVersionGroupBox.Controls.Add(this.label4);
            this.firmwareVersionGroupBox.Controls.Add(this.usbVersionLabel);
            this.firmwareVersionGroupBox.Controls.Add(this.mcu2Label);
            this.firmwareVersionGroupBox.Controls.Add(this.mcu1Label);
            this.firmwareVersionGroupBox.Location = new System.Drawing.Point(307, 8);
            this.firmwareVersionGroupBox.Name = "firmwareVersionGroupBox";
            this.firmwareVersionGroupBox.Size = new System.Drawing.Size(273, 127);
            this.firmwareVersionGroupBox.TabIndex = 8;
            this.firmwareVersionGroupBox.TabStop = false;
            this.firmwareVersionGroupBox.Text = "Firmware Version";
            // 
            // readFirmwareButton
            // 
            this.readFirmwareButton.Location = new System.Drawing.Point(12, 21);
            this.readFirmwareButton.Name = "readFirmwareButton";
            this.readFirmwareButton.Size = new System.Drawing.Size(75, 88);
            this.readFirmwareButton.TabIndex = 6;
            this.readFirmwareButton.Text = "Read Firmware Version";
            this.readFirmwareButton.UseVisualStyleBackColor = true;
            this.readFirmwareButton.Click += new System.EventHandler(this.readFirmwareButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "USB Version";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MCU 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MCU 1";
            // 
            // usbVersionLabel
            // 
            this.usbVersionLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usbVersionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usbVersionLabel.Location = new System.Drawing.Point(178, 86);
            this.usbVersionLabel.Name = "usbVersionLabel";
            this.usbVersionLabel.Size = new System.Drawing.Size(89, 23);
            this.usbVersionLabel.TabIndex = 2;
            this.usbVersionLabel.Text = "-";
            this.usbVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mcu2Label
            // 
            this.mcu2Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mcu2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mcu2Label.Location = new System.Drawing.Point(178, 53);
            this.mcu2Label.Name = "mcu2Label";
            this.mcu2Label.Size = new System.Drawing.Size(89, 23);
            this.mcu2Label.TabIndex = 1;
            this.mcu2Label.Text = "-";
            this.mcu2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mcu1Label
            // 
            this.mcu1Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mcu1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mcu1Label.Location = new System.Drawing.Point(178, 21);
            this.mcu1Label.Name = "mcu1Label";
            this.mcu1Label.Size = new System.Drawing.Size(89, 23);
            this.mcu1Label.TabIndex = 0;
            this.mcu1Label.Text = "-";
            this.mcu1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openCoilBitParameterFrame);
            this.groupBox1.Controls.Add(this.openCoilDetectionButton);
            this.groupBox1.Location = new System.Drawing.Point(586, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 185);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Coil Detection";
            // 
            // openCoilBitParameterFrame
            // 
            this.openCoilBitParameterFrame.Columns = ((uint)(0u));
            this.openCoilBitParameterFrame.DisabledText = "Close";
            this.openCoilBitParameterFrame.EnableText = "Open";
            this.openCoilBitParameterFrame.Location = new System.Drawing.Point(12, 65);
            this.openCoilBitParameterFrame.Name = "openCoilBitParameterFrame";
            this.openCoilBitParameterFrame.paramGroup = null;
            this.openCoilBitParameterFrame.Rows = ((uint)(1u));
            this.openCoilBitParameterFrame.Size = new System.Drawing.Size(304, 114);
            this.openCoilBitParameterFrame.SplitIndex = ((uint)(0u));
            this.openCoilBitParameterFrame.TabIndex = 7;
            this.openCoilBitParameterFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.openCoilBitParameterFrame_Paint);
            // 
            // openCoilDetectionButton
            // 
            this.openCoilDetectionButton.Location = new System.Drawing.Point(12, 21);
            this.openCoilDetectionButton.Name = "openCoilDetectionButton";
            this.openCoilDetectionButton.Size = new System.Drawing.Size(112, 38);
            this.openCoilDetectionButton.TabIndex = 6;
            this.openCoilDetectionButton.Text = "Open Coil Detection";
            this.openCoilDetectionButton.UseVisualStyleBackColor = true;
            this.openCoilDetectionButton.Click += new System.EventHandler(this.openCoilDetectionButton_Click);
            // 
            // lcdPasswordButton
            // 
            this.lcdPasswordButton.Location = new System.Drawing.Point(307, 231);
            this.lcdPasswordButton.Name = "lcdPasswordButton";
            this.lcdPasswordButton.paramGroup = null;
            this.lcdPasswordButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.lcdPasswordButton.Size = new System.Drawing.Size(94, 40);
            this.lcdPasswordButton.TabIndex = 7;
            this.lcdPasswordButton.Text = "Enter Password from LCD";
            this.lcdPasswordButton.UseVisualStyleBackColor = true;
            // 
            // dateTimeFrame
            // 
            this.dateTimeFrame.Location = new System.Drawing.Point(625, 177);
            this.dateTimeFrame.Name = "dateTimeFrame";
            this.dateTimeFrame.paramGroup = null;
            this.dateTimeFrame.Size = new System.Drawing.Size(200, 139);
            this.dateTimeFrame.TabIndex = 5;
            this.dateTimeFrame.writeParamGroup = null;
            // 
            // openBreakerButton
            // 
            this.openBreakerButton.Location = new System.Drawing.Point(416, 231);
            this.openBreakerButton.Name = "openBreakerButton";
            this.openBreakerButton.paramGroup = null;
            this.openBreakerButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.openBreakerButton.Size = new System.Drawing.Size(75, 40);
            this.openBreakerButton.TabIndex = 4;
            this.openBreakerButton.Text = "Open Breaker";
            this.openBreakerButton.UseVisualStyleBackColor = true;
            // 
            // RemoteControl_PD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.firmwareVersionGroupBox);
            this.Controls.Add(this.lcdPasswordButton);
            this.Controls.Add(this.relayGroupBox);
            this.Controls.Add(this.dateTimeFrame);
            this.Controls.Add(this.openBreakerButton);
            this.Controls.Add(this.armsGroupBox);
            this.Controls.Add(this.resetExtGroupBox);
            this.Controls.Add(this.resetIntGroupBox);
            this.Controls.Add(this.resetFunctionGroupbox);
            this.Name = "RemoteControl_PD";
            this.Size = new System.Drawing.Size(968, 567);
            this.Load += new System.EventHandler(this.RemoteControl_PD_Load);
            this.resetFunctionGroupbox.ResumeLayout(false);
            this.resetIntGroupBox.ResumeLayout(false);
            this.resetExtGroupBox.ResumeLayout(false);
            this.armsGroupBox.ResumeLayout(false);
            this.relayGroupBox.ResumeLayout(false);
            this.relayGroupBox.PerformLayout();
            this.firmwareVersionGroupBox.ResumeLayout(false);
            this.firmwareVersionGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox resetFunctionGroupbox;
        private StasaLibrary.DataFrames.ControlButton resetEtuButton;
        private StasaLibrary.DataFrames.ControlButton resetPeakCurrentDemandButton;
        private StasaLibrary.DataFrames.ControlButton resetPeakPowerDemandButton;
        private StasaLibrary.DataFrames.ControlButton resetPowerUpButton;
        private StasaLibrary.DataFrames.ControlButton resetEnergyButton;
        private StasaLibrary.DataFrames.ControlButton resetMinMaxLnVoltageButton;
        private StasaLibrary.DataFrames.ControlButton resetMinMaxLlVoltageButton;
        private StasaLibrary.DataFrames.ControlButton resetMinMaxCurrentButton;
        private StasaLibrary.DataFrames.ControlButton resetAllMinMaxButton;
        private System.Windows.Forms.GroupBox resetIntGroupBox;
        private StasaLibrary.DataFrames.ControlButton intResetRunTimeButton;
        private StasaLibrary.DataFrames.ControlButton intResetMaxTemperatureButton;
        private StasaLibrary.DataFrames.ControlButton intResetOperationsButton;
        private StasaLibrary.DataFrames.ControlButton intResetTripCountersButton;
        private StasaLibrary.DataFrames.ControlButton intResetAllButton;
        private System.Windows.Forms.GroupBox resetExtGroupBox;
        private StasaLibrary.DataFrames.ControlButton extResetRunTimeButton;
        private StasaLibrary.DataFrames.ControlButton extResetMaxTemperatureButton;
        private StasaLibrary.DataFrames.ControlButton extResetOperationsButton;
        private StasaLibrary.DataFrames.ControlButton extResetTripCountersButton;
        private StasaLibrary.DataFrames.ControlButton extResetAllButton;
        private System.Windows.Forms.GroupBox armsGroupBox;
        private StasaLibrary.DataFrames.ControlButton disableArmsButton;
        private StasaLibrary.DataFrames.ControlButton enableArmsButton;
        private StasaLibrary.DataFrames.ControlButton openBreakerButton;
        private StasaLibrary.DataFrames.DateTimeFrame dateTimeFrame;
        private System.Windows.Forms.GroupBox relayGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private StasaLibrary.DataFrames.ControlButton lcdPasswordButton;
        private System.Windows.Forms.Button closeRelayThreeButton;
        private System.Windows.Forms.Button openRelayThreeButton;
        private System.Windows.Forms.Button closeRelayTwoButton;
        private System.Windows.Forms.Button openRelayTwoButton;
        private System.Windows.Forms.Button closeRelayOneButton;
        private System.Windows.Forms.Button openRelayOneButton;
        private System.Windows.Forms.GroupBox firmwareVersionGroupBox;
        private System.Windows.Forms.Button readFirmwareButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label usbVersionLabel;
        private System.Windows.Forms.Label mcu2Label;
        private System.Windows.Forms.Label mcu1Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private StasaLibrary.DataFrames.BitParameterGroupFrame openCoilBitParameterFrame;
        private System.Windows.Forms.Button openCoilDetectionButton;
    }
}

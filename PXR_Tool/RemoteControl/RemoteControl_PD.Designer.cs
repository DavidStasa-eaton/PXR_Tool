
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
            this.enableArmsButton = new StasaLibrary.DataFrames.ControlButton();
            this.disableArmsButton = new StasaLibrary.DataFrames.ControlButton();
            this.openBreakerButton = new StasaLibrary.DataFrames.ControlButton();
            this.dateTimeFrame = new StasaLibrary.DataFrames.DateTimeFrame();
            this.relayGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openRelayOneButton = new StasaLibrary.DataFrames.ControlButton();
            this.closeRelayOneButton = new StasaLibrary.DataFrames.ControlButton();
            this.openRelayTwoButton = new StasaLibrary.DataFrames.ControlButton();
            this.closeRelayTwoButton = new StasaLibrary.DataFrames.ControlButton();
            this.openRelayThreeButton = new StasaLibrary.DataFrames.ControlButton();
            this.closeRelayThreeButton = new StasaLibrary.DataFrames.ControlButton();
            this.lcdPasswordButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetFunctionGroupbox.SuspendLayout();
            this.resetIntGroupBox.SuspendLayout();
            this.resetExtGroupBox.SuspendLayout();
            this.armsGroupBox.SuspendLayout();
            this.relayGroupBox.SuspendLayout();
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
            // dateTimeFrame
            // 
            this.dateTimeFrame.Location = new System.Drawing.Point(561, 300);
            this.dateTimeFrame.Name = "dateTimeFrame";
            this.dateTimeFrame.paramGroup = null;
            this.dateTimeFrame.Size = new System.Drawing.Size(200, 139);
            this.dateTimeFrame.TabIndex = 5;
            this.dateTimeFrame.writeParamGroup = null;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relay 1";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Relay 2";
            // 
            // openRelayOneButton
            // 
            this.openRelayOneButton.Location = new System.Drawing.Point(55, 24);
            this.openRelayOneButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openRelayOneButton.Name = "openRelayOneButton";
            this.openRelayOneButton.paramGroup = null;
            this.openRelayOneButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.openRelayOneButton.Size = new System.Drawing.Size(75, 35);
            this.openRelayOneButton.TabIndex = 7;
            this.openRelayOneButton.Text = "Open";
            this.openRelayOneButton.UseVisualStyleBackColor = true;
            // 
            // closeRelayOneButton
            // 
            this.closeRelayOneButton.Location = new System.Drawing.Point(136, 24);
            this.closeRelayOneButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.closeRelayOneButton.Name = "closeRelayOneButton";
            this.closeRelayOneButton.paramGroup = null;
            this.closeRelayOneButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.closeRelayOneButton.Size = new System.Drawing.Size(75, 35);
            this.closeRelayOneButton.TabIndex = 8;
            this.closeRelayOneButton.Text = "Close";
            this.closeRelayOneButton.UseVisualStyleBackColor = true;
            // 
            // openRelayTwoButton
            // 
            this.openRelayTwoButton.Location = new System.Drawing.Point(55, 69);
            this.openRelayTwoButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openRelayTwoButton.Name = "openRelayTwoButton";
            this.openRelayTwoButton.paramGroup = null;
            this.openRelayTwoButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.openRelayTwoButton.Size = new System.Drawing.Size(75, 35);
            this.openRelayTwoButton.TabIndex = 9;
            this.openRelayTwoButton.Text = "Open";
            this.openRelayTwoButton.UseVisualStyleBackColor = true;
            // 
            // closeRelayTwoButton
            // 
            this.closeRelayTwoButton.Location = new System.Drawing.Point(136, 69);
            this.closeRelayTwoButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.closeRelayTwoButton.Name = "closeRelayTwoButton";
            this.closeRelayTwoButton.paramGroup = null;
            this.closeRelayTwoButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.closeRelayTwoButton.Size = new System.Drawing.Size(75, 35);
            this.closeRelayTwoButton.TabIndex = 10;
            this.closeRelayTwoButton.Text = "Close";
            this.closeRelayTwoButton.UseVisualStyleBackColor = true;
            // 
            // openRelayThreeButton
            // 
            this.openRelayThreeButton.Location = new System.Drawing.Point(55, 114);
            this.openRelayThreeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openRelayThreeButton.Name = "openRelayThreeButton";
            this.openRelayThreeButton.paramGroup = null;
            this.openRelayThreeButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.openRelayThreeButton.Size = new System.Drawing.Size(75, 35);
            this.openRelayThreeButton.TabIndex = 11;
            this.openRelayThreeButton.Text = "Open";
            this.openRelayThreeButton.UseVisualStyleBackColor = true;
            // 
            // closeRelayThreeButton
            // 
            this.closeRelayThreeButton.Location = new System.Drawing.Point(136, 114);
            this.closeRelayThreeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.closeRelayThreeButton.Name = "closeRelayThreeButton";
            this.closeRelayThreeButton.paramGroup = null;
            this.closeRelayThreeButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.closeRelayThreeButton.Size = new System.Drawing.Size(75, 35);
            this.closeRelayThreeButton.TabIndex = 12;
            this.closeRelayThreeButton.Text = "Close";
            this.closeRelayThreeButton.UseVisualStyleBackColor = true;
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
            // RemoteControl_PD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcdPasswordButton);
            this.Controls.Add(this.relayGroupBox);
            this.Controls.Add(this.dateTimeFrame);
            this.Controls.Add(this.openBreakerButton);
            this.Controls.Add(this.armsGroupBox);
            this.Controls.Add(this.resetExtGroupBox);
            this.Controls.Add(this.resetIntGroupBox);
            this.Controls.Add(this.resetFunctionGroupbox);
            this.Name = "RemoteControl_PD";
            this.Size = new System.Drawing.Size(866, 501);
            this.Load += new System.EventHandler(this.RemoteControl_PD_Load);
            this.resetFunctionGroupbox.ResumeLayout(false);
            this.resetIntGroupBox.ResumeLayout(false);
            this.resetExtGroupBox.ResumeLayout(false);
            this.armsGroupBox.ResumeLayout(false);
            this.relayGroupBox.ResumeLayout(false);
            this.relayGroupBox.PerformLayout();
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
        private StasaLibrary.DataFrames.ControlButton closeRelayThreeButton;
        private StasaLibrary.DataFrames.ControlButton openRelayThreeButton;
        private StasaLibrary.DataFrames.ControlButton closeRelayTwoButton;
        private StasaLibrary.DataFrames.ControlButton openRelayTwoButton;
        private StasaLibrary.DataFrames.ControlButton closeRelayOneButton;
        private StasaLibrary.DataFrames.ControlButton openRelayOneButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private StasaLibrary.DataFrames.ControlButton lcdPasswordButton;
    }
}

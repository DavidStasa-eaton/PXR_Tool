
namespace PXR_Tool.RemoteControl
{
    partial class RemoteControl_Tokyo
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
            this.resetPeakPowerDemandButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetEnergyButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetMinMaxLnVoltageButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetMinMaxLlVoltageButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetMinMaxCurrentButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetAllMinMaxButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetEtuButton = new StasaLibrary.DataFrames.ControlButton();
            this.openBreakerButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetOperationsButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetTripCountersButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetRunTimeButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetExternalDiagsButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetInternalDiagsButton = new StasaLibrary.DataFrames.ControlButton();
            this.firmwareVersionGroupBox = new System.Windows.Forms.GroupBox();
            this.readFirmwareButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usbVersionLabel = new System.Windows.Forms.Label();
            this.mcu2Label = new System.Windows.Forms.Label();
            this.mcu1Label = new System.Windows.Forms.Label();
            this.dateTimeFrame = new StasaLibrary.DataFrames.DateTimeFrame();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetFunctionGroupbox.SuspendLayout();
            this.firmwareVersionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetFunctionGroupbox
            // 
            this.resetFunctionGroupbox.Controls.Add(this.resetInternalDiagsButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetExternalDiagsButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetRunTimeButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetTripCountersButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetOperationsButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetPeakPowerDemandButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetEnergyButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetMinMaxLnVoltageButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetMinMaxLlVoltageButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetMinMaxCurrentButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetAllMinMaxButton);
            this.resetFunctionGroupbox.Controls.Add(this.resetEtuButton);
            this.resetFunctionGroupbox.Location = new System.Drawing.Point(3, 3);
            this.resetFunctionGroupbox.Name = "resetFunctionGroupbox";
            this.resetFunctionGroupbox.Size = new System.Drawing.Size(289, 409);
            this.resetFunctionGroupbox.TabIndex = 1;
            this.resetFunctionGroupbox.TabStop = false;
            this.resetFunctionGroupbox.Text = "Reset Functions";
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
            // openBreakerButton
            // 
            this.openBreakerButton.Location = new System.Drawing.Point(307, 141);
            this.openBreakerButton.Name = "openBreakerButton";
            this.openBreakerButton.paramGroup = null;
            this.openBreakerButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.openBreakerButton.Size = new System.Drawing.Size(94, 80);
            this.openBreakerButton.TabIndex = 9;
            this.openBreakerButton.Text = "Open Breaker";
            this.openBreakerButton.UseVisualStyleBackColor = true;
            // 
            // resetOperationsButton
            // 
            this.resetOperationsButton.Location = new System.Drawing.Point(6, 266);
            this.resetOperationsButton.Name = "resetOperationsButton";
            this.resetOperationsButton.paramGroup = null;
            this.resetOperationsButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetOperationsButton.Size = new System.Drawing.Size(260, 40);
            this.resetOperationsButton.TabIndex = 8;
            this.resetOperationsButton.Text = "Reset Operations";
            this.resetOperationsButton.UseVisualStyleBackColor = true;
            // 
            // resetTripCountersButton
            // 
            this.resetTripCountersButton.Location = new System.Drawing.Point(6, 358);
            this.resetTripCountersButton.Name = "resetTripCountersButton";
            this.resetTripCountersButton.paramGroup = null;
            this.resetTripCountersButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetTripCountersButton.Size = new System.Drawing.Size(125, 40);
            this.resetTripCountersButton.TabIndex = 9;
            this.resetTripCountersButton.Text = "Reset Trip Counters";
            this.resetTripCountersButton.UseVisualStyleBackColor = true;
            // 
            // resetRunTimeButton
            // 
            this.resetRunTimeButton.Location = new System.Drawing.Point(141, 358);
            this.resetRunTimeButton.Name = "resetRunTimeButton";
            this.resetRunTimeButton.paramGroup = null;
            this.resetRunTimeButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetRunTimeButton.Size = new System.Drawing.Size(125, 40);
            this.resetRunTimeButton.TabIndex = 10;
            this.resetRunTimeButton.Text = "Reset Run Time";
            this.resetRunTimeButton.UseVisualStyleBackColor = true;
            // 
            // resetExternalDiagsButton
            // 
            this.resetExternalDiagsButton.Location = new System.Drawing.Point(6, 312);
            this.resetExternalDiagsButton.Name = "resetExternalDiagsButton";
            this.resetExternalDiagsButton.paramGroup = null;
            this.resetExternalDiagsButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetExternalDiagsButton.Size = new System.Drawing.Size(125, 40);
            this.resetExternalDiagsButton.TabIndex = 11;
            this.resetExternalDiagsButton.Text = "Reset External Diagnostics";
            this.resetExternalDiagsButton.UseVisualStyleBackColor = true;
            // 
            // resetInternalDiagsButton
            // 
            this.resetInternalDiagsButton.Location = new System.Drawing.Point(141, 312);
            this.resetInternalDiagsButton.Name = "resetInternalDiagsButton";
            this.resetInternalDiagsButton.paramGroup = null;
            this.resetInternalDiagsButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetInternalDiagsButton.Size = new System.Drawing.Size(125, 40);
            this.resetInternalDiagsButton.TabIndex = 12;
            this.resetInternalDiagsButton.Text = "Reset Internal Diagnostics";
            this.resetInternalDiagsButton.UseVisualStyleBackColor = true;
            // 
            // firmwareVersionGroupBox
            // 
            this.firmwareVersionGroupBox.Controls.Add(this.label2);
            this.firmwareVersionGroupBox.Controls.Add(this.label1);
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
            this.firmwareVersionGroupBox.TabIndex = 10;
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
            this.label5.Location = new System.Drawing.Point(105, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MCU 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 21);
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
            this.mcu2Label.Location = new System.Drawing.Point(178, 39);
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
            this.mcu1Label.Location = new System.Drawing.Point(178, 16);
            this.mcu1Label.Name = "mcu1Label";
            this.mcu1Label.Size = new System.Drawing.Size(89, 23);
            this.mcu1Label.TabIndex = 0;
            this.mcu1Label.Text = "-";
            this.mcu1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimeFrame
            // 
            this.dateTimeFrame.Location = new System.Drawing.Point(625, 177);
            this.dateTimeFrame.Name = "dateTimeFrame";
            this.dateTimeFrame.paramGroup = null;
            this.dateTimeFrame.Size = new System.Drawing.Size(200, 139);
            this.dateTimeFrame.TabIndex = 11;
            this.dateTimeFrame.writeParamGroup = null;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(178, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MCU 2 Flash";
            // 
            // RemoteControl_Tokyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimeFrame);
            this.Controls.Add(this.firmwareVersionGroupBox);
            this.Controls.Add(this.openBreakerButton);
            this.Controls.Add(this.resetFunctionGroupbox);
            this.Name = "RemoteControl_Tokyo";
            this.Size = new System.Drawing.Size(921, 561);
            this.resetFunctionGroupbox.ResumeLayout(false);
            this.firmwareVersionGroupBox.ResumeLayout(false);
            this.firmwareVersionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox resetFunctionGroupbox;
        private StasaLibrary.DataFrames.ControlButton resetPeakPowerDemandButton;
        private StasaLibrary.DataFrames.ControlButton resetEnergyButton;
        private StasaLibrary.DataFrames.ControlButton resetMinMaxLnVoltageButton;
        private StasaLibrary.DataFrames.ControlButton resetMinMaxLlVoltageButton;
        private StasaLibrary.DataFrames.ControlButton resetMinMaxCurrentButton;
        private StasaLibrary.DataFrames.ControlButton resetAllMinMaxButton;
        private StasaLibrary.DataFrames.ControlButton resetEtuButton;
        private StasaLibrary.DataFrames.ControlButton openBreakerButton;
        private StasaLibrary.DataFrames.ControlButton resetTripCountersButton;
        private StasaLibrary.DataFrames.ControlButton resetOperationsButton;
        private StasaLibrary.DataFrames.ControlButton resetInternalDiagsButton;
        private StasaLibrary.DataFrames.ControlButton resetExternalDiagsButton;
        private StasaLibrary.DataFrames.ControlButton resetRunTimeButton;
        private System.Windows.Forms.GroupBox firmwareVersionGroupBox;
        private System.Windows.Forms.Button readFirmwareButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label usbVersionLabel;
        private System.Windows.Forms.Label mcu2Label;
        private System.Windows.Forms.Label mcu1Label;
        private StasaLibrary.DataFrames.DateTimeFrame dateTimeFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

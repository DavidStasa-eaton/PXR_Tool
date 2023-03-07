
namespace PXR_Tool
{
    partial class SecondaryInjectionFrame
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainTL = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simulatedRadiobutton = new System.Windows.Forms.RadioButton();
            this.hardwareRadiobutton = new System.Windows.Forms.RadioButton();
            this.phaseGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.currentEntry = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.primaryLabel = new System.Windows.Forms.Label();
            this.causeLabel = new System.Windows.Forms.Label();
            this.secondaryLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelTestButton = new System.Windows.Forms.Button();
            this.rmsNoTripButton = new System.Windows.Forms.Button();
            this.rmsWithTripButton = new System.Windows.Forms.Button();
            this.peakNoTripButton = new System.Windows.Forms.Button();
            this.peakWithTripButton = new System.Windows.Forms.Button();
            this.bindedDataSource1 = new StasaLibrary.DataFrames.BindedDataSource();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dccButton = new StasaLibrary.DataFrames.ControlButton();
            this.bccButton = new StasaLibrary.DataFrames.ControlButton();
            this.csifButton = new StasaLibrary.DataFrames.ControlButton();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.mainTL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.phaseGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindedDataSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTL
            // 
            this.mainTL.ColumnCount = 1;
            this.mainTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTL.Controls.Add(this.bindedDataSource1, 0, 1);
            this.mainTL.Controls.Add(this.panel1, 0, 0);
            this.mainTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTL.Location = new System.Drawing.Point(0, 0);
            this.mainTL.Name = "mainTL";
            this.mainTL.RowCount = 2;
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.mainTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTL.Size = new System.Drawing.Size(978, 544);
            this.mainTL.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.dccButton);
            this.panel1.Controls.Add(this.bccButton);
            this.panel1.Controls.Add(this.csifButton);
            this.panel1.Controls.Add(this.peakWithTripButton);
            this.panel1.Controls.Add(this.peakNoTripButton);
            this.panel1.Controls.Add(this.rmsWithTripButton);
            this.panel1.Controls.Add(this.rmsNoTripButton);
            this.panel1.Controls.Add(this.cancelTestButton);
            this.panel1.Controls.Add(this.currentEntry);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.currentLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.phaseGroupBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 431);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simulatedRadiobutton);
            this.groupBox1.Controls.Add(this.hardwareRadiobutton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 37);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SI Type";
            // 
            // simulatedRadiobutton
            // 
            this.simulatedRadiobutton.AutoSize = true;
            this.simulatedRadiobutton.Location = new System.Drawing.Point(123, 14);
            this.simulatedRadiobutton.Name = "simulatedRadiobutton";
            this.simulatedRadiobutton.Size = new System.Drawing.Size(71, 17);
            this.simulatedRadiobutton.TabIndex = 1;
            this.simulatedRadiobutton.Text = "Simulated";
            this.simulatedRadiobutton.UseVisualStyleBackColor = true;
            // 
            // hardwareRadiobutton
            // 
            this.hardwareRadiobutton.AutoSize = true;
            this.hardwareRadiobutton.Checked = true;
            this.hardwareRadiobutton.Location = new System.Drawing.Point(6, 14);
            this.hardwareRadiobutton.Name = "hardwareRadiobutton";
            this.hardwareRadiobutton.Size = new System.Drawing.Size(71, 17);
            this.hardwareRadiobutton.TabIndex = 0;
            this.hardwareRadiobutton.TabStop = true;
            this.hardwareRadiobutton.Text = "Hardware";
            this.hardwareRadiobutton.UseVisualStyleBackColor = true;
            // 
            // phaseGroupBox
            // 
            this.phaseGroupBox.Controls.Add(this.radioButton11);
            this.phaseGroupBox.Controls.Add(this.radioButton10);
            this.phaseGroupBox.Controls.Add(this.radioButton9);
            this.phaseGroupBox.Controls.Add(this.radioButton7);
            this.phaseGroupBox.Controls.Add(this.radioButton6);
            this.phaseGroupBox.Location = new System.Drawing.Point(3, 46);
            this.phaseGroupBox.Name = "phaseGroupBox";
            this.phaseGroupBox.Size = new System.Drawing.Size(200, 43);
            this.phaseGroupBox.TabIndex = 41;
            this.phaseGroupBox.TabStop = false;
            this.phaseGroupBox.Text = "Phase";
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(162, 17);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(33, 17);
            this.radioButton11.TabIndex = 5;
            this.radioButton11.Text = "G";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(123, 17);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(33, 17);
            this.radioButton10.TabIndex = 4;
            this.radioButton10.Text = "N";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(86, 17);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(32, 17);
            this.radioButton9.TabIndex = 3;
            this.radioButton9.Text = "C";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(48, 17);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(32, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "B";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(10, 17);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(32, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "A";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // currentEntry
            // 
            this.currentEntry.Location = new System.Drawing.Point(7, 121);
            this.currentEntry.Name = "currentEntry";
            this.currentEntry.Size = new System.Drawing.Size(100, 20);
            this.currentEntry.TabIndex = 53;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel1.Controls.Add(label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.primaryLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.causeLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.secondaryLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 319);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(197, 100);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 33);
            label2.TabIndex = 10;
            label2.Text = "Primary";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 33);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 33);
            label4.TabIndex = 12;
            label4.Text = "Secondary";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(3, 66);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 34);
            label6.TabIndex = 14;
            label6.Text = "Cause";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // primaryLabel
            // 
            this.primaryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.primaryLabel.BackColor = System.Drawing.SystemColors.Info;
            this.primaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.primaryLabel.Location = new System.Drawing.Point(68, 5);
            this.primaryLabel.Margin = new System.Windows.Forms.Padding(3);
            this.primaryLabel.Name = "primaryLabel";
            this.primaryLabel.Size = new System.Drawing.Size(126, 23);
            this.primaryLabel.TabIndex = 11;
            this.primaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // causeLabel
            // 
            this.causeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.causeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.causeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.causeLabel.Location = new System.Drawing.Point(68, 71);
            this.causeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.causeLabel.Name = "causeLabel";
            this.causeLabel.Size = new System.Drawing.Size(126, 23);
            this.causeLabel.TabIndex = 20;
            this.causeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // secondaryLabel
            // 
            this.secondaryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondaryLabel.BackColor = System.Drawing.SystemColors.Info;
            this.secondaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondaryLabel.Location = new System.Drawing.Point(68, 38);
            this.secondaryLabel.Margin = new System.Windows.Forms.Padding(3);
            this.secondaryLabel.Name = "secondaryLabel";
            this.secondaryLabel.Size = new System.Drawing.Size(126, 23);
            this.secondaryLabel.TabIndex = 13;
            this.secondaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Location = new System.Drawing.Point(110, 293);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(94, 23);
            this.timeLabel.TabIndex = 51;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Current";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Trip Time (ms)";
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.SystemColors.Info;
            this.currentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentLabel.Location = new System.Drawing.Point(12, 293);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(92, 23);
            this.currentLabel.TabIndex = 49;
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Trip Current (A)";
            // 
            // cancelTestButton
            // 
            this.cancelTestButton.Location = new System.Drawing.Point(113, 105);
            this.cancelTestButton.Name = "cancelTestButton";
            this.cancelTestButton.Size = new System.Drawing.Size(100, 50);
            this.cancelTestButton.TabIndex = 54;
            this.cancelTestButton.Text = "Cancel Test";
            this.cancelTestButton.UseVisualStyleBackColor = true;
            // 
            // rmsNoTripButton
            // 
            this.rmsNoTripButton.Location = new System.Drawing.Point(113, 161);
            this.rmsNoTripButton.Name = "rmsNoTripButton";
            this.rmsNoTripButton.Size = new System.Drawing.Size(100, 50);
            this.rmsNoTripButton.TabIndex = 55;
            this.rmsNoTripButton.Text = "RMS with\r\nNo Trip";
            this.rmsNoTripButton.UseVisualStyleBackColor = true;
            // 
            // rmsWithTripButton
            // 
            this.rmsWithTripButton.Location = new System.Drawing.Point(7, 161);
            this.rmsWithTripButton.Name = "rmsWithTripButton";
            this.rmsWithTripButton.Size = new System.Drawing.Size(100, 50);
            this.rmsWithTripButton.TabIndex = 56;
            this.rmsWithTripButton.Text = "RMS with\r\nTrip";
            this.rmsWithTripButton.UseVisualStyleBackColor = true;
            // 
            // peakNoTripButton
            // 
            this.peakNoTripButton.Location = new System.Drawing.Point(113, 217);
            this.peakNoTripButton.Name = "peakNoTripButton";
            this.peakNoTripButton.Size = new System.Drawing.Size(100, 50);
            this.peakNoTripButton.TabIndex = 57;
            this.peakNoTripButton.Text = "Peak with\r\nNo Trip";
            this.peakNoTripButton.UseVisualStyleBackColor = true;
            // 
            // peakWithTripButton
            // 
            this.peakWithTripButton.Location = new System.Drawing.Point(7, 217);
            this.peakWithTripButton.Name = "peakWithTripButton";
            this.peakWithTripButton.Size = new System.Drawing.Size(100, 50);
            this.peakWithTripButton.TabIndex = 58;
            this.peakWithTripButton.Text = "Peak with\r\nTrip";
            this.peakWithTripButton.UseVisualStyleBackColor = true;
            // 
            // bindedDataSource1
            // 
            this.bindedDataSource1.AllowUserToAddRows = false;
            this.bindedDataSource1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.bindedDataSource1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bindedDataSource1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bindedDataSource1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bindedDataSource1.DefaultCellStyle = dataGridViewCellStyle2;
            this.bindedDataSource1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindedDataSource1.Location = new System.Drawing.Point(3, 434);
            this.bindedDataSource1.Name = "bindedDataSource1";
            this.bindedDataSource1.RowHeadersVisible = false;
            this.bindedDataSource1.Size = new System.Drawing.Size(972, 107);
            this.bindedDataSource1.Source = null;
            this.bindedDataSource1.TabIndex = 0;
            this.bindedDataSource1.typeOfData = StasaLibrary.DataFrames.BindedDataSource.TypeOfData.SI;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EventID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TimeOfEvent";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SubCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dccButton
            // 
            this.dccButton.Location = new System.Drawing.Point(578, 14);
            this.dccButton.Name = "dccButton";
            this.dccButton.paramGroup = null;
            this.dccButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.dccButton.Size = new System.Drawing.Size(120, 60);
            this.dccButton.TabIndex = 61;
            this.dccButton.Text = "Delta Counter Calibration";
            this.dccButton.UseVisualStyleBackColor = true;
            // 
            // bccButton
            // 
            this.bccButton.Location = new System.Drawing.Point(428, 14);
            this.bccButton.Name = "bccButton";
            this.bccButton.paramGroup = null;
            this.bccButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.bccButton.Size = new System.Drawing.Size(120, 60);
            this.bccButton.TabIndex = 60;
            this.bccButton.Text = "Base Counter Calibration";
            this.bccButton.UseVisualStyleBackColor = true;
            // 
            // csifButton
            // 
            this.csifButton.Location = new System.Drawing.Point(274, 14);
            this.csifButton.Name = "csifButton";
            this.csifButton.paramGroup = null;
            this.csifButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.csifButton.Size = new System.Drawing.Size(120, 60);
            this.csifButton.TabIndex = 59;
            this.csifButton.Text = "Clear Secondary Injection Factor";
            this.csifButton.UseVisualStyleBackColor = true;
            // 
            // SecondaryInjectionFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTL);
            this.Name = "SecondaryInjectionFrame";
            this.Size = new System.Drawing.Size(978, 544);
            this.mainTL.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.phaseGroupBox.ResumeLayout(false);
            this.phaseGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindedDataSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTL;
        private StasaLibrary.DataFrames.BindedDataSource bindedDataSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private StasaLibrary.DataFrames.ControlButton dccButton;
        private StasaLibrary.DataFrames.ControlButton bccButton;
        private StasaLibrary.DataFrames.ControlButton csifButton;
        private System.Windows.Forms.Button peakWithTripButton;
        private System.Windows.Forms.Button peakNoTripButton;
        private System.Windows.Forms.Button rmsWithTripButton;
        private System.Windows.Forms.Button rmsNoTripButton;
        private System.Windows.Forms.Button cancelTestButton;
        private System.Windows.Forms.TextBox currentEntry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label primaryLabel;
        private System.Windows.Forms.Label causeLabel;
        private System.Windows.Forms.Label secondaryLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox phaseGroupBox;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton simulatedRadiobutton;
        private System.Windows.Forms.RadioButton hardwareRadiobutton;
    }
}

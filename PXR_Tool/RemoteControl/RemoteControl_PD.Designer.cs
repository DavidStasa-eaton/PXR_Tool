
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
            this.resetEtuButton = new StasaLibrary.DataFrames.ControlButton();
            this.resetFunctionGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetFunctionGroupbox
            // 
            this.resetFunctionGroupbox.Controls.Add(this.resetEtuButton);
            this.resetFunctionGroupbox.Location = new System.Drawing.Point(3, 3);
            this.resetFunctionGroupbox.Name = "resetFunctionGroupbox";
            this.resetFunctionGroupbox.Size = new System.Drawing.Size(289, 275);
            this.resetFunctionGroupbox.TabIndex = 0;
            this.resetFunctionGroupbox.TabStop = false;
            this.resetFunctionGroupbox.Text = "Reset Functions";
            // 
            // resetEtuButton
            // 
            this.resetEtuButton.etuDevice = null;
            this.resetEtuButton.Location = new System.Drawing.Point(6, 19);
            this.resetEtuButton.Name = "resetEtuButton";
            this.resetEtuButton.paramGroup = null;
            this.resetEtuButton.requestType = StasaLibrary.DataFrames.ControlButton.RequestType.ActionCheck;
            this.resetEtuButton.Size = new System.Drawing.Size(277, 53);
            this.resetEtuButton.TabIndex = 0;
            this.resetEtuButton.Text = "Reset Trip Unit";
            this.resetEtuButton.UseVisualStyleBackColor = true;
            // 
            // RemoteControl_PD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetFunctionGroupbox);
            this.Name = "RemoteControl_PD";
            this.Size = new System.Drawing.Size(866, 501);
            this.Load += new System.EventHandler(this.RemoteControl_PD_Load);
            this.resetFunctionGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox resetFunctionGroupbox;
        private StasaLibrary.DataFrames.ControlButton resetEtuButton;
    }
}

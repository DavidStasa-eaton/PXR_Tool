
namespace PXR_Tool.Configuration
{
    partial class ConfigurationFrame_Tokyo
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
            this.etuGroupBox = new System.Windows.Forms.GroupBox();
            this.etuStyleFrame = new StasaLibrary.DataFrames.DropDownValueFrame();
            this.frameModuleGroupBox = new System.Windows.Forms.GroupBox();
            this.breakerGroupBox = new System.Windows.Forms.GroupBox();
            this.breakerRatingFrame = new StasaLibrary.DataFrames.DropDownValueFrame();
            this.etuGroupBox.SuspendLayout();
            this.breakerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // etuGroupBox
            // 
            this.etuGroupBox.Controls.Add(this.etuStyleFrame);
            this.etuGroupBox.Location = new System.Drawing.Point(3, 3);
            this.etuGroupBox.Name = "etuGroupBox";
            this.etuGroupBox.Size = new System.Drawing.Size(286, 157);
            this.etuGroupBox.TabIndex = 0;
            this.etuGroupBox.TabStop = false;
            this.etuGroupBox.Text = "Trip Unit";
            // 
            // etuStyleFrame
            // 
            this.etuStyleFrame.Location = new System.Drawing.Point(6, 19);
            this.etuStyleFrame.Name = "etuStyleFrame";
            this.etuStyleFrame.ParameterText = "Style";
            this.etuStyleFrame.ParameterWidth = 37F;
            this.etuStyleFrame.paramGroup = null;
            this.etuStyleFrame.ReadOnly = false;
            this.etuStyleFrame.requestType = StasaLibrary.DataFrames.DropDownValueFrame.RequestType.ActionCheck;
            this.etuStyleFrame.Size = new System.Drawing.Size(265, 40);
            this.etuStyleFrame.TabIndex = 0;
            this.etuStyleFrame.writeParamGroup = null;
            // 
            // frameModuleGroupBox
            // 
            this.frameModuleGroupBox.Location = new System.Drawing.Point(3, 166);
            this.frameModuleGroupBox.Name = "frameModuleGroupBox";
            this.frameModuleGroupBox.Size = new System.Drawing.Size(271, 100);
            this.frameModuleGroupBox.TabIndex = 1;
            this.frameModuleGroupBox.TabStop = false;
            this.frameModuleGroupBox.Text = "Frame Module";
            // 
            // breakerGroupBox
            // 
            this.breakerGroupBox.Controls.Add(this.breakerRatingFrame);
            this.breakerGroupBox.Location = new System.Drawing.Point(3, 272);
            this.breakerGroupBox.Name = "breakerGroupBox";
            this.breakerGroupBox.Size = new System.Drawing.Size(286, 160);
            this.breakerGroupBox.TabIndex = 2;
            this.breakerGroupBox.TabStop = false;
            this.breakerGroupBox.Text = "Breaker";
            // 
            // breakerRatingFrame
            // 
            this.breakerRatingFrame.Location = new System.Drawing.Point(6, 19);
            this.breakerRatingFrame.Name = "breakerRatingFrame";
            this.breakerRatingFrame.ParameterText = "Rating";
            this.breakerRatingFrame.ParameterWidth = 0F;
            this.breakerRatingFrame.paramGroup = null;
            this.breakerRatingFrame.ReadOnly = false;
            this.breakerRatingFrame.requestType = StasaLibrary.DataFrames.DropDownValueFrame.RequestType.ActionCheck;
            this.breakerRatingFrame.Size = new System.Drawing.Size(265, 40);
            this.breakerRatingFrame.TabIndex = 0;
            this.breakerRatingFrame.writeParamGroup = null;
            // 
            // ConfigurationFrame_Tokyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.breakerGroupBox);
            this.Controls.Add(this.frameModuleGroupBox);
            this.Controls.Add(this.etuGroupBox);
            this.Name = "ConfigurationFrame_Tokyo";
            this.Size = new System.Drawing.Size(612, 509);
            this.etuGroupBox.ResumeLayout(false);
            this.breakerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox etuGroupBox;
        private StasaLibrary.DataFrames.DropDownValueFrame etuStyleFrame;
        private System.Windows.Forms.GroupBox frameModuleGroupBox;
        private System.Windows.Forms.GroupBox breakerGroupBox;
        private StasaLibrary.DataFrames.DropDownValueFrame breakerRatingFrame;
    }
}

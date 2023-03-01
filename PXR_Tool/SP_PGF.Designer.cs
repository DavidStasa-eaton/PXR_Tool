
namespace PXR_Tool
{
    partial class SP_PGF
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
            this.lvFrame = new PXR_Tool.DataFrames.LabledValuesFrame();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lvFrame);
            this.groupBox.Controls.SetChildIndex(this.readButton, 0);
            this.groupBox.Controls.SetChildIndex(this.secondRefreshButton, 0);
            this.groupBox.Controls.SetChildIndex(this.writeButton, 0);
            this.groupBox.Controls.SetChildIndex(this.lvFrame, 0);
            // 
            // writeButton
            // 
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // readButton
            // 
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // lvFrame
            // 
            this.lvFrame.Columns = ((uint)(0u));
            this.lvFrame.Location = new System.Drawing.Point(6, 48);
            this.lvFrame.Name = "lvFrame";
            this.lvFrame.paramGroup = null;
            this.lvFrame.Rows = ((uint)(0u));
            this.lvFrame.Size = new System.Drawing.Size(328, 147);
            this.lvFrame.SplitIndex = ((uint)(0u));
            this.lvFrame.TabIndex = 3;
            // 
            // SP_PGF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SP_PGF";
            this.Load += new System.EventHandler(this.SP_PGF_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataFrames.LabledValuesFrame lvFrame;
    }
}

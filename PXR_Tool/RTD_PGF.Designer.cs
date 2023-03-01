
namespace PXR_Tool
{
    partial class RTD_PGF
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
            this.keyValuesDGV = new PXR_Tool.DataFrames.KeyValuesDGV();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.keyValuesDGV);
            this.groupBox.Controls.SetChildIndex(this.readButton, 0);
            this.groupBox.Controls.SetChildIndex(this.secondRefreshButton, 0);
            this.groupBox.Controls.SetChildIndex(this.writeButton, 0);
            this.groupBox.Controls.SetChildIndex(this.keyValuesDGV, 0);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(134, 18);
            // 
            // readButton
            // 
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // keyValuesDGV
            // 
            this.keyValuesDGV.Location = new System.Drawing.Point(6, 63);
            this.keyValuesDGV.Name = "keyValuesDGV";
            this.keyValuesDGV.paramGroup = null;
            this.keyValuesDGV.Size = new System.Drawing.Size(331, 126);
            this.keyValuesDGV.TabIndex = 4;
            // 
            // RTD_PGF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RTD_PGF";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataFrames.KeyValuesDGV keyValuesDGV;
    }
}

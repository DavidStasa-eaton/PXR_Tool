
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
            this.packPanel = new System.Windows.Forms.Panel();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.packPanel);
            this.groupBox.Controls.SetChildIndex(this.readButton, 0);
            this.groupBox.Controls.SetChildIndex(this.secondRefreshButton, 0);
            this.groupBox.Controls.SetChildIndex(this.writeButton, 0);
            this.groupBox.Controls.SetChildIndex(this.packPanel, 0);
            // 
            // writeButton
            // 
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // readButton
            // 
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // packPanel
            // 
            this.packPanel.Location = new System.Drawing.Point(6, 48);
            this.packPanel.Name = "packPanel";
            this.packPanel.Size = new System.Drawing.Size(328, 141);
            this.packPanel.TabIndex = 3;
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

        private System.Windows.Forms.Panel packPanel;
    }
}

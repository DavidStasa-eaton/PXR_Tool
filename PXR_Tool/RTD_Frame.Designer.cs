
namespace PXR_Tool
{
    partial class RTD_Frame
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
            this.rtdTabControl = new System.Windows.Forms.TabControl();
            this.rtdTabPageA = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtD_PGF1 = new PXR_Tool.RTD_PGF();
            this.rtD_PGF2 = new PXR_Tool.RTD_PGF();
            this.rtD_PGF3 = new PXR_Tool.RTD_PGF();
            this.rtdTabControl.SuspendLayout();
            this.rtdTabPageA.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtdTabControl
            // 
            this.rtdTabControl.Controls.Add(this.rtdTabPageA);
            this.rtdTabControl.Controls.Add(this.tabPage2);
            this.rtdTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtdTabControl.Location = new System.Drawing.Point(0, 0);
            this.rtdTabControl.Name = "rtdTabControl";
            this.rtdTabControl.SelectedIndex = 0;
            this.rtdTabControl.Size = new System.Drawing.Size(1107, 499);
            this.rtdTabControl.TabIndex = 0;
            // 
            // rtdTabPageA
            // 
            this.rtdTabPageA.BackColor = System.Drawing.Color.Silver;
            this.rtdTabPageA.Controls.Add(this.rtD_PGF3);
            this.rtdTabPageA.Controls.Add(this.rtD_PGF2);
            this.rtdTabPageA.Controls.Add(this.rtD_PGF1);
            this.rtdTabPageA.Location = new System.Drawing.Point(4, 22);
            this.rtdTabPageA.Name = "rtdTabPageA";
            this.rtdTabPageA.Padding = new System.Windows.Forms.Padding(3);
            this.rtdTabPageA.Size = new System.Drawing.Size(1099, 473);
            this.rtdTabPageA.TabIndex = 0;
            this.rtdTabPageA.Text = "Groups 0, 1, 10";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtD_PGF1
            // 
            this.rtD_PGF1.BufferByte = ((byte)(0));
            this.rtD_PGF1.Location = new System.Drawing.Point(6, 6);
            this.rtD_PGF1.Name = "rtD_PGF1";
            this.rtD_PGF1.Size = new System.Drawing.Size(695, 195);
            this.rtD_PGF1.TabIndex = 0;
            // 
            // rtD_PGF2
            // 
            this.rtD_PGF2.BufferByte = ((byte)(1));
            this.rtD_PGF2.Location = new System.Drawing.Point(6, 207);
            this.rtD_PGF2.Name = "rtD_PGF2";
            this.rtD_PGF2.Size = new System.Drawing.Size(211, 195);
            this.rtD_PGF2.TabIndex = 1;
            // 
            // rtD_PGF3
            // 
            this.rtD_PGF3.BufferByte = ((byte)(10));
            this.rtD_PGF3.Location = new System.Drawing.Point(490, 207);
            this.rtD_PGF3.Name = "rtD_PGF3";
            this.rtD_PGF3.Size = new System.Drawing.Size(211, 195);
            this.rtD_PGF3.TabIndex = 2;
            // 
            // RTD_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtdTabControl);
            this.Name = "RTD_Frame";
            this.Size = new System.Drawing.Size(1107, 499);
            this.rtdTabControl.ResumeLayout(false);
            this.rtdTabPageA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl rtdTabControl;
        private System.Windows.Forms.TabPage rtdTabPageA;
        private System.Windows.Forms.TabPage tabPage2;
        private RTD_PGF rtD_PGF1;
        private RTD_PGF rtD_PGF2;
        private RTD_PGF rtD_PGF3;
    }
}

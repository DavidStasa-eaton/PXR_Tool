
namespace PXR_Tool
{
    partial class ParameterGroupFrame
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.secondRefreshButton = new System.Windows.Forms.CheckBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.writeButton);
            this.groupBox.Controls.Add(this.secondRefreshButton);
            this.groupBox.Controls.Add(this.readButton);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(340, 195);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Parameter Group";
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(264, 19);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(70, 23);
            this.writeButton.TabIndex = 1;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(6, 19);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(69, 23);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            // 
            // secondRefreshButton
            // 
            this.secondRefreshButton.AutoSize = true;
            this.secondRefreshButton.Location = new System.Drawing.Point(79, 22);
            this.secondRefreshButton.Name = "secondRefreshButton";
            this.secondRefreshButton.Size = new System.Drawing.Size(49, 17);
            this.secondRefreshButton.TabIndex = 2;
            this.secondRefreshButton.Text = "1s ⟳";
            this.secondRefreshButton.UseVisualStyleBackColor = true;
            // 
            // ParameterGroupFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "ParameterGroupFrame";
            this.Size = new System.Drawing.Size(340, 195);
            this.Load += new System.EventHandler(this.ParameterGroupFrame_Load);
            this.SizeChanged += new System.EventHandler(this.ParameterGroupFrame_SizeChanged);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.GroupBox groupBox;
        protected System.Windows.Forms.Button writeButton;
        protected System.Windows.Forms.Button readButton;
        protected System.Windows.Forms.CheckBox secondRefreshButton;
    }
}

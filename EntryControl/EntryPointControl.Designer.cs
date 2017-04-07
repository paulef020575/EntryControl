namespace EntryControl
{
    partial class EntryPointControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPointControl));
            this.labelPointName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.changeStaffTool = new System.Windows.Forms.ToolStripButton();
            this.lboxStaff = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPointName
            // 
            this.labelPointName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPointName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPointName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPointName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPointName.Location = new System.Drawing.Point(0, 0);
            this.labelPointName.Name = "labelPointName";
            this.labelPointName.Padding = new System.Windows.Forms.Padding(5);
            this.labelPointName.Size = new System.Drawing.Size(350, 35);
            this.labelPointName.TabIndex = 0;
            this.labelPointName.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeStaffTool});
            this.toolStrip1.Location = new System.Drawing.Point(326, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 85);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // changeStaffTool
            // 
            this.changeStaffTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.changeStaffTool.Image = ((System.Drawing.Image)(resources.GetObject("changeStaffTool.Image")));
            this.changeStaffTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeStaffTool.Name = "changeStaffTool";
            this.changeStaffTool.Size = new System.Drawing.Size(21, 20);
            this.changeStaffTool.Text = "заменить";
            // 
            // lboxStaff
            // 
            this.lboxStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxStaff.FormattingEnabled = true;
            this.lboxStaff.Location = new System.Drawing.Point(0, 35);
            this.lboxStaff.Name = "lboxStaff";
            this.lboxStaff.Size = new System.Drawing.Size(326, 85);
            this.lboxStaff.TabIndex = 2;
            // 
            // EntryPointControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lboxStaff);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelPointName);
            this.Name = "EntryPointControl";
            this.Size = new System.Drawing.Size(350, 120);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPointName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton changeStaffTool;
        private System.Windows.Forms.ListBox lboxStaff;
    }
}

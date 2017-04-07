namespace EntryControl
{
    partial class CargoItemForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tblPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.tblPanel);
            // 
            // tblPanel
            // 
            this.tblPanel.ColumnCount = 2;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Controls.Add(this.lbl, 0, 0);
            this.tblPanel.Controls.Add(this.tboxName, 1, 0);
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.Padding = new System.Windows.Forms.Padding(5);
            this.tblPanel.RowCount = 2;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Size = new System.Drawing.Size(551, 337);
            this.tblPanel.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl.Location = new System.Drawing.Point(8, 5);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(83, 26);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Наименование";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxName
            // 
            this.tboxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxName.Location = new System.Drawing.Point(97, 8);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(446, 20);
            this.tboxName.TabIndex = 1;
            // 
            // CargoItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 372);
            this.Name = "CargoItemForm";
            this.Text = "CargoItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tboxName;
    }
}
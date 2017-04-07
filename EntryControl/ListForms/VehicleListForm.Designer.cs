namespace EntryControl
{
    partial class VehicleListForm
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
            this.lblContractor = new System.Windows.Forms.Label();
            this.rboxContractor = new EntryControl.ReferenceBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rboxMark = new EntryControl.ReferenceBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.tboxLicense = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Size = new System.Drawing.Size(825, 393);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(0, 425);
            this.pnlBottom.Size = new System.Drawing.Size(825, 35);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tboxLicense);
            this.pnlTop.Controls.Add(this.lblLicense);
            this.pnlTop.Controls.Add(this.rboxMark);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.rboxContractor);
            this.pnlTop.Controls.Add(this.lblContractor);
            this.pnlTop.Size = new System.Drawing.Size(825, 32);
            // 
            // lblContractor
            // 
            this.lblContractor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblContractor.Location = new System.Drawing.Point(5, 5);
            this.lblContractor.Name = "lblContractor";
            this.lblContractor.Size = new System.Drawing.Size(81, 22);
            this.lblContractor.TabIndex = 0;
            this.lblContractor.Text = "Перевозчик";
            this.lblContractor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rboxContractor
            // 
            this.rboxContractor.Database = null;
            this.rboxContractor.DataSource = null;
            this.rboxContractor.Dock = System.Windows.Forms.DockStyle.Left;
            this.rboxContractor.ListForm = "EntryControl.ContractorListForm";
            this.rboxContractor.Location = new System.Drawing.Point(86, 5);
            this.rboxContractor.Name = "rboxContractor";
            this.rboxContractor.SelectedItem = null;
            this.rboxContractor.Size = new System.Drawing.Size(184, 22);
            this.rboxContractor.TabIndex = 1;
            this.rboxContractor.GetList += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxContractor_GetList);
            this.rboxContractor.ShowListForm += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxContractor_ShowListForm);
            this.rboxContractor.SelectedItemChanged += new System.EventHandler(this.rboxContractor_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(270, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Марка т/с";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rboxMark
            // 
            this.rboxMark.Database = null;
            this.rboxMark.DataSource = null;
            this.rboxMark.Dock = System.Windows.Forms.DockStyle.Left;
            this.rboxMark.ListForm = "EntryControl.MarkListForm";
            this.rboxMark.Location = new System.Drawing.Point(343, 5);
            this.rboxMark.Name = "rboxMark";
            this.rboxMark.SelectedItem = null;
            this.rboxMark.Size = new System.Drawing.Size(171, 22);
            this.rboxMark.TabIndex = 3;
            this.rboxMark.GetList += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxMark_GetList);
            this.rboxMark.SelectedItemChanged += new System.EventHandler(this.rboxContractor_SelectedItemChanged);
            // 
            // lblLicense
            // 
            this.lblLicense.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLicense.Location = new System.Drawing.Point(514, 5);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(82, 22);
            this.lblLicense.TabIndex = 4;
            this.lblLicense.Text = "Гос. номер";
            this.lblLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxLicense
            // 
            this.tboxLicense.Dock = System.Windows.Forms.DockStyle.Left;
            this.tboxLicense.Location = new System.Drawing.Point(596, 5);
            this.tboxLicense.Name = "tboxLicense";
            this.tboxLicense.Size = new System.Drawing.Size(100, 20);
            this.tboxLicense.TabIndex = 5;
            this.tboxLicense.TextChanged += new System.EventHandler(this.rboxContractor_SelectedItemChanged);
            // 
            // VehicleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 460);
            this.EditItemForm = "EntryControl.VehicleItemForm";
            this.Name = "VehicleListForm";
            this.Text = "Справочник транспортных средств";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReferenceBox rboxContractor;
        private System.Windows.Forms.Label lblContractor;
        private ReferenceBox rboxMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.TextBox tboxLicense;
    }
}
namespace EntryControl
{
    partial class ContractorListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxContractorGroup = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cboxContractorGroup);
            this.pnlTop.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxContractorGroup
            // 
            this.cboxContractorGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboxContractorGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxContractorGroup.FormattingEnabled = true;
            this.cboxContractorGroup.Location = new System.Drawing.Point(57, 5);
            this.cboxContractorGroup.Name = "cboxContractorGroup";
            this.cboxContractorGroup.Size = new System.Drawing.Size(179, 21);
            this.cboxContractorGroup.TabIndex = 2;
            this.cboxContractorGroup.SelectedIndexChanged += new System.EventHandler(this.cboxContractorGroup_SelectedIndexChanged);
            // 
            // ContractorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 366);
            this.EditItemForm = "EntryControl.ContractorItemForm";
            this.Name = "ContractorListForm";
            this.Text = "Справочник контрагентов";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxContractorGroup;
        private System.Windows.Forms.Label label1;
    }
}
namespace EntryControl
{
    partial class ContractorItemForm
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
            this.dgvContractorGroup = new System.Windows.Forms.DataGridView();
            this.ColumnContractorGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsIncluded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxShortName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.ColumnContactType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContactValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tblPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractorGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.tblPanel);
            // 
            // tblPanel
            // 
            this.tblPanel.ColumnCount = 2;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tblPanel.Controls.Add(this.dgvContractorGroup, 0, 3);
            this.tblPanel.Controls.Add(this.label1, 0, 0);
            this.tblPanel.Controls.Add(this.tboxShortName, 1, 0);
            this.tblPanel.Controls.Add(this.label2, 0, 1);
            this.tblPanel.Controls.Add(this.tboxName, 1, 1);
            this.tblPanel.Controls.Add(this.label3, 0, 2);
            this.tblPanel.Controls.Add(this.label4, 1, 2);
            this.tblPanel.Controls.Add(this.dgvContactList, 1, 3);
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.RowCount = 4;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanel.Size = new System.Drawing.Size(551, 337);
            this.tblPanel.TabIndex = 0;
            // 
            // dgvContractorGroup
            // 
            this.dgvContractorGroup.AllowUserToAddRows = false;
            this.dgvContractorGroup.AllowUserToDeleteRows = false;
            this.dgvContractorGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContractorGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractorGroup.ColumnHeadersVisible = false;
            this.dgvContractorGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContractorGroup,
            this.ColumnIsIncluded});
            this.dgvContractorGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContractorGroup.Location = new System.Drawing.Point(3, 75);
            this.dgvContractorGroup.MultiSelect = false;
            this.dgvContractorGroup.Name = "dgvContractorGroup";
            this.dgvContractorGroup.RowHeadersVisible = false;
            this.dgvContractorGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractorGroup.Size = new System.Drawing.Size(175, 259);
            this.dgvContractorGroup.TabIndex = 5;
            this.dgvContractorGroup.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvContractorGroup_CellBeginEdit);
            // 
            // ColumnContractorGroup
            // 
            this.ColumnContractorGroup.DataPropertyName = "Group";
            this.ColumnContractorGroup.HeaderText = "группа";
            this.ColumnContractorGroup.Name = "ColumnContractorGroup";
            this.ColumnContractorGroup.ReadOnly = true;
            // 
            // ColumnIsIncluded
            // 
            this.ColumnIsIncluded.DataPropertyName = "IsIncluded";
            this.ColumnIsIncluded.FillWeight = 25F;
            this.ColumnIsIncluded.HeaderText = "вкл";
            this.ColumnIsIncluded.Name = "ColumnIsIncluded";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Краткое наименование";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxShortName
            // 
            this.tboxShortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxShortName.Location = new System.Drawing.Point(184, 3);
            this.tboxShortName.Name = "tboxShortName";
            this.tboxShortName.Size = new System.Drawing.Size(364, 20);
            this.tboxShortName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Полное наименование";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxName
            // 
            this.tboxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxName.Location = new System.Drawing.Point(184, 29);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(364, 20);
            this.tboxName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Группы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(184, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Контактная информация";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgvContactList
            // 
            this.dgvContactList.AllowUserToAddRows = false;
            this.dgvContactList.AllowUserToDeleteRows = false;
            this.dgvContactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.ColumnHeadersVisible = false;
            this.dgvContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContactType,
            this.ColumnContactValue});
            this.dgvContactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContactList.Location = new System.Drawing.Point(184, 75);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.RowHeadersVisible = false;
            this.dgvContactList.Size = new System.Drawing.Size(364, 259);
            this.dgvContactList.TabIndex = 8;
            this.dgvContactList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvContractorGroup_CellBeginEdit);
            // 
            // ColumnContactType
            // 
            this.ColumnContactType.DataPropertyName = "ContactType";
            this.ColumnContactType.FillWeight = 25F;
            this.ColumnContactType.HeaderText = "тип контакта";
            this.ColumnContactType.Name = "ColumnContactType";
            this.ColumnContactType.ReadOnly = true;
            // 
            // ColumnContactValue
            // 
            this.ColumnContactValue.DataPropertyName = "ContactValue";
            this.ColumnContactValue.HeaderText = "Значение";
            this.ColumnContactValue.Name = "ColumnContactValue";
            // 
            // ContractorItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 372);
            this.Name = "ContractorItemForm";
            this.Text = "ContractorItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractorGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxShortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.DataGridView dgvContractorGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContractorGroup;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsIncluded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContactType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContactValue;
    }
}
namespace EntryControl
{
    partial class VehicleItemForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleItemForm));
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMark = new System.Windows.Forms.Panel();
            this.tboxVehicleMark = new System.Windows.Forms.TextBox();
            this.btnSelectVehicleMark = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxLicensePlate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlOwners = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnContractor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOwnerList = new System.Windows.Forms.BindingSource(this.components);
            this.ownerListTools = new System.Windows.Forms.ToolStrip();
            this.addItemTool = new System.Windows.Forms.ToolStripButton();
            this.editItemTool = new System.Windows.Forms.ToolStripButton();
            this.deleteItemTool = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tblPanel.SuspendLayout();
            this.pnlMark.SuspendLayout();
            this.pnlOwners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOwnerList)).BeginInit();
            this.ownerListTools.SuspendLayout();
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
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel.Controls.Add(this.label1, 0, 0);
            this.tblPanel.Controls.Add(this.pnlMark, 1, 0);
            this.tblPanel.Controls.Add(this.label2, 0, 1);
            this.tblPanel.Controls.Add(this.tboxLicensePlate, 1, 1);
            this.tblPanel.Controls.Add(this.label3, 0, 2);
            this.tblPanel.Controls.Add(this.pnlOwners, 0, 3);
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.Padding = new System.Windows.Forms.Padding(10);
            this.tblPanel.RowCount = 4;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblPanel.Size = new System.Drawing.Size(551, 337);
            this.tblPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка Т/С";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMark
            // 
            this.pnlMark.Controls.Add(this.tboxVehicleMark);
            this.pnlMark.Controls.Add(this.btnSelectVehicleMark);
            this.pnlMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMark.Location = new System.Drawing.Point(93, 13);
            this.pnlMark.Name = "pnlMark";
            this.pnlMark.Size = new System.Drawing.Size(445, 22);
            this.pnlMark.TabIndex = 1;
            // 
            // tboxVehicleMark
            // 
            this.tboxVehicleMark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxVehicleMark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxVehicleMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxVehicleMark.Location = new System.Drawing.Point(0, 0);
            this.tboxVehicleMark.Name = "tboxVehicleMark";
            this.tboxVehicleMark.Size = new System.Drawing.Size(420, 20);
            this.tboxVehicleMark.TabIndex = 1;
            this.tboxVehicleMark.Validating += new System.ComponentModel.CancelEventHandler(this.tboxVehicleMark_Validating);
            // 
            // btnSelectVehicleMark
            // 
            this.btnSelectVehicleMark.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectVehicleMark.Location = new System.Drawing.Point(420, 0);
            this.btnSelectVehicleMark.Name = "btnSelectVehicleMark";
            this.btnSelectVehicleMark.Size = new System.Drawing.Size(25, 22);
            this.btnSelectVehicleMark.TabIndex = 0;
            this.btnSelectVehicleMark.TabStop = false;
            this.btnSelectVehicleMark.Text = "...";
            this.btnSelectVehicleMark.UseVisualStyleBackColor = true;
            this.btnSelectVehicleMark.Click += new System.EventHandler(this.btnSelectVehicleMark_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Гос. номер";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxLicensePlate
            // 
            this.tboxLicensePlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxLicensePlate.Location = new System.Drawing.Point(93, 41);
            this.tboxLicensePlate.Name = "tboxLicensePlate";
            this.tboxLicensePlate.Size = new System.Drawing.Size(445, 20);
            this.tboxLicensePlate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Перевозчики";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pnlOwners
            // 
            this.tblPanel.SetColumnSpan(this.pnlOwners, 2);
            this.pnlOwners.Controls.Add(this.dataGridView1);
            this.pnlOwners.Controls.Add(this.ownerListTools);
            this.pnlOwners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOwners.Location = new System.Drawing.Point(13, 87);
            this.pnlOwners.Name = "pnlOwners";
            this.pnlOwners.Size = new System.Drawing.Size(525, 237);
            this.pnlOwners.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContractor,
            this.ColumnDateFrom});
            this.dataGridView1.DataSource = this.bsOwnerList;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(525, 212);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnContractor
            // 
            this.ColumnContractor.DataPropertyName = "Contractor";
            this.ColumnContractor.HeaderText = "Владелец";
            this.ColumnContractor.Name = "ColumnContractor";
            this.ColumnContractor.ReadOnly = true;
            this.ColumnContractor.Width = 200;
            // 
            // ColumnDateFrom
            // 
            this.ColumnDateFrom.DataPropertyName = "DateFrom";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnDateFrom.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDateFrom.HeaderText = "Дата получения";
            this.ColumnDateFrom.Name = "ColumnDateFrom";
            this.ColumnDateFrom.ReadOnly = true;
            // 
            // ownerListTools
            // 
            this.ownerListTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemTool,
            this.editItemTool,
            this.deleteItemTool});
            this.ownerListTools.Location = new System.Drawing.Point(0, 0);
            this.ownerListTools.Name = "ownerListTools";
            this.ownerListTools.Size = new System.Drawing.Size(525, 25);
            this.ownerListTools.TabIndex = 0;
            this.ownerListTools.Text = "toolStrip1";
            // 
            // addItemTool
            // 
            this.addItemTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addItemTool.Image = ((System.Drawing.Image)(resources.GetObject("addItemTool.Image")));
            this.addItemTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addItemTool.Name = "addItemTool";
            this.addItemTool.Size = new System.Drawing.Size(23, 22);
            this.addItemTool.Text = "добавить";
            this.addItemTool.Click += new System.EventHandler(this.addItemTool_Click);
            // 
            // editItemTool
            // 
            this.editItemTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editItemTool.Image = ((System.Drawing.Image)(resources.GetObject("editItemTool.Image")));
            this.editItemTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editItemTool.Name = "editItemTool";
            this.editItemTool.Size = new System.Drawing.Size(23, 22);
            this.editItemTool.Text = "изменить";
            this.editItemTool.Click += new System.EventHandler(this.editItemTool_Click);
            // 
            // deleteItemTool
            // 
            this.deleteItemTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteItemTool.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemTool.Image")));
            this.deleteItemTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteItemTool.Name = "deleteItemTool";
            this.deleteItemTool.Size = new System.Drawing.Size(23, 22);
            this.deleteItemTool.Text = "удалить";
            this.deleteItemTool.Click += new System.EventHandler(this.deleteItemTool_Click);
            // 
            // VehicleItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 372);
            this.Name = "VehicleItemForm";
            this.Text = "VehicleItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            this.pnlMark.ResumeLayout(false);
            this.pnlMark.PerformLayout();
            this.pnlOwners.ResumeLayout(false);
            this.pnlOwners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOwnerList)).EndInit();
            this.ownerListTools.ResumeLayout(false);
            this.ownerListTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMark;
        private System.Windows.Forms.TextBox tboxVehicleMark;
        private System.Windows.Forms.Button btnSelectVehicleMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxLicensePlate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlOwners;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContractor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateFrom;
        private System.Windows.Forms.ToolStrip ownerListTools;
        private System.Windows.Forms.ToolStripButton addItemTool;
        private System.Windows.Forms.BindingSource bsOwnerList;
        private System.Windows.Forms.ToolStripButton editItemTool;
        private System.Windows.Forms.ToolStripButton deleteItemTool;
    }
}
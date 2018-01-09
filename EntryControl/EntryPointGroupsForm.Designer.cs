namespace EntryControl
{
    partial class EntryPointGroupsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.ColumnGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeleteGroup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bsGroups = new System.Windows.Forms.BindingSource(this.components);
            this.pnl = new System.Windows.Forms.Panel();
            this.tboxNewGroup = new System.Windows.Forms.TextBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.dgbPointList = new System.Windows.Forms.DataGridView();
            this.ColumnCheckPoint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnEntryPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGroupList = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.panelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroups)).BeginInit();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPointList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlBottom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelGroups, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgbPointList, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pnlBottom, 3);
            this.pnlBottom.Controls.Add(this.btnOk);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(3, 361);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBottom.Size = new System.Drawing.Size(730, 35);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(425, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(525, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(625, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelGroups
            // 
            this.panelGroups.Controls.Add(this.dgvGroups);
            this.panelGroups.Controls.Add(this.pnl);
            this.panelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroups.Location = new System.Drawing.Point(3, 3);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(352, 352);
            this.panelGroups.TabIndex = 1;
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AutoGenerateColumns = false;
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.ColumnHeadersVisible = false;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGroupName,
            this.ColumnDeleteGroup});
            this.dgvGroups.DataSource = this.bsGroups;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.Location = new System.Drawing.Point(0, 0);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.RowHeadersWidth = 25;
            this.dgvGroups.Size = new System.Drawing.Size(352, 325);
            this.dgvGroups.TabIndex = 1;
            this.dgvGroups.VirtualMode = true;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellContentClick);
            this.dgvGroups.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvGroups_CellValueNeeded);
            // 
            // ColumnGroupName
            // 
            this.ColumnGroupName.HeaderText = "Value";
            this.ColumnGroupName.Name = "ColumnGroupName";
            this.ColumnGroupName.ReadOnly = true;
            // 
            // ColumnDeleteGroup
            // 
            this.ColumnDeleteGroup.FillWeight = 25F;
            this.ColumnDeleteGroup.HeaderText = "x";
            this.ColumnDeleteGroup.Name = "ColumnDeleteGroup";
            this.ColumnDeleteGroup.ReadOnly = true;
            this.ColumnDeleteGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDeleteGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDeleteGroup.Text = "x";
            this.ColumnDeleteGroup.ToolTipText = "удалить группу";
            this.ColumnDeleteGroup.UseColumnTextForButtonValue = true;
            // 
            // bsGroups
            // 
            this.bsGroups.CurrentChanged += new System.EventHandler(this.bsGroups_CurrentChanged);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.tboxNewGroup);
            this.pnl.Controls.Add(this.btnAddGroup);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl.Location = new System.Drawing.Point(0, 325);
            this.pnl.Name = "pnl";
            this.pnl.Padding = new System.Windows.Forms.Padding(3);
            this.pnl.Size = new System.Drawing.Size(352, 27);
            this.pnl.TabIndex = 0;
            // 
            // tboxNewGroup
            // 
            this.tboxNewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxNewGroup.Location = new System.Drawing.Point(3, 3);
            this.tboxNewGroup.Name = "tboxNewGroup";
            this.tboxNewGroup.Size = new System.Drawing.Size(246, 20);
            this.tboxNewGroup.TabIndex = 1;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddGroup.Location = new System.Drawing.Point(249, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(100, 21);
            this.btnAddGroup.TabIndex = 0;
            this.btnAddGroup.Text = "добавить";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // dgbPointList
            // 
            this.dgbPointList.AllowUserToAddRows = false;
            this.dgbPointList.AllowUserToDeleteRows = false;
            this.dgbPointList.AutoGenerateColumns = false;
            this.dgbPointList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbPointList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbPointList.ColumnHeadersVisible = false;
            this.dgbPointList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheckPoint,
            this.ColumnEntryPoint});
            this.dgbPointList.DataSource = this.bsGroupList;
            this.dgbPointList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbPointList.Location = new System.Drawing.Point(381, 3);
            this.dgbPointList.Name = "dgbPointList";
            this.dgbPointList.RowHeadersWidth = 25;
            this.dgbPointList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbPointList.Size = new System.Drawing.Size(352, 352);
            this.dgbPointList.TabIndex = 2;
            // 
            // ColumnCheckPoint
            // 
            this.ColumnCheckPoint.DataPropertyName = "IsIncluded";
            this.ColumnCheckPoint.FillWeight = 25F;
            this.ColumnCheckPoint.HeaderText = "вкл";
            this.ColumnCheckPoint.Name = "ColumnCheckPoint";
            // 
            // ColumnEntryPoint
            // 
            this.ColumnEntryPoint.DataPropertyName = "EntryPoint";
            this.ColumnEntryPoint.HeaderText = "оччка";
            this.ColumnEntryPoint.Name = "ColumnEntryPoint";
            this.ColumnEntryPoint.ReadOnly = true;
            // 
            // EntryPointGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EntryPointGroupsForm";
            this.Text = "Группы проходных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryPointGroupsForm_FormClosing);
            this.Load += new System.EventHandler(this.EntryPointGroupsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.panelGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroups)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPointList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.BindingSource bsGroups;
        private System.Windows.Forms.BindingSource bsGroupList;
        private System.Windows.Forms.TextBox tboxNewGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.DataGridView dgbPointList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheckPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEntryPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupName;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeleteGroup;
    }
}
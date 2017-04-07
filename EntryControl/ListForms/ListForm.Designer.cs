namespace EntryControl
{
    partial class ListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.listToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolAddItem = new System.Windows.Forms.ToolStripButton();
            this.toolEditItem = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSearch = new System.Windows.Forms.ToolStripLabel();
            this.tboxSearchTool = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.listToolStrip.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvList);
            this.pnlData.Controls.Add(this.listToolStrip);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 32);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(722, 299);
            this.pnlData.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.DataSource = this.bsList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 27);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(722, 272);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            this.dgvList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellEnter);
            this.dgvList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvList_CellPainting);
            this.dgvList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvList_KeyPress);
            // 
            // listToolStrip
            // 
            this.listToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddItem,
            this.toolEditItem,
            this.toolDeleteItem,
            this.toolStripSeparator1,
            this.toolRefresh,
            this.toolStripSeparator2,
            this.lblSearch,
            this.tboxSearchTool,
            this.toolStripButton1});
            this.listToolStrip.Location = new System.Drawing.Point(0, 0);
            this.listToolStrip.Name = "listToolStrip";
            this.listToolStrip.Size = new System.Drawing.Size(722, 27);
            this.listToolStrip.TabIndex = 0;
            this.listToolStrip.Text = "toolStrip1";
            // 
            // toolAddItem
            // 
            this.toolAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddItem.Image = ((System.Drawing.Image)(resources.GetObject("toolAddItem.Image")));
            this.toolAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddItem.Name = "toolAddItem";
            this.toolAddItem.Size = new System.Drawing.Size(23, 24);
            this.toolAddItem.Text = "добавить";
            this.toolAddItem.Click += new System.EventHandler(this.toolAddItem_Click);
            // 
            // toolEditItem
            // 
            this.toolEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditItem.Image = ((System.Drawing.Image)(resources.GetObject("toolEditItem.Image")));
            this.toolEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditItem.Name = "toolEditItem";
            this.toolEditItem.Size = new System.Drawing.Size(23, 24);
            this.toolEditItem.Text = "изменить";
            this.toolEditItem.Click += new System.EventHandler(this.toolEditItem_Click);
            // 
            // toolDeleteItem
            // 
            this.toolDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("toolDeleteItem.Image")));
            this.toolDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteItem.Name = "toolDeleteItem";
            this.toolDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.toolDeleteItem.Text = "удалить";
            this.toolDeleteItem.Click += new System.EventHandler(this.toolDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolRefresh
            // 
            this.toolRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolRefresh.Image")));
            this.toolRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRefresh.Name = "toolRefresh";
            this.toolRefresh.Size = new System.Drawing.Size(23, 24);
            this.toolRefresh.Text = "обновить";
            this.toolRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = false;
            this.lblSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblSearch.Image = ((System.Drawing.Image)(resources.GetObject("lblSearch.Image")));
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(24, 24);
            this.lblSearch.Text = "поиск";
            // 
            // tboxSearchTool
            // 
            this.tboxSearchTool.Name = "tboxSearchTool";
            this.tboxSearchTool.Size = new System.Drawing.Size(100, 27);
            this.tboxSearchTool.TextChanged += new System.EventHandler(this.tboxSearchTool_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton1.Text = "найти следующий";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTop.Size = new System.Drawing.Size(722, 32);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.TabStop = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 331);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBottom.Size = new System.Drawing.Size(722, 35);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(517, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(617, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 366);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.listToolStrip.ResumeLayout(false);
            this.listToolStrip.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Panel pnlData;
        protected System.Windows.Forms.Panel pnlBottom;
        protected System.Windows.Forms.Panel pnlTop;
        protected System.Windows.Forms.BindingSource bsList;
        private System.Windows.Forms.DataGridView dgvList;
        protected System.Windows.Forms.ToolStrip listToolStrip;
        private System.Windows.Forms.ToolStripButton toolAddItem;
        private System.Windows.Forms.ToolStripButton toolEditItem;
        private System.Windows.Forms.ToolStripButton toolDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tboxSearchTool;
        private System.Windows.Forms.ToolStripLabel lblSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        protected System.Windows.Forms.Button btnOK;
    }
}
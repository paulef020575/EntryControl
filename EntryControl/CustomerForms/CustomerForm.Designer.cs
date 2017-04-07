namespace EntryControl
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.addNewTool = new System.Windows.Forms.ToolStripButton();
            this.editCurrentTool = new System.Windows.Forms.ToolStripButton();
            this.deleteCurrentTool = new System.Windows.Forms.ToolStripButton();
            this.lblSecToRefresh = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordTool = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.appointListTree = new System.Windows.Forms.TreeView();
            this.treeImageList = new System.Windows.Forms.ImageList(this.components);
            this.panelSearch = new System.Windows.Forms.Panel();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlNext = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bgCheckLastModifiedDate = new System.ComponentModel.BackgroundWorker();
            this.bgRefreshAppointList = new System.ComponentModel.BackgroundWorker();
            this.bgSetAppointSeen = new System.ComponentModel.BackgroundWorker();
            this.mainToolStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.pnlNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTool,
            this.editCurrentTool,
            this.deleteCurrentTool,
            this.lblSecToRefresh,
            this.toolStripSeparator1,
            this.refreshTool,
            this.toolStripSeparator2,
            this.printTool,
            this.toolStripSeparator3,
            this.changePasswordTool});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(796, 54);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // addNewTool
            // 
            this.addNewTool.Image = ((System.Drawing.Image)(resources.GetObject("addNewTool.Image")));
            this.addNewTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewTool.Name = "addNewTool";
            this.addNewTool.Size = new System.Drawing.Size(81, 51);
            this.addNewTool.Text = "новая заявка";
            this.addNewTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addNewTool.Click += new System.EventHandler(this.addNewTool_Click);
            // 
            // editCurrentTool
            // 
            this.editCurrentTool.Image = ((System.Drawing.Image)(resources.GetObject("editCurrentTool.Image")));
            this.editCurrentTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCurrentTool.Name = "editCurrentTool";
            this.editCurrentTool.Size = new System.Drawing.Size(63, 51);
            this.editCurrentTool.Text = "изменить";
            this.editCurrentTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editCurrentTool.Click += new System.EventHandler(this.editCurrentTool_Click);
            // 
            // deleteCurrentTool
            // 
            this.deleteCurrentTool.Image = ((System.Drawing.Image)(resources.GetObject("deleteCurrentTool.Image")));
            this.deleteCurrentTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteCurrentTool.Name = "deleteCurrentTool";
            this.deleteCurrentTool.Size = new System.Drawing.Size(54, 51);
            this.deleteCurrentTool.Text = "удалить";
            this.deleteCurrentTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteCurrentTool.Click += new System.EventHandler(this.deleteCurrentTool_Click);
            // 
            // lblSecToRefresh
            // 
            this.lblSecToRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblSecToRefresh.Name = "lblSecToRefresh";
            this.lblSecToRefresh.Size = new System.Drawing.Size(40, 51);
            this.lblSecToRefresh.Text = "45 сек";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // refreshTool
            // 
            this.refreshTool.Image = ((System.Drawing.Image)(resources.GetObject("refreshTool.Image")));
            this.refreshTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshTool.Name = "refreshTool";
            this.refreshTool.Size = new System.Drawing.Size(63, 51);
            this.refreshTool.Text = "обновить";
            this.refreshTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshTool.Click += new System.EventHandler(this.refreshTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // printTool
            // 
            this.printTool.Image = ((System.Drawing.Image)(resources.GetObject("printTool.Image")));
            this.printTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printTool.Name = "printTool";
            this.printTool.Size = new System.Drawing.Size(48, 51);
            this.printTool.Text = "печать";
            this.printTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printTool.Click += new System.EventHandler(this.printTool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // changePasswordTool
            // 
            this.changePasswordTool.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordTool.Image")));
            this.changePasswordTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changePasswordTool.Name = "changePasswordTool";
            this.changePasswordTool.Size = new System.Drawing.Size(100, 51);
            this.changePasswordTool.Text = "сменить пароль";
            this.changePasswordTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.changePasswordTool.Click += new System.EventHandler(this.changePasswordTool_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.appointListTree);
            this.splitContainer1.Panel1.Controls.Add(this.panelSearch);
            this.splitContainer1.Panel1.Controls.Add(this.pnlNext);
            this.splitContainer1.Size = new System.Drawing.Size(796, 462);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // appointListTree
            // 
            this.appointListTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointListTree.ImageIndex = 0;
            this.appointListTree.ImageList = this.treeImageList;
            this.appointListTree.Location = new System.Drawing.Point(0, 22);
            this.appointListTree.Name = "appointListTree";
            this.appointListTree.SelectedImageIndex = 0;
            this.appointListTree.Size = new System.Drawing.Size(265, 403);
            this.appointListTree.TabIndex = 0;
            this.appointListTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeImageList
            // 
            this.treeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.treeImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.tboxSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(265, 22);
            this.panelSearch.TabIndex = 1;
            // 
            // tboxSearch
            // 
            this.tboxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxSearch.Location = new System.Drawing.Point(0, 0);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(240, 20);
            this.tboxSearch.TabIndex = 1;
            this.tboxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(240, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 22);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.TabStop = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlNext
            // 
            this.pnlNext.Controls.Add(this.linkLabel1);
            this.pnlNext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNext.Location = new System.Drawing.Point(0, 425);
            this.pnlNext.Name = "pnlNext";
            this.pnlNext.Padding = new System.Windows.Forms.Padding(10);
            this.pnlNext.Size = new System.Drawing.Size(265, 37);
            this.pnlNext.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Location = new System.Drawing.Point(10, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Показать еще >>";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bgCheckLastModifiedDate
            // 
            this.bgCheckLastModifiedDate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgCheckLastModifiedDate_DoWork);
            this.bgCheckLastModifiedDate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgCheckLastModifiedDate_RunWorkerCompleted);
            // 
            // bgRefreshAppointList
            // 
            this.bgRefreshAppointList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgRefreshAppointList_DoWork);
            this.bgRefreshAppointList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgRefreshAppointList_RunWorkerCompleted);
            // 
            // bgSetAppointSeen
            // 
            this.bgSetAppointSeen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgSetAppointSeen_DoWork);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 516);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "CustomerForm";
            this.Text = "Заявки на пропуск";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.pnlNext.ResumeLayout(false);
            this.pnlNext.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton addNewTool;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton editCurrentTool;
        private System.Windows.Forms.ToolStripButton deleteCurrentTool;
        private System.Windows.Forms.ToolStripLabel lblSecToRefresh;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker bgCheckLastModifiedDate;
        private System.ComponentModel.BackgroundWorker bgRefreshAppointList;
        private System.ComponentModel.BackgroundWorker bgSetAppointSeen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshTool;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TreeView appointListTree;
        private System.Windows.Forms.Panel pnlNext;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ImageList treeImageList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton changePasswordTool;
        private System.Windows.Forms.ToolStripButton printTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}
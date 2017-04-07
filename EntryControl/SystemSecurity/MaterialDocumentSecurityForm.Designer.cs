namespace EntryControl
{
    partial class MaterialDocumentSecurityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialDocumentSecurityForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lboxUnitList = new System.Windows.Forms.ListBox();
            this.bsUnitList = new System.Windows.Forms.BindingSource(this.components);
            this.unitListTools = new System.Windows.Forms.ToolStrip();
            this.addUnitTool = new System.Windows.Forms.ToolStripButton();
            this.deleteUnitTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tboxFindUnit = new System.Windows.Forms.ToolStripTextBox();
            this.tblPanelUser = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnToCreator = new System.Windows.Forms.Button();
            this.btnFromCreator = new System.Windows.Forms.Button();
            this.gboxCreatorGroup = new System.Windows.Forms.GroupBox();
            this.lboxCreatorGroup = new System.Windows.Forms.ListBox();
            this.bsCreatorGroup = new System.Windows.Forms.BindingSource(this.components);
            this.pnlAllUserList = new System.Windows.Forms.Panel();
            this.lboxNotUser = new System.Windows.Forms.ListBox();
            this.bsNonUserList = new System.Windows.Forms.BindingSource(this.components);
            this.userListTool = new System.Windows.Forms.ToolStrip();
            this.addUserTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblFindUser = new System.Windows.Forms.ToolStripLabel();
            this.tboxFindUser = new System.Windows.Forms.ToolStripTextBox();
            this.gboxSigner = new System.Windows.Forms.GroupBox();
            this.lboxSignerGroup = new System.Windows.Forms.ListBox();
            this.bsSignerGroup = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFromSigner = new System.Windows.Forms.Button();
            this.btnToSigner = new System.Windows.Forms.Button();
            this.pnlUnitData = new System.Windows.Forms.Panel();
            this.btnSaveUnit = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxCode = new System.Windows.Forms.TextBox();
            this.bsUnitItem = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitList)).BeginInit();
            this.unitListTools.SuspendLayout();
            this.tblPanelUser.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gboxCreatorGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCreatorGroup)).BeginInit();
            this.pnlAllUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsNonUserList)).BeginInit();
            this.userListTool.SuspendLayout();
            this.gboxSigner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSignerGroup)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlUnitData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitItem)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lboxUnitList);
            this.splitContainer1.Panel1.Controls.Add(this.unitListTools);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tblPanelUser);
            this.splitContainer1.Panel2.Controls.Add(this.pnlUnitData);
            this.splitContainer1.Size = new System.Drawing.Size(851, 526);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // lboxUnitList
            // 
            this.lboxUnitList.DataSource = this.bsUnitList;
            this.lboxUnitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxUnitList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lboxUnitList.FormattingEnabled = true;
            this.lboxUnitList.ItemHeight = 16;
            this.lboxUnitList.Location = new System.Drawing.Point(0, 27);
            this.lboxUnitList.Name = "lboxUnitList";
            this.lboxUnitList.Size = new System.Drawing.Size(246, 499);
            this.lboxUnitList.TabIndex = 1;
            this.lboxUnitList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lboxUnitList_DrawItem);
            // 
            // bsUnitList
            // 
            this.bsUnitList.CurrentChanged += new System.EventHandler(this.bsUnitList_CurrentChanged);
            // 
            // unitListTools
            // 
            this.unitListTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUnitTool,
            this.deleteUnitTool,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tboxFindUnit});
            this.unitListTools.Location = new System.Drawing.Point(0, 0);
            this.unitListTools.Name = "unitListTools";
            this.unitListTools.Size = new System.Drawing.Size(246, 27);
            this.unitListTools.TabIndex = 0;
            this.unitListTools.Text = "toolStrip1";
            // 
            // addUnitTool
            // 
            this.addUnitTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addUnitTool.Image = ((System.Drawing.Image)(resources.GetObject("addUnitTool.Image")));
            this.addUnitTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addUnitTool.Name = "addUnitTool";
            this.addUnitTool.Size = new System.Drawing.Size(23, 24);
            this.addUnitTool.Text = "добавить";
            this.addUnitTool.Click += new System.EventHandler(this.addUnitTool_Click);
            // 
            // deleteUnitTool
            // 
            this.deleteUnitTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteUnitTool.Image = ((System.Drawing.Image)(resources.GetObject("deleteUnitTool.Image")));
            this.deleteUnitTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteUnitTool.Name = "deleteUnitTool";
            this.deleteUnitTool.Size = new System.Drawing.Size(23, 24);
            this.deleteUnitTool.Text = "удалить";
            this.deleteUnitTool.Click += new System.EventHandler(this.deleteUnitTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 24);
            this.toolStripLabel1.Text = "поиск";
            // 
            // tboxFindUnit
            // 
            this.tboxFindUnit.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.tboxFindUnit.Name = "tboxFindUnit";
            this.tboxFindUnit.Size = new System.Drawing.Size(120, 27);
            this.tboxFindUnit.TextChanged += new System.EventHandler(this.tboxFindUnit_TextChanged);
            // 
            // tblPanelUser
            // 
            this.tblPanelUser.ColumnCount = 3;
            this.tblPanelUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanelUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelUser.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tblPanelUser.Controls.Add(this.gboxCreatorGroup, 2, 1);
            this.tblPanelUser.Controls.Add(this.pnlAllUserList, 0, 0);
            this.tblPanelUser.Controls.Add(this.gboxSigner, 2, 0);
            this.tblPanelUser.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tblPanelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelUser.Location = new System.Drawing.Point(0, 37);
            this.tblPanelUser.Name = "tblPanelUser";
            this.tblPanelUser.RowCount = 2;
            this.tblPanelUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.12883F));
            this.tblPanelUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.87116F));
            this.tblPanelUser.Size = new System.Drawing.Size(601, 489);
            this.tblPanelUser.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnToCreator, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFromCreator, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(283, 164);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(34, 322);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnToCreator
            // 
            this.btnToCreator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnToCreator.Location = new System.Drawing.Point(3, 129);
            this.btnToCreator.Name = "btnToCreator";
            this.btnToCreator.Size = new System.Drawing.Size(28, 28);
            this.btnToCreator.TabIndex = 3;
            this.btnToCreator.TabStop = false;
            this.btnToCreator.Tag = "Right";
            this.btnToCreator.UseVisualStyleBackColor = true;
            this.btnToCreator.Click += new System.EventHandler(this.arrowButtonClick);
            // 
            // btnFromCreator
            // 
            this.btnFromCreator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFromCreator.Location = new System.Drawing.Point(3, 164);
            this.btnFromCreator.Name = "btnFromCreator";
            this.btnFromCreator.Size = new System.Drawing.Size(28, 28);
            this.btnFromCreator.TabIndex = 2;
            this.btnFromCreator.TabStop = false;
            this.btnFromCreator.Tag = "Left";
            this.btnFromCreator.UseVisualStyleBackColor = true;
            this.btnFromCreator.Click += new System.EventHandler(this.arrowButtonClick);
            // 
            // gboxCreatorGroup
            // 
            this.gboxCreatorGroup.Controls.Add(this.lboxCreatorGroup);
            this.gboxCreatorGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxCreatorGroup.Location = new System.Drawing.Point(323, 164);
            this.gboxCreatorGroup.Name = "gboxCreatorGroup";
            this.gboxCreatorGroup.Size = new System.Drawing.Size(275, 322);
            this.gboxCreatorGroup.TabIndex = 2;
            this.gboxCreatorGroup.TabStop = false;
            this.gboxCreatorGroup.Text = "Кладовщики";
            // 
            // lboxCreatorGroup
            // 
            this.lboxCreatorGroup.DataSource = this.bsCreatorGroup;
            this.lboxCreatorGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxCreatorGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lboxCreatorGroup.FormattingEnabled = true;
            this.lboxCreatorGroup.Location = new System.Drawing.Point(3, 16);
            this.lboxCreatorGroup.Name = "lboxCreatorGroup";
            this.lboxCreatorGroup.Size = new System.Drawing.Size(269, 303);
            this.lboxCreatorGroup.TabIndex = 0;
            this.lboxCreatorGroup.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.userLBox_DrawItem);
            // 
            // bsCreatorGroup
            // 
            this.bsCreatorGroup.DataSourceChanged += new System.EventHandler(this.bsCreatorGroup_CurrentChanged);
            this.bsCreatorGroup.CurrentChanged += new System.EventHandler(this.bsCreatorGroup_CurrentChanged);
            // 
            // pnlAllUserList
            // 
            this.pnlAllUserList.Controls.Add(this.lboxNotUser);
            this.pnlAllUserList.Controls.Add(this.userListTool);
            this.pnlAllUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllUserList.Location = new System.Drawing.Point(3, 3);
            this.pnlAllUserList.Name = "pnlAllUserList";
            this.tblPanelUser.SetRowSpan(this.pnlAllUserList, 2);
            this.pnlAllUserList.Size = new System.Drawing.Size(274, 483);
            this.pnlAllUserList.TabIndex = 0;
            // 
            // lboxNotUser
            // 
            this.lboxNotUser.DataSource = this.bsNonUserList;
            this.lboxNotUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxNotUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lboxNotUser.FormattingEnabled = true;
            this.lboxNotUser.Location = new System.Drawing.Point(0, 27);
            this.lboxNotUser.Name = "lboxNotUser";
            this.lboxNotUser.Size = new System.Drawing.Size(274, 456);
            this.lboxNotUser.TabIndex = 0;
            this.lboxNotUser.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.userLBox_DrawItem);
            // 
            // bsNonUserList
            // 
            this.bsNonUserList.DataSourceChanged += new System.EventHandler(this.bsNonUserList_CurrentChanged);
            this.bsNonUserList.CurrentChanged += new System.EventHandler(this.bsNonUserList_CurrentChanged);
            // 
            // userListTool
            // 
            this.userListTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserTool,
            this.toolStripSeparator2,
            this.lblFindUser,
            this.tboxFindUser});
            this.userListTool.Location = new System.Drawing.Point(0, 0);
            this.userListTool.Name = "userListTool";
            this.userListTool.Size = new System.Drawing.Size(274, 27);
            this.userListTool.TabIndex = 0;
            this.userListTool.Text = "toolStrip2";
            // 
            // addUserTool
            // 
            this.addUserTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addUserTool.Image = ((System.Drawing.Image)(resources.GetObject("addUserTool.Image")));
            this.addUserTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addUserTool.Name = "addUserTool";
            this.addUserTool.Size = new System.Drawing.Size(23, 24);
            this.addUserTool.Text = "создать нового";
            this.addUserTool.Click += new System.EventHandler(this.addUserTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // lblFindUser
            // 
            this.lblFindUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblFindUser.Name = "lblFindUser";
            this.lblFindUser.Size = new System.Drawing.Size(0, 24);
            this.lblFindUser.Text = "toolStripLabel2";
            // 
            // tboxFindUser
            // 
            this.tboxFindUser.Name = "tboxFindUser";
            this.tboxFindUser.Size = new System.Drawing.Size(150, 27);
            this.tboxFindUser.TextChanged += new System.EventHandler(this.tboxFindUser_TextChanged);
            // 
            // gboxSigner
            // 
            this.gboxSigner.Controls.Add(this.lboxSignerGroup);
            this.gboxSigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxSigner.Location = new System.Drawing.Point(323, 3);
            this.gboxSigner.Name = "gboxSigner";
            this.gboxSigner.Size = new System.Drawing.Size(275, 155);
            this.gboxSigner.TabIndex = 1;
            this.gboxSigner.TabStop = false;
            this.gboxSigner.Text = "Руководители";
            // 
            // lboxSignerGroup
            // 
            this.lboxSignerGroup.DataSource = this.bsSignerGroup;
            this.lboxSignerGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxSignerGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lboxSignerGroup.FormattingEnabled = true;
            this.lboxSignerGroup.Location = new System.Drawing.Point(3, 16);
            this.lboxSignerGroup.Name = "lboxSignerGroup";
            this.lboxSignerGroup.Size = new System.Drawing.Size(269, 136);
            this.lboxSignerGroup.TabIndex = 0;
            this.lboxSignerGroup.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.userLBox_DrawItem);
            // 
            // bsSignerGroup
            // 
            this.bsSignerGroup.DataSourceChanged += new System.EventHandler(this.bsSignerGroup_CurrentChanged);
            this.bsSignerGroup.CurrentChanged += new System.EventHandler(this.bsSignerGroup_CurrentChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnFromSigner, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnToSigner, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(283, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(34, 155);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnFromSigner
            // 
            this.btnFromSigner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFromSigner.Location = new System.Drawing.Point(3, 81);
            this.btnFromSigner.Name = "btnFromSigner";
            this.btnFromSigner.Size = new System.Drawing.Size(28, 28);
            this.btnFromSigner.TabIndex = 1;
            this.btnFromSigner.TabStop = false;
            this.btnFromSigner.Tag = "Left";
            this.btnFromSigner.UseVisualStyleBackColor = true;
            this.btnFromSigner.Click += new System.EventHandler(this.arrowButtonClick);
            // 
            // btnToSigner
            // 
            this.btnToSigner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnToSigner.Location = new System.Drawing.Point(3, 46);
            this.btnToSigner.Name = "btnToSigner";
            this.btnToSigner.Size = new System.Drawing.Size(28, 28);
            this.btnToSigner.TabIndex = 0;
            this.btnToSigner.TabStop = false;
            this.btnToSigner.Tag = "Right";
            this.btnToSigner.UseVisualStyleBackColor = true;
            this.btnToSigner.Click += new System.EventHandler(this.arrowButtonClick);
            // 
            // pnlUnitData
            // 
            this.pnlUnitData.Controls.Add(this.btnSaveUnit);
            this.pnlUnitData.Controls.Add(this.tboxName);
            this.pnlUnitData.Controls.Add(this.tboxCode);
            this.pnlUnitData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUnitData.Location = new System.Drawing.Point(0, 0);
            this.pnlUnitData.Name = "pnlUnitData";
            this.pnlUnitData.Padding = new System.Windows.Forms.Padding(5);
            this.pnlUnitData.Size = new System.Drawing.Size(601, 37);
            this.pnlUnitData.TabIndex = 0;
            // 
            // btnSaveUnit
            // 
            this.btnSaveUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveUnit.BackgroundImage")));
            this.btnSaveUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveUnit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveUnit.Location = new System.Drawing.Point(569, 5);
            this.btnSaveUnit.Name = "btnSaveUnit";
            this.btnSaveUnit.Size = new System.Drawing.Size(27, 27);
            this.btnSaveUnit.TabIndex = 2;
            this.btnSaveUnit.UseVisualStyleBackColor = true;
            this.btnSaveUnit.Click += new System.EventHandler(this.btnSaveUnit_Click);
            // 
            // tboxName
            // 
            this.tboxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxName.Location = new System.Drawing.Point(112, 5);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(484, 26);
            this.tboxName.TabIndex = 1;
            // 
            // tboxCode
            // 
            this.tboxCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.tboxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxCode.Location = new System.Drawing.Point(5, 5);
            this.tboxCode.Name = "tboxCode";
            this.tboxCode.Size = new System.Drawing.Size(107, 26);
            this.tboxCode.TabIndex = 0;
            // 
            // MaterialDocumentSecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 526);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MaterialDocumentSecurityForm";
            this.Text = "Администрирование материальных пропусков";
            this.Load += new System.EventHandler(this.MaterialDocumentSecurityForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitList)).EndInit();
            this.unitListTools.ResumeLayout(false);
            this.unitListTools.PerformLayout();
            this.tblPanelUser.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gboxCreatorGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsCreatorGroup)).EndInit();
            this.pnlAllUserList.ResumeLayout(false);
            this.pnlAllUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsNonUserList)).EndInit();
            this.userListTool.ResumeLayout(false);
            this.userListTool.PerformLayout();
            this.gboxSigner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSignerGroup)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlUnitData.ResumeLayout(false);
            this.pnlUnitData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lboxUnitList;
        private System.Windows.Forms.ToolStrip unitListTools;
        private System.Windows.Forms.ToolStripButton addUnitTool;
        private System.Windows.Forms.ToolStripButton deleteUnitTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tboxFindUnit;
        private System.Windows.Forms.BindingSource bsUnitList;
        private System.Windows.Forms.TableLayoutPanel tblPanelUser;
        private System.Windows.Forms.Panel pnlUnitData;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Button btnSaveUnit;
        private System.Windows.Forms.TextBox tboxCode;
        private System.Windows.Forms.BindingSource bsUnitItem;
        private System.Windows.Forms.GroupBox gboxCreatorGroup;
        private System.Windows.Forms.Panel pnlAllUserList;
        private System.Windows.Forms.GroupBox gboxSigner;
        private System.Windows.Forms.ToolStrip userListTool;
        private System.Windows.Forms.ListBox lboxNotUser;
        private System.Windows.Forms.BindingSource bsNonUserList;
        private System.Windows.Forms.ListBox lboxCreatorGroup;
        private System.Windows.Forms.BindingSource bsCreatorGroup;
        private System.Windows.Forms.ListBox lboxSignerGroup;
        private System.Windows.Forms.BindingSource bsSignerGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnToCreator;
        private System.Windows.Forms.Button btnFromCreator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFromSigner;
        private System.Windows.Forms.Button btnToSigner;
        private System.Windows.Forms.ToolStripButton addUserTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblFindUser;
        private System.Windows.Forms.ToolStripTextBox tboxFindUser;
    }
}
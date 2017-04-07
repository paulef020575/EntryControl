namespace EntryControl
{
    partial class SystemSecurityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemSecurityForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lboxUserList = new System.Windows.Forms.ListBox();
            this.bsUserList = new System.Windows.Forms.BindingSource(this.components);
            this.itemPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Фамилия = new System.Windows.Forms.Label();
            this.tboxLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxSecondname = new System.Windows.Forms.TextBox();
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkIsDomain = new System.Windows.Forms.CheckBox();
            this.tboxDomainName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRoleList = new System.Windows.Forms.DataGridView();
            this.ColumnRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsIncluded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userTools = new System.Windows.Forms.ToolStrip();
            this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnPassword = new System.Windows.Forms.ToolStripButton();
            this.bsUserItem = new System.Windows.Forms.BindingSource(this.components);
            this.btnMaterialSecurity = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserList)).BeginInit();
            this.itemPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).BeginInit();
            this.userTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserItem)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lboxUserList);
            this.splitContainer1.Panel1.Controls.Add(this.btnMaterialSecurity);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.itemPanel);
            this.splitContainer1.Panel2.Controls.Add(this.userTools);
            this.splitContainer1.Size = new System.Drawing.Size(703, 497);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 0;
            // 
            // lboxUserList
            // 
            this.lboxUserList.DataSource = this.bsUserList;
            this.lboxUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxUserList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lboxUserList.FormattingEnabled = true;
            this.lboxUserList.Location = new System.Drawing.Point(0, 0);
            this.lboxUserList.Name = "lboxUserList";
            this.lboxUserList.Size = new System.Drawing.Size(234, 447);
            this.lboxUserList.TabIndex = 0;
            this.lboxUserList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lboxUserList_DrawItem);
            // 
            // bsUserList
            // 
            this.bsUserList.CurrentChanged += new System.EventHandler(this.bsUserList_CurrentChanged);
            // 
            // itemPanel
            // 
            this.itemPanel.ColumnCount = 2;
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemPanel.Controls.Add(this.label5, 0, 7);
            this.itemPanel.Controls.Add(this.tboxUserName, 1, 6);
            this.itemPanel.Controls.Add(this.label4, 0, 6);
            this.itemPanel.Controls.Add(this.Фамилия, 0, 0);
            this.itemPanel.Controls.Add(this.tboxLastname, 1, 0);
            this.itemPanel.Controls.Add(this.label1, 0, 1);
            this.itemPanel.Controls.Add(this.tboxFirstname, 1, 1);
            this.itemPanel.Controls.Add(this.label2, 0, 2);
            this.itemPanel.Controls.Add(this.tboxSecondname, 1, 2);
            this.itemPanel.Controls.Add(this.chkLocked, 1, 3);
            this.itemPanel.Controls.Add(this.panel1, 0, 8);
            this.itemPanel.Controls.Add(this.chkIsDomain, 1, 4);
            this.itemPanel.Controls.Add(this.tboxDomainName, 1, 5);
            this.itemPanel.Controls.Add(this.label3, 0, 5);
            this.itemPanel.Controls.Add(this.dgvRoleList, 1, 7);
            this.itemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel.Enabled = false;
            this.itemPanel.Location = new System.Drawing.Point(0, 59);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.RowCount = 9;
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.itemPanel.Size = new System.Drawing.Size(465, 438);
            this.itemPanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 100);
            this.label5.TabIndex = 14;
            this.label5.Text = "Роли пользователя";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tboxUserName
            // 
            this.tboxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxUserName.Location = new System.Drawing.Point(203, 153);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(259, 20);
            this.tboxUserName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Имя пользователя";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Фамилия
            // 
            this.Фамилия.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Фамилия.Location = new System.Drawing.Point(3, 0);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(194, 26);
            this.Фамилия.TabIndex = 0;
            this.Фамилия.Text = "Фамилия";
            this.Фамилия.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxLastname
            // 
            this.tboxLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxLastname.Location = new System.Drawing.Point(203, 3);
            this.tboxLastname.Name = "tboxLastname";
            this.tboxLastname.Size = new System.Drawing.Size(259, 20);
            this.tboxLastname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxFirstname
            // 
            this.tboxFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxFirstname.Location = new System.Drawing.Point(203, 29);
            this.tboxFirstname.Name = "tboxFirstname";
            this.tboxFirstname.Size = new System.Drawing.Size(259, 20);
            this.tboxFirstname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отчество";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxSecondname
            // 
            this.tboxSecondname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxSecondname.Location = new System.Drawing.Point(203, 55);
            this.tboxSecondname.Name = "tboxSecondname";
            this.tboxSecondname.Size = new System.Drawing.Size(259, 20);
            this.tboxSecondname.TabIndex = 5;
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(203, 81);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(114, 17);
            this.chkLocked.TabIndex = 6;
            this.chkLocked.Text = "доступ запрещен";
            this.chkLocked.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.itemPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btnCargo);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 279);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(459, 35);
            this.panel1.TabIndex = 7;
            // 
            // btnCargo
            // 
            this.btnCargo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCargo.Location = new System.Drawing.Point(5, 5);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(100, 25);
            this.btnCargo.TabIndex = 2;
            this.btnCargo.TabStop = false;
            this.btnCargo.Text = "Грузы...";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(254, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReset.Location = new System.Drawing.Point(354, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 25);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkIsDomain
            // 
            this.chkIsDomain.AutoSize = true;
            this.chkIsDomain.Location = new System.Drawing.Point(203, 104);
            this.chkIsDomain.Name = "chkIsDomain";
            this.chkIsDomain.Size = new System.Drawing.Size(138, 17);
            this.chkIsDomain.TabIndex = 8;
            this.chkIsDomain.Text = "пользователь домена";
            this.chkIsDomain.UseVisualStyleBackColor = true;
            // 
            // tboxDomainName
            // 
            this.tboxDomainName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxDomainName.Location = new System.Drawing.Point(203, 127);
            this.tboxDomainName.Name = "tboxDomainName";
            this.tboxDomainName.Size = new System.Drawing.Size(259, 20);
            this.tboxDomainName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя домена";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvRoleList
            // 
            this.dgvRoleList.AllowUserToAddRows = false;
            this.dgvRoleList.AllowUserToDeleteRows = false;
            this.dgvRoleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleList.ColumnHeadersVisible = false;
            this.dgvRoleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRoleName,
            this.ColumnIsIncluded});
            this.dgvRoleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoleList.Location = new System.Drawing.Point(203, 179);
            this.dgvRoleList.Name = "dgvRoleList";
            this.dgvRoleList.RowHeadersVisible = false;
            this.dgvRoleList.Size = new System.Drawing.Size(259, 94);
            this.dgvRoleList.TabIndex = 13;
            this.dgvRoleList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvRoleList_CellBeginEdit);
            // 
            // ColumnRoleName
            // 
            this.ColumnRoleName.DataPropertyName = "Role";
            this.ColumnRoleName.Frozen = true;
            this.ColumnRoleName.HeaderText = "Роль";
            this.ColumnRoleName.Name = "ColumnRoleName";
            this.ColumnRoleName.ReadOnly = true;
            this.ColumnRoleName.Width = 150;
            // 
            // ColumnIsIncluded
            // 
            this.ColumnIsIncluded.DataPropertyName = "IsIncluded";
            this.ColumnIsIncluded.HeaderText = "вкл";
            this.ColumnIsIncluded.Name = "ColumnIsIncluded";
            // 
            // userTools
            // 
            this.userTools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.userTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAdd,
            this.tbtnEdit,
            this.tbtnDelete,
            this.toolStripSeparator1,
            this.tbtnPassword});
            this.userTools.Location = new System.Drawing.Point(0, 0);
            this.userTools.Name = "userTools";
            this.userTools.Size = new System.Drawing.Size(465, 59);
            this.userTools.TabIndex = 0;
            this.userTools.Text = "Инструменты";
            // 
            // tbtnAdd
            // 
            this.tbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAdd.Image")));
            this.tbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAdd.Name = "tbtnAdd";
            this.tbtnAdd.Size = new System.Drawing.Size(80, 56);
            this.tbtnAdd.Text = "Добавить";
            this.tbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnAdd.Click += new System.EventHandler(this.tbtnAdd_Click);
            // 
            // tbtnEdit
            // 
            this.tbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEdit.Image")));
            this.tbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEdit.Name = "tbtnEdit";
            this.tbtnEdit.Size = new System.Drawing.Size(82, 56);
            this.tbtnEdit.Text = "Изменить";
            this.tbtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnEdit.Click += new System.EventHandler(this.tbtnEdit_Click);
            // 
            // tbtnDelete
            // 
            this.tbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDelete.Image")));
            this.tbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDelete.Name = "tbtnDelete";
            this.tbtnDelete.Size = new System.Drawing.Size(69, 56);
            this.tbtnDelete.Text = "Удалить";
            this.tbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnDelete.Click += new System.EventHandler(this.tbtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
            // 
            // tbtnPassword
            // 
            this.tbtnPassword.Image = ((System.Drawing.Image)(resources.GetObject("tbtnPassword.Image")));
            this.tbtnPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPassword.Name = "tbtnPassword";
            this.tbtnPassword.Size = new System.Drawing.Size(66, 56);
            this.tbtnPassword.Text = "Пароль";
            this.tbtnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnPassword.Click += new System.EventHandler(this.tbtnPassword_Click);
            // 
            // bsUserItem
            // 
            this.bsUserItem.DataSourceChanged += new System.EventHandler(this.bsUserItem_DataSourceChanged);
            // 
            // btnMaterialSecurity
            // 
            this.btnMaterialSecurity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMaterialSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaterialSecurity.Location = new System.Drawing.Point(0, 447);
            this.btnMaterialSecurity.Name = "btnMaterialSecurity";
            this.btnMaterialSecurity.Size = new System.Drawing.Size(234, 50);
            this.btnMaterialSecurity.TabIndex = 1;
            this.btnMaterialSecurity.Text = "Материальные пропуска";
            this.btnMaterialSecurity.UseVisualStyleBackColor = true;
            this.btnMaterialSecurity.Click += new System.EventHandler(this.btnMaterialSecurity_Click);
            // 
            // SystemSecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 497);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SystemSecurityForm";
            this.Text = "SystemSecurityForm";
            this.Load += new System.EventHandler(this.SystemSecurityForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsUserList)).EndInit();
            this.itemPanel.ResumeLayout(false);
            this.itemPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).EndInit();
            this.userTools.ResumeLayout(false);
            this.userTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource bsUserList;
        private System.Windows.Forms.ToolStrip userTools;
        private System.Windows.Forms.ToolStripButton tbtnAdd;
        private System.Windows.Forms.ToolStripButton tbtnEdit;
        private System.Windows.Forms.ToolStripButton tbtnDelete;
        private System.Windows.Forms.BindingSource bsUserItem;
        private System.Windows.Forms.TableLayoutPanel itemPanel;
        private System.Windows.Forms.Label Фамилия;
        private System.Windows.Forms.TextBox tboxLastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxSecondname;
        private System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lboxUserList;
        private System.Windows.Forms.CheckBox chkIsDomain;
        private System.Windows.Forms.TextBox tboxDomainName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRoleList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsIncluded;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnPassword;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnMaterialSecurity;
    }
}
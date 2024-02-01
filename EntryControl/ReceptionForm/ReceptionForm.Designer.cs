namespace EntryControl
{
    partial class ReceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsPermitList = new System.Windows.Forms.BindingSource(this.components);
            this.bsPlanAppointList = new System.Windows.Forms.BindingSource(this.components);
            this.bgRefreshPermitList = new System.ComponentModel.BackgroundWorker();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.bgLastUpdateDate = new System.ComponentModel.BackgroundWorker();
            this.bgLastPlanAppointDate = new System.ComponentModel.BackgroundWorker();
            this.bgRefreshPlanAppointList = new System.ComponentModel.BackgroundWorker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.permitPage = new System.Windows.Forms.TabPage();
            this.dgvPermitList = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPermitState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMultiEntry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permitTools = new System.Windows.Forms.ToolStrip();
            this.lblToRefresh = new System.Windows.Forms.ToolStripLabel();
            this.addPermitTool = new System.Windows.Forms.ToolStripButton();
            this.editPermitTool = new System.Windows.Forms.ToolStripButton();
            this.deletePermitTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshPermiListTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printPermitListTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.findLabel = new System.Windows.Forms.ToolStripLabel();
            this.findTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findNextTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblPermitPage = new System.Windows.Forms.ToolStripLabel();
            this.btnPreviousPermitPage = new System.Windows.Forms.ToolStripButton();
            this.btnNextPermitPage = new System.Windows.Forms.ToolStripButton();
            this.permitTopPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxPermitType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rboxEntryPoint = new EntryControl.ReferenceBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pickDateFinish = new System.Windows.Forms.DateTimePicker();
            this.pickDateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMoving = new System.Windows.Forms.DataGridView();
            this.ColumnMoving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMovingPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMovingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEntryPoints = new System.Windows.Forms.GroupBox();
            this.dgvPointList = new System.Windows.Forms.DataGridView();
            this.ColumnPermitPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxPermitComment = new System.Windows.Forms.GroupBox();
            this.tboxPermitComment = new System.Windows.Forms.TextBox();
            this.pnlInitializer = new System.Windows.Forms.Panel();
            this.tboxPermitCreator = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pagePlanAppointList = new System.Windows.Forms.TabPage();
            this.dgvPlanAppointList = new System.Windows.Forms.DataGridView();
            this.ColumnDateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWhereTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAppointCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlComment = new System.Windows.Forms.GroupBox();
            this.tboxComment = new System.Windows.Forms.TextBox();
            this.planAppointTools = new System.Windows.Forms.ToolStrip();
            this.lblToRefresh2 = new System.Windows.Forms.ToolStripLabel();
            this.createPermitTool = new System.Windows.Forms.ToolStripButton();
            this.lockAppointTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblPageNumber = new System.Windows.Forms.ToolStripLabel();
            this.btnPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.pickPlanAppointStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pageMaterialDocumentList = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvMaterialPermitList = new System.Windows.Forms.DataGridView();
            this.ColumnMdDocNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMdDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMdUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdColumnCreated = new System.Windows.Forms.DataGridViewImageColumn();
            this.mdColumnSigned = new System.Windows.Forms.DataGridViewImageColumn();
            this.mdColumnEntry = new System.Windows.Forms.DataGridViewImageColumn();
            this.bsMaterialDocumentList = new System.Windows.Forms.BindingSource(this.components);
            this.materialPermitToolStrip = new System.Windows.Forms.ToolStrip();
            this.lblToRefresh3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlMaterialPermitFilter = new System.Windows.Forms.Panel();
            this.pickMdDateTo = new System.Windows.Forms.DateTimePicker();
            this.pickMdDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.mdTable = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxMdEntryDate = new System.Windows.Forms.TextBox();
            this.tboxMdEntryPoint = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pboxMdEntry = new System.Windows.Forms.PictureBox();
            this.tboxSigner = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxMdSignedDate = new System.Windows.Forms.TextBox();
            this.pboxMdSigned = new System.Windows.Forms.PictureBox();
            this.tboxMdCreatedDate = new System.Windows.Forms.TextBox();
            this.tboxMdCreator = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxMdLicensePlate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxMdVehicleMark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxMdPerson = new System.Windows.Forms.TextBox();
            this.pboxCreatedImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLockMd = new System.Windows.Forms.Button();
            this.btnSignMd = new System.Windows.Forms.Button();
            this.dgvMdItems = new System.Windows.Forms.DataGridView();
            this.mdItemColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdItemColUnity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdItemColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdItemColWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMdItems = new System.Windows.Forms.BindingSource(this.components);
            this.pbarMdLoading = new System.Windows.Forms.ProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.materialPermitTool = new System.Windows.Forms.ToolStripButton();
            this.btnChangePassword = new System.Windows.Forms.ToolStripButton();
            this.blackListButton = new System.Windows.Forms.ToolStripButton();
            this.bgRefreshMaterialDocumentList = new System.ComponentModel.BackgroundWorker();
            this.bgLastMaterialDocumentDate = new System.ComponentModel.BackgroundWorker();
            this.bsMaterialDocumentItem = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsPermitList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanAppointList)).BeginInit();
            this.tabControl.SuspendLayout();
            this.permitPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermitList)).BeginInit();
            this.permitTools.SuspendLayout();
            this.permitTopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoving)).BeginInit();
            this.pnlEntryPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointList)).BeginInit();
            this.gboxPermitComment.SuspendLayout();
            this.pnlInitializer.SuspendLayout();
            this.pagePlanAppointList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanAppointList)).BeginInit();
            this.pnlComment.SuspendLayout();
            this.planAppointTools.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.pageMaterialDocumentList.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialPermitList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterialDocumentList)).BeginInit();
            this.materialPermitToolStrip.SuspendLayout();
            this.pnlMaterialPermitFilter.SuspendLayout();
            this.mdTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMdEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMdSigned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreatedImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMdItems)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterialDocumentItem)).BeginInit();
            this.SuspendLayout();
            // 
            // bsPermitList
            // 
            this.bsPermitList.CurrentChanged += new System.EventHandler(this.bsPermitList_CurrentChanged);
            // 
            // bsPlanAppointList
            // 
            this.bsPlanAppointList.DataSourceChanged += new System.EventHandler(this.bsPlanAppointList_DataSourceChanged);
            this.bsPlanAppointList.CurrentChanged += new System.EventHandler(this.bsPlanAppointList_CurrentChanged);
            // 
            // bgRefreshPermitList
            // 
            this.bgRefreshPermitList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgRefresh_DoWork);
            this.bgRefreshPermitList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgRefresh_RunWorkerCompleted);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // bgLastUpdateDate
            // 
            this.bgLastUpdateDate.WorkerSupportsCancellation = true;
            this.bgLastUpdateDate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLastUpdateDate_DoWork);
            this.bgLastUpdateDate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLastUpdateDate_RunWorkerCompleted);
            // 
            // bgLastPlanAppointDate
            // 
            this.bgLastPlanAppointDate.WorkerSupportsCancellation = true;
            this.bgLastPlanAppointDate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLastPlanAppointDate_DoWork);
            this.bgLastPlanAppointDate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLastPlanAppointDate_RunWorkerCompleted);
            // 
            // bgRefreshPlanAppointList
            // 
            this.bgRefreshPlanAppointList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgRefreshPlanAppointList_DoWork);
            this.bgRefreshPlanAppointList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgRefreshPlanAppointList_RunWorkerCompleted);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.permitPage);
            this.tabControl.Controls.Add(this.pagePlanAppointList);
            this.tabControl.Controls.Add(this.pageMaterialDocumentList);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1522, 730);
            this.tabControl.TabIndex = 0;
            // 
            // permitPage
            // 
            this.permitPage.Controls.Add(this.dgvPermitList);
            this.permitPage.Controls.Add(this.permitTools);
            this.permitPage.Controls.Add(this.permitTopPanel);
            this.permitPage.Controls.Add(this.panel1);
            this.permitPage.Location = new System.Drawing.Point(4, 29);
            this.permitPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.permitPage.Name = "permitPage";
            this.permitPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.permitPage.Size = new System.Drawing.Size(1514, 697);
            this.permitPage.TabIndex = 0;
            this.permitPage.Text = "Пропуски";
            this.permitPage.UseVisualStyleBackColor = true;
            // 
            // dgvPermitList
            // 
            this.dgvPermitList.AllowUserToAddRows = false;
            this.dgvPermitList.AllowUserToDeleteRows = false;
            this.dgvPermitList.AutoGenerateColumns = false;
            this.dgvPermitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermitList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnPermitState,
            this.ColumnPeriod,
            this.ColumnPCargo,
            this.ColumnPVehicle,
            this.ColumnPDriver,
            this.ColumnPContact,
            this.ColumnMultiEntry});
            this.dgvPermitList.DataSource = this.bsPermitList;
            this.dgvPermitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermitList.Location = new System.Drawing.Point(4, 165);
            this.dgvPermitList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPermitList.MultiSelect = false;
            this.dgvPermitList.Name = "dgvPermitList";
            this.dgvPermitList.ReadOnly = true;
            this.dgvPermitList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermitList.Size = new System.Drawing.Size(981, 527);
            this.dgvPermitList.TabIndex = 2;
            this.dgvPermitList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermitList_CellDoubleClick);
            this.dgvPermitList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPermitList_RowPrePaint);
            this.dgvPermitList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pickDateStart_KeyDown);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.DataPropertyName = "Header";
            this.ColumnNumber.HeaderText = "Номер пропуска";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 150;
            // 
            // ColumnPermitState
            // 
            this.ColumnPermitState.DataPropertyName = "PermitState";
            this.ColumnPermitState.HeaderText = "Вид пропуска";
            this.ColumnPermitState.Name = "ColumnPermitState";
            this.ColumnPermitState.ReadOnly = true;
            // 
            // ColumnPeriod
            // 
            this.ColumnPeriod.DataPropertyName = "ActivePeriod";
            this.ColumnPeriod.HeaderText = "Период действия";
            this.ColumnPeriod.Name = "ColumnPeriod";
            this.ColumnPeriod.ReadOnly = true;
            this.ColumnPeriod.Width = 150;
            // 
            // ColumnPCargo
            // 
            this.ColumnPCargo.DataPropertyName = "Cargo";
            this.ColumnPCargo.HeaderText = "Груз";
            this.ColumnPCargo.Name = "ColumnPCargo";
            this.ColumnPCargo.ReadOnly = true;
            // 
            // ColumnPVehicle
            // 
            this.ColumnPVehicle.DataPropertyName = "Vehicle";
            this.ColumnPVehicle.HeaderText = "Т/средство";
            this.ColumnPVehicle.Name = "ColumnPVehicle";
            this.ColumnPVehicle.ReadOnly = true;
            // 
            // ColumnPDriver
            // 
            this.ColumnPDriver.DataPropertyName = "DriverName";
            this.ColumnPDriver.HeaderText = "Водитель";
            this.ColumnPDriver.Name = "ColumnPDriver";
            this.ColumnPDriver.ReadOnly = true;
            // 
            // ColumnPContact
            // 
            this.ColumnPContact.DataPropertyName = "Contact";
            this.ColumnPContact.HeaderText = "Конт. информация";
            this.ColumnPContact.Name = "ColumnPContact";
            this.ColumnPContact.ReadOnly = true;
            // 
            // ColumnMultiEntry
            // 
            this.ColumnMultiEntry.DataPropertyName = "MultiEntry";
            this.ColumnMultiEntry.HeaderText = "въезд/выезд";
            this.ColumnMultiEntry.Name = "ColumnMultiEntry";
            this.ColumnMultiEntry.ReadOnly = true;
            // 
            // permitTools
            // 
            this.permitTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblToRefresh,
            this.addPermitTool,
            this.editPermitTool,
            this.deletePermitTool,
            this.toolStripSeparator1,
            this.refreshPermiListTool,
            this.toolStripSeparator2,
            this.printPermitListTool,
            this.toolStripSeparator3,
            this.findLabel,
            this.findTextBox,
            this.findNextTool,
            this.toolStripSeparator5,
            this.toolStripLabel2,
            this.lblPermitPage,
            this.btnPreviousPermitPage,
            this.btnNextPermitPage});
            this.permitTools.Location = new System.Drawing.Point(4, 140);
            this.permitTools.Name = "permitTools";
            this.permitTools.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.permitTools.Size = new System.Drawing.Size(981, 25);
            this.permitTools.TabIndex = 1;
            this.permitTools.Text = "toolStrip1";
            // 
            // lblToRefresh
            // 
            this.lblToRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblToRefresh.Name = "lblToRefresh";
            this.lblToRefresh.Size = new System.Drawing.Size(34, 22);
            this.lblToRefresh.Text = "0 сек";
            // 
            // addPermitTool
            // 
            this.addPermitTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addPermitTool.Image = ((System.Drawing.Image)(resources.GetObject("addPermitTool.Image")));
            this.addPermitTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addPermitTool.Name = "addPermitTool";
            this.addPermitTool.Size = new System.Drawing.Size(23, 22);
            this.addPermitTool.Text = "добавить";
            this.addPermitTool.Click += new System.EventHandler(this.addPermitTool_Click);
            // 
            // editPermitTool
            // 
            this.editPermitTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editPermitTool.Image = ((System.Drawing.Image)(resources.GetObject("editPermitTool.Image")));
            this.editPermitTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPermitTool.Name = "editPermitTool";
            this.editPermitTool.Size = new System.Drawing.Size(23, 22);
            this.editPermitTool.Text = "изменить";
            this.editPermitTool.Click += new System.EventHandler(this.editPermitTool_Click);
            // 
            // deletePermitTool
            // 
            this.deletePermitTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deletePermitTool.Image = ((System.Drawing.Image)(resources.GetObject("deletePermitTool.Image")));
            this.deletePermitTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletePermitTool.Name = "deletePermitTool";
            this.deletePermitTool.Size = new System.Drawing.Size(23, 22);
            this.deletePermitTool.Text = "toolStripButton1";
            this.deletePermitTool.Click += new System.EventHandler(this.deletePermitTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshPermiListTool
            // 
            this.refreshPermiListTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshPermiListTool.Image = ((System.Drawing.Image)(resources.GetObject("refreshPermiListTool.Image")));
            this.refreshPermiListTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshPermiListTool.Name = "refreshPermiListTool";
            this.refreshPermiListTool.Size = new System.Drawing.Size(23, 22);
            this.refreshPermiListTool.Text = "обновить";
            this.refreshPermiListTool.Click += new System.EventHandler(this.refreshPermiListTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // printPermitListTool
            // 
            this.printPermitListTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPermitListTool.Image = ((System.Drawing.Image)(resources.GetObject("printPermitListTool.Image")));
            this.printPermitListTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPermitListTool.Name = "printPermitListTool";
            this.printPermitListTool.Size = new System.Drawing.Size(23, 22);
            this.printPermitListTool.Text = "печать";
            this.printPermitListTool.Click += new System.EventHandler(this.printPermitListTool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // findLabel
            // 
            this.findLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(0, 22);
            this.findLabel.Text = "Поиск";
            // 
            // findTextBox
            // 
            this.findTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(148, 25);
            this.findTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pickDateStart_KeyDown);
            this.findTextBox.TextChanged += new System.EventHandler(this.findTextBox_TextChanged);
            // 
            // findNextTool
            // 
            this.findNextTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findNextTool.Image = ((System.Drawing.Image)(resources.GetObject("findNextTool.Image")));
            this.findNextTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findNextTool.Name = "findNextTool";
            this.findNextTool.Size = new System.Drawing.Size(23, 22);
            this.findNextTool.Text = "Найти следующий";
            this.findNextTool.Click += new System.EventHandler(this.findNextTool_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel2.Text = "Стр.";
            // 
            // lblPermitPage
            // 
            this.lblPermitPage.Name = "lblPermitPage";
            this.lblPermitPage.Size = new System.Drawing.Size(30, 22);
            this.lblPermitPage.Text = "0 / 0";
            // 
            // btnPreviousPermitPage
            // 
            this.btnPreviousPermitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousPermitPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousPermitPage.Image")));
            this.btnPreviousPermitPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousPermitPage.Name = "btnPreviousPermitPage";
            this.btnPreviousPermitPage.Size = new System.Drawing.Size(23, 22);
            this.btnPreviousPermitPage.Text = "Предыдущая";
            this.btnPreviousPermitPage.Click += new System.EventHandler(this.btnPreviousPermitPage_Click);
            // 
            // btnNextPermitPage
            // 
            this.btnNextPermitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPermitPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPermitPage.Image")));
            this.btnNextPermitPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPermitPage.Name = "btnNextPermitPage";
            this.btnNextPermitPage.Size = new System.Drawing.Size(23, 22);
            this.btnNextPermitPage.Text = "Следующая";
            this.btnNextPermitPage.Click += new System.EventHandler(this.btnNextPermitPage_Click);
            // 
            // permitTopPanel
            // 
            this.permitTopPanel.Controls.Add(this.label5);
            this.permitTopPanel.Controls.Add(this.cboxPermitType);
            this.permitTopPanel.Controls.Add(this.label3);
            this.permitTopPanel.Controls.Add(this.rboxEntryPoint);
            this.permitTopPanel.Controls.Add(this.label2);
            this.permitTopPanel.Controls.Add(this.pickDateFinish);
            this.permitTopPanel.Controls.Add(this.pickDateStart);
            this.permitTopPanel.Controls.Add(this.label1);
            this.permitTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.permitTopPanel.Location = new System.Drawing.Point(4, 5);
            this.permitTopPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.permitTopPanel.Name = "permitTopPanel";
            this.permitTopPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.permitTopPanel.Size = new System.Drawing.Size(981, 135);
            this.permitTopPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(428, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "(на выбор не влияет)";
            // 
            // cboxPermitType
            // 
            this.cboxPermitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPermitType.FormattingEnabled = true;
            this.cboxPermitType.Location = new System.Drawing.Point(138, 91);
            this.cboxPermitType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxPermitType.Name = "cboxPermitType";
            this.cboxPermitType.Size = new System.Drawing.Size(272, 28);
            this.cboxPermitType.TabIndex = 6;
            this.cboxPermitType.SelectedIndexChanged += new System.EventHandler(this.pickDateStart_ValueChanged);
            this.cboxPermitType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pickDateStart_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вид пропуска";
            // 
            // rboxEntryPoint
            // 
            this.rboxEntryPoint.Database = null;
            this.rboxEntryPoint.DataSource = null;
            this.rboxEntryPoint.ListForm = "EntryControl.EntryPointListForm";
            this.rboxEntryPoint.Location = new System.Drawing.Point(138, 48);
            this.rboxEntryPoint.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rboxEntryPoint.Name = "rboxEntryPoint";
            this.rboxEntryPoint.SelectedItem = null;
            this.rboxEntryPoint.Size = new System.Drawing.Size(274, 34);
            this.rboxEntryPoint.TabIndex = 4;
            this.rboxEntryPoint.GetList += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxEntryPoint_GetList);
            this.rboxEntryPoint.SelectedItemChanged += new System.EventHandler(this.pickDateStart_ValueChanged);
            this.rboxEntryPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pickDateStart_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Проходная";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pickDateFinish
            // 
            this.pickDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateFinish.Location = new System.Drawing.Point(294, 8);
            this.pickDateFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickDateFinish.Name = "pickDateFinish";
            this.pickDateFinish.Size = new System.Drawing.Size(145, 26);
            this.pickDateFinish.TabIndex = 2;
            this.pickDateFinish.ValueChanged += new System.EventHandler(this.pickDateStart_ValueChanged);
            this.pickDateFinish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pickDateStart_KeyDown);
            // 
            // pickDateStart
            // 
            this.pickDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateStart.Location = new System.Drawing.Point(138, 8);
            this.pickDateStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickDateStart.Name = "pickDateStart";
            this.pickDateStart.Size = new System.Drawing.Size(145, 26);
            this.pickDateStart.TabIndex = 1;
            this.pickDateStart.ValueChanged += new System.EventHandler(this.pickDateStart_ValueChanged);
            this.pickDateStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pickDateStart_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMoving);
            this.panel1.Controls.Add(this.pnlEntryPoints);
            this.panel1.Controls.Add(this.gboxPermitComment);
            this.panel1.Controls.Add(this.pnlInitializer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(985, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 687);
            this.panel1.TabIndex = 4;
            // 
            // dgvMoving
            // 
            this.dgvMoving.AllowUserToAddRows = false;
            this.dgvMoving.AllowUserToDeleteRows = false;
            this.dgvMoving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoving.ColumnHeadersVisible = false;
            this.dgvMoving.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMoving,
            this.ColumnMovingPoint,
            this.ColumnMovingTime});
            this.dgvMoving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMoving.Location = new System.Drawing.Point(0, 208);
            this.dgvMoving.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMoving.Name = "dgvMoving";
            this.dgvMoving.ReadOnly = true;
            this.dgvMoving.RowHeadersVisible = false;
            this.dgvMoving.Size = new System.Drawing.Size(525, 237);
            this.dgvMoving.TabIndex = 5;
            // 
            // ColumnMoving
            // 
            this.ColumnMoving.DataPropertyName = "Moving";
            this.ColumnMoving.HeaderText = "Column1";
            this.ColumnMoving.Name = "ColumnMoving";
            this.ColumnMoving.ReadOnly = true;
            this.ColumnMoving.Width = 75;
            // 
            // ColumnMovingPoint
            // 
            this.ColumnMovingPoint.DataPropertyName = "EntryPoint";
            this.ColumnMovingPoint.HeaderText = "Column1";
            this.ColumnMovingPoint.Name = "ColumnMovingPoint";
            this.ColumnMovingPoint.ReadOnly = true;
            this.ColumnMovingPoint.Width = 150;
            // 
            // ColumnMovingTime
            // 
            this.ColumnMovingTime.DataPropertyName = "MovingTime";
            this.ColumnMovingTime.HeaderText = "Column1";
            this.ColumnMovingTime.Name = "ColumnMovingTime";
            this.ColumnMovingTime.ReadOnly = true;
            // 
            // pnlEntryPoints
            // 
            this.pnlEntryPoints.Controls.Add(this.dgvPointList);
            this.pnlEntryPoints.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEntryPoints.Location = new System.Drawing.Point(0, 445);
            this.pnlEntryPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEntryPoints.Name = "pnlEntryPoints";
            this.pnlEntryPoints.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEntryPoints.Size = new System.Drawing.Size(525, 242);
            this.pnlEntryPoints.TabIndex = 6;
            this.pnlEntryPoints.TabStop = false;
            this.pnlEntryPoints.Text = "Разрешенные пункты пропуска";
            // 
            // dgvPointList
            // 
            this.dgvPointList.AllowUserToAddRows = false;
            this.dgvPointList.AllowUserToDeleteRows = false;
            this.dgvPointList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPointList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPointList.ColumnHeadersVisible = false;
            this.dgvPointList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPermitPoint});
            this.dgvPointList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPointList.Location = new System.Drawing.Point(4, 24);
            this.dgvPointList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPointList.Name = "dgvPointList";
            this.dgvPointList.ReadOnly = true;
            this.dgvPointList.RowHeadersVisible = false;
            this.dgvPointList.Size = new System.Drawing.Size(517, 213);
            this.dgvPointList.TabIndex = 1;
            // 
            // ColumnPermitPoint
            // 
            this.ColumnPermitPoint.DataPropertyName = "Point";
            this.ColumnPermitPoint.HeaderText = "Column4";
            this.ColumnPermitPoint.Name = "ColumnPermitPoint";
            this.ColumnPermitPoint.ReadOnly = true;
            // 
            // gboxPermitComment
            // 
            this.gboxPermitComment.Controls.Add(this.tboxPermitComment);
            this.gboxPermitComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxPermitComment.Location = new System.Drawing.Point(0, 42);
            this.gboxPermitComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxPermitComment.Name = "gboxPermitComment";
            this.gboxPermitComment.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxPermitComment.Size = new System.Drawing.Size(525, 166);
            this.gboxPermitComment.TabIndex = 4;
            this.gboxPermitComment.TabStop = false;
            this.gboxPermitComment.Text = "Комментарий";
            // 
            // tboxPermitComment
            // 
            this.tboxPermitComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxPermitComment.Enabled = false;
            this.tboxPermitComment.Location = new System.Drawing.Point(4, 24);
            this.tboxPermitComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxPermitComment.Multiline = true;
            this.tboxPermitComment.Name = "tboxPermitComment";
            this.tboxPermitComment.Size = new System.Drawing.Size(517, 137);
            this.tboxPermitComment.TabIndex = 1;
            // 
            // pnlInitializer
            // 
            this.pnlInitializer.AutoSize = true;
            this.pnlInitializer.Controls.Add(this.tboxPermitCreator);
            this.pnlInitializer.Controls.Add(this.label13);
            this.pnlInitializer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInitializer.Location = new System.Drawing.Point(0, 0);
            this.pnlInitializer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInitializer.Name = "pnlInitializer";
            this.pnlInitializer.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlInitializer.Size = new System.Drawing.Size(525, 42);
            this.pnlInitializer.TabIndex = 7;
            // 
            // tboxPermitCreator
            // 
            this.tboxPermitCreator.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxPermitCreator.Location = new System.Drawing.Point(144, 8);
            this.tboxPermitCreator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxPermitCreator.Name = "tboxPermitCreator";
            this.tboxPermitCreator.ReadOnly = true;
            this.tboxPermitCreator.Size = new System.Drawing.Size(373, 26);
            this.tboxPermitCreator.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Location = new System.Drawing.Point(8, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "Инициатор";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pagePlanAppointList
            // 
            this.pagePlanAppointList.Controls.Add(this.dgvPlanAppointList);
            this.pagePlanAppointList.Controls.Add(this.pnlComment);
            this.pagePlanAppointList.Controls.Add(this.planAppointTools);
            this.pagePlanAppointList.Controls.Add(this.panelFilter);
            this.pagePlanAppointList.Location = new System.Drawing.Point(4, 29);
            this.pagePlanAppointList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagePlanAppointList.Name = "pagePlanAppointList";
            this.pagePlanAppointList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagePlanAppointList.Size = new System.Drawing.Size(1514, 697);
            this.pagePlanAppointList.TabIndex = 1;
            this.pagePlanAppointList.Text = "tabPage2";
            this.pagePlanAppointList.UseVisualStyleBackColor = true;
            // 
            // dgvPlanAppointList
            // 
            this.dgvPlanAppointList.AllowUserToAddRows = false;
            this.dgvPlanAppointList.AllowUserToDeleteRows = false;
            this.dgvPlanAppointList.AllowUserToOrderColumns = true;
            this.dgvPlanAppointList.AutoGenerateColumns = false;
            this.dgvPlanAppointList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanAppointList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDateModified,
            this.ColumnCargo,
            this.ColumnDateFrom,
            this.ColumnVehicle,
            this.ColumnDriverName,
            this.ColumnContact,
            this.ColumnWhereTo,
            this.ColumnAppointCreator});
            this.dgvPlanAppointList.DataSource = this.bsPlanAppointList;
            this.dgvPlanAppointList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanAppointList.Location = new System.Drawing.Point(4, 76);
            this.dgvPlanAppointList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPlanAppointList.MultiSelect = false;
            this.dgvPlanAppointList.Name = "dgvPlanAppointList";
            this.dgvPlanAppointList.ReadOnly = true;
            this.dgvPlanAppointList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanAppointList.Size = new System.Drawing.Size(1506, 462);
            this.dgvPlanAppointList.TabIndex = 1;
            this.dgvPlanAppointList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPlanAppointList_RowPrePaint);
            // 
            // ColumnDateModified
            // 
            this.ColumnDateModified.DataPropertyName = "DateModified";
            this.ColumnDateModified.HeaderText = "Дата изменения";
            this.ColumnDateModified.Name = "ColumnDateModified";
            this.ColumnDateModified.ReadOnly = true;
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.DataPropertyName = "Cargo";
            this.ColumnCargo.HeaderText = "Груз";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            // 
            // ColumnDateFrom
            // 
            this.ColumnDateFrom.DataPropertyName = "DateFrom";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnDateFrom.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDateFrom.HeaderText = "дата прибытия";
            this.ColumnDateFrom.Name = "ColumnDateFrom";
            this.ColumnDateFrom.ReadOnly = true;
            this.ColumnDateFrom.Width = 75;
            // 
            // ColumnVehicle
            // 
            this.ColumnVehicle.DataPropertyName = "Vehicle";
            this.ColumnVehicle.HeaderText = "Т/средство";
            this.ColumnVehicle.Name = "ColumnVehicle";
            this.ColumnVehicle.ReadOnly = true;
            // 
            // ColumnDriverName
            // 
            this.ColumnDriverName.DataPropertyName = "DriverName";
            this.ColumnDriverName.HeaderText = "Водитель";
            this.ColumnDriverName.Name = "ColumnDriverName";
            this.ColumnDriverName.ReadOnly = true;
            // 
            // ColumnContact
            // 
            this.ColumnContact.DataPropertyName = "Contact";
            this.ColumnContact.HeaderText = "Конт. информация";
            this.ColumnContact.Name = "ColumnContact";
            this.ColumnContact.ReadOnly = true;
            // 
            // ColumnWhereTo
            // 
            this.ColumnWhereTo.DataPropertyName = "WhereTo";
            this.ColumnWhereTo.HeaderText = "Откуда/куда";
            this.ColumnWhereTo.Name = "ColumnWhereTo";
            this.ColumnWhereTo.ReadOnly = true;
            // 
            // ColumnAppointCreator
            // 
            this.ColumnAppointCreator.DataPropertyName = "Creator";
            this.ColumnAppointCreator.HeaderText = "Инициатор";
            this.ColumnAppointCreator.Name = "ColumnAppointCreator";
            this.ColumnAppointCreator.ReadOnly = true;
            // 
            // pnlComment
            // 
            this.pnlComment.Controls.Add(this.tboxComment);
            this.pnlComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlComment.Location = new System.Drawing.Point(4, 538);
            this.pnlComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlComment.Name = "pnlComment";
            this.pnlComment.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlComment.Size = new System.Drawing.Size(1506, 154);
            this.pnlComment.TabIndex = 2;
            this.pnlComment.TabStop = false;
            this.pnlComment.Text = "Комментарий";
            // 
            // tboxComment
            // 
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxComment.Enabled = false;
            this.tboxComment.Location = new System.Drawing.Point(4, 24);
            this.tboxComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxComment.Multiline = true;
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.Size = new System.Drawing.Size(1498, 125);
            this.tboxComment.TabIndex = 0;
            // 
            // planAppointTools
            // 
            this.planAppointTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblToRefresh2,
            this.createPermitTool,
            this.lockAppointTool,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.lblPageNumber,
            this.btnPreviousPage,
            this.btnNextPage});
            this.planAppointTools.Location = new System.Drawing.Point(4, 51);
            this.planAppointTools.Name = "planAppointTools";
            this.planAppointTools.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.planAppointTools.Size = new System.Drawing.Size(1506, 25);
            this.planAppointTools.TabIndex = 0;
            this.planAppointTools.Text = "toolStrip1";
            // 
            // lblToRefresh2
            // 
            this.lblToRefresh2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblToRefresh2.Name = "lblToRefresh2";
            this.lblToRefresh2.Size = new System.Drawing.Size(34, 22);
            this.lblToRefresh2.Text = "0 сек";
            // 
            // createPermitTool
            // 
            this.createPermitTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createPermitTool.Image = ((System.Drawing.Image)(resources.GetObject("createPermitTool.Image")));
            this.createPermitTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createPermitTool.Name = "createPermitTool";
            this.createPermitTool.Size = new System.Drawing.Size(23, 22);
            this.createPermitTool.Text = "оформить пропускэ";
            this.createPermitTool.Click += new System.EventHandler(this.createPermitTool_Click);
            // 
            // lockAppointTool
            // 
            this.lockAppointTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lockAppointTool.Image = ((System.Drawing.Image)(resources.GetObject("lockAppointTool.Image")));
            this.lockAppointTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lockAppointTool.Name = "lockAppointTool";
            this.lockAppointTool.Size = new System.Drawing.Size(23, 22);
            this.lockAppointTool.Text = "отказать в пропуске";
            this.lockAppointTool.Click += new System.EventHandler(this.lockAppointTool_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "стр. ";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(30, 22);
            this.lblPageNumber.Text = "0 / 0";
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.Image")));
            this.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(23, 22);
            this.btnPreviousPage.Text = "предыдущая";
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(23, 22);
            this.btnNextPage.Text = "следующая";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.pickPlanAppointStart);
            this.panelFilter.Controls.Add(this.label4);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(4, 5);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1506, 46);
            this.panelFilter.TabIndex = 3;
            // 
            // pickPlanAppointStart
            // 
            this.pickPlanAppointStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickPlanAppointStart.Location = new System.Drawing.Point(180, 5);
            this.pickPlanAppointStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickPlanAppointStart.Name = "pickPlanAppointStart";
            this.pickPlanAppointStart.Size = new System.Drawing.Size(146, 26);
            this.pickPlanAppointStart.TabIndex = 1;
            this.pickPlanAppointStart.ValueChanged += new System.EventHandler(this.pickPlanAppointStart_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Заявки не ранее";
            // 
            // pageMaterialDocumentList
            // 
            this.pageMaterialDocumentList.Controls.Add(this.splitContainer1);
            this.pageMaterialDocumentList.Location = new System.Drawing.Point(4, 29);
            this.pageMaterialDocumentList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageMaterialDocumentList.Name = "pageMaterialDocumentList";
            this.pageMaterialDocumentList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageMaterialDocumentList.Size = new System.Drawing.Size(1514, 684);
            this.pageMaterialDocumentList.TabIndex = 2;
            this.pageMaterialDocumentList.Text = "materialDocumentPage";
            this.pageMaterialDocumentList.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 5);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvMaterialPermitList);
            this.splitContainer1.Panel1.Controls.Add(this.materialPermitToolStrip);
            this.splitContainer1.Panel1.Controls.Add(this.pnlMaterialPermitFilter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mdTable);
            this.splitContainer1.Panel2.Controls.Add(this.pbarMdLoading);
            this.splitContainer1.Size = new System.Drawing.Size(1506, 674);
            this.splitContainer1.SplitterDistance = 851;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvMaterialPermitList
            // 
            this.dgvMaterialPermitList.AllowUserToAddRows = false;
            this.dgvMaterialPermitList.AllowUserToDeleteRows = false;
            this.dgvMaterialPermitList.AutoGenerateColumns = false;
            this.dgvMaterialPermitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialPermitList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMdDocNumber,
            this.ColumnMdDocDate,
            this.ColumnMdUnit,
            this.mdColumnCreated,
            this.mdColumnSigned,
            this.mdColumnEntry});
            this.dgvMaterialPermitList.DataSource = this.bsMaterialDocumentList;
            this.dgvMaterialPermitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterialPermitList.Location = new System.Drawing.Point(0, 73);
            this.dgvMaterialPermitList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMaterialPermitList.Name = "dgvMaterialPermitList";
            this.dgvMaterialPermitList.ReadOnly = true;
            this.dgvMaterialPermitList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialPermitList.Size = new System.Drawing.Size(851, 601);
            this.dgvMaterialPermitList.TabIndex = 2;
            // 
            // ColumnMdDocNumber
            // 
            this.ColumnMdDocNumber.DataPropertyName = "DocNumber";
            this.ColumnMdDocNumber.HeaderText = "Номер документа";
            this.ColumnMdDocNumber.Name = "ColumnMdDocNumber";
            this.ColumnMdDocNumber.ReadOnly = true;
            // 
            // ColumnMdDocDate
            // 
            this.ColumnMdDocDate.DataPropertyName = "DocDate";
            this.ColumnMdDocDate.HeaderText = "Дата документа";
            this.ColumnMdDocDate.Name = "ColumnMdDocDate";
            this.ColumnMdDocDate.ReadOnly = true;
            // 
            // ColumnMdUnit
            // 
            this.ColumnMdUnit.DataPropertyName = "Unit";
            this.ColumnMdUnit.HeaderText = "Подразделение";
            this.ColumnMdUnit.Name = "ColumnMdUnit";
            this.ColumnMdUnit.ReadOnly = true;
            // 
            // mdColumnCreated
            // 
            this.mdColumnCreated.DataPropertyName = "CreatedImage";
            this.mdColumnCreated.HeaderText = "подтв.";
            this.mdColumnCreated.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.mdColumnCreated.Name = "mdColumnCreated";
            this.mdColumnCreated.ReadOnly = true;
            this.mdColumnCreated.Width = 35;
            // 
            // mdColumnSigned
            // 
            this.mdColumnSigned.DataPropertyName = "SignedImage";
            this.mdColumnSigned.HeaderText = "СБ";
            this.mdColumnSigned.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.mdColumnSigned.Name = "mdColumnSigned";
            this.mdColumnSigned.ReadOnly = true;
            this.mdColumnSigned.Width = 35;
            // 
            // mdColumnEntry
            // 
            this.mdColumnEntry.DataPropertyName = "EntryImage";
            this.mdColumnEntry.HeaderText = "выезд";
            this.mdColumnEntry.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.mdColumnEntry.Name = "mdColumnEntry";
            this.mdColumnEntry.ReadOnly = true;
            this.mdColumnEntry.Width = 35;
            // 
            // bsMaterialDocumentList
            // 
            this.bsMaterialDocumentList.CurrentChanged += new System.EventHandler(this.bsMaterialDocumentList_CurrentChanged);
            // 
            // materialPermitToolStrip
            // 
            this.materialPermitToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblToRefresh3,
            this.toolStripButton1});
            this.materialPermitToolStrip.Location = new System.Drawing.Point(0, 48);
            this.materialPermitToolStrip.Name = "materialPermitToolStrip";
            this.materialPermitToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.materialPermitToolStrip.Size = new System.Drawing.Size(851, 25);
            this.materialPermitToolStrip.TabIndex = 1;
            this.materialPermitToolStrip.Text = "toolStrip2";
            // 
            // lblToRefresh3
            // 
            this.lblToRefresh3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblToRefresh3.Name = "lblToRefresh3";
            this.lblToRefresh3.Size = new System.Drawing.Size(34, 22);
            this.lblToRefresh3.Text = "0 сек";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pnlMaterialPermitFilter
            // 
            this.pnlMaterialPermitFilter.Controls.Add(this.pickMdDateTo);
            this.pnlMaterialPermitFilter.Controls.Add(this.pickMdDateFrom);
            this.pnlMaterialPermitFilter.Controls.Add(this.label14);
            this.pnlMaterialPermitFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMaterialPermitFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlMaterialPermitFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMaterialPermitFilter.Name = "pnlMaterialPermitFilter";
            this.pnlMaterialPermitFilter.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlMaterialPermitFilter.Size = new System.Drawing.Size(851, 48);
            this.pnlMaterialPermitFilter.TabIndex = 0;
            // 
            // pickMdDateTo
            // 
            this.pickMdDateTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pickMdDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickMdDateTo.Location = new System.Drawing.Point(246, 8);
            this.pickMdDateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickMdDateTo.Name = "pickMdDateTo";
            this.pickMdDateTo.Size = new System.Drawing.Size(145, 26);
            this.pickMdDateTo.TabIndex = 3;
            this.pickMdDateTo.ValueChanged += new System.EventHandler(this.pickDateStart_ValueChanged);
            // 
            // pickMdDateFrom
            // 
            this.pickMdDateFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.pickMdDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickMdDateFrom.Location = new System.Drawing.Point(101, 8);
            this.pickMdDateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickMdDateFrom.Name = "pickMdDateFrom";
            this.pickMdDateFrom.Size = new System.Drawing.Size(145, 26);
            this.pickMdDateFrom.TabIndex = 2;
            this.pickMdDateFrom.ValueChanged += new System.EventHandler(this.pickDateStart_ValueChanged);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Location = new System.Drawing.Point(8, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "Период";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mdTable
            // 
            this.mdTable.ColumnCount = 2;
            this.mdTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mdTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mdTable.Controls.Add(this.textBox1, 1, 10);
            this.mdTable.Controls.Add(this.label12, 0, 10);
            this.mdTable.Controls.Add(this.tboxMdEntryDate, 1, 9);
            this.mdTable.Controls.Add(this.tboxMdEntryPoint, 1, 8);
            this.mdTable.Controls.Add(this.label11, 0, 8);
            this.mdTable.Controls.Add(this.pboxMdEntry, 0, 9);
            this.mdTable.Controls.Add(this.tboxSigner, 1, 5);
            this.mdTable.Controls.Add(this.label10, 0, 5);
            this.mdTable.Controls.Add(this.tboxMdSignedDate, 1, 6);
            this.mdTable.Controls.Add(this.pboxMdSigned, 0, 6);
            this.mdTable.Controls.Add(this.tboxMdCreatedDate, 1, 4);
            this.mdTable.Controls.Add(this.tboxMdCreator, 1, 3);
            this.mdTable.Controls.Add(this.label9, 0, 3);
            this.mdTable.Controls.Add(this.tboxMdLicensePlate, 1, 2);
            this.mdTable.Controls.Add(this.label8, 0, 2);
            this.mdTable.Controls.Add(this.tboxMdVehicleMark, 1, 1);
            this.mdTable.Controls.Add(this.label7, 0, 1);
            this.mdTable.Controls.Add(this.label6, 0, 0);
            this.mdTable.Controls.Add(this.tboxMdPerson, 1, 0);
            this.mdTable.Controls.Add(this.pboxCreatedImage, 0, 4);
            this.mdTable.Controls.Add(this.tableLayoutPanel1, 1, 7);
            this.mdTable.Controls.Add(this.dgvMdItems, 0, 11);
            this.mdTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdTable.Location = new System.Drawing.Point(0, 35);
            this.mdTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mdTable.Name = "mdTable";
            this.mdTable.RowCount = 12;
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mdTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.mdTable.Size = new System.Drawing.Size(649, 639);
            this.mdTable.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(159, 489);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(482, 26);
            this.textBox1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(4, 481);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 42);
            this.label12.TabIndex = 19;
            this.label12.Text = "Основание";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxMdEntryDate
            // 
            this.tboxMdEntryDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxMdEntryDate.Location = new System.Drawing.Point(159, 433);
            this.tboxMdEntryDate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tboxMdEntryDate.Name = "tboxMdEntryDate";
            this.tboxMdEntryDate.ReadOnly = true;
            this.tboxMdEntryDate.Size = new System.Drawing.Size(482, 26);
            this.tboxMdEntryDate.TabIndex = 18;
            // 
            // tboxMdEntryPoint
            // 
            this.tboxMdEntryPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxMdEntryPoint.Location = new System.Drawing.Point(159, 391);
            this.tboxMdEntryPoint.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tboxMdEntryPoint.Name = "tboxMdEntryPoint";
            this.tboxMdEntryPoint.ReadOnly = true;
            this.tboxMdEntryPoint.Size = new System.Drawing.Size(482, 26);
            this.tboxMdEntryPoint.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(4, 383);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 42);
            this.label11.TabIndex = 16;
            this.label11.Text = "П. пропуска";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pboxMdEntry
            // 
            this.pboxMdEntry.Dock = System.Windows.Forms.DockStyle.Right;
            this.pboxMdEntry.Location = new System.Drawing.Point(113, 433);
            this.pboxMdEntry.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pboxMdEntry.Name = "pboxMdEntry";
            this.pboxMdEntry.Size = new System.Drawing.Size(30, 40);
            this.pboxMdEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMdEntry.TabIndex = 15;
            this.pboxMdEntry.TabStop = false;
            // 
            // tboxSigner
            // 
            this.tboxSigner.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxSigner.Location = new System.Drawing.Point(159, 232);
            this.tboxSigner.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tboxSigner.Name = "tboxSigner";
            this.tboxSigner.ReadOnly = true;
            this.tboxSigner.Size = new System.Drawing.Size(482, 26);
            this.tboxSigner.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(4, 224);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 42);
            this.label10.TabIndex = 13;
            this.label10.Text = "Сл. безопасности";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxMdSignedDate
            // 
            this.tboxMdSignedDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxMdSignedDate.Location = new System.Drawing.Point(159, 274);
            this.tboxMdSignedDate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tboxMdSignedDate.Name = "tboxMdSignedDate";
            this.tboxMdSignedDate.ReadOnly = true;
            this.tboxMdSignedDate.Size = new System.Drawing.Size(482, 26);
            this.tboxMdSignedDate.TabIndex = 11;
            // 
            // pboxMdSigned
            // 
            this.pboxMdSigned.Dock = System.Windows.Forms.DockStyle.Right;
            this.pboxMdSigned.Location = new System.Drawing.Point(113, 274);
            this.pboxMdSigned.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pboxMdSigned.Name = "pboxMdSigned";
            this.pboxMdSigned.Size = new System.Drawing.Size(30, 40);
            this.pboxMdSigned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMdSigned.TabIndex = 10;
            this.pboxMdSigned.TabStop = false;
            // 
            // tboxMdCreatedDate
            // 
            this.tboxMdCreatedDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxMdCreatedDate.Location = new System.Drawing.Point(159, 176);
            this.tboxMdCreatedDate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tboxMdCreatedDate.Name = "tboxMdCreatedDate";
            this.tboxMdCreatedDate.ReadOnly = true;
            this.tboxMdCreatedDate.Size = new System.Drawing.Size(482, 26);
            this.tboxMdCreatedDate.TabIndex = 9;
            // 
            // tboxMdCreator
            // 
            this.tboxMdCreator.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxMdCreator.Location = new System.Drawing.Point(159, 134);
            this.tboxMdCreator.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tboxMdCreator.Name = "tboxMdCreator";
            this.tboxMdCreator.ReadOnly = true;
            this.tboxMdCreator.Size = new System.Drawing.Size(482, 26);
            this.tboxMdCreator.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(4, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 42);
            this.label9.TabIndex = 6;
            this.label9.Text = "Кладовщик";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxMdLicensePlate
            // 
            this.tboxMdLicensePlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxMdLicensePlate.Location = new System.Drawing.Point(159, 92);
            this.tboxMdLicensePlate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tboxMdLicensePlate.Name = "tboxMdLicensePlate";
            this.tboxMdLicensePlate.ReadOnly = true;
            this.tboxMdLicensePlate.Size = new System.Drawing.Size(482, 26);
            this.tboxMdLicensePlate.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(4, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 42);
            this.label8.TabIndex = 4;
            this.label8.Text = "Номер ТС";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxMdVehicleMark
            // 
            this.tboxMdVehicleMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxMdVehicleMark.Location = new System.Drawing.Point(159, 50);
            this.tboxMdVehicleMark.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tboxMdVehicleMark.Name = "tboxMdVehicleMark";
            this.tboxMdVehicleMark.ReadOnly = true;
            this.tboxMdVehicleMark.Size = new System.Drawing.Size(482, 26);
            this.tboxMdVehicleMark.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 42);
            this.label7.TabIndex = 2;
            this.label7.Text = "Марка ТС";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Предъявитель";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxMdPerson
            // 
            this.tboxMdPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxMdPerson.Location = new System.Drawing.Point(159, 8);
            this.tboxMdPerson.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tboxMdPerson.Name = "tboxMdPerson";
            this.tboxMdPerson.ReadOnly = true;
            this.tboxMdPerson.Size = new System.Drawing.Size(482, 26);
            this.tboxMdPerson.TabIndex = 1;
            // 
            // pboxCreatedImage
            // 
            this.pboxCreatedImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pboxCreatedImage.Location = new System.Drawing.Point(113, 176);
            this.pboxCreatedImage.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pboxCreatedImage.Name = "pboxCreatedImage";
            this.pboxCreatedImage.Size = new System.Drawing.Size(30, 40);
            this.pboxCreatedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxCreatedImage.TabIndex = 8;
            this.pboxCreatedImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnLockMd, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSignMd, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 327);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 51);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // btnLockMd
            // 
            this.btnLockMd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLockMd.Location = new System.Drawing.Point(256, 5);
            this.btnLockMd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLockMd.Name = "btnLockMd";
            this.btnLockMd.Size = new System.Drawing.Size(230, 42);
            this.btnLockMd.TabIndex = 1;
            this.btnLockMd.Text = "Отклонить";
            this.btnLockMd.UseVisualStyleBackColor = true;
            this.btnLockMd.Click += new System.EventHandler(this.btnLockMd_Click);
            // 
            // btnSignMd
            // 
            this.btnSignMd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignMd.Location = new System.Drawing.Point(4, 5);
            this.btnSignMd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignMd.Name = "btnSignMd";
            this.btnSignMd.Size = new System.Drawing.Size(229, 42);
            this.btnSignMd.TabIndex = 0;
            this.btnSignMd.Text = "Подтвердить";
            this.btnSignMd.UseVisualStyleBackColor = true;
            this.btnSignMd.Click += new System.EventHandler(this.btnSignMd_Click);
            // 
            // dgvMdItems
            // 
            this.dgvMdItems.AllowUserToAddRows = false;
            this.dgvMdItems.AllowUserToDeleteRows = false;
            this.dgvMdItems.AutoGenerateColumns = false;
            this.dgvMdItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mdItemColName,
            this.mdItemColUnity,
            this.mdItemColQuantity,
            this.mdItemColWeight});
            this.mdTable.SetColumnSpan(this.dgvMdItems, 2);
            this.dgvMdItems.DataSource = this.bsMdItems;
            this.dgvMdItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMdItems.Location = new System.Drawing.Point(4, 528);
            this.dgvMdItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMdItems.Name = "dgvMdItems";
            this.dgvMdItems.ReadOnly = true;
            this.dgvMdItems.Size = new System.Drawing.Size(641, 106);
            this.dgvMdItems.TabIndex = 21;
            // 
            // mdItemColName
            // 
            this.mdItemColName.DataPropertyName = "Material";
            this.mdItemColName.HeaderText = "наименование";
            this.mdItemColName.Name = "mdItemColName";
            this.mdItemColName.ReadOnly = true;
            // 
            // mdItemColUnity
            // 
            this.mdItemColUnity.DataPropertyName = "MaterialUnit";
            this.mdItemColUnity.FillWeight = 20F;
            this.mdItemColUnity.HeaderText = "ед.";
            this.mdItemColUnity.Name = "mdItemColUnity";
            this.mdItemColUnity.ReadOnly = true;
            // 
            // mdItemColQuantity
            // 
            this.mdItemColQuantity.DataPropertyName = "Quantity";
            this.mdItemColQuantity.FillWeight = 20F;
            this.mdItemColQuantity.HeaderText = "кол-во";
            this.mdItemColQuantity.Name = "mdItemColQuantity";
            this.mdItemColQuantity.ReadOnly = true;
            // 
            // mdItemColWeight
            // 
            this.mdItemColWeight.DataPropertyName = "Tonnage";
            this.mdItemColWeight.FillWeight = 20F;
            this.mdItemColWeight.HeaderText = "вес";
            this.mdItemColWeight.Name = "mdItemColWeight";
            this.mdItemColWeight.ReadOnly = true;
            // 
            // pbarMdLoading
            // 
            this.pbarMdLoading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbarMdLoading.Location = new System.Drawing.Point(0, 0);
            this.pbarMdLoading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbarMdLoading.Name = "pbarMdLoading";
            this.pbarMdLoading.Size = new System.Drawing.Size(649, 35);
            this.pbarMdLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbarMdLoading.TabIndex = 0;
            this.pbarMdLoading.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialPermitTool,
            this.btnChangePassword,
            this.blackListButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1522, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // materialPermitTool
            // 
            this.materialPermitTool.Image = ((System.Drawing.Image)(resources.GetObject("materialPermitTool.Image")));
            this.materialPermitTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.materialPermitTool.Name = "materialPermitTool";
            this.materialPermitTool.Size = new System.Drawing.Size(163, 22);
            this.materialPermitTool.Text = "материальные пропуска";
            this.materialPermitTool.Visible = false;
            this.materialPermitTool.Click += new System.EventHandler(this.materialPermitTool_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(116, 22);
            this.btnChangePassword.Text = "сменить пароль";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // blackListButton
            // 
            this.blackListButton.Image = ((System.Drawing.Image)(resources.GetObject("blackListButton.Image")));
            this.blackListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blackListButton.Name = "blackListButton";
            this.blackListButton.Size = new System.Drawing.Size(113, 22);
            this.blackListButton.Text = "Черный список";
            this.blackListButton.Click += new System.EventHandler(this.blackListButton_Click);
            // 
            // bgRefreshMaterialDocumentList
            // 
            this.bgRefreshMaterialDocumentList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgRefreshMaterialDocumentList_DoWork);
            this.bgRefreshMaterialDocumentList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgRefreshMaterialDocumentList_RunWorkerCompleted);
            // 
            // bgLastMaterialDocumentDate
            // 
            this.bgLastMaterialDocumentDate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLastMaterialDocumentDate_DoWork);
            this.bgLastMaterialDocumentDate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLastMaterialDocumentDate_RunWorkerCompleted);
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 755);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReceptionForm";
            this.Text = "Бюро пропусков";
            ((System.ComponentModel.ISupportInitialize)(this.bsPermitList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanAppointList)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.permitPage.ResumeLayout(false);
            this.permitPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermitList)).EndInit();
            this.permitTools.ResumeLayout(false);
            this.permitTools.PerformLayout();
            this.permitTopPanel.ResumeLayout(false);
            this.permitTopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoving)).EndInit();
            this.pnlEntryPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointList)).EndInit();
            this.gboxPermitComment.ResumeLayout(false);
            this.gboxPermitComment.PerformLayout();
            this.pnlInitializer.ResumeLayout(false);
            this.pnlInitializer.PerformLayout();
            this.pagePlanAppointList.ResumeLayout(false);
            this.pagePlanAppointList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanAppointList)).EndInit();
            this.pnlComment.ResumeLayout(false);
            this.pnlComment.PerformLayout();
            this.planAppointTools.ResumeLayout(false);
            this.planAppointTools.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.pageMaterialDocumentList.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialPermitList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterialDocumentList)).EndInit();
            this.materialPermitToolStrip.ResumeLayout(false);
            this.materialPermitToolStrip.PerformLayout();
            this.pnlMaterialPermitFilter.ResumeLayout(false);
            this.mdTable.ResumeLayout(false);
            this.mdTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMdEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMdSigned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreatedImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMdItems)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterialDocumentItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage permitPage;
        private System.Windows.Forms.Panel permitTopPanel;
        private System.Windows.Forms.DateTimePicker pickDateFinish;
        private System.Windows.Forms.DateTimePicker pickDateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pagePlanAppointList;
        private ReferenceBox rboxEntryPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsPermitList;
        private System.Windows.Forms.DataGridView dgvPermitList;
        private System.Windows.Forms.ToolStrip permitTools;
        private System.ComponentModel.BackgroundWorker bgRefreshPermitList;
        private System.Windows.Forms.Timer refreshTimer;
        private System.ComponentModel.BackgroundWorker bgLastUpdateDate;
        private System.ComponentModel.BackgroundWorker bgLastPlanAppointDate;
        private System.ComponentModel.BackgroundWorker bgRefreshPlanAppointList;
        private System.Windows.Forms.BindingSource bsPlanAppointList;
        private System.Windows.Forms.DataGridView dgvPlanAppointList;
        private System.Windows.Forms.ToolStrip planAppointTools;
        private System.Windows.Forms.ToolStripLabel lblToRefresh;
        private System.Windows.Forms.ToolStripLabel lblToRefresh2;
        private System.Windows.Forms.ToolStripButton createPermitTool;
        private System.Windows.Forms.ToolStripButton lockAppointTool;
        private System.Windows.Forms.ToolStripButton addPermitTool;
        private System.Windows.Forms.ToolStripButton editPermitTool;
        private System.Windows.Forms.ToolStripButton deletePermitTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshPermiListTool;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton materialPermitTool;
        private System.Windows.Forms.GroupBox pnlComment;
        private System.Windows.Forms.TextBox tboxComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gboxPermitComment;
        private System.Windows.Forms.TextBox tboxPermitComment;
        private System.Windows.Forms.DataGridView dgvMoving;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMoving;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMovingPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMovingTime;
        private System.Windows.Forms.GroupBox pnlEntryPoints;
        private System.Windows.Forms.DataGridView dgvPointList;
        private System.Windows.Forms.ToolStripButton btnChangePassword;
        private System.Windows.Forms.ComboBox cboxPermitType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton printPermitListTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWhereTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAppointCreator;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.DateTimePicker pickPlanAppointStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel findLabel;
        private System.Windows.Forms.ToolStripTextBox findTextBox;
        private System.Windows.Forms.ToolStripButton findNextTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblPageNumber;
        private System.Windows.Forms.ToolStripButton btnPreviousPage;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblPermitPage;
        private System.Windows.Forms.ToolStripButton btnPreviousPermitPage;
        private System.Windows.Forms.ToolStripButton btnNextPermitPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPermitPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage pageMaterialDocumentList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvMaterialPermitList;
        private System.Windows.Forms.BindingSource bsMaterialDocumentList;
        private System.Windows.Forms.ToolStrip materialPermitToolStrip;
        private System.Windows.Forms.Panel pnlMaterialPermitFilter;
        private System.ComponentModel.BackgroundWorker bgRefreshMaterialDocumentList;
        private System.Windows.Forms.ToolStripLabel lblToRefresh3;
        private System.ComponentModel.BackgroundWorker bgLastMaterialDocumentDate;
        private System.Windows.Forms.ProgressBar pbarMdLoading;
        private System.Windows.Forms.TableLayoutPanel mdTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxMdPerson;
        private System.Windows.Forms.BindingSource bsMaterialDocumentItem;
        private System.Windows.Forms.TextBox tboxMdVehicleMark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxMdLicensePlate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxMdCreator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pboxCreatedImage;
        private System.Windows.Forms.TextBox tboxMdCreatedDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tboxMdSignedDate;
        private System.Windows.Forms.PictureBox pboxMdSigned;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLockMd;
        private System.Windows.Forms.Button btnSignMd;
        private System.Windows.Forms.TextBox tboxSigner;
        private System.Windows.Forms.TextBox tboxMdEntryDate;
        private System.Windows.Forms.TextBox tboxMdEntryPoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pboxMdEntry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvMdItems;
        private System.Windows.Forms.BindingSource bsMdItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdItemColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdItemColUnity;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdItemColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdItemColWeight;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel pnlInitializer;
        private System.Windows.Forms.TextBox tboxPermitCreator;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPermitState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPContact;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnMultiEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMdDocNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMdDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMdUnit;
        private System.Windows.Forms.DataGridViewImageColumn mdColumnCreated;
        private System.Windows.Forms.DataGridViewImageColumn mdColumnSigned;
        private System.Windows.Forms.DataGridViewImageColumn mdColumnEntry;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker pickMdDateTo;
        private System.Windows.Forms.DateTimePicker pickMdDateFrom;
        private System.Windows.Forms.ToolStripButton blackListButton;
    }
}
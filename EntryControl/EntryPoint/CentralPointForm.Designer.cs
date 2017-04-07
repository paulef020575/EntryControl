namespace EntryControl
{
    partial class EntryPointForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPointForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.bgEnteredRefresh = new System.ComponentModel.BackgroundWorker();
            this.bgPlanAppointRefresh = new System.ComponentModel.BackgroundWorker();
            this.bsHistoryReport = new System.Windows.Forms.BindingSource(this.components);
            this.bsPlanAppoint = new System.Windows.Forms.BindingSource(this.components);
            this.bsEnteredVehicle = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelEntered = new System.Windows.Forms.Panel();
            this.panelHistoryReport = new System.Windows.Forms.Panel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.dgvHistoryReport = new System.Windows.Forms.DataGridView();
            this.ColHstMovingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHstEntryPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHstDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHstCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHstMoving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHstPermit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelReportHeader = new System.Windows.Forms.Panel();
            this.btnPrintHistory = new System.Windows.Forms.Button();
            this.tboxVehicleMask = new System.Windows.Forms.TextBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPlanAppoints = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ClmVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planAppointTools = new System.Windows.Forms.ToolStrip();
            this.createPermitTool = new System.Windows.Forms.ToolStripButton();
            this.btnNotifyProperties = new System.Windows.Forms.ToolStripButton();
            this.btnAlwaysNotify = new System.Windows.Forms.ToolStripButton();
            this.panelEnteredVehicles = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnEntryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVehicleMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lboxStaff = new System.Windows.Forms.ListBox();
            this.panelEntryPointList = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.staffTool = new System.Windows.Forms.ToolStripButton();
            this.panelComment = new System.Windows.Forms.Panel();
            this.gboxCreator = new System.Windows.Forms.GroupBox();
            this.lblCreator = new System.Windows.Forms.Label();
            this.gboxComment = new System.Windows.Forms.GroupBox();
            this.lblComment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsHistoryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanAppoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnteredVehicle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelEntered.SuspendLayout();
            this.panelHistoryReport.SuspendLayout();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryReport)).BeginInit();
            this.panelReportHeader.SuspendLayout();
            this.panelPlanAppoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.planAppointTools.SuspendLayout();
            this.panelEnteredVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelComment.SuspendLayout();
            this.gboxCreator.SuspendLayout();
            this.gboxComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // bgEnteredRefresh
            // 
            this.bgEnteredRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgEnteredRefresh_DoWork);
            this.bgEnteredRefresh.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgEnteredRefresh_RunWorkerCompleted);
            // 
            // bgPlanAppointRefresh
            // 
            this.bgPlanAppointRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgPlanAppointRefresh_DoWork);
            this.bgPlanAppointRefresh.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgPlanAppointRefresh_RunWorkerCompleted);
            // 
            // bsHistoryReport
            // 
            this.bsHistoryReport.CurrentChanged += new System.EventHandler(this.bsHistoryReport_CurrentChanged);
            // 
            // bsPlanAppoint
            // 
            this.bsPlanAppoint.DataSourceChanged += new System.EventHandler(this.bsPlanAppoint_CurrentChanged);
            this.bsPlanAppoint.CurrentChanged += new System.EventHandler(this.bsPlanAppoint_CurrentChanged);
            // 
            // bsEnteredVehicle
            // 
            this.bsEnteredVehicle.CurrentChanged += new System.EventHandler(this.bsEnteredVehicle_CurrentChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panelEntered, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelComment, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(969, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelEntered
            // 
            this.panelEntered.Controls.Add(this.panelHistoryReport);
            this.panelEntered.Controls.Add(this.panelPlanAppoints);
            this.panelEntered.Controls.Add(this.panelEnteredVehicles);
            this.panelEntered.Controls.Add(this.tableLayoutPanel2);
            this.panelEntered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelEntered.Location = new System.Drawing.Point(3, 3);
            this.panelEntered.Name = "panelEntered";
            this.panelEntered.Size = new System.Drawing.Size(663, 570);
            this.panelEntered.TabIndex = 0;
            // 
            // panelHistoryReport
            // 
            this.panelHistoryReport.Controls.Add(this.panelReport);
            this.panelHistoryReport.Controls.Add(this.panelReportHeader);
            this.panelHistoryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistoryReport.Location = new System.Drawing.Point(0, 84);
            this.panelHistoryReport.Name = "panelHistoryReport";
            this.panelHistoryReport.Size = new System.Drawing.Size(663, 486);
            this.panelHistoryReport.TabIndex = 2;
            this.panelHistoryReport.VisibleChanged += new System.EventHandler(this.panelHistoryReport_VisibleChanged);
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.dgvHistoryReport);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 86);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(663, 400);
            this.panelReport.TabIndex = 1;
            // 
            // dgvHistoryReport
            // 
            this.dgvHistoryReport.AllowUserToAddRows = false;
            this.dgvHistoryReport.AllowUserToDeleteRows = false;
            this.dgvHistoryReport.AutoGenerateColumns = false;
            this.dgvHistoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHstMovingTime,
            this.ColVehicle,
            this.ColHstEntryPoint,
            this.ColHstDriverName,
            this.ColHstCargo,
            this.ColHstMoving,
            this.ColHstPermit});
            this.dgvHistoryReport.DataSource = this.bsHistoryReport;
            this.dgvHistoryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistoryReport.Location = new System.Drawing.Point(0, 0);
            this.dgvHistoryReport.Name = "dgvHistoryReport";
            this.dgvHistoryReport.ReadOnly = true;
            this.dgvHistoryReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoryReport.Size = new System.Drawing.Size(663, 400);
            this.dgvHistoryReport.TabIndex = 0;
            this.dgvHistoryReport.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvHistoryReport_RowPrePaint);
            // 
            // ColHstMovingTime
            // 
            this.ColHstMovingTime.DataPropertyName = "MovingTime";
            dataGridViewCellStyle1.Format = "dd.MM HH:mm";
            dataGridViewCellStyle1.NullValue = null;
            this.ColHstMovingTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColHstMovingTime.HeaderText = "";
            this.ColHstMovingTime.Name = "ColHstMovingTime";
            this.ColHstMovingTime.ReadOnly = true;
            // 
            // ColVehicle
            // 
            this.ColVehicle.DataPropertyName = "Vehicle";
            this.ColVehicle.HeaderText = "т/средство";
            this.ColVehicle.Name = "ColVehicle";
            this.ColVehicle.ReadOnly = true;
            this.ColVehicle.Width = 250;
            // 
            // ColHstEntryPoint
            // 
            this.ColHstEntryPoint.DataPropertyName = "EntryPoint";
            this.ColHstEntryPoint.HeaderText = "п/пропуска";
            this.ColHstEntryPoint.Name = "ColHstEntryPoint";
            this.ColHstEntryPoint.ReadOnly = true;
            this.ColHstEntryPoint.Width = 200;
            // 
            // ColHstDriverName
            // 
            this.ColHstDriverName.DataPropertyName = "DriverName";
            this.ColHstDriverName.HeaderText = "водитель";
            this.ColHstDriverName.Name = "ColHstDriverName";
            this.ColHstDriverName.ReadOnly = true;
            this.ColHstDriverName.Width = 200;
            // 
            // ColHstCargo
            // 
            this.ColHstCargo.DataPropertyName = "Cargo";
            this.ColHstCargo.HeaderText = "Груз";
            this.ColHstCargo.Name = "ColHstCargo";
            this.ColHstCargo.ReadOnly = true;
            // 
            // ColHstMoving
            // 
            this.ColHstMoving.DataPropertyName = "Moving";
            this.ColHstMoving.HeaderText = "операция";
            this.ColHstMoving.Name = "ColHstMoving";
            this.ColHstMoving.ReadOnly = true;
            // 
            // ColHstPermit
            // 
            this.ColHstPermit.DataPropertyName = "PermitNumber";
            this.ColHstPermit.HeaderText = "пропуск";
            this.ColHstPermit.Name = "ColHstPermit";
            this.ColHstPermit.ReadOnly = true;
            // 
            // panelReportHeader
            // 
            this.panelReportHeader.Controls.Add(this.btnPrintHistory);
            this.panelReportHeader.Controls.Add(this.tboxVehicleMask);
            this.panelReportHeader.Controls.Add(this.dtpDateTo);
            this.panelReportHeader.Controls.Add(this.dtpDateFrom);
            this.panelReportHeader.Controls.Add(this.label2);
            this.panelReportHeader.Controls.Add(this.label1);
            this.panelReportHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportHeader.Location = new System.Drawing.Point(0, 0);
            this.panelReportHeader.Name = "panelReportHeader";
            this.panelReportHeader.Size = new System.Drawing.Size(663, 86);
            this.panelReportHeader.TabIndex = 0;
            // 
            // btnPrintHistory
            // 
            this.btnPrintHistory.Location = new System.Drawing.Point(291, 47);
            this.btnPrintHistory.Name = "btnPrintHistory";
            this.btnPrintHistory.Size = new System.Drawing.Size(186, 33);
            this.btnPrintHistory.TabIndex = 5;
            this.btnPrintHistory.Text = "печать";
            this.btnPrintHistory.UseVisualStyleBackColor = true;
            this.btnPrintHistory.Click += new System.EventHandler(this.btnPrintHistory_Click);
            // 
            // tboxVehicleMask
            // 
            this.tboxVehicleMask.Location = new System.Drawing.Point(99, 45);
            this.tboxVehicleMask.Name = "tboxVehicleMask";
            this.tboxVehicleMask.Size = new System.Drawing.Size(186, 26);
            this.tboxVehicleMask.TabIndex = 4;
            this.tboxVehicleMask.TextChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(291, 15);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowUpDown = true;
            this.dtpDateTo.Size = new System.Drawing.Size(186, 26);
            this.dtpDateTo.TabIndex = 3;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(99, 15);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.ShowUpDown = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(186, 26);
            this.dtpDateFrom.TabIndex = 2;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер т/с";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период";
            // 
            // panelPlanAppoints
            // 
            this.panelPlanAppoints.Controls.Add(this.dataGridView2);
            this.panelPlanAppoints.Controls.Add(this.planAppointTools);
            this.panelPlanAppoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlanAppoints.Location = new System.Drawing.Point(0, 84);
            this.panelPlanAppoints.Name = "panelPlanAppoints";
            this.panelPlanAppoints.Size = new System.Drawing.Size(663, 486);
            this.panelPlanAppoints.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmVehicle,
            this.ClmnDriverName,
            this.ClmnCargo,
            this.ClmnDateFrom,
            this.ClmnDateTo});
            this.dataGridView2.DataSource = this.bsPlanAppoint;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(663, 461);
            this.dataGridView2.TabIndex = 1;
            // 
            // ClmVehicle
            // 
            this.ClmVehicle.DataPropertyName = "Vehicle";
            this.ClmVehicle.FillWeight = 150F;
            this.ClmVehicle.HeaderText = "Т/С";
            this.ClmVehicle.Name = "ClmVehicle";
            this.ClmVehicle.ReadOnly = true;
            // 
            // ClmnDriverName
            // 
            this.ClmnDriverName.DataPropertyName = "DriverName";
            this.ClmnDriverName.FillWeight = 150F;
            this.ClmnDriverName.HeaderText = "водитель";
            this.ClmnDriverName.Name = "ClmnDriverName";
            this.ClmnDriverName.ReadOnly = true;
            // 
            // ClmnCargo
            // 
            this.ClmnCargo.DataPropertyName = "Cargo";
            this.ClmnCargo.FillWeight = 150F;
            this.ClmnCargo.HeaderText = "груз";
            this.ClmnCargo.Name = "ClmnCargo";
            this.ClmnCargo.ReadOnly = true;
            // 
            // ClmnDateFrom
            // 
            this.ClmnDateFrom.DataPropertyName = "DateFrom";
            dataGridViewCellStyle2.Format = "dd.MM ";
            dataGridViewCellStyle2.NullValue = null;
            this.ClmnDateFrom.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClmnDateFrom.FillWeight = 75F;
            this.ClmnDateFrom.HeaderText = "ожидается";
            this.ClmnDateFrom.Name = "ClmnDateFrom";
            this.ClmnDateFrom.ReadOnly = true;
            // 
            // ClmnDateTo
            // 
            this.ClmnDateTo.DataPropertyName = "DateTo";
            dataGridViewCellStyle3.Format = "dd.MM";
            this.ClmnDateTo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClmnDateTo.HeaderText = "прибытие";
            this.ClmnDateTo.Name = "ClmnDateTo";
            this.ClmnDateTo.ReadOnly = true;
            // 
            // planAppointTools
            // 
            this.planAppointTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPermitTool,
            this.btnNotifyProperties,
            this.btnAlwaysNotify});
            this.planAppointTools.Location = new System.Drawing.Point(0, 0);
            this.planAppointTools.Name = "planAppointTools";
            this.planAppointTools.Size = new System.Drawing.Size(663, 25);
            this.planAppointTools.TabIndex = 0;
            this.planAppointTools.Text = "toolStrip1";
            // 
            // createPermitTool
            // 
            this.createPermitTool.Image = ((System.Drawing.Image)(resources.GetObject("createPermitTool.Image")));
            this.createPermitTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createPermitTool.Name = "createPermitTool";
            this.createPermitTool.Size = new System.Drawing.Size(133, 22);
            this.createPermitTool.Text = "оформить пропуск";
            this.createPermitTool.Click += new System.EventHandler(this.createPermitTool_Click);
            // 
            // btnNotifyProperties
            // 
            this.btnNotifyProperties.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNotifyProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNotifyProperties.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifyProperties.Image")));
            this.btnNotifyProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNotifyProperties.Name = "btnNotifyProperties";
            this.btnNotifyProperties.Size = new System.Drawing.Size(23, 22);
            this.btnNotifyProperties.Text = "Настройки оповещения";
            this.btnNotifyProperties.Click += new System.EventHandler(this.btnNotifyProperties_Click);
            // 
            // btnAlwaysNotify
            // 
            this.btnAlwaysNotify.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAlwaysNotify.CheckOnClick = true;
            this.btnAlwaysNotify.Image = ((System.Drawing.Image)(resources.GetObject("btnAlwaysNotify.Image")));
            this.btnAlwaysNotify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlwaysNotify.Name = "btnAlwaysNotify";
            this.btnAlwaysNotify.Size = new System.Drawing.Size(126, 22);
            this.btnAlwaysNotify.Text = "оповещать всегда";
            this.btnAlwaysNotify.CheckedChanged += new System.EventHandler(this.btnAlwaysNotify_CheckedChanged);
            // 
            // panelEnteredVehicles
            // 
            this.panelEnteredVehicles.Controls.Add(this.dataGridView1);
            this.panelEnteredVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnteredVehicles.Location = new System.Drawing.Point(0, 84);
            this.panelEnteredVehicles.Name = "panelEnteredVehicles";
            this.panelEnteredVehicles.Size = new System.Drawing.Size(663, 486);
            this.panelEnteredVehicles.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEntryTime,
            this.ColumnVehicleMark,
            this.ColumnDriverName,
            this.ColumnCargo});
            this.dataGridView1.DataSource = this.bsEnteredVehicle;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(663, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnEntryTime
            // 
            this.ColumnEntryTime.DataPropertyName = "EntryInfo";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEntryTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnEntryTime.HeaderText = "въезд";
            this.ColumnEntryTime.Name = "ColumnEntryTime";
            this.ColumnEntryTime.ReadOnly = true;
            // 
            // ColumnVehicleMark
            // 
            this.ColumnVehicleMark.DataPropertyName = "VehicleInfo";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnVehicleMark.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnVehicleMark.HeaderText = "Автомобиль";
            this.ColumnVehicleMark.Name = "ColumnVehicleMark";
            this.ColumnVehicleMark.ReadOnly = true;
            // 
            // ColumnDriverName
            // 
            this.ColumnDriverName.DataPropertyName = "DriverInfo";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDriverName.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnDriverName.HeaderText = "водитель";
            this.ColumnDriverName.Name = "ColumnDriverName";
            this.ColumnDriverName.ReadOnly = true;
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.DataPropertyName = "Cargo";
            this.ColumnCargo.HeaderText = "груз";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.rbtn3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtn2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtn1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(663, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rbtn3
            // 
            this.rbtn3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn3.AutoSize = true;
            this.rbtn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.rbtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn3.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbtn3.Location = new System.Drawing.Point(527, 13);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(123, 58);
            this.rbtn3.TabIndex = 3;
            this.rbtn3.Text = "история";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
            // 
            // rbtn2
            // 
            this.rbtn2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn2.AutoSize = true;
            this.rbtn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSalmon;
            this.rbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn2.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtn2.Location = new System.Drawing.Point(270, 13);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(251, 58);
            this.rbtn2.TabIndex = 1;
            this.rbtn2.Text = "заявки на пропуск";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
            // 
            // rbtn1
            // 
            this.rbtn1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn1.AutoSize = true;
            this.rbtn1.Checked = true;
            this.rbtn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.rbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn1.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtn1.Location = new System.Drawing.Point(13, 13);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(251, 58);
            this.rbtn1.TabIndex = 0;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "машины на территории";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(672, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 570);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lboxStaff, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelEntryPointList, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 545F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1, 545);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lboxStaff
            // 
            this.lboxStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxStaff.FormattingEnabled = true;
            this.lboxStaff.Location = new System.Drawing.Point(3, 3);
            this.lboxStaff.Name = "lboxStaff";
            this.lboxStaff.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxStaff.Size = new System.Drawing.Size(1, 539);
            this.lboxStaff.TabIndex = 0;
            // 
            // panelEntryPointList
            // 
            this.panelEntryPointList.AutoScroll = true;
            this.panelEntryPointList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntryPointList.Location = new System.Drawing.Point(3, 3);
            this.panelEntryPointList.Name = "panelEntryPointList";
            this.panelEntryPointList.Size = new System.Drawing.Size(1, 539);
            this.panelEntryPointList.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffTool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // staffTool
            // 
            this.staffTool.Image = ((System.Drawing.Image)(resources.GetObject("staffTool.Image")));
            this.staffTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.staffTool.Name = "staffTool";
            this.staffTool.Size = new System.Drawing.Size(82, 20);
            this.staffTool.Text = "Персонал";
            this.staffTool.Click += new System.EventHandler(this.staffTool_Click);
            // 
            // panelComment
            // 
            this.panelComment.Controls.Add(this.gboxCreator);
            this.panelComment.Controls.Add(this.gboxComment);
            this.panelComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComment.Location = new System.Drawing.Point(672, 3);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(294, 570);
            this.panelComment.TabIndex = 2;
            // 
            // gboxCreator
            // 
            this.gboxCreator.Controls.Add(this.lblCreator);
            this.gboxCreator.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gboxCreator.Location = new System.Drawing.Point(0, 195);
            this.gboxCreator.Name = "gboxCreator";
            this.gboxCreator.Size = new System.Drawing.Size(294, 100);
            this.gboxCreator.TabIndex = 1;
            this.gboxCreator.TabStop = false;
            this.gboxCreator.Text = "Инициатор";
            // 
            // lblCreator
            // 
            this.lblCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreator.Location = new System.Drawing.Point(3, 19);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(288, 78);
            this.lblCreator.TabIndex = 0;
            // 
            // gboxComment
            // 
            this.gboxComment.Controls.Add(this.lblComment);
            this.gboxComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gboxComment.Location = new System.Drawing.Point(0, 0);
            this.gboxComment.Name = "gboxComment";
            this.gboxComment.Padding = new System.Windows.Forms.Padding(10);
            this.gboxComment.Size = new System.Drawing.Size(294, 195);
            this.gboxComment.TabIndex = 0;
            this.gboxComment.TabStop = false;
            this.gboxComment.Text = "Комментарий";
            // 
            // lblComment
            // 
            this.lblComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComment.Location = new System.Drawing.Point(10, 26);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(274, 159);
            this.lblComment.TabIndex = 5;
            // 
            // EntryPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EntryPointForm";
            this.Text = "Дежурная часть";
            ((System.ComponentModel.ISupportInitialize)(this.bsHistoryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanAppoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnteredVehicle)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelEntered.ResumeLayout(false);
            this.panelHistoryReport.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryReport)).EndInit();
            this.panelReportHeader.ResumeLayout(false);
            this.panelReportHeader.PerformLayout();
            this.panelPlanAppoints.ResumeLayout(false);
            this.panelPlanAppoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.planAppointTools.ResumeLayout(false);
            this.planAppointTools.PerformLayout();
            this.panelEnteredVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelComment.ResumeLayout(false);
            this.gboxCreator.ResumeLayout(false);
            this.gboxComment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsEnteredVehicle;
        private System.Windows.Forms.BindingSource bsPlanAppoint;
        private System.Windows.Forms.Timer refreshTimer;
        private System.ComponentModel.BackgroundWorker bgEnteredRefresh;
        private System.ComponentModel.BackgroundWorker bgPlanAppointRefresh;
        private System.Windows.Forms.Panel panelEntered;
        private System.Windows.Forms.Panel panelPlanAppoints;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip planAppointTools;
        private System.Windows.Forms.ToolStripButton createPermitTool;
        private System.Windows.Forms.Panel panelEnteredVehicles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox lboxStaff;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton staffTool;
        private System.Windows.Forms.Panel panelEntryPointList;
        private System.Windows.Forms.ToolStripButton btnAlwaysNotify;
        private System.Windows.Forms.ToolStripButton btnNotifyProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEntryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVehicleMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.Panel panelHistoryReport;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Panel panelReportHeader;
        private System.Windows.Forms.TextBox tboxVehicleMask;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHistoryReport;
        private System.Windows.Forms.BindingSource bsHistoryReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHstMovingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHstEntryPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHstDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHstCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHstMoving;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHstPermit;
        private System.Windows.Forms.Button btnPrintHistory;
        private System.Windows.Forms.Panel panelComment;
        private System.Windows.Forms.GroupBox gboxComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.GroupBox gboxCreator;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDateTo;
    }
}
namespace EntryControl
{
    partial class MaterialPermitListForm
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
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ColumnDocNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreate = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSign = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnEntry = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlDocument = new System.Windows.Forms.TableLayoutPanel();
            this.tboxBaseDocument = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSigner = new System.Windows.Forms.Label();
            this.pboxSignedImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxVehicleMark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxLicensePlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCreator = new System.Windows.Forms.Panel();
            this.lblCreator = new System.Windows.Forms.Label();
            this.pboxCreatedImage = new System.Windows.Forms.PictureBox();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.pbarLoading = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.MaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialUnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.paneTop = new System.Windows.Forms.Panel();
            this.refreshLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.bckGetChanges = new System.ComponentModel.BackgroundWorker();
            this.bckRefresh = new System.ComponentModel.BackgroundWorker();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.bckGetItemList = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlDocument.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSignedImage)).BeginInit();
            this.pnlCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreatedImage)).BeginInit();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.paneTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsList
            // 
            this.bsList.CurrentChanged += new System.EventHandler(this.bsList_CurrentChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 30);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvList);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlDocument);
            this.splitContainer.Size = new System.Drawing.Size(802, 342);
            this.splitContainer.SplitterDistance = 450;
            this.splitContainer.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDocNumber,
            this.ColumnDocDate,
            this.ColumnUnit,
            this.ColumnCreate,
            this.ColumnSign,
            this.ColumnEntry});
            this.dgvList.DataSource = this.bsList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(450, 342);
            this.dgvList.TabIndex = 0;
            // 
            // ColumnDocNumber
            // 
            this.ColumnDocNumber.DataPropertyName = "DocNumber";
            this.ColumnDocNumber.HeaderText = "№ пропуска";
            this.ColumnDocNumber.Name = "ColumnDocNumber";
            this.ColumnDocNumber.ReadOnly = true;
            // 
            // ColumnDocDate
            // 
            this.ColumnDocDate.DataPropertyName = "DocDate";
            this.ColumnDocDate.HeaderText = "Дата выдачи";
            this.ColumnDocDate.Name = "ColumnDocDate";
            this.ColumnDocDate.ReadOnly = true;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.DataPropertyName = "Unit";
            this.ColumnUnit.HeaderText = "Подразделение";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            // 
            // ColumnCreate
            // 
            this.ColumnCreate.DataPropertyName = "CreatedImage";
            this.ColumnCreate.HeaderText = "клад.";
            this.ColumnCreate.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnCreate.Name = "ColumnCreate";
            this.ColumnCreate.ReadOnly = true;
            this.ColumnCreate.Width = 25;
            // 
            // ColumnSign
            // 
            this.ColumnSign.DataPropertyName = "SignedImage";
            this.ColumnSign.HeaderText = "рук-ль";
            this.ColumnSign.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnSign.Name = "ColumnSign";
            this.ColumnSign.ReadOnly = true;
            this.ColumnSign.Width = 25;
            // 
            // ColumnEntry
            // 
            this.ColumnEntry.DataPropertyName = "EntryImage";
            this.ColumnEntry.HeaderText = "выезд";
            this.ColumnEntry.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEntry.Name = "ColumnEntry";
            this.ColumnEntry.ReadOnly = true;
            this.ColumnEntry.Width = 25;
            // 
            // pnlDocument
            // 
            this.pnlDocument.ColumnCount = 2;
            this.pnlDocument.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.pnlDocument.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.pnlDocument.Controls.Add(this.tboxBaseDocument, 1, 5);
            this.pnlDocument.Controls.Add(this.panel1, 1, 4);
            this.pnlDocument.Controls.Add(this.label5, 0, 4);
            this.pnlDocument.Controls.Add(this.label1, 0, 0);
            this.pnlDocument.Controls.Add(this.tboxPerson, 1, 0);
            this.pnlDocument.Controls.Add(this.label2, 0, 1);
            this.pnlDocument.Controls.Add(this.tboxVehicleMark, 1, 1);
            this.pnlDocument.Controls.Add(this.label3, 0, 2);
            this.pnlDocument.Controls.Add(this.tboxLicensePlate, 1, 2);
            this.pnlDocument.Controls.Add(this.label4, 0, 3);
            this.pnlDocument.Controls.Add(this.pnlCreator, 1, 3);
            this.pnlDocument.Controls.Add(this.pnlProgress, 0, 6);
            this.pnlDocument.Controls.Add(this.dgvItemList, 0, 7);
            this.pnlDocument.Controls.Add(this.label7, 0, 5);
            this.pnlDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDocument.Location = new System.Drawing.Point(0, 0);
            this.pnlDocument.Name = "pnlDocument";
            this.pnlDocument.RowCount = 9;
            this.pnlDocument.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDocument.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDocument.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDocument.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDocument.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDocument.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDocument.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDocument.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDocument.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDocument.Size = new System.Drawing.Size(348, 342);
            this.pnlDocument.TabIndex = 0;
            // 
            // tboxBaseDocument
            // 
            this.tboxBaseDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxBaseDocument.Enabled = false;
            this.tboxBaseDocument.Location = new System.Drawing.Point(117, 133);
            this.tboxBaseDocument.Name = "tboxBaseDocument";
            this.tboxBaseDocument.Size = new System.Drawing.Size(228, 20);
            this.tboxBaseDocument.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSigner);
            this.panel1.Controls.Add(this.pboxSignedImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(117, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 20);
            this.panel1.TabIndex = 9;
            // 
            // lblSigner
            // 
            this.lblSigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSigner.Location = new System.Drawing.Point(20, 0);
            this.lblSigner.Name = "lblSigner";
            this.lblSigner.Size = new System.Drawing.Size(208, 20);
            this.lblSigner.TabIndex = 1;
            this.lblSigner.Text = "label5";
            this.lblSigner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pboxSignedImage
            // 
            this.pboxSignedImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxSignedImage.Location = new System.Drawing.Point(0, 0);
            this.pboxSignedImage.Name = "pboxSignedImage";
            this.pboxSignedImage.Size = new System.Drawing.Size(20, 20);
            this.pboxSignedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSignedImage.TabIndex = 0;
            this.pboxSignedImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Руководитель";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Предъявитель";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxPerson
            // 
            this.tboxPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxPerson.Enabled = false;
            this.tboxPerson.Location = new System.Drawing.Point(117, 3);
            this.tboxPerson.Name = "tboxPerson";
            this.tboxPerson.Size = new System.Drawing.Size(228, 20);
            this.tboxPerson.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Марка т/с";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxVehicleMark
            // 
            this.tboxVehicleMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxVehicleMark.Enabled = false;
            this.tboxVehicleMark.Location = new System.Drawing.Point(117, 29);
            this.tboxVehicleMark.Name = "tboxVehicleMark";
            this.tboxVehicleMark.Size = new System.Drawing.Size(228, 20);
            this.tboxVehicleMark.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Гос. номер";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxLicensePlate
            // 
            this.tboxLicensePlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxLicensePlate.Enabled = false;
            this.tboxLicensePlate.Location = new System.Drawing.Point(117, 55);
            this.tboxLicensePlate.Name = "tboxLicensePlate";
            this.tboxLicensePlate.Size = new System.Drawing.Size(228, 20);
            this.tboxLicensePlate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кладовщик";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCreator
            // 
            this.pnlCreator.Controls.Add(this.lblCreator);
            this.pnlCreator.Controls.Add(this.pboxCreatedImage);
            this.pnlCreator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreator.Location = new System.Drawing.Point(117, 81);
            this.pnlCreator.Name = "pnlCreator";
            this.pnlCreator.Size = new System.Drawing.Size(228, 20);
            this.pnlCreator.TabIndex = 7;
            // 
            // lblCreator
            // 
            this.lblCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreator.Location = new System.Drawing.Point(20, 0);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(208, 20);
            this.lblCreator.TabIndex = 1;
            this.lblCreator.Text = "label5";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pboxCreatedImage
            // 
            this.pboxCreatedImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxCreatedImage.Location = new System.Drawing.Point(0, 0);
            this.pboxCreatedImage.Name = "pboxCreatedImage";
            this.pboxCreatedImage.Size = new System.Drawing.Size(20, 20);
            this.pboxCreatedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxCreatedImage.TabIndex = 0;
            this.pboxCreatedImage.TabStop = false;
            // 
            // pnlProgress
            // 
            this.pnlDocument.SetColumnSpan(this.pnlProgress, 2);
            this.pnlProgress.Controls.Add(this.pbarLoading);
            this.pnlProgress.Controls.Add(this.label6);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgress.Location = new System.Drawing.Point(3, 159);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(342, 17);
            this.pnlProgress.TabIndex = 10;
            this.pnlProgress.Visible = false;
            // 
            // pbarLoading
            // 
            this.pbarLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbarLoading.Location = new System.Drawing.Point(62, 0);
            this.pbarLoading.Name = "pbarLoading";
            this.pbarLoading.Size = new System.Drawing.Size(280, 17);
            this.pbarLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbarLoading.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "загрузка...";
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialColumn,
            this.MaterialUnitColumn,
            this.QuantityColumn,
            this.ColumnTonnage});
            this.pnlDocument.SetColumnSpan(this.dgvItemList, 2);
            this.dgvItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemList.Location = new System.Drawing.Point(3, 182);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(342, 137);
            this.dgvItemList.TabIndex = 11;
            // 
            // MaterialColumn
            // 
            this.MaterialColumn.DataPropertyName = "Material";
            this.MaterialColumn.HeaderText = "Наименование груза";
            this.MaterialColumn.Name = "MaterialColumn";
            this.MaterialColumn.ReadOnly = true;
            this.MaterialColumn.Width = 200;
            // 
            // MaterialUnitColumn
            // 
            this.MaterialUnitColumn.DataPropertyName = "MaterialUnit";
            this.MaterialUnitColumn.HeaderText = "ед.";
            this.MaterialUnitColumn.Name = "MaterialUnitColumn";
            this.MaterialUnitColumn.ReadOnly = true;
            this.MaterialUnitColumn.Width = 50;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "Quantity";
            this.QuantityColumn.HeaderText = "Кол-во";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 50;
            // 
            // ColumnTonnage
            // 
            this.ColumnTonnage.DataPropertyName = "Tonnage";
            this.ColumnTonnage.HeaderText = "вес (тн)";
            this.ColumnTonnage.Name = "ColumnTonnage";
            this.ColumnTonnage.ReadOnly = true;
            this.ColumnTonnage.Width = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Основание";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paneTop
            // 
            this.paneTop.Controls.Add(this.refreshLabel);
            this.paneTop.Controls.Add(this.refreshButton);
            this.paneTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneTop.Location = new System.Drawing.Point(0, 0);
            this.paneTop.Name = "paneTop";
            this.paneTop.Padding = new System.Windows.Forms.Padding(3);
            this.paneTop.Size = new System.Drawing.Size(802, 30);
            this.paneTop.TabIndex = 0;
            // 
            // refreshLabel
            // 
            this.refreshLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshLabel.Location = new System.Drawing.Point(580, 3);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(195, 24);
            this.refreshLabel.TabIndex = 0;
            this.refreshLabel.Text = "Обновление...";
            this.refreshLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshButton.Location = new System.Drawing.Point(775, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(24, 24);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // bckGetChanges
            // 
            this.bckGetChanges.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckGetChanges_DoWork);
            this.bckGetChanges.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckGetChanges_RunWorkerCompleted);
            // 
            // bckRefresh
            // 
            this.bckRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckRefresh_DoWork);
            this.bckRefresh.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckRefresh_RunWorkerCompleted);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // bckGetItemList
            // 
            this.bckGetItemList.WorkerSupportsCancellation = true;
            this.bckGetItemList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckGetItemList_DoWork);
            this.bckGetItemList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckGetItemList_RunWorkerCompleted);
            // 
            // MaterialPermitListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 372);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.paneTop);
            this.Name = "MaterialPermitListForm";
            this.Text = "Учет материальных пропусков";
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlDocument.ResumeLayout(false);
            this.pnlDocument.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSignedImage)).EndInit();
            this.pnlCreator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreatedImage)).EndInit();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.paneTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneTop;
        private System.Windows.Forms.Label refreshLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.BindingSource bsList;
        private System.Windows.Forms.DataGridView dgvList;
        private System.ComponentModel.BackgroundWorker bckGetChanges;
        private System.ComponentModel.BackgroundWorker bckRefresh;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewImageColumn ColumnCreate;
        private System.Windows.Forms.DataGridViewImageColumn ColumnSign;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEntry;
        private System.Windows.Forms.TableLayoutPanel pnlDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxVehicleMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxLicensePlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCreator;
        private System.Windows.Forms.PictureBox pboxCreatedImage;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSigner;
        private System.Windows.Forms.PictureBox pboxSignedImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.ProgressBar pbarLoading;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker bckGetItemList;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.TextBox tboxBaseDocument;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialUnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTonnage;
    }
}
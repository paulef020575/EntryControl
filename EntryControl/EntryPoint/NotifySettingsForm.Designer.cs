namespace EntryControl
{
    partial class NotifySettingsForm
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gboxAdvancedDays = new System.Windows.Forms.GroupBox();
            this.lboxAdvancedDates = new System.Windows.Forms.ListBox();
            this.bsAdvancedDates = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpAdvancedDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddAdvancedDate = new System.Windows.Forms.Button();
            this.btnRemoveAdvancedDate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkShowNotifyWindow = new System.Windows.Forms.CheckBox();
            this.dtpWorkdayFinish = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkNotifyAlways = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpWorkdayStart = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxNotifySound = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.btnPlaySound = new System.Windows.Forms.Button();
            this.gboxVacation = new System.Windows.Forms.GroupBox();
            this.lboxVacations = new System.Windows.Forms.ListBox();
            this.bsVacationDates = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpVacation = new System.Windows.Forms.DateTimePicker();
            this.btnAddVacation = new System.Windows.Forms.Button();
            this.btnRemoveVacation = new System.Windows.Forms.Button();
            this.bsSettings = new System.Windows.Forms.BindingSource(this.components);
            this.openSoundFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gboxAdvancedDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvancedDates)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gboxVacation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVacationDates)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnOk);
            this.panelBottom.Controls.Add(this.btnSave);
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 432);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(3);
            this.panelBottom.Size = new System.Drawing.Size(649, 31);
            this.panelBottom.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(346, 3);
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
            this.btnSave.Location = new System.Drawing.Point(446, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(546, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gboxAdvancedDays, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gboxVacation, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 432);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gboxAdvancedDays
            // 
            this.gboxAdvancedDays.Controls.Add(this.lboxAdvancedDates);
            this.gboxAdvancedDays.Controls.Add(this.panel3);
            this.gboxAdvancedDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxAdvancedDays.Location = new System.Drawing.Point(327, 3);
            this.gboxAdvancedDays.Name = "gboxAdvancedDays";
            this.tableLayoutPanel1.SetRowSpan(this.gboxAdvancedDays, 2);
            this.gboxAdvancedDays.Size = new System.Drawing.Size(319, 426);
            this.gboxAdvancedDays.TabIndex = 2;
            this.gboxAdvancedDays.TabStop = false;
            this.gboxAdvancedDays.Text = "Дополнительные выходные дни";
            // 
            // lboxAdvancedDates
            // 
            this.lboxAdvancedDates.DataSource = this.bsAdvancedDates;
            this.lboxAdvancedDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxAdvancedDates.FormatString = "d";
            this.lboxAdvancedDates.FormattingEnabled = true;
            this.lboxAdvancedDates.Location = new System.Drawing.Point(3, 43);
            this.lboxAdvancedDates.Name = "lboxAdvancedDates";
            this.lboxAdvancedDates.Size = new System.Drawing.Size(313, 380);
            this.lboxAdvancedDates.Sorted = true;
            this.lboxAdvancedDates.TabIndex = 1;
            this.lboxAdvancedDates.SelectedIndexChanged += new System.EventHandler(this.lboxAdvancedDates_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpAdvancedDate);
            this.panel3.Controls.Add(this.btnAddAdvancedDate);
            this.panel3.Controls.Add(this.btnRemoveAdvancedDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(313, 27);
            this.panel3.TabIndex = 0;
            // 
            // dtpAdvancedDate
            // 
            this.dtpAdvancedDate.CustomFormat = "dd MMMM";
            this.dtpAdvancedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpAdvancedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdvancedDate.Location = new System.Drawing.Point(3, 3);
            this.dtpAdvancedDate.Name = "dtpAdvancedDate";
            this.dtpAdvancedDate.Size = new System.Drawing.Size(265, 20);
            this.dtpAdvancedDate.TabIndex = 2;
            // 
            // btnAddAdvancedDate
            // 
            this.btnAddAdvancedDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAdvancedDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddAdvancedDate.Location = new System.Drawing.Point(268, 3);
            this.btnAddAdvancedDate.Name = "btnAddAdvancedDate";
            this.btnAddAdvancedDate.Size = new System.Drawing.Size(21, 21);
            this.btnAddAdvancedDate.TabIndex = 1;
            this.btnAddAdvancedDate.TabStop = false;
            this.btnAddAdvancedDate.UseVisualStyleBackColor = true;
            this.btnAddAdvancedDate.Click += new System.EventHandler(this.btnAddAdvancedDate_Click);
            // 
            // btnRemoveAdvancedDate
            // 
            this.btnRemoveAdvancedDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveAdvancedDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveAdvancedDate.Location = new System.Drawing.Point(289, 3);
            this.btnRemoveAdvancedDate.Name = "btnRemoveAdvancedDate";
            this.btnRemoveAdvancedDate.Size = new System.Drawing.Size(21, 21);
            this.btnRemoveAdvancedDate.TabIndex = 0;
            this.btnRemoveAdvancedDate.TabStop = false;
            this.btnRemoveAdvancedDate.UseVisualStyleBackColor = true;
            this.btnRemoveAdvancedDate.Click += new System.EventHandler(this.btnRemoveAdvancedDate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkShowNotifyWindow, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpWorkdayFinish, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkNotifyAlways, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpWorkdayStart, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 200);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(57, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Файл звукового оповещения";
            // 
            // checkShowNotifyWindow
            // 
            this.checkShowNotifyWindow.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.checkShowNotifyWindow, 2);
            this.checkShowNotifyWindow.Location = new System.Drawing.Point(8, 113);
            this.checkShowNotifyWindow.Margin = new System.Windows.Forms.Padding(8);
            this.checkShowNotifyWindow.Name = "checkShowNotifyWindow";
            this.checkShowNotifyWindow.Size = new System.Drawing.Size(180, 17);
            this.checkShowNotifyWindow.TabIndex = 5;
            this.checkShowNotifyWindow.Text = "показывать окно оповещения";
            this.checkShowNotifyWindow.UseVisualStyleBackColor = true;
            // 
            // dtpWorkdayFinish
            // 
            this.dtpWorkdayFinish.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpWorkdayFinish.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWorkdayFinish.Location = new System.Drawing.Point(167, 77);
            this.dtpWorkdayFinish.Margin = new System.Windows.Forms.Padding(8);
            this.dtpWorkdayFinish.Name = "dtpWorkdayFinish";
            this.dtpWorkdayFinish.ShowUpDown = true;
            this.dtpWorkdayFinish.Size = new System.Drawing.Size(143, 20);
            this.dtpWorkdayFinish.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Окончание рабочего дня";
            // 
            // checkNotifyAlways
            // 
            this.checkNotifyAlways.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.checkNotifyAlways, 2);
            this.checkNotifyAlways.Location = new System.Drawing.Point(8, 8);
            this.checkNotifyAlways.Margin = new System.Windows.Forms.Padding(8);
            this.checkNotifyAlways.Name = "checkNotifyAlways";
            this.checkNotifyAlways.Size = new System.Drawing.Size(120, 17);
            this.checkNotifyAlways.TabIndex = 0;
            this.checkNotifyAlways.Text = "оповещать всегда";
            this.checkNotifyAlways.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начало рабочего дня";
            // 
            // dtpWorkdayStart
            // 
            this.dtpWorkdayStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpWorkdayStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWorkdayStart.Location = new System.Drawing.Point(167, 41);
            this.dtpWorkdayStart.Margin = new System.Windows.Forms.Padding(8);
            this.dtpWorkdayStart.Name = "dtpWorkdayStart";
            this.dtpWorkdayStart.ShowUpDown = true;
            this.dtpWorkdayStart.Size = new System.Drawing.Size(143, 20);
            this.dtpWorkdayStart.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tboxNotifySound);
            this.panel1.Controls.Add(this.buttonSelectFile);
            this.panel1.Controls.Add(this.btnPlaySound);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(162, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 21);
            this.panel1.TabIndex = 7;
            // 
            // tboxNotifySound
            // 
            this.tboxNotifySound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxNotifySound.Location = new System.Drawing.Point(0, 0);
            this.tboxNotifySound.Name = "tboxNotifySound";
            this.tboxNotifySound.Size = new System.Drawing.Size(103, 20);
            this.tboxNotifySound.TabIndex = 1;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSelectFile.Location = new System.Drawing.Point(103, 0);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(25, 21);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.TabStop = false;
            this.buttonSelectFile.Text = "...";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // btnPlaySound
            // 
            this.btnPlaySound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlaySound.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlaySound.Location = new System.Drawing.Point(128, 0);
            this.btnPlaySound.Name = "btnPlaySound";
            this.btnPlaySound.Size = new System.Drawing.Size(25, 21);
            this.btnPlaySound.TabIndex = 2;
            this.btnPlaySound.TabStop = false;
            this.btnPlaySound.UseVisualStyleBackColor = true;
            this.btnPlaySound.Click += new System.EventHandler(this.btnPlaySound_Click);
            // 
            // gboxVacation
            // 
            this.gboxVacation.Controls.Add(this.lboxVacations);
            this.gboxVacation.Controls.Add(this.panel2);
            this.gboxVacation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxVacation.Location = new System.Drawing.Point(3, 209);
            this.gboxVacation.Name = "gboxVacation";
            this.gboxVacation.Size = new System.Drawing.Size(318, 220);
            this.gboxVacation.TabIndex = 1;
            this.gboxVacation.TabStop = false;
            this.gboxVacation.Text = "Праздничные дни (ежегодные оповещения)";
            // 
            // lboxVacations
            // 
            this.lboxVacations.DataSource = this.bsVacationDates;
            this.lboxVacations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxVacations.FormatString = "dd MMMM";
            this.lboxVacations.FormattingEnabled = true;
            this.lboxVacations.Location = new System.Drawing.Point(3, 43);
            this.lboxVacations.Name = "lboxVacations";
            this.lboxVacations.Size = new System.Drawing.Size(312, 174);
            this.lboxVacations.TabIndex = 1;
            this.lboxVacations.SelectedValueChanged += new System.EventHandler(this.lboxVacations_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpVacation);
            this.panel2.Controls.Add(this.btnAddVacation);
            this.panel2.Controls.Add(this.btnRemoveVacation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(312, 27);
            this.panel2.TabIndex = 0;
            // 
            // dtpVacation
            // 
            this.dtpVacation.CustomFormat = "dd MMMM";
            this.dtpVacation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpVacation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVacation.Location = new System.Drawing.Point(3, 3);
            this.dtpVacation.Name = "dtpVacation";
            this.dtpVacation.Size = new System.Drawing.Size(264, 20);
            this.dtpVacation.TabIndex = 2;
            // 
            // btnAddVacation
            // 
            this.btnAddVacation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddVacation.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddVacation.Location = new System.Drawing.Point(267, 3);
            this.btnAddVacation.Name = "btnAddVacation";
            this.btnAddVacation.Size = new System.Drawing.Size(21, 21);
            this.btnAddVacation.TabIndex = 1;
            this.btnAddVacation.TabStop = false;
            this.btnAddVacation.UseVisualStyleBackColor = true;
            this.btnAddVacation.Click += new System.EventHandler(this.btnAddVacation_Click);
            // 
            // btnRemoveVacation
            // 
            this.btnRemoveVacation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveVacation.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveVacation.Location = new System.Drawing.Point(288, 3);
            this.btnRemoveVacation.Name = "btnRemoveVacation";
            this.btnRemoveVacation.Size = new System.Drawing.Size(21, 21);
            this.btnRemoveVacation.TabIndex = 0;
            this.btnRemoveVacation.TabStop = false;
            this.btnRemoveVacation.UseVisualStyleBackColor = true;
            this.btnRemoveVacation.Click += new System.EventHandler(this.btnRemoveVacation_Click);
            // 
            // openSoundFileDialog
            // 
            this.openSoundFileDialog.Filter = "файлы wav|*.wav|все файлы|*.*";
            this.openSoundFileDialog.Title = "Укажите звуковой файл";
            // 
            // NotifySettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelBottom);
            this.Name = "NotifySettingsForm";
            this.Text = "Настройки оповещений";
            this.panelBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gboxAdvancedDays.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvancedDates)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gboxVacation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsVacationDates)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpWorkdayFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkNotifyAlways;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpWorkdayStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkShowNotifyWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxNotifySound;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.GroupBox gboxVacation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveVacation;
        private System.Windows.Forms.Button btnAddVacation;
        private System.Windows.Forms.GroupBox gboxAdvancedDays;
        private System.Windows.Forms.ListBox lboxAdvancedDates;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpAdvancedDate;
        private System.Windows.Forms.Button btnAddAdvancedDate;
        private System.Windows.Forms.Button btnRemoveAdvancedDate;
        private System.Windows.Forms.ListBox lboxVacations;
        private System.Windows.Forms.DateTimePicker dtpVacation;
        private System.Windows.Forms.BindingSource bsSettings;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsAdvancedDates;
        private System.Windows.Forms.BindingSource bsVacationDates;
        private System.Windows.Forms.OpenFileDialog openSoundFileDialog;
        private System.Windows.Forms.Button btnPlaySound;
    }
}
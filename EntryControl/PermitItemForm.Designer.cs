namespace EntryControl
{
    partial class PermitItemForm
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
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDocNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxPermitState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDates = new System.Windows.Forms.Panel();
            this.pickDateTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pickDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rboxCargo = new EntryControl.ReferenceBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rboxVehicle = new EntryControl.ReferenceBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxDriverName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxContact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rboxEntryPoint = new EntryControl.ReferenceBox();
            this.chkMultiEntry = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tboxComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tblPanel.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.tblPanel);
            // 
            // tblPanel
            // 
            this.tblPanel.ColumnCount = 2;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel.Controls.Add(this.label11, 0, 10);
            this.tblPanel.Controls.Add(this.label1, 0, 0);
            this.tblPanel.Controls.Add(this.label2, 0, 1);
            this.tblPanel.Controls.Add(this.lblDocNumber, 1, 1);
            this.tblPanel.Controls.Add(this.label3, 0, 2);
            this.tblPanel.Controls.Add(this.cboxPermitState, 1, 2);
            this.tblPanel.Controls.Add(this.label4, 0, 3);
            this.tblPanel.Controls.Add(this.pnlDates, 1, 3);
            this.tblPanel.Controls.Add(this.label6, 0, 4);
            this.tblPanel.Controls.Add(this.rboxCargo, 1, 4);
            this.tblPanel.Controls.Add(this.label7, 0, 5);
            this.tblPanel.Controls.Add(this.rboxVehicle, 1, 5);
            this.tblPanel.Controls.Add(this.label8, 0, 6);
            this.tblPanel.Controls.Add(this.tboxDriverName, 1, 6);
            this.tblPanel.Controls.Add(this.label9, 0, 7);
            this.tblPanel.Controls.Add(this.tboxContact, 1, 7);
            this.tblPanel.Controls.Add(this.label10, 0, 8);
            this.tblPanel.Controls.Add(this.rboxEntryPoint, 1, 8);
            this.tblPanel.Controls.Add(this.chkMultiEntry, 1, 9);
            this.tblPanel.Controls.Add(this.tboxComment, 1, 10);
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.Padding = new System.Windows.Forms.Padding(10);
            this.tblPanel.RowCount = 11;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblPanel.Size = new System.Drawing.Size(551, 337);
            this.tblPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.tblPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер пропуска";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDocNumber
            // 
            this.lblDocNumber.AutoSize = true;
            this.lblDocNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocNumber.Location = new System.Drawing.Point(167, 32);
            this.lblDocNumber.Name = "lblDocNumber";
            this.lblDocNumber.Size = new System.Drawing.Size(371, 22);
            this.lblDocNumber.TabIndex = 2;
            this.lblDocNumber.Text = "label3";
            this.lblDocNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вид пропуска";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxPermitState
            // 
            this.cboxPermitState.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxPermitState.FormattingEnabled = true;
            this.cboxPermitState.Location = new System.Drawing.Point(167, 57);
            this.cboxPermitState.Name = "cboxPermitState";
            this.cboxPermitState.Size = new System.Drawing.Size(371, 21);
            this.cboxPermitState.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Период действия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDates
            // 
            this.pnlDates.Controls.Add(this.pickDateTo);
            this.pnlDates.Controls.Add(this.label5);
            this.pnlDates.Controls.Add(this.pickDateFrom);
            this.pnlDates.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDates.Location = new System.Drawing.Point(167, 84);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(371, 22);
            this.pnlDates.TabIndex = 6;
            // 
            // pickDateTo
            // 
            this.pickDateTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pickDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateTo.Location = new System.Drawing.Point(115, 0);
            this.pickDateTo.Name = "pickDateTo";
            this.pickDateTo.Size = new System.Drawing.Size(95, 20);
            this.pickDateTo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(95, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pickDateFrom
            // 
            this.pickDateFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.pickDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateFrom.Location = new System.Drawing.Point(0, 0);
            this.pickDateFrom.Name = "pickDateFrom";
            this.pickDateFrom.Size = new System.Drawing.Size(95, 20);
            this.pickDateFrom.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(13, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Груз";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rboxCargo
            // 
            this.rboxCargo.Database = null;
            this.rboxCargo.DataSource = null;
            this.rboxCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.rboxCargo.ListForm = "EntryControl.CargoListForm";
            this.rboxCargo.Location = new System.Drawing.Point(167, 112);
            this.rboxCargo.Name = "rboxCargo";
            this.rboxCargo.SelectedItem = null;
            this.rboxCargo.Size = new System.Drawing.Size(371, 22);
            this.rboxCargo.TabIndex = 8;
            this.rboxCargo.GetList += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxCargo_GetList);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(13, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Т/средство";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rboxVehicle
            // 
            this.rboxVehicle.Database = null;
            this.rboxVehicle.DataSource = null;
            this.rboxVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.rboxVehicle.ListForm = "EntryControl.VehicleListForm";
            this.rboxVehicle.Location = new System.Drawing.Point(167, 140);
            this.rboxVehicle.Name = "rboxVehicle";
            this.rboxVehicle.SelectedItem = null;
            this.rboxVehicle.Size = new System.Drawing.Size(371, 22);
            this.rboxVehicle.TabIndex = 10;
            this.rboxVehicle.GetList += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxVehicle_GetList);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(13, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "ФИО водителя";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxDriverName
            // 
            this.tboxDriverName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxDriverName.Location = new System.Drawing.Point(167, 168);
            this.tboxDriverName.Name = "tboxDriverName";
            this.tboxDriverName.Size = new System.Drawing.Size(371, 20);
            this.tboxDriverName.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(13, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Контактная информация";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxContact
            // 
            this.tboxContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxContact.Location = new System.Drawing.Point(167, 194);
            this.tboxContact.Name = "tboxContact";
            this.tboxContact.Size = new System.Drawing.Size(371, 20);
            this.tboxContact.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(13, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 28);
            this.label10.TabIndex = 15;
            this.label10.Text = "Пункт пропуска";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rboxEntryPoint
            // 
            this.rboxEntryPoint.Database = null;
            this.rboxEntryPoint.DataSource = null;
            this.rboxEntryPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.rboxEntryPoint.ListForm = "EntryControl.EntryPointListForm";
            this.rboxEntryPoint.Location = new System.Drawing.Point(167, 220);
            this.rboxEntryPoint.Name = "rboxEntryPoint";
            this.rboxEntryPoint.SelectedItem = null;
            this.rboxEntryPoint.Size = new System.Drawing.Size(371, 22);
            this.rboxEntryPoint.TabIndex = 16;
            this.rboxEntryPoint.GetList += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxEntryPoint_GetList);
            // 
            // chkMultiEntry
            // 
            this.chkMultiEntry.AutoSize = true;
            this.chkMultiEntry.Location = new System.Drawing.Point(167, 248);
            this.chkMultiEntry.Name = "chkMultiEntry";
            this.chkMultiEntry.Size = new System.Drawing.Size(161, 17);
            this.chkMultiEntry.TabIndex = 17;
            this.chkMultiEntry.Text = "допускается въезд/выезд";
            this.chkMultiEntry.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(13, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 59);
            this.label11.TabIndex = 18;
            this.label11.Text = "Пункт пропуска";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tboxComment
            // 
            this.tboxComment.AcceptsReturn = true;
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxComment.Location = new System.Drawing.Point(167, 271);
            this.tboxComment.Multiline = true;
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.Size = new System.Drawing.Size(371, 53);
            this.tboxComment.TabIndex = 19;
            // 
            // PermitItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 372);
            this.Name = "PermitItemForm";
            this.Text = "PermitItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            this.pnlDates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDocNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxPermitState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDates;
        private System.Windows.Forms.DateTimePicker pickDateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker pickDateFrom;
        private System.Windows.Forms.Label label6;
        private ReferenceBox rboxCargo;
        private System.Windows.Forms.Label label7;
        private ReferenceBox rboxVehicle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxDriverName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxContact;
        private System.Windows.Forms.Label label10;
        private ReferenceBox rboxEntryPoint;
        private System.Windows.Forms.CheckBox chkMultiEntry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tboxComment;
    }
}
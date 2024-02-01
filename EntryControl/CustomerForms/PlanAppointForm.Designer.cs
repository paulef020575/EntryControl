namespace EntryControl
{
    partial class PlanAppointForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanAppointForm));
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pickDateTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxWhereTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreationInformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rboxContractor = new EntryControl.ReferenceBox();
            this.rboxCargo = new EntryControl.ReferenceBox();
            this.rboxMark = new EntryControl.ReferenceBox();
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.tboxVehicle = new System.Windows.Forms.TextBox();
            this.btnFindVehicle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxDriverName = new System.Windows.Forms.TextBox();
            this.pickDateFrom = new System.Windows.Forms.DateTimePicker();
            this.tboxContact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxComment = new System.Windows.Forms.TextBox();
            this.formErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tblPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(0, 391);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(8);
            this.pnlBottom.Size = new System.Drawing.Size(714, 35);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.tblPanel);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlData.Size = new System.Drawing.Size(714, 391);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(406, 8);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Size = new System.Drawing.Size(100, 19);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(506, 8);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Size = new System.Drawing.Size(100, 19);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(606, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Size = new System.Drawing.Size(100, 19);
            // 
            // tblPanel
            // 
            this.tblPanel.ColumnCount = 2;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Controls.Add(this.pickDateTo, 1, 9);
            this.tblPanel.Controls.Add(this.label8, 0, 8);
            this.tblPanel.Controls.Add(this.tboxWhereTo, 1, 7);
            this.tblPanel.Controls.Add(this.label7, 0, 7);
            this.tblPanel.Controls.Add(this.panel1, 0, 0);
            this.tblPanel.Controls.Add(this.label2, 0, 1);
            this.tblPanel.Controls.Add(this.label3, 0, 2);
            this.tblPanel.Controls.Add(this.label4, 0, 3);
            this.tblPanel.Controls.Add(this.label5, 0, 4);
            this.tblPanel.Controls.Add(this.rboxContractor, 1, 2);
            this.tblPanel.Controls.Add(this.rboxCargo, 1, 1);
            this.tblPanel.Controls.Add(this.rboxMark, 1, 3);
            this.tblPanel.Controls.Add(this.pnlVehicle, 1, 4);
            this.tblPanel.Controls.Add(this.label6, 0, 5);
            this.tblPanel.Controls.Add(this.tboxDriverName, 1, 5);
            this.tblPanel.Controls.Add(this.pickDateFrom, 1, 8);
            this.tblPanel.Controls.Add(this.tboxContact, 1, 6);
            this.tblPanel.Controls.Add(this.label9, 0, 6);
            this.tblPanel.Controls.Add(this.label10, 0, 10);
            this.tblPanel.Controls.Add(this.tboxComment, 1, 10);
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.Padding = new System.Windows.Forms.Padding(5);
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
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanel.Size = new System.Drawing.Size(714, 391);
            this.tblPanel.TabIndex = 0;
            // 
            // pickDateTo
            // 
            this.pickDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateTo.Location = new System.Drawing.Point(278, 268);
            this.pickDateTo.Name = "pickDateTo";
            this.pickDateTo.Size = new System.Drawing.Size(83, 20);
            this.pickDateTo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(8, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Прибытие в Кондопогу (период)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxWhereTo
            // 
            this.tboxWhereTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxWhereTo.Location = new System.Drawing.Point(278, 216);
            this.tboxWhereTo.Name = "tboxWhereTo";
            this.tboxWhereTo.Size = new System.Drawing.Size(428, 20);
            this.tboxWhereTo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(8, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Отправление/назначение груза";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.tblPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lblCreationInformation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 25);
            this.panel1.TabIndex = 0;
            // 
            // lblCreationInformation
            // 
            this.lblCreationInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreationInformation.Location = new System.Drawing.Point(74, 0);
            this.lblCreationInformation.Name = "lblCreationInformation";
            this.lblCreationInformation.Size = new System.Drawing.Size(624, 25);
            this.lblCreationInformation.TabIndex = 1;
            this.lblCreationInformation.Text = "label2";
            this.lblCreationInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создана:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вид груза";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Перевозчик";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Марка т/с";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(8, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Автомобиль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rboxContractor
            // 
            this.rboxContractor.Database = null;
            this.rboxContractor.DataSource = null;
            this.rboxContractor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rboxContractor.ListForm = "EntryControl.ContractorListForm";
            this.rboxContractor.Location = new System.Drawing.Point(279, 73);
            this.rboxContractor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rboxContractor.Name = "rboxContractor";
            this.rboxContractor.SelectedItem = null;
            this.rboxContractor.Size = new System.Drawing.Size(426, 22);
            this.rboxContractor.TabIndex = 1;
            this.rboxContractor.GetList += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxContractor_GetList);
            this.rboxContractor.ShowListForm += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxContractor_ShowListForm);
            // 
            // rboxCargo
            // 
            this.rboxCargo.Database = null;
            this.rboxCargo.DataSource = null;
            this.rboxCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rboxCargo.ListForm = "EntryControl.CargoListForm";
            this.rboxCargo.Location = new System.Drawing.Point(279, 41);
            this.rboxCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rboxCargo.Name = "rboxCargo";
            this.rboxCargo.SelectedItem = null;
            this.rboxCargo.Size = new System.Drawing.Size(426, 22);
            this.rboxCargo.TabIndex = 0;
            this.rboxCargo.GetList += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxCargo_GetList);
            // 
            // rboxMark
            // 
            this.rboxMark.Database = null;
            this.rboxMark.DataSource = null;
            this.rboxMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rboxMark.ListForm = "EntryControl.MarkListForm";
            this.rboxMark.Location = new System.Drawing.Point(279, 105);
            this.rboxMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rboxMark.Name = "rboxMark";
            this.rboxMark.SelectedItem = null;
            this.rboxMark.Size = new System.Drawing.Size(426, 22);
            this.rboxMark.TabIndex = 2;
            this.rboxMark.GetList += new System.EventHandler<EntryControl.ReferenceBox.ReferenceBoxEventArgs>(this.rboxMark_GetList);
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.Controls.Add(this.tboxVehicle);
            this.pnlVehicle.Controls.Add(this.btnFindVehicle);
            this.pnlVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVehicle.Location = new System.Drawing.Point(278, 135);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Size = new System.Drawing.Size(428, 22);
            this.pnlVehicle.TabIndex = 3;
            // 
            // tboxVehicle
            // 
            this.tboxVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxVehicle.Location = new System.Drawing.Point(0, 0);
            this.tboxVehicle.Name = "tboxVehicle";
            this.tboxVehicle.Size = new System.Drawing.Size(403, 20);
            this.tboxVehicle.TabIndex = 0;
            this.tboxVehicle.Validating += new System.ComponentModel.CancelEventHandler(this.tboxVehicle_Validating);
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindVehicle.BackgroundImage")));
            this.btnFindVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindVehicle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFindVehicle.Location = new System.Drawing.Point(403, 0);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(25, 22);
            this.btnFindVehicle.TabIndex = 0;
            this.btnFindVehicle.TabStop = false;
            this.btnFindVehicle.UseVisualStyleBackColor = true;
            this.btnFindVehicle.Click += new System.EventHandler(this.btnFindVehicle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(8, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Водитель";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxDriverName
            // 
            this.tboxDriverName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxDriverName.Location = new System.Drawing.Point(278, 164);
            this.tboxDriverName.Name = "tboxDriverName";
            this.tboxDriverName.Size = new System.Drawing.Size(428, 20);
            this.tboxDriverName.TabIndex = 3;
            this.tboxDriverName.Validating += new System.ComponentModel.CancelEventHandler(this.tboxDriverName_Validating);
            // 
            // pickDateFrom
            // 
            this.pickDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateFrom.Location = new System.Drawing.Point(278, 242);
            this.pickDateFrom.Name = "pickDateFrom";
            this.pickDateFrom.Size = new System.Drawing.Size(83, 20);
            this.pickDateFrom.TabIndex = 6;
            // 
            // tboxContact
            // 
            this.tboxContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxContact.Location = new System.Drawing.Point(278, 190);
            this.tboxContact.Name = "tboxContact";
            this.tboxContact.Size = new System.Drawing.Size(428, 20);
            this.tboxContact.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(8, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Контакты водителя";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(8, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 95);
            this.label10.TabIndex = 20;
            this.label10.Text = "Комментарий";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tboxComment
            // 
            this.tboxComment.AcceptsReturn = true;
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxComment.Location = new System.Drawing.Point(278, 294);
            this.tboxComment.Multiline = true;
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.Size = new System.Drawing.Size(428, 89);
            this.tboxComment.TabIndex = 21;
            // 
            // formErrorProvider
            // 
            this.formErrorProvider.ContainerControl = this;
            // 
            // PlanAppointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 426);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlanAppointForm";
            this.Text = "PlanAppointForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlVehicle.ResumeLayout(false);
            this.pnlVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreationInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ReferenceBox rboxContractor;
        private ReferenceBox rboxCargo;
        private ReferenceBox rboxMark;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.TextBox tboxVehicle;
        private System.Windows.Forms.Button btnFindVehicle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxDriverName;
        private System.Windows.Forms.TextBox tboxWhereTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker pickDateFrom;
        private System.Windows.Forms.TextBox tboxContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker pickDateTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tboxComment;
        private System.Windows.Forms.ErrorProvider formErrorProvider;
    }
}
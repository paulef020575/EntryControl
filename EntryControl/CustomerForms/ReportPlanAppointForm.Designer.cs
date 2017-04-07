namespace EntryControl
{
    partial class ReportPlanAppointForm
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxCargo = new System.Windows.Forms.ComboBox();
            this.pickPlanDate = new System.Windows.Forms.DateTimePicker();
            this.panelBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonPrint);
            this.panelBottom.Controls.Add(this.buttonPreview);
            this.panelBottom.Controls.Add(this.buttonClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 243);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(5);
            this.panelBottom.Size = new System.Drawing.Size(664, 35);
            this.panelBottom.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPrint.Location = new System.Drawing.Point(359, 5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(100, 25);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPreview.Location = new System.Drawing.Point(459, 5);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(100, 25);
            this.buttonPreview.TabIndex = 1;
            this.buttonPreview.Text = "Просмотр";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Location = new System.Drawing.Point(559, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 25);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxCargo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pickPlanDate, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 243);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(116, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата отгрузки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид груза";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxCargo
            // 
            this.cboxCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxCargo.FormattingEnabled = true;
            this.cboxCargo.Location = new System.Drawing.Point(203, 3);
            this.cboxCargo.Name = "cboxCargo";
            this.cboxCargo.Size = new System.Drawing.Size(458, 21);
            this.cboxCargo.TabIndex = 2;
            // 
            // pickPlanDate
            // 
            this.pickPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickPlanDate.Location = new System.Drawing.Point(203, 30);
            this.pickPlanDate.Name = "pickPlanDate";
            this.pickPlanDate.Size = new System.Drawing.Size(146, 20);
            this.pickPlanDate.TabIndex = 3;
            // 
            // ReportPlanAppointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 278);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelBottom);
            this.Name = "ReportPlanAppointForm";
            this.Text = "План прибытия транспорта";
            this.panelBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxCargo;
        private System.Windows.Forms.DateTimePicker pickPlanDate;
    }
}
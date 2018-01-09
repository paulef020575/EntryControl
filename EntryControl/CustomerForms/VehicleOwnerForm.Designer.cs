namespace EntryControl
{
    partial class VehicleOwnerForm
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
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContractor = new System.Windows.Forms.Panel();
            this.tboxContractor = new System.Windows.Forms.TextBox();
            this.btnSelectContractor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pickDateFrom = new System.Windows.Forms.DateTimePicker();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.tblPanel.SuspendLayout();
            this.pnlContractor.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanel
            // 
            this.tblPanel.ColumnCount = 2;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Controls.Add(this.label1, 0, 0);
            this.tblPanel.Controls.Add(this.pnlContractor, 1, 0);
            this.tblPanel.Controls.Add(this.label2, 0, 1);
            this.tblPanel.Controls.Add(this.pickDateFrom, 1, 1);
            this.tblPanel.Controls.Add(this.panelBottom, 0, 3);
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.Padding = new System.Windows.Forms.Padding(10);
            this.tblPanel.RowCount = 4;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblPanel.Size = new System.Drawing.Size(531, 244);
            this.tblPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перевозчик";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlContractor
            // 
            this.pnlContractor.Controls.Add(this.tboxContractor);
            this.pnlContractor.Controls.Add(this.btnSelectContractor);
            this.pnlContractor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContractor.Location = new System.Drawing.Point(268, 13);
            this.pnlContractor.Name = "pnlContractor";
            this.pnlContractor.Size = new System.Drawing.Size(250, 22);
            this.pnlContractor.TabIndex = 1;
            // 
            // tboxContractor
            // 
            this.tboxContractor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxContractor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxContractor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxContractor.Location = new System.Drawing.Point(0, 0);
            this.tboxContractor.Name = "tboxContractor";
            this.tboxContractor.Size = new System.Drawing.Size(225, 20);
            this.tboxContractor.TabIndex = 1;
            this.tboxContractor.Validating += new System.ComponentModel.CancelEventHandler(this.tboxContractor_Validating);
            // 
            // btnSelectContractor
            // 
            this.btnSelectContractor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectContractor.Location = new System.Drawing.Point(225, 0);
            this.btnSelectContractor.Name = "btnSelectContractor";
            this.btnSelectContractor.Size = new System.Drawing.Size(25, 22);
            this.btnSelectContractor.TabIndex = 0;
            this.btnSelectContractor.TabStop = false;
            this.btnSelectContractor.Text = "...";
            this.btnSelectContractor.UseVisualStyleBackColor = true;
            this.btnSelectContractor.Click += new System.EventHandler(this.btnSelectContractor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата получения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pickDateFrom
            // 
            this.pickDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateFrom.Location = new System.Drawing.Point(268, 41);
            this.pickDateFrom.Name = "pickDateFrom";
            this.pickDateFrom.Size = new System.Drawing.Size(112, 20);
            this.pickDateFrom.TabIndex = 3;
            this.pickDateFrom.Value = new System.DateTime(2015, 12, 11, 0, 0, 0, 0);
            // 
            // panelBottom
            // 
            this.tblPanel.SetColumnSpan(this.panelBottom, 2);
            this.panelBottom.Controls.Add(this.btnOK);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(13, 202);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(2);
            this.panelBottom.Size = new System.Drawing.Size(505, 29);
            this.panelBottom.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(303, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 25);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(403, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // VehicleOwnerForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(531, 244);
            this.Controls.Add(this.tblPanel);
            this.Name = "VehicleOwnerForm";
            this.Text = "VehicleOwnerForm";
            this.Load += new System.EventHandler(this.VehicleOwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            this.pnlContractor.ResumeLayout(false);
            this.pnlContractor.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsItem;
        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContractor;
        private System.Windows.Forms.TextBox tboxContractor;
        private System.Windows.Forms.Button btnSelectContractor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pickDateFrom;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}
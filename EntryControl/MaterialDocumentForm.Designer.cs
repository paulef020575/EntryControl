namespace EntryControl
{
    partial class MaterialDocumentForm
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tboxVehicle = new EntryControl.Controls.MemberTextBox();
            this.lblVehicle = new EntryControl.Controls.CaptionLabel();
            this.tboxPerson = new EntryControl.Controls.MemberTextBox();
            this.lblPerson = new EntryControl.Controls.CaptionLabel();
            this.tboxDocDate = new EntryControl.Controls.MemberTextBox();
            this.lblDocDate = new EntryControl.Controls.CaptionLabel();
            this.tboxDocNumber = new EntryControl.Controls.MemberTextBox();
            this.lblDocNumber = new EntryControl.Controls.CaptionLabel();
            this.captionLabel1 = new EntryControl.Controls.CaptionLabel();
            this.tboxUnit = new EntryControl.Controls.MemberTextBox();
            this.memberPictureBox1 = new EntryControl.Controls.MemberPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 341);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBottom.Size = new System.Drawing.Size(686, 33);
            this.pnlBottom.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tboxVehicle, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVehicle, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxPerson, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPerson, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxDocDate, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDocDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboxDocNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDocNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.captionLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxUnit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.memberPictureBox1, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 341);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tboxVehicle
            // 
            this.tboxVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxVehicle.Location = new System.Drawing.Point(423, 55);
            this.tboxVehicle.MemberName = "Vehicle";
            this.tboxVehicle.Name = "tboxVehicle";
            this.tboxVehicle.ReadOnly = true;
            this.tboxVehicle.Size = new System.Drawing.Size(230, 20);
            this.tboxVehicle.TabIndex = 9;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVehicle.Location = new System.Drawing.Point(355, 57);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(5);
            this.lblVehicle.MemberName = "Vehicle";
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(60, 16);
            this.lblVehicle.TabIndex = 8;
            this.lblVehicle.Text = "Vehicle";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxPerson
            // 
            this.tboxPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxPerson.Location = new System.Drawing.Point(87, 55);
            this.tboxPerson.MemberName = "Person";
            this.tboxPerson.Name = "tboxPerson";
            this.tboxPerson.ReadOnly = true;
            this.tboxPerson.Size = new System.Drawing.Size(230, 20);
            this.tboxPerson.TabIndex = 7;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPerson.Location = new System.Drawing.Point(5, 57);
            this.lblPerson.Margin = new System.Windows.Forms.Padding(5);
            this.lblPerson.MemberName = "Person";
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(74, 16);
            this.lblPerson.TabIndex = 6;
            this.lblPerson.Text = "Person";
            this.lblPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxDocDate
            // 
            this.tboxDocDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxDocDate.Location = new System.Drawing.Point(423, 29);
            this.tboxDocDate.MemberName = "DocDate";
            this.tboxDocDate.Name = "tboxDocDate";
            this.tboxDocDate.ReadOnly = true;
            this.tboxDocDate.Size = new System.Drawing.Size(230, 20);
            this.tboxDocDate.TabIndex = 5;
            // 
            // lblDocDate
            // 
            this.lblDocDate.AutoSize = true;
            this.lblDocDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocDate.Location = new System.Drawing.Point(355, 31);
            this.lblDocDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblDocDate.MemberName = "DocDate";
            this.lblDocDate.Name = "lblDocDate";
            this.lblDocDate.Size = new System.Drawing.Size(60, 16);
            this.lblDocDate.TabIndex = 4;
            this.lblDocDate.Text = "lblDocDate";
            this.lblDocDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxDocNumber
            // 
            this.tboxDocNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxDocNumber.Location = new System.Drawing.Point(87, 29);
            this.tboxDocNumber.MemberName = "DocNumber";
            this.tboxDocNumber.Name = "tboxDocNumber";
            this.tboxDocNumber.ReadOnly = true;
            this.tboxDocNumber.Size = new System.Drawing.Size(230, 20);
            this.tboxDocNumber.TabIndex = 3;
            // 
            // lblDocNumber
            // 
            this.lblDocNumber.AutoSize = true;
            this.lblDocNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocNumber.Location = new System.Drawing.Point(5, 31);
            this.lblDocNumber.Margin = new System.Windows.Forms.Padding(5);
            this.lblDocNumber.MemberName = "DocNumber";
            this.lblDocNumber.Name = "lblDocNumber";
            this.lblDocNumber.Size = new System.Drawing.Size(74, 16);
            this.lblDocNumber.TabIndex = 2;
            this.lblDocNumber.Text = "lblDocNumber";
            this.lblDocNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // captionLabel1
            // 
            this.captionLabel1.AutoSize = true;
            this.captionLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captionLabel1.Location = new System.Drawing.Point(5, 5);
            this.captionLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.captionLabel1.MemberName = "Unit";
            this.captionLabel1.Name = "captionLabel1";
            this.captionLabel1.Size = new System.Drawing.Size(74, 16);
            this.captionLabel1.TabIndex = 0;
            this.captionLabel1.Text = "lblUnit";
            this.captionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxUnit
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tboxUnit, 4);
            this.tboxUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxUnit.Location = new System.Drawing.Point(87, 3);
            this.tboxUnit.MemberName = "Unit";
            this.tboxUnit.Name = "tboxUnit";
            this.tboxUnit.ReadOnly = true;
            this.tboxUnit.Size = new System.Drawing.Size(566, 20);
            this.tboxUnit.TabIndex = 1;
            // 
            // memberPictureBox1
            // 
            this.memberPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberPictureBox1.Location = new System.Drawing.Point(323, 81);
            this.memberPictureBox1.MemberName = "CreatedImage";
            this.memberPictureBox1.Name = "memberPictureBox1";
            this.memberPictureBox1.Size = new System.Drawing.Size(24, 27);
            this.memberPictureBox1.TabIndex = 10;
            this.memberPictureBox1.TabStop = false;
            // 
            // MaterialDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlBottom);
            this.Name = "MaterialDocumentForm";
            this.Text = "MaterialDocumentForm";
            this.Load += new System.EventHandler(this.MaterialDocumentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CaptionLabel captionLabel1;
        private System.Windows.Forms.BindingSource bsItem;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.MemberTextBox tboxUnit;
        private Controls.MemberTextBox tboxDocNumber;
        private Controls.CaptionLabel lblDocNumber;
        private Controls.MemberTextBox tboxDocDate;
        private Controls.CaptionLabel lblDocDate;
        private Controls.CaptionLabel lblPerson;
        private Controls.MemberTextBox tboxVehicle;
        private Controls.CaptionLabel lblVehicle;
        private Controls.MemberTextBox tboxPerson;
        private Controls.MemberPictureBox memberPictureBox1;
    }
}
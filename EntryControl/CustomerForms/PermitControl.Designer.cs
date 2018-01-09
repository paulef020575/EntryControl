namespace EntryControl
{
    partial class PermitControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblFullNumber = new System.Windows.Forms.Label();
            this.lblDriverInfo = new System.Windows.Forms.Label();
            this.lblActivePeriod = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCargo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVehicle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFullNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDriverInfo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblActivePeriod, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PermitControl_MouseDown);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.lblDriverInfo_MouseLeave);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVehicle_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVehicle.Location = new System.Drawing.Point(3, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.tableLayoutPanel1.SetRowSpan(this.lblVehicle, 2);
            this.lblVehicle.Size = new System.Drawing.Size(302, 66);
            this.lblVehicle.TabIndex = 0;
            this.lblVehicle.Text = "lblVehicle";
            this.lblVehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PermitControl_MouseDown);
            this.lblVehicle.MouseLeave += new System.EventHandler(this.lblDriverInfo_MouseLeave);
            this.lblVehicle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVehicle_MouseMove);
            this.lblVehicle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // lblFullNumber
            // 
            this.lblFullNumber.AutoSize = true;
            this.lblFullNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFullNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullNumber.Location = new System.Drawing.Point(311, 0);
            this.lblFullNumber.Name = "lblFullNumber";
            this.lblFullNumber.Size = new System.Drawing.Size(303, 33);
            this.lblFullNumber.TabIndex = 1;
            this.lblFullNumber.Text = "lblPermitNumber";
            this.lblFullNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFullNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PermitControl_MouseDown);
            this.lblFullNumber.MouseLeave += new System.EventHandler(this.lblDriverInfo_MouseLeave);
            this.lblFullNumber.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVehicle_MouseMove);
            this.lblFullNumber.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // lblDriverInfo
            // 
            this.lblDriverInfo.AutoSize = true;
            this.lblDriverInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDriverInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDriverInfo.Location = new System.Drawing.Point(311, 66);
            this.lblDriverInfo.Name = "lblDriverInfo";
            this.lblDriverInfo.Size = new System.Drawing.Size(303, 34);
            this.lblDriverInfo.TabIndex = 2;
            this.lblDriverInfo.Text = "lblDriverInfo";
            this.lblDriverInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PermitControl_MouseDown);
            this.lblDriverInfo.MouseLeave += new System.EventHandler(this.lblDriverInfo_MouseLeave);
            this.lblDriverInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVehicle_MouseMove);
            this.lblDriverInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // lblActivePeriod
            // 
            this.lblActivePeriod.AutoSize = true;
            this.lblActivePeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActivePeriod.Location = new System.Drawing.Point(311, 33);
            this.lblActivePeriod.Name = "lblActivePeriod";
            this.lblActivePeriod.Size = new System.Drawing.Size(303, 33);
            this.lblActivePeriod.TabIndex = 3;
            this.lblActivePeriod.Text = "lblActivePeriod";
            this.lblActivePeriod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblActivePeriod.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PermitControl_MouseDown);
            this.lblActivePeriod.MouseLeave += new System.EventHandler(this.lblDriverInfo_MouseLeave);
            this.lblActivePeriod.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVehicle_MouseMove);
            this.lblActivePeriod.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCargo.Location = new System.Drawing.Point(3, 66);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(302, 34);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "lblCargo";
            this.lblCargo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PermitControl_MouseDown);
            this.lblCargo.MouseLeave += new System.EventHandler(this.lblDriverInfo_MouseLeave);
            this.lblCargo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVehicle_MouseMove);
            this.lblCargo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // PermitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PermitControl";
            this.Size = new System.Drawing.Size(617, 100);
            this.Load += new System.EventHandler(this.PermitControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PermitControl_MouseDown);
            this.MouseLeave += new System.EventHandler(this.lblDriverInfo_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVehicle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblFullNumber;
        private System.Windows.Forms.Label lblDriverInfo;
        private System.Windows.Forms.Label lblActivePeriod;
        private System.Windows.Forms.Label lblCargo;
    }
}

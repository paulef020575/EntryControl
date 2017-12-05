namespace EntryControl
{
    partial class PlanAppointViewControl
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblVehicleMark = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblCreation = new System.Windows.Forms.Label();
            this.tboxComment = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPermit = new System.Windows.Forms.GroupBox();
            this.lboxPermitMoving = new System.Windows.Forms.ListBox();
            this.lblPermit = new System.Windows.Forms.Label();
            this.gboxPointList = new System.Windows.Forms.GroupBox();
            this.lboxPointList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlPermit.SuspendLayout();
            this.gboxPointList.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCargo.Location = new System.Drawing.Point(18, 18);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(18);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(60, 24);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "label1";
            // 
            // lblVehicleMark
            // 
            this.lblVehicleMark.BackColor = System.Drawing.Color.White;
            this.lblVehicleMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVehicleMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVehicleMark.Location = new System.Drawing.Point(18, 42);
            this.lblVehicleMark.Margin = new System.Windows.Forms.Padding(18);
            this.lblVehicleMark.Name = "lblVehicleMark";
            this.lblVehicleMark.Size = new System.Drawing.Size(1005, 100);
            this.lblVehicleMark.TabIndex = 2;
            this.lblVehicleMark.Text = "label1";
            this.lblVehicleMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDriver.Location = new System.Drawing.Point(18, 142);
            this.lblDriver.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(60, 24);
            this.lblDriver.TabIndex = 3;
            this.lblDriver.Text = "label1";
            // 
            // lblCreation
            // 
            this.lblCreation.AutoSize = true;
            this.lblCreation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCreation.Location = new System.Drawing.Point(18, 458);
            this.lblCreation.Name = "lblCreation";
            this.lblCreation.Size = new System.Drawing.Size(60, 24);
            this.lblCreation.TabIndex = 4;
            this.lblCreation.Text = "label1";
            // 
            // tboxComment
            // 
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxComment.Enabled = false;
            this.tboxComment.Location = new System.Drawing.Point(18, 166);
            this.tboxComment.Multiline = true;
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.Size = new System.Drawing.Size(1005, 91);
            this.tboxComment.TabIndex = 5;
            // 
            // pnlBottom
            // 
            this.pnlBottom.ColumnCount = 2;
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBottom.Controls.Add(this.pnlPermit, 0, 0);
            this.pnlBottom.Controls.Add(this.gboxPointList, 1, 0);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(18, 257);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.RowCount = 1;
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlBottom.Size = new System.Drawing.Size(1005, 201);
            this.pnlBottom.TabIndex = 6;
            // 
            // pnlPermit
            // 
            this.pnlPermit.Controls.Add(this.lboxPermitMoving);
            this.pnlPermit.Controls.Add(this.lblPermit);
            this.pnlPermit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPermit.Location = new System.Drawing.Point(3, 3);
            this.pnlPermit.Name = "pnlPermit";
            this.pnlPermit.Size = new System.Drawing.Size(496, 195);
            this.pnlPermit.TabIndex = 0;
            this.pnlPermit.TabStop = false;
            this.pnlPermit.Text = "Пропуск на въезд";
            // 
            // lboxPermitMoving
            // 
            this.lboxPermitMoving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxPermitMoving.FormattingEnabled = true;
            this.lboxPermitMoving.ItemHeight = 24;
            this.lboxPermitMoving.Location = new System.Drawing.Point(3, 49);
            this.lboxPermitMoving.Name = "lboxPermitMoving";
            this.lboxPermitMoving.Size = new System.Drawing.Size(490, 143);
            this.lboxPermitMoving.TabIndex = 2;
            // 
            // lblPermit
            // 
            this.lblPermit.AutoSize = true;
            this.lblPermit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPermit.Location = new System.Drawing.Point(3, 25);
            this.lblPermit.Name = "lblPermit";
            this.lblPermit.Size = new System.Drawing.Size(170, 24);
            this.lblPermit.TabIndex = 1;
            this.lblPermit.Text = "Пропуск на въезд";
            // 
            // gboxPointList
            // 
            this.gboxPointList.Controls.Add(this.lboxPointList);
            this.gboxPointList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxPointList.Location = new System.Drawing.Point(505, 3);
            this.gboxPointList.Name = "gboxPointList";
            this.gboxPointList.Size = new System.Drawing.Size(497, 195);
            this.gboxPointList.TabIndex = 1;
            this.gboxPointList.TabStop = false;
            this.gboxPointList.Text = "Разрешенные пункты пропуска";
            // 
            // lboxPointList
            // 
            this.lboxPointList.DisplayMember = "Point";
            this.lboxPointList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxPointList.FormattingEnabled = true;
            this.lboxPointList.ItemHeight = 24;
            this.lboxPointList.Location = new System.Drawing.Point(3, 25);
            this.lboxPointList.Name = "lboxPointList";
            this.lboxPointList.Size = new System.Drawing.Size(491, 167);
            this.lboxPointList.Sorted = true;
            this.lboxPointList.TabIndex = 0;
            // 
            // PlanAppointViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.tboxComment);
            this.Controls.Add(this.lblCreation);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.lblVehicleMark);
            this.Controls.Add(this.lblCargo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PlanAppointViewControl";
            this.Padding = new System.Windows.Forms.Padding(18);
            this.Size = new System.Drawing.Size(1041, 500);
            this.Load += new System.EventHandler(this.PlanAppointViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlPermit.ResumeLayout(false);
            this.pnlPermit.PerformLayout();
            this.gboxPointList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.BindingSource bsItem;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblVehicleMark;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblCreation;
        private System.Windows.Forms.TextBox tboxComment;
        private System.Windows.Forms.TableLayoutPanel pnlBottom;
        private System.Windows.Forms.GroupBox pnlPermit;
        private System.Windows.Forms.Label lblPermit;
        private System.Windows.Forms.ListBox lboxPermitMoving;
        private System.Windows.Forms.GroupBox gboxPointList;
        private System.Windows.Forms.ListBox lboxPointList;
    }
}

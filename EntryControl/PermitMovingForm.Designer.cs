namespace EntryControl
{
    partial class PermitMovingForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pickMovingDate = new System.Windows.Forms.DateTimePicker();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblMoving = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pickMovingDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVehicle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMoving, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(270, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(261, 56);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // pickMovingDate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pickMovingDate, 2);
            this.pickMovingDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.pickMovingDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickMovingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickMovingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickMovingDate.Location = new System.Drawing.Point(3, 123);
            this.pickMovingDate.Name = "pickMovingDate";
            this.pickMovingDate.ShowUpDown = true;
            this.pickMovingDate.Size = new System.Drawing.Size(528, 44);
            this.pickMovingDate.TabIndex = 6;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblVehicle, 2);
            this.lblVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVehicle.Location = new System.Drawing.Point(0, 60);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Padding = new System.Windows.Forms.Padding(10);
            this.lblVehicle.Size = new System.Drawing.Size(534, 60);
            this.lblVehicle.TabIndex = 4;
            this.lblVehicle.Text = "lblVehicle";
            // 
            // lblMoving
            // 
            this.lblMoving.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMoving, 2);
            this.lblMoving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMoving.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoving.Location = new System.Drawing.Point(0, 0);
            this.lblMoving.Margin = new System.Windows.Forms.Padding(0);
            this.lblMoving.Name = "lblMoving";
            this.lblMoving.Padding = new System.Windows.Forms.Padding(10);
            this.lblMoving.Size = new System.Drawing.Size(534, 60);
            this.lblMoving.TabIndex = 3;
            this.lblMoving.Text = "lblMoving";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightGreen;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnOK.Location = new System.Drawing.Point(3, 183);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(261, 56);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // PermitMovingForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(534, 242);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PermitMovingForm";
            this.Text = "PermitMovingForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker pickMovingDate;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblMoving;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;

    }
}
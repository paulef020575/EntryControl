namespace EntryControl
{
    partial class EntryPointForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPointForm));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblEntryPoint = new System.Windows.Forms.Label();
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPermit = new System.Windows.Forms.Panel();
            this.tboxPermit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.tboxVehicle = new System.Windows.Forms.TextBox();
            this.btnFindVehicle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tblVehiclePanel = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.tblPanel.SuspendLayout();
            this.pnlPermit.SuspendLayout();
            this.pnlVehicle.SuspendLayout();
            this.tblVehiclePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblEntryPoint);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 240);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottom.Size = new System.Drawing.Size(719, 35);
            this.panelBottom.TabIndex = 0;
            // 
            // lblEntryPoint
            // 
            this.lblEntryPoint.AutoSize = true;
            this.lblEntryPoint.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEntryPoint.Location = new System.Drawing.Point(10, 10);
            this.lblEntryPoint.Name = "lblEntryPoint";
            this.lblEntryPoint.Size = new System.Drawing.Size(87, 13);
            this.lblEntryPoint.TabIndex = 0;
            this.lblEntryPoint.Text = "Пункт пропуска";
            this.lblEntryPoint.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // tblPanel
            // 
            this.tblPanel.ColumnCount = 1;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel.Controls.Add(this.pnlPermit, 0, 0);
            this.tblPanel.Controls.Add(this.pnlVehicle, 0, 1);
            this.tblPanel.Controls.Add(this.tblVehiclePanel, 0, 2);
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.RowCount = 3;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanel.Size = new System.Drawing.Size(719, 240);
            this.tblPanel.TabIndex = 1;
            // 
            // pnlPermit
            // 
            this.pnlPermit.Controls.Add(this.tboxPermit);
            this.pnlPermit.Controls.Add(this.label1);
            this.pnlPermit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPermit.Location = new System.Drawing.Point(3, 3);
            this.pnlPermit.Name = "pnlPermit";
            this.pnlPermit.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPermit.Size = new System.Drawing.Size(713, 74);
            this.pnlPermit.TabIndex = 0;
            // 
            // tboxPermit
            // 
            this.tboxPermit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxPermit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxPermit.Location = new System.Drawing.Point(237, 5);
            this.tboxPermit.Name = "tboxPermit";
            this.tboxPermit.Size = new System.Drawing.Size(471, 62);
            this.tboxPermit.TabIndex = 1;
            this.tboxPermit.TextChanged += new System.EventHandler(this.tboxPermit_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ пропуска";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.Controls.Add(this.tboxVehicle);
            this.pnlVehicle.Controls.Add(this.btnFindVehicle);
            this.pnlVehicle.Controls.Add(this.label2);
            this.pnlVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVehicle.Location = new System.Drawing.Point(3, 83);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Padding = new System.Windows.Forms.Padding(5);
            this.pnlVehicle.Size = new System.Drawing.Size(713, 74);
            this.pnlVehicle.TabIndex = 1;
            // 
            // tboxVehicle
            // 
            this.tboxVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxVehicle.Location = new System.Drawing.Point(237, 5);
            this.tboxVehicle.Name = "tboxVehicle";
            this.tboxVehicle.Size = new System.Drawing.Size(400, 62);
            this.tboxVehicle.TabIndex = 2;
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindVehicle.BackgroundImage")));
            this.btnFindVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindVehicle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFindVehicle.Location = new System.Drawing.Point(637, 5);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(71, 64);
            this.btnFindVehicle.TabIndex = 1;
            this.btnFindVehicle.TabStop = false;
            this.btnFindVehicle.UseVisualStyleBackColor = true;
            this.btnFindVehicle.Click += new System.EventHandler(this.btnFindVehicle_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "Гос. номер т/средства (цифры)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblVehiclePanel
            // 
            this.tblVehiclePanel.ColumnCount = 3;
            this.tblVehiclePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblVehiclePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblVehiclePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblVehiclePanel.Controls.Add(this.button1, 1, 0);
            this.tblVehiclePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblVehiclePanel.Location = new System.Drawing.Point(3, 163);
            this.tblVehiclePanel.Name = "tblVehiclePanel";
            this.tblVehiclePanel.RowCount = 1;
            this.tblVehiclePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblVehiclePanel.Size = new System.Drawing.Size(713, 74);
            this.tblVehiclePanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(242, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Лесовоз";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EntryPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 275);
            this.Controls.Add(this.tblPanel);
            this.Controls.Add(this.panelBottom);
            this.Name = "EntryPointForm";
            this.Text = "Пункт пропуска";
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.tblPanel.ResumeLayout(false);
            this.pnlPermit.ResumeLayout(false);
            this.pnlPermit.PerformLayout();
            this.pnlVehicle.ResumeLayout(false);
            this.pnlVehicle.PerformLayout();
            this.tblVehiclePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblEntryPoint;
        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Panel pnlPermit;
        private System.Windows.Forms.TextBox tboxPermit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.TextBox tboxVehicle;
        private System.Windows.Forms.Button btnFindVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tblVehiclePanel;
        private System.Windows.Forms.Button button1;
    }
}
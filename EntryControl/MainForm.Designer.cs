namespace EntryControl
{
    partial class MainForm
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
            this.rbuttonCustomer = new System.Windows.Forms.RadioButton();
            this.rbuttonReception = new System.Windows.Forms.RadioButton();
            this.rbuttonCentralPoint = new System.Windows.Forms.RadioButton();
            this.chkForever = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rbuttonSystemSecurity = new System.Windows.Forms.RadioButton();
            this.cboxServer = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbuttonCustomer
            // 
            this.rbuttonCustomer.AutoSize = true;
            this.rbuttonCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbuttonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbuttonCustomer.Location = new System.Drawing.Point(0, 0);
            this.rbuttonCustomer.Name = "rbuttonCustomer";
            this.rbuttonCustomer.Padding = new System.Windows.Forms.Padding(10);
            this.rbuttonCustomer.Size = new System.Drawing.Size(315, 44);
            this.rbuttonCustomer.TabIndex = 0;
            this.rbuttonCustomer.TabStop = true;
            this.rbuttonCustomer.Text = "ВВОД ЗАЯВОК";
            this.rbuttonCustomer.UseVisualStyleBackColor = true;
            // 
            // rbuttonReception
            // 
            this.rbuttonReception.AutoSize = true;
            this.rbuttonReception.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbuttonReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbuttonReception.Location = new System.Drawing.Point(0, 44);
            this.rbuttonReception.Name = "rbuttonReception";
            this.rbuttonReception.Padding = new System.Windows.Forms.Padding(10);
            this.rbuttonReception.Size = new System.Drawing.Size(315, 44);
            this.rbuttonReception.TabIndex = 1;
            this.rbuttonReception.TabStop = true;
            this.rbuttonReception.Text = "БЮРО ПРОПУСКОВ";
            this.rbuttonReception.UseVisualStyleBackColor = true;
            // 
            // rbuttonCentralPoint
            // 
            this.rbuttonCentralPoint.AutoSize = true;
            this.rbuttonCentralPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbuttonCentralPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbuttonCentralPoint.Location = new System.Drawing.Point(0, 88);
            this.rbuttonCentralPoint.Name = "rbuttonCentralPoint";
            this.rbuttonCentralPoint.Padding = new System.Windows.Forms.Padding(10);
            this.rbuttonCentralPoint.Size = new System.Drawing.Size(315, 44);
            this.rbuttonCentralPoint.TabIndex = 2;
            this.rbuttonCentralPoint.TabStop = true;
            this.rbuttonCentralPoint.Text = "ДЕЖУРНАЯ ЧАСТЬ";
            this.rbuttonCentralPoint.UseVisualStyleBackColor = true;
            // 
            // chkForever
            // 
            this.chkForever.AutoSize = true;
            this.chkForever.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkForever.Location = new System.Drawing.Point(0, 197);
            this.chkForever.Name = "chkForever";
            this.chkForever.Padding = new System.Windows.Forms.Padding(10);
            this.chkForever.Size = new System.Drawing.Size(315, 37);
            this.chkForever.TabIndex = 3;
            this.chkForever.Text = "запомнить выбор";
            this.chkForever.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 234);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(315, 51);
            this.panel1.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(110, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 41);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(210, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rbuttonSystemSecurity
            // 
            this.rbuttonSystemSecurity.AutoSize = true;
            this.rbuttonSystemSecurity.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbuttonSystemSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbuttonSystemSecurity.Location = new System.Drawing.Point(0, 132);
            this.rbuttonSystemSecurity.Name = "rbuttonSystemSecurity";
            this.rbuttonSystemSecurity.Padding = new System.Windows.Forms.Padding(10);
            this.rbuttonSystemSecurity.Size = new System.Drawing.Size(315, 44);
            this.rbuttonSystemSecurity.TabIndex = 5;
            this.rbuttonSystemSecurity.TabStop = true;
            this.rbuttonSystemSecurity.Text = "АДМИНИСТРИРОВАНИЕ";
            this.rbuttonSystemSecurity.UseVisualStyleBackColor = true;
            // 
            // cboxServer
            // 
            this.cboxServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxServer.FormattingEnabled = true;
            this.cboxServer.Items.AddRange(new object[] {
            "172.18.39.135",
            "192.168.10.33",
            "localhost"});
            this.cboxServer.Location = new System.Drawing.Point(0, 176);
            this.cboxServer.Name = "cboxServer";
            this.cboxServer.Size = new System.Drawing.Size(315, 21);
            this.cboxServer.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(315, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkForever);
            this.Controls.Add(this.cboxServer);
            this.Controls.Add(this.rbuttonSystemSecurity);
            this.Controls.Add(this.rbuttonCentralPoint);
            this.Controls.Add(this.rbuttonReception);
            this.Controls.Add(this.rbuttonCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите режим работы";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbuttonCustomer;
        private System.Windows.Forms.RadioButton rbuttonReception;
        private System.Windows.Forms.RadioButton rbuttonCentralPoint;
        private System.Windows.Forms.CheckBox chkForever;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbuttonSystemSecurity;
        private System.Windows.Forms.ComboBox cboxServer;
    }
}


namespace EntryControl
{
    partial class UserItemForm
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
            this.itemPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tboxRepeatPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Фамилия = new System.Windows.Forms.Label();
            this.tboxLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxSecondname = new System.Windows.Forms.TextBox();
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.chkIsDomain = new System.Windows.Forms.CheckBox();
            this.tboxDomainName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.itemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.itemPanel);
            // 
            // itemPanel
            // 
            this.itemPanel.ColumnCount = 3;
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.itemPanel.Controls.Add(this.tboxRepeatPassword, 1, 8);
            this.itemPanel.Controls.Add(this.label6, 0, 8);
            this.itemPanel.Controls.Add(this.tboxUserName, 1, 6);
            this.itemPanel.Controls.Add(this.label4, 0, 6);
            this.itemPanel.Controls.Add(this.Фамилия, 0, 0);
            this.itemPanel.Controls.Add(this.tboxLastname, 1, 0);
            this.itemPanel.Controls.Add(this.label1, 0, 1);
            this.itemPanel.Controls.Add(this.tboxFirstname, 1, 1);
            this.itemPanel.Controls.Add(this.label2, 0, 2);
            this.itemPanel.Controls.Add(this.tboxSecondname, 1, 2);
            this.itemPanel.Controls.Add(this.chkLocked, 1, 3);
            this.itemPanel.Controls.Add(this.chkIsDomain, 1, 4);
            this.itemPanel.Controls.Add(this.tboxDomainName, 1, 5);
            this.itemPanel.Controls.Add(this.label3, 0, 5);
            this.itemPanel.Controls.Add(this.label5, 0, 7);
            this.itemPanel.Controls.Add(this.tboxPassword, 1, 7);
            this.itemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel.Location = new System.Drawing.Point(0, 0);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.RowCount = 10;
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.itemPanel.Size = new System.Drawing.Size(551, 337);
            this.itemPanel.TabIndex = 2;
            // 
            // tboxRepeatPassword
            // 
            this.tboxRepeatPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxRepeatPassword.Location = new System.Drawing.Point(203, 205);
            this.tboxRepeatPassword.Name = "tboxRepeatPassword";
            this.tboxRepeatPassword.PasswordChar = '*';
            this.tboxRepeatPassword.Size = new System.Drawing.Size(300, 20);
            this.tboxRepeatPassword.TabIndex = 16;
            this.tboxRepeatPassword.Validated += new System.EventHandler(this.tboxRepeatPassword_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Подтвердите пароль";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxUserName
            // 
            this.tboxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxUserName.Location = new System.Drawing.Point(203, 153);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(300, 20);
            this.tboxUserName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Имя пользователя";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Фамилия
            // 
            this.Фамилия.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Фамилия.Location = new System.Drawing.Point(3, 0);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(194, 26);
            this.Фамилия.TabIndex = 0;
            this.Фамилия.Text = "Фамилия";
            this.Фамилия.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxLastname
            // 
            this.tboxLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxLastname.Location = new System.Drawing.Point(203, 3);
            this.tboxLastname.Name = "tboxLastname";
            this.tboxLastname.Size = new System.Drawing.Size(300, 20);
            this.tboxLastname.TabIndex = 1;
            this.tboxLastname.Validated += new System.EventHandler(this.tboxLastname_Validated);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxFirstname
            // 
            this.tboxFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxFirstname.Location = new System.Drawing.Point(203, 29);
            this.tboxFirstname.Name = "tboxFirstname";
            this.tboxFirstname.Size = new System.Drawing.Size(300, 20);
            this.tboxFirstname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отчество";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxSecondname
            // 
            this.tboxSecondname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxSecondname.Location = new System.Drawing.Point(203, 55);
            this.tboxSecondname.Name = "tboxSecondname";
            this.tboxSecondname.Size = new System.Drawing.Size(300, 20);
            this.tboxSecondname.TabIndex = 5;
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(203, 81);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(114, 17);
            this.chkLocked.TabIndex = 6;
            this.chkLocked.Text = "доступ запрещен";
            this.chkLocked.UseVisualStyleBackColor = true;
            // 
            // chkIsDomain
            // 
            this.chkIsDomain.AutoSize = true;
            this.chkIsDomain.Location = new System.Drawing.Point(203, 104);
            this.chkIsDomain.Name = "chkIsDomain";
            this.chkIsDomain.Size = new System.Drawing.Size(138, 17);
            this.chkIsDomain.TabIndex = 8;
            this.chkIsDomain.Text = "пользователь домена";
            this.chkIsDomain.UseVisualStyleBackColor = true;
            // 
            // tboxDomainName
            // 
            this.tboxDomainName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxDomainName.Location = new System.Drawing.Point(203, 127);
            this.tboxDomainName.Name = "tboxDomainName";
            this.tboxDomainName.Size = new System.Drawing.Size(300, 20);
            this.tboxDomainName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя домена";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxPassword
            // 
            this.tboxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxPassword.Location = new System.Drawing.Point(203, 179);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(300, 20);
            this.tboxPassword.TabIndex = 14;
            this.tboxPassword.Validated += new System.EventHandler(this.tboxPassword_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UserItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 372);
            this.Name = "UserItemForm";
            this.Text = "UserItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsDataItem)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.itemPanel.ResumeLayout(false);
            this.itemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel itemPanel;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Фамилия;
        private System.Windows.Forms.TextBox tboxLastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxSecondname;
        private System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.CheckBox chkIsDomain;
        private System.Windows.Forms.TextBox tboxDomainName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxRepeatPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
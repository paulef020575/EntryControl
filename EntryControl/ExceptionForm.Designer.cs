namespace EntryControl
{
    partial class ExceptionForm
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tboxAdvanced = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(579, 80);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRepeat);
            this.panel1.Controls.Add(this.btnIgnore);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(579, 35);
            this.panel1.TabIndex = 2;
            // 
            // btnRepeat
            // 
            this.btnRepeat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRepeat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRepeat.Location = new System.Drawing.Point(274, 5);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(100, 25);
            this.btnRepeat.TabIndex = 1;
            this.btnRepeat.Text = "Повторить";
            this.btnRepeat.UseVisualStyleBackColor = true;
            // 
            // btnIgnore
            // 
            this.btnIgnore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIgnore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIgnore.Location = new System.Drawing.Point(374, 5);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(100, 25);
            this.btnIgnore.TabIndex = 2;
            this.btnIgnore.Text = "Пропустить";
            this.btnIgnore.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(474, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tboxAdvanced
            // 
            this.tboxAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxAdvanced.Enabled = false;
            this.tboxAdvanced.Location = new System.Drawing.Point(0, 115);
            this.tboxAdvanced.Multiline = true;
            this.tboxAdvanced.Name = "tboxAdvanced";
            this.tboxAdvanced.ReadOnly = true;
            this.tboxAdvanced.Size = new System.Drawing.Size(579, 333);
            this.tboxAdvanced.TabIndex = 3;
            // 
            // ExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(579, 448);
            this.Controls.Add(this.tboxAdvanced);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExceptionForm";
            this.Text = "Ошибка выполнения";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tboxAdvanced;
    }
}
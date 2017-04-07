namespace EntryControl
{
    partial class ReferenceBox
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
            this.btnShowListForm = new System.Windows.Forms.Button();
            this.tboxValue = new System.Windows.Forms.TextBox();
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowListForm
            // 
            this.btnShowListForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowListForm.Location = new System.Drawing.Point(225, 0);
            this.btnShowListForm.Name = "btnShowListForm";
            this.btnShowListForm.Size = new System.Drawing.Size(25, 22);
            this.btnShowListForm.TabIndex = 0;
            this.btnShowListForm.TabStop = false;
            this.btnShowListForm.Text = "...";
            this.btnShowListForm.UseVisualStyleBackColor = true;
            this.btnShowListForm.Click += new System.EventHandler(this.btnShowListForm_Click);
            // 
            // tboxValue
            // 
            this.tboxValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxValue.Location = new System.Drawing.Point(0, 0);
            this.tboxValue.Name = "tboxValue";
            this.tboxValue.Size = new System.Drawing.Size(225, 20);
            this.tboxValue.TabIndex = 1;
            this.tboxValue.Validating += new System.ComponentModel.CancelEventHandler(this.tboxValue_Validating);
            // 
            // bsList
            // 
            this.bsList.DataSourceChanged += new System.EventHandler(this.bsList_DataSourceChanged);
            // 
            // ReferenceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tboxValue);
            this.Controls.Add(this.btnShowListForm);
            this.Name = "ReferenceBox";
            this.Size = new System.Drawing.Size(250, 22);
            this.Load += new System.EventHandler(this.ReferenceBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowListForm;
        private System.Windows.Forms.TextBox tboxValue;
        private System.Windows.Forms.BindingSource bsList;
    }
}

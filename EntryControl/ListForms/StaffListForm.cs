using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;

namespace EntryControl
{
    public partial class StaffListForm : ListForm
    {
        public StaffListForm(EntryControlDatabase database)
            : base(database, false)
        {
            InitializeComponent();
            Icon = EntryControl.Resources.Images.StaffIcon;

            
        }

        protected override void AddColumns()
        {
            AddTextBoxColumn("Код", "Code");
            AddTextBoxColumn("Фамилия", "Lastname", 250);
            AddTextBoxColumn("Имя", "Firstname", 200);
            AddTextBoxColumn("Отчество", "Secondname", 200);
            AddCheckBoxColumn("уволен", "IsFired");
        }

        protected override object LoadList()
        {
            return new BindingList<Staff>(Staff.LoadList(Database));
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Size = new System.Drawing.Size(879, 388);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(0, 420);
            this.pnlBottom.Size = new System.Drawing.Size(879, 35);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(879, 32);
            // 
            // StaffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 455);
            this.EditItemForm = "EntryControl.StaffItemForm";
            this.Name = "StaffListForm";
            this.Text = "Сотрудники ЧОП";
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

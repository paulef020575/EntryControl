using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EntryControl.Classes;

namespace EntryControl
{
    public partial class MarkListForm : ListForm
    {
        public MarkListForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public BindingList<VehicleMark> MarkList
        {
            get { return (BindingList<VehicleMark>)bsList.DataSource; }
            set { bsList.DataSource = value; }
        }

        protected override void AddColumns()
        {
            AddTextBoxColumn("Наименование", "Name", 250);
        }

        protected override object LoadList()
        {
            return new BindingList<VehicleMark>(VehicleMark.LoadList(Database));
        }
    }
}

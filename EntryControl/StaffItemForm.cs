using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;
using EPV.Database;

namespace EntryControl
{
    public partial class StaffItemForm : DataItemForm
    {
        public Staff Staff
        {
            get { return (Staff)Item; }
            set { Item = value; }
        }

        public StaffItemForm(Database database, Staff staff)
            : base(database)
        {
            InitializeComponent();
        }

        public StaffItemForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        protected override EPV.DataItem.DataItem CreateNewDataItem()
        {
            return new Staff();
        }

        protected override void CreateDataBindings()
        {
            base.CreateDataBindings();

            tboxCode.DataBindings.Add("Text", bsDataItem, "Code", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxLastname.DataBindings.Add("Text", bsDataItem, "Lastname", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxFirstname.DataBindings.Add("Text", bsDataItem, "Firstname", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxSecondname.DataBindings.Add("Text", bsDataItem, "Secondname", true, DataSourceUpdateMode.OnPropertyChanged);

            chkFired.DataBindings.Add("Checked", bsDataItem, "IsFired", true, DataSourceUpdateMode.OnPropertyChanged);
        }

    }
}

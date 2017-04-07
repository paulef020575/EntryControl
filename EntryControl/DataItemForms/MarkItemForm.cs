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
    public partial class MarkItemForm : DataItemForm
    {
        public MarkItemForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public VehicleMark VehicleMark
        {
            get { return (VehicleMark)Item; }
            set { Item = value; }
        }

        protected override void CreateDataBindings()
        {
            tboxName.DataBindings.Add("Text", bsDataItem, "Name");
        }


        protected override EPV.DataItem.DataItem CreateNewDataItem()
        {
            return new VehicleMark();
        }
    }
}

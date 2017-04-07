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
    public partial class EntryPointItemForm : DataItemForm
    {
        public EntryPointItemForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public EntryPoint EntryPoint
        {
            get { return (EntryPoint)Item; }
            set { Item = value; }
        }

        protected override void CreateDataBindings()
        {
            tboxName.DataBindings.Add("Text", bsDataItem, "Name");
            tboxPhone.DataBindings.Add("Text", bsDataItem, "Phone");
        }

        protected override EPV.DataItem.DataItem CreateNewDataItem()
        {
            return new EntryPoint();
        }
    }
}

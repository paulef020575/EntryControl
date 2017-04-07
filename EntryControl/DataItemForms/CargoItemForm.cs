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
    public partial class CargoItemForm : DataItemForm
    {
        public CargoItemForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public Cargo Cargo
        {
            get { return (Cargo)Item; }
            set { Item = value; }
        }

        protected override EPV.DataItem.DataItem CreateNewDataItem()
        {
            return new Cargo();
        }

        protected override void CreateDataBindings()
        {
            base.CreateDataBindings();

            tboxName.DataBindings.Add("Text", bsDataItem, "Name");
        }
    }
}

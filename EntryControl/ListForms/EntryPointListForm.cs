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
    public partial class EntryPointListForm : ListForm
    {
        public EntryPointListForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        protected override void AddColumns()
        {
            AddTextBoxColumn("Пункт пропуска", "Name", 200);
            AddTextBoxColumn("Телефон", "Phone");
        }

        protected override object LoadList()
        {
            return new BindingList<EntryPoint>(EntryPoint.LoadList(Database));
        }
    }
}

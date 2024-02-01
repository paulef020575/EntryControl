using EntryControl.Classes.Ref;
using EPV.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EntryControl.ListForms
{
    public partial class BlackListForm : ListForm
    {
        public BlackListForm(Database database, bool forSelection = false)
            : base(database, forSelection)
        {
            InitializeComponent();
            
        }   

        public IList<BlackList> BlackListItems
        {
            get => (IList<BlackList>)bsList.DataSource;
            set => bsList.DataSource = value;
        }

        protected override object LoadList()
        {
            return new BindingList<BlackList>(BlackList.LoadList(Database));
        }

        protected override void AddColumns()
        {
            AddTextBoxColumn("Текст", nameof(BlackList.Text), 300);
        }
    }
}

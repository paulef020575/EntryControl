using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EntryControl.Classes;
using EPV.DataItem;

namespace EntryControl
{
    public partial class CargoListForm : ListForm
    {
        #region Конструктор
        
        public CargoListForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public CargoListForm(Database database, bool forSelection)
            : base(database, forSelection)
        {
            InitializeComponent();
        }

        #endregion

        #region Свойства

        public IList<Cargo> CargoList
        {
            get { return (IList<Cargo>)bsList.DataSource; }
            set { bsList.DataSource = value; }
        }

        #endregion

        #region Методы

        #region Переопределенные

        protected override void AddColumns()
        {
            AddTextBoxColumn("Наименование", "Name", 300);
        }

        protected override object LoadList()
        {
            return new BindingList<Cargo>(Cargo.LoadList(Database));
        }

        #endregion

        #endregion
    }
}

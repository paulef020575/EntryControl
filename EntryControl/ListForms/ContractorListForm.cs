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
    public partial class ContractorListForm : ListForm
    {
        public ContractorListForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public ContractorListForm(Database database, bool forSelection)
            : base(database, forSelection)
        {
            InitializeComponent();
        }

        #region Свойства

        public BindingList<Contractor> ContractorList
        {
            get { return (BindingList<Contractor>)bsList.DataSource; }
            set { bsList.DataSource = value; }
        }

        private EnumerationItem contractorGroup;

        public EnumerationItem ContractorGroup
        {
            set { contractorGroup = value; }
        }

        #endregion

        #region Методы

        protected override void AddColumns()
        {
            AddTextBoxColumn("Краткое наименование", "ShortName", 200);
            AddTextBoxColumn("Полное наименование", "Name", 300);
        }

        protected override object LoadList()
        {
            return new BindingList<Contractor>(Contractor.LoadList(Database, (EnumerationItem)cboxContractorGroup.SelectedItem));
        }

        protected override void PreloadData()
        {
            Enumeration enumeration = new Enumeration(Database, "contractorGroup");

            List<EnumerationItem> items = new List<EnumerationItem>();
            items.Add(new EnumerationItem(-1, "ВСЕ"));

            foreach (EnumerationItem item in enumeration.Values)
                items.Add(item);

            cboxContractorGroup.DataSource = items;
            if (contractorGroup != null)
                cboxContractorGroup.SelectedItem = contractorGroup;
        }

        #endregion

        private void cboxContractorGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}

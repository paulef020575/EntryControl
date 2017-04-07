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
    public partial class ContractorItemForm : DataItemForm
    {
        public ContractorItemForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public Contractor Contractor
        {
            get { return (Contractor)Item; }
            set { Item = Contractor; }
        }

        protected override void CreateDataBindings()
        {
            base.CreateDataBindings();

            tboxShortName.DataBindings.Add("Text", bsDataItem, "ShortName");
            tboxName.DataBindings.Add("Text", bsDataItem, "Name");

            dgvContractorGroup.DataSource = Contractor.GetGroupList(Database);
            dgvContactList.DataSource = Contractor.GetContactList(Database);
        }

        protected override EPV.DataItem.DataItem CreateNewDataItem()
        {
            return new Contractor();
        }

        private void dgvContractorGroup_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            MarkAsModified();
        }
    }
}

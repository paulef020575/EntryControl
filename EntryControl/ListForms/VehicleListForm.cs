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
    public partial class VehicleListForm : ListForm
    {
        public VehicleListForm(Database database)
            : base(database)
        {
            InitializeComponent();

            rboxContractor.Database = Database;
            rboxMark.Database = Database;
        }

        #region Свойства

        public BindingList<Vehicle> VehicleList
        {
            get { return (BindingList<Vehicle>)bsList.DataSource; }
            set { bsList.DataSource = value; }
        }

        public Contractor Contractor
        {
            set { rboxContractor.SelectedItem = value; }
        }

        public VehicleMark Mark
        {
            set { rboxMark.SelectedItem = value; }
        }

        public string License
        {
            set { tboxLicense.Text = value; }
        }

        #endregion

        #region Методы

        protected override void AddColumns()
        {
            AddTextBoxColumn("Марка", "VehicleMark", 200);
            AddTextBoxColumn("Гос. номер", "LicensePlate");
            AddTextBoxColumn("Владелец", "Owner", 200);
        }

        protected override object LoadList()
        {
            return new BindingList<Vehicle>(Vehicle.LoadList(Database, 
                                                            (Contractor)rboxContractor.SelectedItem, 
                                                            (VehicleMark)rboxMark.SelectedItem,
                                                            tboxLicense.Text));
        }

        #endregion

        private void rboxContractor_GetList(object sender, ReferenceBox.ReferenceBoxEventArgs e)
        {
            e.ItemList = Contractor.LoadVehicleOwnerList(Database);
        }

        private void rboxContractor_SelectedItemChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void rboxContractor_ShowListForm(object sender, ReferenceBox.ReferenceBoxEventArgs e)
        {
            ContractorListForm form = (ContractorListForm)e.Form;

            form.ContractorGroup = EntryControlDatabase.VehicleOwnerGroup;
        }

        private void rboxMark_GetList(object sender, ReferenceBox.ReferenceBoxEventArgs e)
        {
            e.ItemList = VehicleMark.LoadList(Database);
        }
    }
}

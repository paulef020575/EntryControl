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
    public partial class PlanAppointForm : DataItemForm
    {
        #region Конструктор
        
        public PlanAppointForm(Database database)
            : base(database)
        {
            InitializeComponent();

            rboxCargo.Database = Database;
            rboxContractor.Database = Database;
            rboxMark.Database = Database;
        }

        #endregion

        #region Свойства

        public PlanAppoint PlanAppoint
        {
            get { return (PlanAppoint)Item; }
            set { Item = value.LoadCopy(Database); }
        }

        #endregion

        #region Методы

        #region Переопределенные

        protected override EPV.DataItem.DataItem CreateNewDataItem()
        {
            PlanAppoint planAppoint = new PlanAppoint();
            planAppoint.Creator = Database.ConnectedUser;
            return planAppoint;
        }

        protected override void CreateDataBindings()
        {
            base.CreateDataBindings();

            lblCreationInformation.DataBindings.Add("Text", bsDataItem, "CreationInfo");
            rboxCargo.DataBindings.Add("SelectedItem", bsDataItem, "Cargo");
            tboxDriverName.DataBindings.Add("Text", bsDataItem, "DriverName");
            tboxContact.DataBindings.Add("Text", bsDataItem, "Contact");
            tboxWhereTo.DataBindings.Add("Text", bsDataItem, "WhereTo");
            pickDateFrom.DataBindings.Add("Value", bsDataItem, "DateFrom", false, DataSourceUpdateMode.OnPropertyChanged);
            pickDateTo.DataBindings.Add("Value", bsDataItem, "DateTo", false, DataSourceUpdateMode.OnPropertyChanged);
            tboxComment.DataBindings.Add("Text", bsDataItem, "Comment", true, DataSourceUpdateMode.OnPropertyChanged);

            Vehicle vehicle = (Vehicle)PlanAppoint.Vehicle;
            if (!vehicle.Equals(Vehicle.Empty))
                vehicle = vehicle.LoadCopy(Database);
            tboxVehicle.Text = vehicle.LicensePlate;
            rboxContractor.SelectedItem = vehicle.Owner;
            rboxMark.SelectedItem = vehicle.VehicleMark;

            PlanAppoint.PropertyChanged += new PropertyChangedEventHandler(PlanAppoint_PropertyChanged);
        }

        #endregion

        private void rboxCargo_GetList(object sender, ReferenceBox.ReferenceBoxEventArgs e)
        {
            e.ItemList = Cargo.LoadList(Database);
        }

        #endregion

        private void rboxContractor_GetList(object sender, ReferenceBox.ReferenceBoxEventArgs e)
        {
            e.ItemList = Contractor.LoadVehicleOwnerList(Database);
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

        private void btnFindVehicle_Click(object sender, EventArgs e)
        {
            SearchVehicle();
        }

        private void SearchVehicle()
        {
            Contractor contractor = (Contractor)rboxContractor.SelectedItem;
            VehicleMark mark = (VehicleMark)rboxMark.SelectedItem;
            string license = tboxVehicle.Text;

            List<Vehicle> vehicleList = Vehicle.LoadList(Database, contractor, mark, license);

            switch (vehicleList.Count)
            {
                case 1:
                    SetAppointVehicle(vehicleList[0]);
                    break;

                case 0:
                    CreateNewVehicle(contractor, mark, license);
                    break;

                default:
                    SelectVehicleFromList(contractor, mark, license);
                    break;
            }
        }

        private void SelectVehicleFromList(Contractor contractor, VehicleMark mark, string license)
        {
            VehicleListForm form = new VehicleListForm(Database);
            form.Contractor = contractor;
            form.Mark = mark;
            form.License = license;

            form.SelectedItem = PlanAppoint.Vehicle;

            form.ItemSelected += new EventHandler(formVehicleItemSelected);
            form.Show();
        }

        void formVehicleItemSelected(object sender, EventArgs e)
        {
            SetAppointVehicle((Vehicle)sender);
        }

        private void CreateNewVehicle(Contractor contractor, VehicleMark mark, string license)
        {
            string message = EntryControl.Resources.Message.Question.NoSuchVehicle;

            if (MessageBox.Show(message, "Транспортное средство", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.VehicleMark = (mark == null ? VehicleMark.Empty : mark);
                vehicle.LicensePlate = license;
                if (contractor != null && !contractor.Equals(Contractor.Empty))
                    vehicle.AddOwner(contractor);

                VehicleItemForm form = new VehicleItemForm(Database);
                form.Vehicle = vehicle;
                form.ItemSaved += formVehicleItemSelected;
                form.Show();
            }
            else
            {
                tboxVehicle.Clear();
            }
        }

        private void SetAppointVehicle(Vehicle vehicle)
        {
            PlanAppoint.Vehicle = vehicle;
            rboxContractor.SelectedItem = vehicle.Owner;
            rboxMark.SelectedItem = vehicle.VehicleMark;
            tboxVehicle.Text = vehicle.LicensePlate;
        }

        private void tboxVehicle_Validating(object sender, CancelEventArgs e)
        {
            Vehicle vehicle = (Vehicle)PlanAppoint.Vehicle;
            if (!string.Equals(tboxVehicle.Text, vehicle.LicensePlate))
            {
                SearchVehicle();
            }
        }

        void PlanAppoint_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, "Vehicle", StringComparison.InvariantCultureIgnoreCase))
                PlanAppoint.GetDriverInfo(Database);
        }

        protected override bool SaveItem()
        {
            if (CheckProperties())
                return base.SaveItem();

            return false;
        }

        private bool CheckProperties()
        {
            bool result = true;

            if (PlanAppoint.Cargo == null || PlanAppoint.Cargo.Id == 0)
            {
                formErrorProvider.SetError(rboxCargo, "Выберите груз из справочника");
                result = false;
            }

            return result;
        }
    }
}

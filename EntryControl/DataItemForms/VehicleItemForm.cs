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
    public partial class VehicleItemForm : DataItemForm
    {
        public VehicleItemForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        private List<VehicleMark> markList;

        public Vehicle Vehicle
        {
            get { return (Vehicle)Item; }
            set { Item = value; }
        }

        protected override EPV.DataItem.DataItem CreateNewDataItem()
        {
            return new Vehicle();
        }

        protected override void CreateDataBindings()
        {
            base.CreateDataBindings();

            tboxVehicleMark.DataBindings.Add("Text", bsDataItem, "VehicleMark");
            tboxLicensePlate.DataBindings.Add("Text", bsDataItem, "LicensePlate");

            bsOwnerList.DataSource = Vehicle.GetOwnerList(Database);
        }

        private void btnSelectVehicleMark_Click(object sender, EventArgs e)
        {
            MarkListForm form = new MarkListForm(Database);
            form.SelectedItem = Vehicle.VehicleMark;
            form.ItemSelected +=new EventHandler(markItemSelected);

            form.Show();
        }

        private void markItemSelected(object sender, EventArgs e)
        {
            FillMarkAutoCompleteList();
            Vehicle.VehicleMark = (VehicleMark)sender;
        }

        protected override void PreloadData()
        {
            FillMarkAutoCompleteList();
        }

        private void FillMarkAutoCompleteList()
        {
            AutoCompleteStringCollection list = new AutoCompleteStringCollection();

            markList = VehicleMark.LoadList(Database);

            foreach (VehicleMark mark in markList)
                list.Add(mark.ToString());

            tboxVehicleMark.AutoCompleteCustomSource = list;
        }

        private void tboxVehicleMark_Validating(object sender, CancelEventArgs e)
        {
            foreach (VehicleMark mark in markList)
            {
                if (string.Equals(mark.ToString(), tboxVehicleMark.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    Vehicle.VehicleMark = mark;
                    e.Cancel = false;
                    return;
                }
            }

            tboxVehicleMark.Text = Vehicle.VehicleMark.ToString();
            e.Cancel = false;
        }

        private void addItemTool_Click(object sender, EventArgs e)
        {
            AddNewOwner();
        }

        private void AddNewOwner()
        {
            VehicleOwner owner = new VehicleOwner(Vehicle);
            VehicleOwnerForm form = new VehicleOwnerForm(Database);
            form.VehicleOwner = owner;

            if (form.ShowDialog() == DialogResult.OK)
            {
                bsOwnerList.Add(owner);
                MarkAsModified();
            }
        }

        private void editItemTool_Click(object sender, EventArgs e)
        {
            EditCurrentOwner();
        }

        private void EditCurrentOwner()
        {
            if (bsOwnerList.Current != null)
            {
                VehicleOwner owner = (VehicleOwner)bsOwnerList.Current;
                VehicleOwner ownerCopy = new VehicleOwner(Vehicle, owner.Contractor, owner.DateFrom);

                VehicleOwnerForm form = new VehicleOwnerForm(Database);
                form.VehicleOwner = ownerCopy;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    owner.Contractor = ownerCopy.Contractor;
                    owner.DateFrom = ownerCopy.DateFrom;

                    MarkAsModified();
                }
            }
        }

        private void deleteItemTool_Click(object sender, EventArgs e)
        {
            DeleteCurrentOwner();
        }

        private void DeleteCurrentOwner()
        {
            string message = EntryControl.Resources.Message.Question.DeleteVehicleOwner;
            if (bsOwnerList.Current != null
                && MessageBox.Show(message, Vehicle.ToString(), MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
            {
                Vehicle.RemoveOwner((VehicleOwner)bsOwnerList.Current);
                MarkAsModified();
            }
        }

        protected override bool SaveItem()
        {
            if (CheckControls())
                return base.SaveItem();

            return false;
        }

        private bool CheckControls()
        {
            bool result = true;

            if (Vehicle.VehicleMark == null || Vehicle.VehicleMark.Id == 0)
            {
                formErrorProvider.SetError(tboxVehicleMark, "Укажите марку Т/С");
                result = false;
            }

            if (Vehicle.LicensePlate.Trim().Length == 0)
            {
                formErrorProvider.SetError(tboxLicensePlate, "Укажите номер Т/С");
                result = false;
            }

            return result;
        }
    }
}

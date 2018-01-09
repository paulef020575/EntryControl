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
    public partial class VehicleOwnerForm : EntryControlForm
    {
        private VehicleOwnerForm()
            : base()
        {
            InitializeComponent();
        }

        public VehicleOwnerForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public VehicleOwner VehicleOwner
        {
            get { return (VehicleOwner)bsItem.DataSource; }
            set { bsItem.DataSource = value; }
        }

        private List<Contractor> contractorList;

        private void VehicleOwnerForm_Load(object sender, EventArgs e)
        {
            PreloadData();
            AddDataBindings();
        }

        private void AddDataBindings()
        {
            Text = VehicleOwner.Vehicle.ToString();

            tboxContractor.DataBindings.Add("Text", bsItem, "Contractor");
            pickDateFrom.DataBindings.Add("Value", bsItem, "DateFrom");
        }

        private void PreloadData()
        {
            contractorList = Contractor.LoadList(Database, EntryControlDatabase.VehicleOwnerGroup);

            AutoCompleteStringCollection nameList = new AutoCompleteStringCollection();
            foreach (Contractor contractor in contractorList)
                nameList.Add(contractor.ToString());

            tboxContractor.AutoCompleteCustomSource = nameList;
        }

        private void btnSelectContractor_Click(object sender, EventArgs e)
        {
            ContractorListForm form = new ContractorListForm(Database);
            form.ContractorGroup = EntryControlDatabase.VehicleOwnerGroup;

            form.SelectedItem = VehicleOwner.Contractor;
            form.ItemSelected += new EventHandler(contractorItemSelected);

            form.Show();
        }

        void contractorItemSelected(object sender, EventArgs e)
        {
            PreloadData();
            VehicleOwner.Contractor = (Contractor)sender;
        }

        private void tboxContractor_Validating(object sender, CancelEventArgs e)
        {
            foreach (Contractor contractor in contractorList)
            {
                if (string.Equals(contractor.ToString(), tboxContractor.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    VehicleOwner.Contractor = contractor;
                    e.Cancel = false;
                    return;
                }
            }

            tboxContractor.Text = VehicleOwner.Contractor.ToString();
            e.Cancel = false;
        }

    }
}

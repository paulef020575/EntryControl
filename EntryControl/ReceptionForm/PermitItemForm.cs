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
    public partial class PermitItemForm : DataItemForm
    {
        private bool isDataLoaded = false;

        public PermitItemForm(Database database)
            : base(database)
        {
            InitializeComponent();

            rboxCargo.Database = Database;
            rboxVehicle.Database = Database;
        }

        public PlanAppoint PlanAppoint
        {
            private get;
            set;
        }

        public Permit Permit
        {
            get { return (Permit)Item; }
            set 
            { 
                Item = value;
                Permit.GetComment(Database);
            }
        }

        private void FillPointList()
        {
            bsPoints.DataSource = Permit.ReloadPointList(Database);

            foreach (PermitPoint pp in (List<PermitPoint>)bsPoints.DataSource)
                pp.PropertyChanged += Pp_PropertyChanged;
        }

        private void Pp_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Permit.MarkAsModified();
        }

        protected override EPV.DataItem.DataItem CreateNewDataItem()
        {
            Permit permit = null;
            
            if (PlanAppoint != null)
                permit = new Permit(PlanAppoint);
            else
                permit = new Permit();

            permit.Creator = ((EntryControlDatabase)Database).ConnectedUser;
            permit.DocNumber = EntryControl.Classes.Permit.GetPermitNumber(Database, permit.Period);


            return permit;
        }

        protected override void CreateDataBindings()
        {
            base.CreateDataBindings();

            lblDocNumber.Text = Permit.ShortNumber;
            cboxPermitState.DataBindings.Add("SelectedItem", bsDataItem, "PermitState");
            pickDateFrom.DataBindings.Add("Value", bsDataItem, "DateFrom");
            pickDateTo.DataBindings.Add("Value", bsDataItem, "DateTo");
            rboxCargo.DataBindings.Add("SelectedItem", bsDataItem, "Cargo");
            rboxVehicle.DataBindings.Add("SelectedItem", bsDataItem, "Vehicle");
            tboxDriverName.DataBindings.Add("Text", bsDataItem, "DriverName");
            tboxContact.DataBindings.Add("Text", bsDataItem, "Contact");
            chkMultiEntry.DataBindings.Add("Checked", bsDataItem, "IsMultiEntry");
            tboxComment.DataBindings.Add("Text", bsDataItem, "Comment");

            FillPointList();

            FillCboxSelection();

            isDataLoaded = true;

        }

        protected override void PreloadData()
        {
            Enumeration permitStateList = new Enumeration(Database, "permitState");
            List<EnumerationItem> states = new List<EnumerationItem>();
            foreach (EnumerationItem item in permitStateList.Values)
                states.Add(item);

            cboxPermitState.DataSource = states;
        }

        private void rboxCargo_GetList(object sender, ReferenceBox.ReferenceBoxEventArgs e)
        {
            e.ItemList = Cargo.LoadList(Database);
        }

        private void rboxVehicle_GetList(object sender, ReferenceBox.ReferenceBoxEventArgs e)
        {
            e.ItemList = Vehicle.LoadList(Database);
        }

        private void btnCheckAllPoints_Click(object sender, EventArgs e)
        {
            CheckAllPoints();
        }

        private void CheckAllPoints()
        {
            List<PermitPoint> permitPointList = (List<PermitPoint>)bsPoints.DataSource;
            foreach (PermitPoint permitPoint in permitPointList)
                permitPoint.IsAllowed = true;
            dataGridView1.Refresh();
        }

        private void btnClearAllCheck_Click(object sender, EventArgs e)
        {
            ClearAllPoints();
        }

        private void ClearAllPoints()
        {
            List<PermitPoint> permitPointList = (List<PermitPoint>)bsPoints.DataSource;
            foreach (PermitPoint permitPoint in permitPointList)
                permitPoint.IsAllowed = false;
            dataGridView1.Refresh();
        }

        private void btnSprEntryPoint_Click(object sender, EventArgs e)
        {
            EntryPointListForm form = new EntryControl.EntryPointListForm(Database);
            form.FormClosed += EntryPointListFormClosed;
            form.Show();
        }

        private void EntryPointListFormClosed(object sender, FormClosedEventArgs e)
        {
            isDataLoaded = false;
            FillPointList();
            FillCboxSelection();
            isDataLoaded = true;
        }

        private void FillCboxSelection()
        {
            cboxSelection.Items.Clear();
            cboxSelection.Items.Add("Снять все");
            cboxSelection.Items.Add("Разрешить все");

            List<string> groupList = EntryPointGroup.LoadGroupList(Database);
            foreach (string groupName in groupList)
                cboxSelection.Items.Add(groupName);
        }

        private void cboxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isDataLoaded)
            {
                if (cboxSelection.SelectedIndex == 0)
                    ClearAllPoints();

                if (cboxSelection.SelectedIndex == 1)
                    CheckAllPoints();

                if (cboxSelection.SelectedIndex > 1)
                    CheckGroupPoints(cboxSelection.Text);
            }
        }

        private void CheckGroupPoints(string text)
        {
            List<EntryPointGroup> groupPoints = EntryPointGroup.LoadGroup(Database, text);
            Dictionary<EntryPoint, bool> pointList = new Dictionary<EntryPoint, bool>();
            foreach (EntryPointGroup item in groupPoints)
                pointList.Add(item.EntryPoint, item.IsIncluded);

            List<PermitPoint> permitPointList = (List<PermitPoint>)bsPoints.DataSource;
            foreach (PermitPoint item in permitPointList)
                item.IsAllowed = pointList[item.Point];
            dataGridView1.Refresh();

        }
    }
}

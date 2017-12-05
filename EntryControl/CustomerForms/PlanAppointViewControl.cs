using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;
using EPV.Database;

namespace EntryControl
{
    public partial class PlanAppointViewControl : UserControl, ITimeredControl
    {
        private Database Database;

        private PlanAppointViewControl()
        {
            InitializeComponent();
        }

        public PlanAppointViewControl(Database database)
            : this()
        {
            Database = database;
        }

        public PlanAppoint PlanAppoint
        {
            get { return (PlanAppoint)bsItem.DataSource; }
            set { bsItem.DataSource = value; }
        }

        public Timer Timer
        {
            get { return timer; }
        }

        public void StopTimer()
        {
            timer.Stop();
        }

        private void PlanAppointViewControl_Load(object sender, EventArgs e)
        {
            AddBindings();
        }

        private void AddBindings()
        {
            if (PlanAppoint.IsUpdated)
                timer.Start();

            lblCargo.Text = PlanAppoint.Cargo.ToString();
            lblVehicleMark.Text = PlanAppoint.Vehicle.ToString();
            lblDriver.Text = PlanAppoint.DriverName + " (" + PlanAppoint.Contact + ")";
            lblCreation.Text = PlanAppoint.CreationInfo;

            PlanAppoint.GetComment(Database);
            tboxComment.DataBindings.Add("Text", bsItem, "Comment");

            if (PlanAppoint.HasPermit)
            {
                Permit permit = PlanAppoint.LoadPermit(Database);
                lblPermit.Text = permit.ToString();

                switch (permit.PermitState.Id)
                {
                    case 4:
                        lblPermit.Text += " (закрыт)";
                        break;

                    case 3:
                        lblPermit.Text += " (заблокирован)";
                        break;

                    case 2:
                        lblPermit.Text += " (постоянный)";
                        break;
                }

                lboxPermitMoving.DataSource = permit.GetMovingList(Database);
                lboxPointList.DataSource = permit.GetAllowedPointList(Database);
            }
            else
            {
                lblPermit.Text = "не выдан";
            }
        } 

        private void timer_Tick(object sender, EventArgs e)
        {
            RaiseItemSeen();
        }

        private EventHandler onItemSeen;

        public event EventHandler ItemSeen
        {
            add { onItemSeen += value; }
            remove { onItemSeen -= value; }
        }

        private void RaiseItemSeen()
        {
            if (onItemSeen != null)
                onItemSeen(this, EventArgs.Empty);
        }

    }
}

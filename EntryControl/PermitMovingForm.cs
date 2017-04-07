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
    public partial class PermitMovingForm : EntryControlForm
    {
        private PermitMovingForm()
            : base()
        {
            InitializeComponent();
        }

        public PermitMovingForm(Database database, PermitMoving moving)
            : base(database)
        {
            InitializeComponent();

            PermitMoving = moving;
        }

        private PermitMoving permitMoving;

        public PermitMoving PermitMoving
        {
            get { return permitMoving; }
            set
            {
                permitMoving = value;
                AddBindings();
            }
        }

        private void AddBindings()
        {
            lblMoving.Text = PermitMoving.Moving.ToString();

            switch (PermitMoving.Moving.Id)
            {
                case 2:
                    lblMoving.ForeColor = Color.Green;
                    break;

                case 3:
                    lblMoving.ForeColor = Color.Red;
                    break;
            }

            lblVehicle.Text = PermitMoving.Permit.Vehicle.ToString();

            pickMovingDate.DataBindings.Add("Value", PermitMoving, "MovingTime");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PermitMoving.Save(Database);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;

namespace EntryControl
{
    public partial class PermitControl : UserControl
    {
        public Permit Permit { get; private set; }

        public PermitControl(Permit permit)
        {
            InitializeComponent();

            Permit = permit;
        }

        private void PermitControl_Load(object sender, EventArgs e)
        {
            lblVehicle.Text = Permit.Vehicle.ToString();
            lblFullNumber.Text = Permit.FullNumber.ToString();
            lblActivePeriod.Text = Permit.ActivePeriod;
            lblDriverInfo.Text = Permit.DriverName;
            lblCargo.Text = Permit.Cargo.ToString();
        }

       
        private void lblDriverInfo_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void lblVehicle_MouseMove(object sender, MouseEventArgs e)
        {
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void PermitControl_MouseDown(object sender, MouseEventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.LightGreen;
        }

        private void tableLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            tableLayoutPanel1.BackColor = SystemColors.Control;
        }
    }
}

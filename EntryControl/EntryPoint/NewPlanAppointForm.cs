using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EntryControl
{
    public partial class NewPlanAppointForm : Form
    {
        public NewPlanAppointForm()
        {
            InitializeComponent();
            pictureBox.Image = EntryControl.Resources.Images.YellowLight;
        }

        private void NewPlanAppointForm_Load(object sender, EventArgs e)
        {
        }
    }
}

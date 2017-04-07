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
    public partial class EntryPointControl : UserControl
    {
        private EntryPoint entryPoint;

        private EntryPointControl()
        {
            InitializeComponent();

            changeStaffTool.Image = EntryControl.Resources.Images.Replace;
        }

        public EntryPointControl(EntryPoint point, Database connection, Dictionary<int, Staff> staffDictionary)
            : this()
        {
            entryPoint = point;

            labelPointName.Text = entryPoint.Name;

            lboxStaff.DataSource = entryPoint.GetStaffList(connection, staffDictionary);
        }
    }
}

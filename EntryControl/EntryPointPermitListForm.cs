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
    public partial class EntryPointPermitListForm : EntryControlForm
    {
        private EntryPointPermitListForm()
        {
            InitializeComponent();
        }

        public EntryPointPermitListForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public List<Permit> PermitList
        {
            set { AddControls(value); }
        }

        private void AddControls(List<Permit> permitList)
        {
            foreach (Permit permit in permitList)
            {
                PermitControl control = new PermitControl(permit);
                Controls.Add(control);
                control.Dock = DockStyle.Top;
            }
        }
    }
}

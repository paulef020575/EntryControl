using EntryControl.Classes;
using EntryControl.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EntryControl
{
    public partial class MaterialDocumentForm : Form, IEntityForm
    {
        public MaterialDocumentForm()
        {
            InitializeComponent();
            MaterialPermit = new MaterialPermit();
            ImplementMemberControls(Controls);
        }

        public BindingSource EntitySource => bsItem;

        public MaterialPermit MaterialPermit
        {
            get { return bsItem.DataSource as MaterialPermit; }
            set { bsItem.DataSource = value; }
        }

        private void ImplementMemberControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                IMemberControl memberControl = control as IMemberControl;
                if (memberControl != null)
                    memberControl.ImplementMember(typeof(MaterialPermit));

                ImplementMemberControls(control.Controls);
            }
        }

 
        private void MaterialDocumentForm_Load(object sender, EventArgs e)
        {

        }
    }
}

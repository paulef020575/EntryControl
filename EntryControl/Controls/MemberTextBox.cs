using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EntryControl.Controls
{
    public class MemberTextBox : TextBox, IMemberControl
    {
        public string MemberName { get; set; }

        public void ImplementMember(Type type)
        {
            IEntityForm form = GetParentForm(this) as IEntityForm;

            if (form != null)
                DataBindings.Add(new Binding("Text", form.EntitySource, MemberName, true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private Form GetParentForm(Control control)
        {
            Control parentControl = control.Parent;
            Form form = parentControl as Form;

            while (form == null)
            {
                parentControl = parentControl.Parent;
                form = parentControl as Form;
            }

            return form;
        }
    }
}

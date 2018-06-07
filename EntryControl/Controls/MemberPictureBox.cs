using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EntryControl.Controls
{
    public class MemberPictureBox : PictureBox, IMemberControl
    {

        public MemberPictureBox()
            : base()
        {
            base.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public string MemberName { get; set; }
        
        public void ImplementMember(Type type)
        {
            IEntityForm form = GetParentForm() as IEntityForm;

            if (form != null)
                DataBindings.Add(new Binding("Image", form.EntitySource, MemberName, true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private Form GetParentForm()
        {
            Control parentControl = Parent;
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

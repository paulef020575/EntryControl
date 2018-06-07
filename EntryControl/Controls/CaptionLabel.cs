using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using EntryControl.Classes;

namespace EntryControl.Controls
{
    public partial class CaptionLabel : Label, IMemberControl
    {
        public CaptionLabel()
            : base()
        {
        }

        public string MemberName { get; set; }

        public void ImplementMember(Type entityType)
        {
            PropertyInfo propertyInfo = entityType.GetProperty(MemberName);
            
            if (propertyInfo != null)
            {
                object[] attributes = propertyInfo.GetCustomAttributes(typeof(CaptionAttribute), false);
                if (attributes.Length > 0)
                    Text = ((CaptionAttribute)attributes[0]).Text;
            }
        }

        private Form GetParentForm(CaptionLabel control)
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

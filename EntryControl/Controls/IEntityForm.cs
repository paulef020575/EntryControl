using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EntryControl.Controls
{
    interface IEntityForm
    {
        BindingSource EntitySource { get; }
    }
}

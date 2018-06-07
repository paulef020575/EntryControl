using System;
using System.Collections.Generic;
using System.Text;

namespace EntryControl.Controls
{
    public interface IMemberControl
    {
        string MemberName { get; set; }
        void ImplementMember(Type type);
    }
}

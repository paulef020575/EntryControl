using System;
using System.Collections.Generic;
using System.Text;

namespace EntryControl.Classes
{
    public class ItemEventArgs : EventArgs
    {
        public object Item { get; private set; }

        private ItemEventArgs() : base() { }

        public ItemEventArgs(object item)
            : this()
        {
            Item = item;
        }
    }
}

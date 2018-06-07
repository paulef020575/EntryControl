using System;
using System.Collections.Generic;
using System.Text;

namespace EntryControl.Classes
{
    public class CaptionAttribute : Attribute
    {
        public string Text { get; private set; }

        public CaptionAttribute(string text)
        {
            Text = text;
        }
    }
}

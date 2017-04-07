using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EntryControl
{
    interface ITimeredControl
    {
        Timer Timer { get; }

        void StopTimer();
    }
}

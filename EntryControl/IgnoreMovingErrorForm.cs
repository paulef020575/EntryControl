using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;

namespace EntryControl
{
    public partial class IgnoreMovingErrorForm : Form
    {
        private IgnoreMovingErrorForm()
        {
            InitializeComponent();
        }

        public IgnoreMovingErrorForm(PermitMoving moving)
        {
            InitializeComponent();
            lblIgnoreText.Text = moving.AskToIgnore();
        }
    }
}

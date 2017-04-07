using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EntryControl.Classes;
using EntryControl.Properties;
using System.Configuration;

namespace EntryControl
{
    public partial class EntryControlForm : Form
    {
        protected EntryControlDatabase Database;

        protected EntryControlForm()
        {
            InitializeComponent();
        }

        public EntryControlForm(Database database)
        {
            InitializeComponent();

            Database = (EntryControlDatabase)database;
        }
    }
}

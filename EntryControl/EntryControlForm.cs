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

        protected void WrapAction(Database param, Action<Database> action)
        {
            bool exit = false;

            while (!exit)
            {
                try
                {
                    action(param);
                    exit = true;
                }
                catch (Exception exc)
                {
                    ExceptionForm form = new EntryControl.ExceptionForm(exc);
                    exit = (form.ShowDialog() == DialogResult.Cancel);
                }
            }
        }

        protected void WrapAction(Delegate action)
        {
            bool exit = false;

            while (!exit)
            {
                try
                {
                    action.DynamicInvoke();
                    exit = true;
                }
                catch (Exception exc)
                {
                    ExceptionForm form = new EntryControl.ExceptionForm(exc);
                    exit = (form.ShowDialog() == DialogResult.Cancel);
                }
            }
        }
    }
}

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


namespace EntryControl
{
    public partial class EntryPointForm : EntryControlForm
    {
        private EntryPointForm()
            : base()
        {
            InitializeComponent();
        }

        public EntryPointForm(Database database)
            : base(database)
        {
            InitializeComponent();

            EntryPoint = EntryPoint.Load(Database, Settings.Default.EntryPoint);
        }

        private EntryPoint entryPoint;

        public EntryPoint EntryPoint
        {
            get { return entryPoint; }
            set
            {
                entryPoint = value;
                lblEntryPoint.Text = EntryPoint.ToString();
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            SelectEntryPoint();
        }

        private void SelectEntryPoint()
        {
            EntryPointListForm form = new EntryPointListForm(Database);
            form.SelectedItem = EntryPoint;
            form.ItemSelected += new EventHandler(entryPointSelected);
            form.Show();
        }

        void entryPointSelected(object sender, EventArgs e)
        {
            EntryPoint = (EntryPoint)sender;
            SetDefaultEntryPoint();
        }

        private void SetDefaultEntryPoint()
        {
            Settings.Default.EntryPoint = EntryPoint.Id;
            Settings.Default.Save();
        }

        private void tboxPermit_TextChanged(object sender, EventArgs e)
        {
            if (tboxPermit.Text.Length == 13)
                CreatePermitMoving(tboxPermit.Text);
        }

        private void CreatePermitMoving(string fullNumber)
        {
            long n;
            if (!long.TryParse(fullNumber, out n))
            {
                tboxPermit.ForeColor = Color.Red;
                return;
            }
            else
            {
                tboxPermit.ForeColor = SystemColors.WindowText;
            }


            try
            {
                
                Permit permit = Permit.LoadByNumber(Database, fullNumber);

                if (!permit.CheckClosed(Database))
                {
                    if (permit.CheckPeriod())
                    {
                        if (permit.CheckEntryPoint(EntryPoint))
                        {
                            EntryPointPermitForm form = new EntryPointPermitForm(Database);
                            form.EntryPoint = EntryPoint;
                            form.Permit = permit;
                            form.Show();
                            tboxPermit.Clear();
                        }
                        else
                        {
                            string message = EntryControl.Resources.Doc.Permit.WrongEntryPoint;
                            message = message.Replace("@EntryPoint", permit.EntryPoint.ToString());
                            MessageBox.Show(message, permit.FullNumber.ToString());
                            tboxPermit.Clear();
                        }
                    }
                    else
                    {
                        string periodMessage = EntryControl.Resources.Doc.Permit.WrongPeriod;
                        periodMessage = periodMessage.Replace("@dateFrom", permit.DateFrom.ToShortDateString());
                        periodMessage = periodMessage.Replace("@dateTo", permit.DateTo.ToShortDateString());
                        MessageBox.Show(periodMessage);
                        tboxPermit.Clear();
                    }
                }
                else
                {
                    MessageBox.Show(EntryControl.Resources.Message.Error.PermitIsClosed);
                    tboxPermit.Clear();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, fullNumber);
            }
        }

        private void btnFindVehicle_Click(object sender, EventArgs e)
        {
            FindPermitForVehicle(tboxVehicle.Text);
        }

        private void FindPermitForVehicle(string p)
        {
            List<Permit> permitList = Permit.LoadForVehicle(Database, p);
            if (permitList.Count > 1)
            {
                EntryPointPermitListForm form = new EntryPointPermitListForm(Database);
                form.PermitList = permitList;
                form.Show();
            }
        }
        
    }
}

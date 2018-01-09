using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryControl.Properties;
using EPV.Database;
using EntryControl.Classes;

namespace EntryControl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Получение имени компьютера.
            String host = System.Net.Dns.GetHostName();
            // Получение ip-адреса.
            System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[0];

            if (ip.ToString().StartsWith("192.168.10."))
                cboxServer.SelectedIndex = 1;
            else
                cboxServer.SelectedIndex = 0;

#if DEBUG
            cboxServer.SelectedIndex = 2;
#endif
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.ServerName = cboxServer.Text;
            if (cboxServer.SelectedIndex == 2)
                Settings.Default.Path = @"c:\Prog\dispatcher\DISPATCHER.FDB";
            else
                Settings.Default.Path = @"c:\DB_Pulp\Dispatcher.fdb";
            Settings.Default.Save();

            if (chkForever.Checked)
                SaveSettings();

            if (ShowNextForm())
                Hide();
            else
                Close();

        }

        private bool ShowNextForm()
        {
            EntryControlDatabase database = Program.ShowAuthorizationForm();

            if (database == null)
            {
                return false;
            }

            int result = GetResult();
            if (database.ConnectedUser.CheckRole(database, result))
            {
                switch (result)
                {
                    case 1:
                        ShowCustomerForm(database);
                        break;

                    case 2:
                        ShowReceptionForm(database);
                        break;

                    case 3:
                        ShowEntryPointForm(database);
                        break;

                    case 4:
                        ShowSystemSecurityForm(database);
                        break;
                }
                return true;
            }
            else
            {
                Program.MessageWrongUserRole();
                return false;
            }
            
        }

        private void ShowSystemSecurityForm(Database database)
        {
            SystemSecurityForm form = new SystemSecurityForm(database);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
        }


        private void ShowCustomerForm(Database database)
        {
            CustomerForm form = new CustomerForm(database);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void ShowReceptionForm(Database database)
        {
            ReceptionForm form = new ReceptionForm(database);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
        }

        private void ShowEntryPointForm(Database database)
        {
            EntryPointForm form = new EntryPointForm(database);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
        }

        private void SaveSettings()
        {
            Settings.Default.StartForm = GetResult();
            Settings.Default.Save();
        }

        private int GetResult()
        {
            if (rbuttonCustomer.Checked) return 1;
            if (rbuttonReception.Checked) return 2;
            if (rbuttonCentralPoint.Checked) return 3;
            if (rbuttonSystemSecurity.Checked) return 4;

            return 0;
        }

        private Database ShowAuthorizationForm()
        {
            using (AuthorizationForm form = new AuthorizationForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    return form.database;
            }

            Application.Exit();
            return null;
        }
    }
}

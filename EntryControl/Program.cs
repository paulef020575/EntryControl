using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EntryControl.Properties;
using EPV.Database;
using EntryControl.Classes;
using Stimulsoft.Report;
using EntryControl.Migrations;

namespace EntryControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StiConfig.Services.Add(new Stimulsoft.Report.Dictionary.StiFirebirdAdapterService());
            StiConfig.Services.Add(new Stimulsoft.Report.Dictionary.StiFirebirdDatabase());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(SelectForm());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private static Form SelectForm()
        {
#if DEBUG
            Settings.Default.StartForm = 0;
            Settings.Default.Save();
#endif
            if (Settings.Default.StartForm == 0)
                return new MainForm();

            EntryControlDatabase database = ShowAuthorizationForm();
            if (database == null)
                Environment.Exit(1);

            if (Settings.Default.StartForm == 0
                || database.ConnectedUser.CheckRole(database, Settings.Default.StartForm))
            {
                switch (Settings.Default.StartForm)
                {
                    case 1:
                        return new CustomerForm(database);

                    case 2:
                        return new ReceptionForm(database);

                    case 3:
                        return new EntryPointForm(database);

                    case 4:
                        return new SystemSecurityForm(database);

                    default:
                        return new MainForm();
                }
            }
            else
            {
                MessageWrongUserRole();
                Environment.Exit(1);
            }




            return null;
        }

        public static void MessageWrongUserRole()
        {
            MessageBox.Show(EntryControl.Resources.Message.Error.WrongUserRole);
        }

        public static EntryControlDatabase ShowAuthorizationForm()
        {
            using (AuthorizationForm form = new AuthorizationForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    return form.database;


                return null;
            }
        }

        private static string migratorLog = string.Empty;

        private static void MigratorLog(string s)
        {
            MessageBox.Show(s);
        }

    }
}

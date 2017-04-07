using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;
using EntryControl.Properties;

namespace EntryControl
{
    public partial class AuthorizationForm : Form
    {
        private EntryControlDatabase database;

        public AuthorizationForm()
        {
            InitializeComponent();

        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            database = new EntryControlDatabase(Settings.Default.ServerName, Settings.Default.Path);
            if (!CheckDomainUser())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                cboxUser.DataSource = LoadUserList();
            }
        }

        private List<User> LoadUserList()
        {
            return User.LoadList(database);
        }

        private bool CheckDomainUser()
        {
            User user = User.GetDomainUser(database, Environment.UserDomainName, Environment.UserName);

            if (user != null)
                database.ConnectedUser = user;

            return true;
        }
    }
}

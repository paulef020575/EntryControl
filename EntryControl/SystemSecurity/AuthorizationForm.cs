using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;
using EntryControl.Properties;
using System.Security.Cryptography;

namespace EntryControl
{
    public partial class AuthorizationForm : Form
    {
        public EntryControlDatabase database;

        private User SelectedUser
        {
            get { return (User)cboxUser.SelectedItem; }
        }

        public AuthorizationForm()
        {
            InitializeComponent();

        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            try
            {
                database = new EntryControlDatabase(Settings.Default.ServerName.ToLower(), Settings.Default.Path.ToLower());


                if (CheckDomainUser())
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    cboxUser.DataSource = LoadUserList();
                    GetLastUser();
                }
            }
            catch (Exception exc)
            {
                Settings.Default.StartForm = 0;
                Settings.Default.Save();
                MessageBox.Show(exc.Message, "ОШИБКА СОЕДИНЕНИЯ");
                Environment.Exit(1);
            }
        }

        private void GetLastUser()
        {
            User lastUser = new User(Settings.Default.LastUser, "LastUser");
            if (cboxUser.DataSource != null)
            {
                cboxUser.SelectedItem = lastUser;
                tboxPassword.Select();
            }
        }

        private List<User> LoadUserList()
        {
            return User.LoadList(database);
        }

        private bool CheckDomainUser()
        {
            User user = User.GetDomainUser(database, Environment.UserDomainName.ToLower(), Environment.UserName.ToLower());

            if (user != null)
            {
                database.ConnectedUser = user;

                return true;
            }

            return false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (SelectedUser.CheckPassword(database, MD5Hash(tboxPassword.Text)))
            {
                SetLastUser();
                database.ConnectedUser = SelectedUser;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageWrongPassword();
            }
        }

        private void SetLastUser()
        {
            Settings.Default.LastUser = SelectedUser.Id;
            Settings.Default.Save();
        }

        private void MessageWrongPassword()
        {
            MessageBox.Show(EntryControl.Resources.Message.Error.WrongPassword, SelectedUser.ToString());
            tboxPassword.SelectAll();
            tboxPassword.Select();

        }

        static string MD5Hash(string instr)
        {
            string strHash = string.Empty;

            foreach (byte b in new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(instr)))
            {
                strHash += b.ToString("X2");
            }
            return strHash;
        }

    }
}

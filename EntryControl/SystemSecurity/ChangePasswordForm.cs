using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EntryControl.Classes;
using System.Security.Cryptography;

namespace EntryControl
{
    public partial class ChangePasswordForm : EntryControlForm
    {
        public User CurrentUser { private get; set; }

        private bool IsConnectedUser { get { return CurrentUser.Equals(Database.ConnectedUser); } }

        private ChangePasswordForm()
            : base()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(Database database)
            : base(database)
        {
            InitializeComponent();
            CurrentUser = ((EntryControlDatabase)database).ConnectedUser;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            ShowCurrentControls();

        }

        private void ShowCurrentControls()
        {
            label1.Visible = IsConnectedUser;
            tboxCurrentPassword.Visible = IsConnectedUser;

            Text = "Смена пароля: " + CurrentUser.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!IsConnectedUser 
                || CurrentUser.CheckPassword(Database, MD5Hash(tboxCurrentPassword.Text)))
            {
                if (tboxNewPassword.Text == tboxConfirmPassword.Text)
                {
                    CurrentUser.SetPassword(Database, MD5Hash(tboxNewPassword.Text));
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(EntryControl.Resources.Message.Error.WrongPasswordConfirm);
                    tboxNewPassword.Clear();
                    tboxConfirmPassword.Clear();
                    tboxNewPassword.Select();
                }
            }
            else
            {
                MessageBox.Show(EntryControl.Resources.Message.Error.WrongPassword);
                tboxCurrentPassword.Select();
            }

        }

        internal static string MD5Hash(string instr)
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

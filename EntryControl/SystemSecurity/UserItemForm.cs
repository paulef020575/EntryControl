using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EntryControl.Classes;

namespace EntryControl
{
    public partial class UserItemForm : DataItemForm
    {
        public User User
        {
            get { return (User)Item; }
            set { Item = value; }
        }

        public UserItemForm(Database database, User user)
            : base(database)
        {
            InitializeComponent();
            Item = user;
        }

        private UserItemForm(Database database)
            : this(database, new User())
        { }

        protected override void CreateDataBindings()
        {
            base.CreateDataBindings();

            tboxLastname.DataBindings.Add("Text", bsDataItem, "Lastname", false, DataSourceUpdateMode.OnPropertyChanged);
            tboxFirstname.DataBindings.Add("Text", bsDataItem, "Firstname", false, DataSourceUpdateMode.OnPropertyChanged);
            tboxSecondname.DataBindings.Add("Text", bsDataItem, "Secondname", false, DataSourceUpdateMode.OnPropertyChanged);

            chkLocked.DataBindings.Add("Checked", bsDataItem, "IsLocked", false, DataSourceUpdateMode.OnPropertyChanged);

            chkIsDomain.DataBindings.Add("Checked", bsDataItem, "IsDomainUser", false, DataSourceUpdateMode.OnPropertyChanged);
            tboxDomainName.DataBindings.Add("Text", bsDataItem, "DomainName", false, DataSourceUpdateMode.OnPropertyChanged);
            tboxUserName.DataBindings.Add("Text", bsDataItem, "UserName", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void tboxLastname_Validated(object sender, EventArgs e)
        {
            if (User.Lastname.Trim().Length == 0)
                errorProvider.SetError(tboxLastname, EntryControl.Resources.Message.Error.CannotBeEmpty);
            else
                errorProvider.SetError(tboxLastname, "");
        }

        private void tboxPassword_Validated(object sender, EventArgs e)
        {
            if (tboxPassword.Text.Trim().Length == 0)
                errorProvider.SetError(tboxPassword, EntryControl.Resources.Message.Error.CannotBeEmpty);
            else
                errorProvider.SetError(tboxPassword, "");
        }

        private void tboxRepeatPassword_Validated(object sender, EventArgs e)
        {
            if (tboxPassword.Text != tboxRepeatPassword.Text)
                errorProvider.SetError(tboxRepeatPassword, EntryControl.Resources.Message.Error.PasswordNotEqual);
            else
                errorProvider.SetError(tboxRepeatPassword, "");

        }

        protected override bool SaveItem()
        {
            bool canSave = true;

            if (User.Lastname.Trim().Length == 0)
            {
                errorProvider.SetError(tboxLastname, EntryControl.Resources.Message.Error.CannotBeEmpty);
                canSave = false;
            }

            if (tboxPassword.Text.Trim().Length == 0)
            {
                errorProvider.SetError(tboxPassword, EntryControl.Resources.Message.Error.CannotBeEmpty);
                canSave = false;
            }

            if (tboxPassword.Text != tboxRepeatPassword.Text)
            {
                errorProvider.SetError(tboxRepeatPassword, EntryControl.Resources.Message.Error.PasswordNotEqual);
                canSave = false;
            }

            if (canSave)
            {
                base.SaveItem();
                User.SetPassword(Database, ChangePasswordForm.MD5Hash(tboxPassword.Text));
            }

            return canSave;
        }
    }
}

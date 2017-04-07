using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EntryControl.Properties;
using EntryControl.Classes;

namespace EntryControl
{
    public partial class SystemSecurityForm : EntryControlForm
    {
        List<Binding> editBindingList;

        public BindingList<User> UserList
        {
            get { return (BindingList<User>)bsUserList.DataSource; }
            set { bsUserList.DataSource = value; }
        }

        public User SelectedUser
        {
            get { return (User)bsUserList.Current; }
            set { bsUserList.Position = bsUserList.IndexOf(value); }
        }

        public User CurrentUser
        {
            get { return (User)bsUserItem.DataSource; }
            set { bsUserItem.DataSource = value; }
        }

        public bool EditMode { get { return itemPanel.Enabled; } }

        public bool CanEdit { get { return (!EditMode && (SelectedUser != null)); } }

        private SystemSecurityForm()
            : base()
        {
            InitializeComponent();
        }

        public SystemSecurityForm(Database database)
            : base(database)
        {
            InitializeComponent();
            dgvRoleList.AutoGenerateColumns = false;
            Text = Environment.UserDomainName + " # " + Environment.UserName;

        }

        private void Autorizate()
        {
            AuthorizationForm form = new AuthorizationForm();
            if (form.ShowDialog() != DialogResult.OK)
                Environment.Exit(0);
        }

        private void AddBindings()
        {
            tboxLastname.DataBindings.Add("Text", bsUserItem, "Lastname", true,
                                            DataSourceUpdateMode.OnPropertyChanged);
            tboxFirstname.DataBindings.Add("Text", bsUserItem, "Firstname", true,
                                            DataSourceUpdateMode.OnPropertyChanged);
            tboxSecondname.DataBindings.Add("Text", bsUserItem, "Secondname", true,
                                            DataSourceUpdateMode.OnPropertyChanged);
            chkLocked.DataBindings.Add("Checked", bsUserItem, "IsLocked", true,
                                            DataSourceUpdateMode.OnPropertyChanged);

            chkIsDomain.DataBindings.Add("Checked", bsUserItem, "IsDomainUser", false, 
                                            DataSourceUpdateMode.OnPropertyChanged);
            tboxDomainName.DataBindings.Add("Text", bsUserItem, "DomainName", true,
                                            DataSourceUpdateMode.OnPropertyChanged);
            tboxUserName.DataBindings.Add("Text", bsUserItem, "UserName", true,
                                            DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SystemSecurityForm_Load(object sender, EventArgs e)
        {
            RefreshList();
            AddBindings();
        }

        private void RefreshList()
        {
            User user1 = SelectedUser;

            UserList = new BindingList<User>(User.LoadList(Database));
            if (user1 != null)
                SetSelected(user1);
        }

        private void SetSelected(User user)
        {
            bsUserList.Position = bsUserList.IndexOf(user);
        }

        private void bsUserList_CurrentChanged(object sender, EventArgs e)
        {
            CheckItemState();
            CurrentUser = SelectedUser.LoadCopy(Database);
        }

        private void CheckItemState()
        {
            if (CurrentUser != null && CurrentUser.IsModified
                && MessageBox.Show(EntryControl.Resources.Message.Question.ItemIsModified,
                                    CurrentUser.ToString(), MessageBoxButtons.YesNo) == DialogResult.Yes)
                CurrentUser.Save(Database);

            SetEditModeOff();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentUser.Save(Database);
            SetEditModeOff();
            RefreshList();
        }

        private void lboxUserList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (UserList != null && e.Index >= 0 && e.Index < UserList.Count)
            {

                Brush myBrash = new SolidBrush(SystemColors.WindowText);

                if ((e.State & DrawItemState.Selected) > 0)
                    myBrash = new SolidBrush(Color.White);

                if (UserList[e.Index].IsLocked)
                    myBrash = new SolidBrush(Color.LightGray);
                                
                e.Graphics.DrawString(UserList[e.Index].ToString(), e.Font, myBrash, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void bsUserItem_DataSourceChanged(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                CurrentUser.LoadDomainInfo(Database);
                dgvRoleList.DataSource = CurrentUser.GetRoleList(Database);
            }
        }

        private void tbtnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedUser != null)
                DeleteUser(SelectedUser);
        }

        private void DeleteUser(User user)
        {
            if (MessageBox.Show(EntryControl.Resources.Message.Question.Delete, SelectedUser.ToString(), MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
            {
                user.Delete();
                user.Save(Database);
                bsUserList.Remove(user);
            }
        }

        private void tbtnEdit_Click(object sender, EventArgs e)
        {
            SetEditModeOn();
        }

        private void SetEditModeOn()
        {
            itemPanel.Enabled = true;
            AddEditBindings();
        }

        private void AddEditBindings()
        {
            if (editBindingList == null)
                editBindingList = new List<Binding>();

            editBindingList.Add(tboxDomainName.DataBindings.Add("Enabled", bsUserItem, "IsDomainUser"));
            editBindingList.Add(tboxUserName.DataBindings.Add("Enabled", bsUserItem, "IsDomainUser"));

            editBindingList.Add(btnSave.DataBindings.Add("Enabled", bsUserItem, "IsModified"));
            editBindingList.Add(btnReset.DataBindings.Add("Enabled", bsUserItem, "IsModified"));
        }

        private void SetEditModeOff()
        {
            itemPanel.Enabled = false;
            ClearEditBindings();
        }

        private void ClearEditBindings()
        {
            if (editBindingList != null)
            {
                foreach (Binding binding in editBindingList)
                    binding.Control.DataBindings.Remove(binding);
                editBindingList.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetEditModeOff();
            CurrentUser = SelectedUser.LoadCopy(Database);
        }

        private void dgvRoleList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (CurrentUser != null)
                CurrentUser.MarkAsModified();
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        private void AddNewUser()
        {
            CurrentUser = new User();
            SetEditModeOn();
        }

        private void tbtnPassword_Click(object sender, EventArgs e)
        {
            CheckItemState();

            using (ChangePasswordForm form = new ChangePasswordForm(Database))
            {
                form.CurrentUser = CurrentUser;
                form.ShowDialog();
            }
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            if (CurrentUser.IsModified)
                CurrentUser.Save(Database);

            UserCargoForm form = new UserCargoForm(Database);
            form.User = CurrentUser;
            form.Show();
        }

        private void btnMaterialSecurity_Click(object sender, EventArgs e)
        {
            MaterialDocumentSecurityForm form = new MaterialDocumentSecurityForm(Database);
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshList();
        }
    }
}

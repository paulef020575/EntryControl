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
    public partial class SystemSecurityForm : Form
    {
        private Database database;

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

        public SystemSecurityForm()
        {
            InitializeComponent();
            dgvRoleList.AutoGenerateColumns = false;
            Text = Environment.UserDomainName + " # " + Environment.UserName;

            database = new EntryControlDatabase(Settings.Default.ServerName, Settings.Default.Path);

            Autorizate();
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
            User user = SelectedUser;

            UserList = new BindingList<User>(User.LoadList(database));
            if (user != null)
                SetSelected(user);
        }

        private void SetSelected(User user)
        {
            bsUserList.Position = bsUserList.IndexOf(user);
        }

        private void bsUserList_CurrentChanged(object sender, EventArgs e)
        {
            CheckItemState();
            CurrentUser = SelectedUser.LoadCopy(database);
        }

        private void CheckItemState()
        {
            if (CurrentUser != null && CurrentUser.IsModified
                && MessageBox.Show(EntryControl.Resources.Message.Question.ItemIsModified,
                                    CurrentUser.ToString(), MessageBoxButtons.YesNo) == DialogResult.Yes)
                CurrentUser.Save(database);

            SetEditModeOff();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentUser.Save(database);
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
                CurrentUser.LoadDomainInfo(database);
                dgvRoleList.DataSource = CurrentUser.GetRoleList(database);
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
                user.Save(database);
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
            CurrentUser = SelectedUser.LoadCopy(database);
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

    }
}

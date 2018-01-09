using EntryControl.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EntryControl
{
    public partial class EntryPointGroupsForm : EntryControlForm, INotifyPropertyChanged
    {
        private EntryPointGroupsForm()
        {
            InitializeComponent();
        }

        public EntryPointGroupsForm(EntryControlDatabase database)
            : base(database)
        {
            InitializeComponent();
        }

        #region Fields and properties

        private List<EntryPointGroup> modifiedObjects = new List<EntryPointGroup>();

        private List<string> removedObjects = new List<string>();

        public bool IsModified { get { return (modifiedObjects.Count > 0) || (removedObjects.Count > 0); } }

        private Dictionary<string, List<EntryPointGroup>> groupList = new Dictionary<string, List<EntryPointGroup>>();

        #endregion

        #region INotifyPropertyChanged 

        private PropertyChangedEventHandler onPropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (onPropertyChanged != null)
                onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Methods

        private void LoadGroups()
        {
            bsGroups.DataSource = EntryPointGroup.LoadGroupList(Database);
        }

        private void AddNewGroup(string groupName)
        {
            if (bsGroups.Contains(groupName))
                MessageBox.Show("Группа с таким именем уже существует", "Ошибка");
            else
                bsGroups.Add(groupName);

            bsGroups.Position = bsGroups.IndexOf(groupName);
        }

        private List<EntryPointGroup> GetGroupList(string groupName)
        {
            if (groupList.ContainsKey(groupName))
                return groupList[groupName];

            List<EntryPointGroup> list = EntryPointGroup.LoadGroup(Database, groupName);
            foreach (EntryPointGroup item in list)
                item.PropertyChanged += ObjectModified;
            groupList.Add(groupName, list);

            return list;
        }

        private void ObjectModified(object sender, PropertyChangedEventArgs e)
        {
            modifiedObjects.Add((EntryPointGroup)sender);
            OnPropertyChanged("IsModified");
        }

        private void RemoveGroup(string removedGroup)
        {
            removedObjects.Add(removedGroup);
            OnPropertyChanged("IsModified");
        }

        private void Save()
        {
            EntryPointGroup.Save(Database, modifiedObjects);
            modifiedObjects.Clear();

            foreach (string group in removedObjects)
                EntryPointGroup.ClearGroup(Database, group);
            removedObjects.Clear();

            OnPropertyChanged("IsModified");
        }

        #endregion

        private void EntryPointGroupsForm_Load(object sender, EventArgs e)
        {
            LoadGroups();

            btnOk.DataBindings.Add("Enabled", this, "IsModified", false, DataSourceUpdateMode.OnPropertyChanged);
            btnSave.DataBindings.Add("Enabled", this, "IsModified", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AddNewGroup(tboxNewGroup.Text);
            tboxNewGroup.Clear();
        }

        private void dgvGroups_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == ColumnGroupName.Index)
            {
                e.Value = bsGroups[e.RowIndex];
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bsGroups_CurrentChanged(object sender, EventArgs e)
        {
            if (bsGroups.Current != null)
                bsGroupList.DataSource = GetGroupList((string)bsGroups.Current);
            else
                bsGroups.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnDeleteGroup.Index)
            {
                string removedGroup = (string)bsGroups[e.RowIndex];
                bsGroups.Remove(removedGroup);
                RemoveGroup(removedGroup);
            }
        }

        private void EntryPointGroupsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsModified)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Группы проходных", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        Save();
                        e.Cancel = false;
                        break;

                    case DialogResult.No:
                        e.Cancel = false;
                        break;

                    default:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}

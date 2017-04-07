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
    public partial class MaterialDocumentSecurityForm : EntryControlForm
    {
        private List<Unit> UnitList 
        {
            get { return (List<Unit>)bsUnitList.DataSource; }
            set { bsUnitList.DataSource = value; }
        }

        private Unit SelectedUnit { get { return (Unit)bsUnitList.Current; } }

        private List<Button> arrowButtonList;

        private User SelectedNonUser { get { return (User)bsNonUserList.Current; } }

        private User SelectedSignerUser { get { return (User)bsSignerGroup.Current; } }

        private User SelectedCreatorUser { get { return (User)bsCreatorGroup.Current; } }

        private MaterialDocumentSecurityForm()
            : base()
        {
            InitializeComponent();
        }

        public MaterialDocumentSecurityForm(Database database)
            : base(database)
        {
            InitializeComponent();

            ShowArrows();
            addUserTool.Image = EntryControl.Resources.Images.Add;
            lblFindUser.Image = EntryControl.Resources.Images.Find;
        }

        private void ShowArrows()
        {
            arrowButtonList = new List<Button>();

            arrowButtonList.Add(btnToSigner);
            arrowButtonList.Add(btnToCreator);

            arrowButtonList.Add(btnFromSigner);
            arrowButtonList.Add(btnFromCreator);

            foreach (Button button in arrowButtonList)
                ShowArrow(button);
        }

        private void ShowArrow(Button button)
        {
            button.BackgroundImageLayout = ImageLayout.Zoom;

            switch ((string)button.Tag)
            {
                case "Right":
                    button.BackgroundImage = EntryControl.Resources.Images.Right;
                    break;

                case "Left":
                    button.BackgroundImage = EntryControl.Resources.Images.Left;
                    break;

                default:
                    MessageBox.Show(EntryControl.Resources.Message.Error.UnknownControl, button.Name);
                    break;
            }
        }

        private void MaterialDocumentSecurityForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            AddBindings();
        }

        private void AddBindings()
        {
            tboxCode.DataBindings.Add("Text", bsUnitItem, "Code");
            tboxName.DataBindings.Add("Text", bsUnitItem, "Name");

            btnSaveUnit.DataBindings.Add("Enabled", bsUnitItem, "IsModified", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void RefreshData()
        {
            UnitList = Unit.LoadList(Database);
        }

        private void bsUnitList_CurrentChanged(object sender, EventArgs e)
        {
            bsUnitItem.DataSource = SelectedUnit.LoadCopy(Database);

            bsNonUserList.DataSource = SelectedUnit.GetUserList(Database, 0);
            bsCreatorGroup.DataSource = SelectedUnit.GetUserList(Database, EntryControlDatabase.MaterialCreatorGroup);
            bsSignerGroup.DataSource = SelectedUnit.GetUserList(Database, EntryControlDatabase.MaterialSignerGroup);

            tblPanelUser.Visible = true;
        }

        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            Unit unit = (Unit)bsUnitItem.DataSource;

            unit.Save(Database);

            RefreshData();
            bsUnitList.Position = bsUnitList.IndexOf(unit);
        }

        private void arrowButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "btnToSigner":
                    SetUserToSigner(SelectedNonUser);
                    break;

                case "btnFromSigner":
                    ClearUser(SelectedSignerUser);
                    break;

                case "btnToCreator":
                    SetUserToCreator(SelectedNonUser);
                    break;

                case "btnFromCreator":
                    ClearUser(SelectedCreatorUser);
                    break;

                default:
                    MessageBox.Show(EntryControl.Resources.Message.Error.UnknownControl, button.Name);
                    break;
            }
        }

        private void SetUserToCreator(User user)
        {
            try
            {
                SetUserToGroup(user, EntryControlDatabase.MaterialCreatorGroup);

                bsNonUserList.Remove(user);
                bsCreatorGroup.Add(user);
            }
            catch (Exception)
            {
                MessageBox.Show(EntryControl.Resources.Message.Error.CannotMoveUser);
            }
        }

        private void ClearUser(User user)
        {
            try
            {
                SetUserToGroup(user, 0);

                bsNonUserList.Add(user);
                bsSignerGroup.Remove(user);
                bsCreatorGroup.Remove(user);
            }
            catch (Exception)
            {
                MessageBox.Show(EntryControl.Resources.Message.Error.CannotMoveUser);
            }
        }

        private void SetUserToSigner(User user)
        {
            try
            {
                SetUserToGroup(user, EntryControlDatabase.MaterialSignerGroup);

                bsNonUserList.Remove(user);
                bsSignerGroup.Add(user);
            }
            catch (Exception)
            {
                MessageBox.Show(EntryControl.Resources.Message.Error.CannotMoveUser);
            }
        }

        private void SetUserToGroup(User user, int p)
        {
            string query = EntryControl.Resources.Ref.Unit.SetUserUnit;
            QueryParameters parameters = new QueryParameters("unitId", SelectedUnit.Id);
            parameters.Add("userId", user.Id);
            parameters.Add("roleId", p);

            Database.ExecuteQuery(query, parameters);
        }

        private void bsNonUserList_CurrentChanged(object sender, EventArgs e)
        {
            btnToCreator.Enabled = (bsNonUserList.Current != null);
            btnToSigner.Enabled = (bsNonUserList.Current != null);
        }

        private void bsSignerGroup_CurrentChanged(object sender, EventArgs e)
        {
            btnFromSigner.Enabled = (bsSignerGroup.Current != null);
        }

        private void bsCreatorGroup_CurrentChanged(object sender, EventArgs e)
        {
            btnFromCreator.Enabled = (bsCreatorGroup.Current != null);
        }

        private void tboxFindUnit_TextChanged(object sender, EventArgs e)
        {
            if (tboxFindUnit.Text.Length > 0)
            {
                foreach (Unit unit in UnitList)
                {
                    if (unit.ToString().ToUpper().Contains(tboxFindUnit.Text.ToUpper()))
                    {
                        bsUnitList.Position = bsUnitList.IndexOf(unit);
                        tboxFindUnit.ForeColor = SystemColors.WindowText;

                        lboxUnitList.Refresh();
                        return;
                    }
                }
                tboxFindUnit.ForeColor = Color.Red;

                System.Media.SystemSounds.Beep.Play();
                lboxUnitList.Refresh();
            }
        }

        private void lboxUnitList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (UnitList != null)
            {
                e.DrawBackground();

                Brush myBrush = new SolidBrush(e.ForeColor);

                if (tboxFindUnit.Text.Length > 0
                    && UnitList[e.Index].ToString().ToUpper().Contains(tboxFindUnit.Text.ToUpper()))
                    myBrush = new SolidBrush(Color.Red);

                e.Graphics.DrawString(UnitList[e.Index].ToString(), e.Font, myBrush, e.Bounds,
                                        StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void tboxFindUser_TextChanged(object sender, EventArgs e)
        {
            bool isFound = (tboxFindUser.Text.Length == 0);

            if (!isFound)
            {
                isFound = (isFound || FindUserInLBox(lboxNotUser));
                isFound = (isFound || FindUserInLBox(lboxSignerGroup));
                isFound = (isFound || FindUserInLBox(lboxCreatorGroup));
            }

            if (!isFound)
            {
                tboxFindUser.ForeColor = Color.Red;
                System.Media.SystemSounds.Beep.Play();
            }
            else
            {
                tboxFindUser.ForeColor = SystemColors.WindowText;
            }

            lboxNotUser.Refresh();
            lboxCreatorGroup.Refresh();
            lboxSignerGroup.Refresh();
        }


        private bool FindUserInLBox(ListBox lbox)
        {
            BindingSource bs = (BindingSource)lbox.DataSource;
            List<User> userList = (List<User>)bs.DataSource;

            foreach (User user in userList)
            {
                if (user.ToString().ToUpper().Contains(tboxFindUser.Text.ToUpper()))
                {
                    bs.Position = bs.IndexOf(user);
                    return true;
                }
            }

            return false;
        }

        private void userLBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox lbox = (ListBox)sender;
            BindingSource bs = (BindingSource)lbox.DataSource;

            if (bs != null && bs.Count > 0 && e.Index >= 0 && e.Index < bs.Count)
            {
                List<User> userList = (List<User>)bs.DataSource;

                if (userList != null)
                {
                    e.DrawBackground();

                    Brush myBrush = new SolidBrush(e.ForeColor);

                    if (tboxFindUser.Text.Length > 0
                        && userList[e.Index].ToString().ToUpper().Contains(tboxFindUser.Text.ToUpper()))
                        myBrush = new SolidBrush(Color.Red);

                    e.Graphics.DrawString(userList[e.Index].ToString(), e.Font, myBrush, e.Bounds,
                                            StringFormat.GenericDefault);
                    e.DrawFocusRectangle();
                }
            }
        }

        private void addUnitTool_Click(object sender, EventArgs e)
        {
            AddNewUnit();
        }

        private void AddNewUnit()
        {
            bsUnitItem.DataSource = new Unit();

            tblPanelUser.Visible = false;
            tboxCode.Select();
        }

        private void deleteUnitTool_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(EntryControl.Resources.Message.Question.Delete, SelectedUnit.ToString(),
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteUnit(SelectedUnit);
            }
        }

        private void DeleteUnit(Unit unit)
        {
            try
            {
                unit.Delete();
                unit.Save(Database);
                bsUnitList.Remove(unit);
            }
            catch (Exception exc)
            {
                MessageBox.Show(EntryControl.Resources.Message.Error.CannotDelete, unit.ToString());
                unit.ClearModified();
            }

        }

        private void addUserTool_Click(object sender, EventArgs e)
        {
            CreateNewUser();        
        }

        private void CreateNewUser()
        {
            UserItemForm form = new UserItemForm(Database, new User());
            form.ItemSaved += new EventHandler(formUserItemSaved);
            form.Show();
        }

        void formUserItemSaved(object sender, EventArgs e)
        {
            bsNonUserList.DataSource = SelectedUnit.GetUserList(Database, 0);
            bsNonUserList.Position = bsNonUserList.IndexOf((User)sender);
        }
    }
}

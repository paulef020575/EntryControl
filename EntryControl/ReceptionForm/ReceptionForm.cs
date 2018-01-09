using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EntryControl.Classes;
using Stimulsoft.Report;
using System.IO;
using Stimulsoft.Report.Dictionary;
using EntryControl.Properties;

namespace EntryControl
{
    public partial class ReceptionForm : EntryControlForm
    {
        private ReceptionForm()
            : base()
        {
            InitializeComponent();
        }

        private int planAppointPage = 1;

        public int PlanAppointPage
        {
            get { return planAppointPage; }
            set
            {
                planAppointPage = value;

                RefreshPlanAppointList();
            }
        }

        private int permitListPage = 1;
        public int PermitListPage
        {
            get { return permitListPage; }
            set
            {
                permitListPage = value;
                RefreshPermitList();
            }
        }

        
        public ReceptionForm(Database database)
            : base(database)
        {
            InitializeComponent();

            btnChangePassword.Image = EntryControl.Resources.Images.Password;
            printPermitListTool.Image = EntryControl.Resources.Images.Print;
            findLabel.Image = EntryControl.Resources.Images.Find;
            findNextTool.Image = EntryControl.Resources.Images.FindNext;

            btnPreviousPage.Image = EntryControl.Resources.Images.Left;
            btnNextPage.Image = EntryControl.Resources.Images.Right;

            btnPreviousPermitPage.Image = EntryControl.Resources.Images.Left;
            btnNextPermitPage.Image = EntryControl.Resources.Images.Right;

            dgvMoving.AutoGenerateColumns = false;
            dgvPointList.AutoGenerateColumns = false;

            materialPermitTool.Image = EntryControl.Resources.Images.Document;
            rboxEntryPoint.Database = Database;

            InitializeFilterControls();
            //tboxComment.DataBindings.Add("Text", bsPlanAppointList, "Comment", true, DataSourceUpdateMode.OnPropertyChanged);
            //tboxPermitComment.DataBindings.Add("Text", bsPermitList, "Comment", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private int secToUpdate = 0;
        private int startSeconds = 45;
        private DateTime lastPermitModifiedDate = DateTime.MinValue;
        private DateTime lastPlanAppouintModifiedDate = DateTime.MinValue;
        bool isInitialized = false;

        private bool isRefreshing = false;

        public Permit SelectedPermit
        {
            get { return (Permit)bsPermitList.Current; }
            set { bsPermitList.Position = bsPermitList.IndexOf(value); }
        }

        public PlanAppoint SelectedPlanAppoint
        {
            get { return (PlanAppoint)bsPlanAppointList.Current; }
            set { bsPlanAppointList.Position = bsPlanAppointList.IndexOf(value); }
        }

        private struct RefreshParams
        {
            public Database database;
           
            public DateTime dateStart;
            public DateTime dateFinish;
            public EntryPoint entryPoint;
            public EnumerationItem defaultState;

            public int pageNumber;
        }

        private struct RefreshResult
        {
            public int totalPages;

            public object List;
        }

        private void InitializeFilterControls()
        {
            DateTime today = DateTime.Today;

            pickDateStart.Value = new DateTime(today.Year, today.Month, 1);
            pickDateFinish.Value = pickDateStart.Value.AddMonths(1).AddDays(-1);

            rboxEntryPoint.SelectedItem = EntryPoint.Empty;

            Enumeration permitStates = new Enumeration(Database, "permitState");
            List<EnumerationItem> itemList = new List<EnumerationItem>();
            itemList.Add(new EnumerationItem(0, "ВСЕ ПРОПУСКА"));
            foreach (EnumerationItem item in permitStates.Values)
                itemList.Add(item);
            cboxPermitType.DataSource = itemList;

            cboxPermitType.SelectedItem = EntryControlDatabase.OneTimePermitState;

            pickPlanAppointStart.Value = DateTime.Today.AddDays(-7);

            isInitialized = true;
            ForceRefreshData();
        }

        private void rboxEntryPoint_GetList(object sender, ReferenceBox.ReferenceBoxEventArgs e)
        {
            e.ItemList = EntryPoint.LoadList(Database);
        }


        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            secToUpdate--;
            lblToRefresh.Text = secToUpdate.ToString() + " сек.";
            lblToRefresh2.Text = secToUpdate.ToString() + " сек.";

            if (secToUpdate <= 0)
                RefreshData();
        }

        private void RefreshData()
        {
            if (isRefreshing) return;

            isRefreshing = true;
            refreshTimer.Stop();

            lblToRefresh.Text = "обновляем...";
            lblToRefresh2.Text = "обновляем...";

            bgLastUpdateDate.RunWorkerAsync(Database);
            bgLastPlanAppointDate.RunWorkerAsync(Database);
        }

        private void ForceRefreshData()
        {
            if (isRefreshing) return;

            isRefreshing = true;
            refreshTimer.Stop();

            lblToRefresh.Text = "обновляем...";
            lblToRefresh2.Text = "обновляем...";

            RefreshParams parameters = new RefreshParams();
            parameters.database = Database;
            parameters.dateStart = pickDateStart.Value;
            parameters.dateFinish = pickDateFinish.Value;
            parameters.entryPoint = EntryPoint.Empty;
            parameters.defaultState = (EnumerationItem)cboxPermitType.SelectedItem;
            parameters.pageNumber = PermitListPage;

            bgRefreshPermitList.RunWorkerAsync(parameters);

            parameters.pageNumber = planAppointPage;

            bgRefreshPlanAppointList.RunWorkerAsync(parameters);
        }

        private List<Permit> LoadPermitList(Database database, DateTime dateStart, DateTime dateFinish,
                                                EntryPoint entryPoint, EnumerationItem defaultState, int pageNum)
        {
            return Permit.LoadList(database, dateStart, dateFinish, entryPoint, defaultState, pageNum);
        }



        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            //RefreshData();
        }

        private void bgLastUpdateDate_DoWork(object sender, DoWorkEventArgs e)
        {
            Database database = (Database)e.Argument;

            string query = EntryControl.Resources.Doc.Permit.GetLasUpdateDate;
            object result = database.ExecuteScalar(query);
            e.Result = (result == null || DBNull.Value.Equals(result) ? DateTime.MinValue : (DateTime)result);
        }

        private void bgLastUpdateDate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DateTime lastDate = (DateTime)e.Result;

            if (lastDate > lastPermitModifiedDate)
            {
                lastPermitModifiedDate = lastDate;

                RefreshParams parameters = new RefreshParams();
                parameters.database = Database;
                parameters.dateStart = pickDateStart.Value;
                parameters.dateFinish = pickDateFinish.Value;
                parameters.entryPoint = EntryPoint.Empty;
                parameters.defaultState = (EnumerationItem)cboxPermitType.SelectedItem;
                parameters.pageNumber = PermitListPage;

                bgRefreshPermitList.RunWorkerAsync(parameters);


            }
        }

        private void bgRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshParams parameters = (RefreshParams)e.Argument;

            RefreshResult result = new RefreshResult();

            result.totalPages = Permit.GetCount(parameters.database, parameters.dateStart, parameters.dateFinish,
                                        parameters.entryPoint, parameters.defaultState);

            result.List = LoadPermitList(parameters.database, parameters.dateStart,
                                            parameters.dateFinish, parameters.entryPoint, parameters.defaultState,
                                            parameters.pageNumber);

            e.Result = result;
        }

        private void bgRefresh_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RefreshResult result = (RefreshResult)e.Result;

            int totalPages = result.totalPages / 100;
            if (result.totalPages % 100 > 0) totalPages++;

            lblPermitPage.Text = PermitListPage.ToString() + " / " + totalPages.ToString();
            btnPreviousPermitPage.Enabled = (PermitListPage > 1);
            btnNextPermitPage.Enabled = (PermitListPage < totalPages);


            List<Permit> permitList = (List<Permit>)result.List;

            if (permitList != null)
                bsPermitList.DataSource = new BindingList<Permit>(permitList);

        }

        private void StartTimer()
        {
            isRefreshing = false;
            secToUpdate = startSeconds;
            refreshTimer.Start();
        }

        private void bgLastPlanAppointDate_DoWork(object sender, DoWorkEventArgs e)
        {
            Database database = (Database)e.Argument;

            string query = EntryControl.Resources.Doc.PlanAppoint.GetLastDateModified;
            object result = database.ExecuteScalar(query);
            e.Result = (result == null || DBNull.Value.Equals(result) ? DateTime.MinValue : (DateTime)result);

        }

        private void bgLastPlanAppointDate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DateTime lastDate = (DateTime)e.Result;

            if (lastDate > lastPlanAppouintModifiedDate)
            {
                lastPlanAppouintModifiedDate = lastDate;

                RefreshParams args = new RefreshParams();
                args.database = Database;
                args.pageNumber = planAppointPage;
                args.dateStart = pickPlanAppointStart.Value;

                bgRefreshPlanAppointList.RunWorkerAsync(args);
            }
            else
            {
                StartTimer();
            }
        }

        private void bgRefreshPlanAppointList_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshParams args = (RefreshParams)e.Argument;

            Database database = args.database;

            RefreshResult result = new RefreshResult();
            result.totalPages = PlanAppoint.GetNumberWOPermit(database, args.dateStart);
            result.List = PlanAppoint.LoadWoPermit(database, args.dateStart, args.pageNumber);
            e.Result = result;
        }

        private void bgRefreshPlanAppointList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RefreshResult result = (RefreshResult)e.Result;

            int totalPages = result.totalPages / 100;
            if (result.totalPages % 100 > 0) totalPages++;

            lblPageNumber.Text = PlanAppointPage.ToString() + "/" + totalPages.ToString();

            btnPreviousPage.Enabled = (PlanAppointPage > 1);
            btnNextPage.Enabled = (PlanAppointPage < totalPages);

            List<PlanAppoint> appointList = (List<PlanAppoint>)result.List;

            bsPlanAppointList.DataSource = new BindingList<PlanAppoint>(appointList);

            StartTimer();
        }

        private void bsPlanAppointList_DataSourceChanged(object sender, EventArgs e)
        {
            pagePlanAppointList.Text = "Заявки (" + bsPlanAppointList.Count.ToString() + ")";
        }

        private void createPermitTool_Click(object sender, EventArgs e)
        {
            if (SelectedPlanAppoint != null)
                CreatePermitForPlanAppoint(SelectedPlanAppoint);

        }

        private void CreatePermitForPlanAppoint(PlanAppoint planAppoint)
        {
            try
            {
                PermitItemForm form = new PermitItemForm(Database);
                form.PlanAppoint = planAppoint;
                form.ItemSaved += new EventHandler(form_ItemSaved);
                form.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }

        void form_ItemSaved(object sender, EventArgs e)
        {
            ForceRefreshData();
        }

        private void lockAppointTool_Click(object sender, EventArgs e)
        {
            if (SelectedPlanAppoint != null)
                LockPlanAppoint(SelectedPlanAppoint);
        }

        private void LockPlanAppoint(PlanAppoint planAppoint)
        {
            if (MessageBox.Show("Отказать в проезде транспорта на территорию?",
                                planAppoint.ToString(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = EntryControl.Resources.Doc.PlanAppoint.SetPermitLocked;
                QueryParameters parameters = new QueryParameters("planAppoint", planAppoint.Id);
                Database.ExecuteQuery(query, parameters);
                RefreshData();
            }
        }

        private void dgvPlanAppointList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PlanAppoint appoint = (PlanAppoint)bsPlanAppointList[e.RowIndex];
                if (appoint.IsLocked)
                {
                    dgvPlanAppointList.Rows[e.RowIndex].DefaultCellStyle.ForeColor
                        = Color.Red;
                    dgvPlanAppointList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor
                        = Color.Red;
                }
            }
        }

        private void dgvPermitList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Permit permit = (Permit)bsPermitList[e.RowIndex];


                switch (permit.PermitState.Id)
                {
                    case 1:
                        dgvPermitList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                        dgvPermitList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Green;
                        break;
                        
                    case 2:
                        dgvPermitList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
                        dgvPermitList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Blue;
                        break;

                    case 3:
                        dgvPermitList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        dgvPermitList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red;
                        break;

                    case 4:
                        dgvPermitList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                        dgvPermitList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Gray;
                        break;
                }

            }
        }

        private void permitTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            CreateEmptyPermit();
        }

        private void CreateEmptyPermit()
        {
            PermitItemForm form = new PermitItemForm(Database);
            form.ItemSaved += form_ItemSaved;
            form.Show();
        }

        private void pickDateStart_ValueChanged(object sender, EventArgs e)
        {
            if (isInitialized) ForceRefreshData();
        }

        private void editPermitTool_Click(object sender, EventArgs e)
        {
            if (SelectedPermit != null)
                EditPermit(SelectedPermit);
        }

        private void EditPermit(Permit permit)
        {
            PermitItemForm form = new PermitItemForm(Database);
            form.Permit = permit.LoadCopy(Database);
            form.ItemSaved += form_ItemSaved;
            form.Show();

        }

        private void addPermitTool_Click(object sender, EventArgs e)
        {
            CreateEmptyPermit();
        }

        private void deletePermitTool_Click(object sender, EventArgs e)
        {
            if (SelectedPermit != null)
            DeletePermit(SelectedPermit);
        }

        private void DeletePermit(Permit permit)
        {
            string message = EntryControl.Resources.Message.Question.Delete;
            if (MessageBox.Show(message, permit.ToString(), MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                bsPermitList.Remove(permit);
                permit.Delete();
                permit.Save(Database);
            }
        }

        private void refreshPermiListTool_Click(object sender, EventArgs e)
        {
            ForceRefreshData();
        }

        private void materialPermitTool_Click(object sender, EventArgs e)
        {
            ShowMaterialPermitList();
        }

        private void ShowMaterialPermitList()
        {
            MaterialPermitListForm form = new MaterialPermitListForm(Database);

            form.Show();
        }

        private void bsPermitList_CurrentChanged(object sender, EventArgs e)
        {
            if (bsPermitList.Current != null)
            {
                Permit permit = (Permit)bsPermitList.Current;
                tboxPermitComment.Text = permit.GetComment(Database);

                dgvMoving.DataSource = permit.GetMovingList(Database);
                dgvPointList.DataSource = permit.GetAllowedPointList(Database);
                //MaterialPermit materialPermit = permit.GetMaterialPermit(Database);

                //if (materialPermit != null)
                //{
                //    lblMaterialPermit.Text = materialPermit.ToString();
                //    dgvPointList.DataSource = materialPermit.GetItemList(Database);
                //    dgvPointList.Visible = true;
                //}
                //else
                //{
                //    lblMaterialPermit.Text = "не привязан";
                //    dgvPointList.DataSource = null;
                //    dgvPointList.Visible = false;
                //}
            }
            else
            {
                tboxPermitComment.Text = "";
                dgvPointList.DataSource = null;
                //lblMaterialPermit.Text = "";
                dgvPointList.DataSource = null;
                //dgvPointList.Visible = false;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(Database);
            form.CurrentUser = Database.ConnectedUser;
            form.ShowDialog();
        }

        private void bsPlanAppointList_CurrentChanged(object sender, EventArgs e)
        {
            if (bsPlanAppointList.Current != null)
            {
                tboxComment.Text = ((PlanAppoint)bsPlanAppointList.Current).GetComment(Database); //.Comment;
            }
            else
            {
                tboxComment.Text = "";
            }
                
        }

        private void printPermitListTool_Click(object sender, EventArgs e)
        {
            printPermitList();
        }

        private void printPermitList()
        {
            StiReport report = new StiReport();
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = Path.Combine(path, "Report");
            string fileName = Path.Combine(path, "PermitList.mrt");

            report.Load(fileName);

            report.Dictionary.Databases.Clear();
            report.Dictionary.Databases.Add(new StiFirebirdDatabase("Woodserver", Database.ConnectionString));
            report.Compile();

            report["dateFrom"] = pickDateStart.Value;
            report["dateTo"] = pickDateFinish.Value;
            report["entryPoint"] = EntryPoint.Empty;  //rboxEntryPoint.SelectedItem.Id;
            report["defaultState"] = ((EnumerationItem)cboxPermitType.SelectedItem).Id;

            report.Show();

        }

        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            if (findTextBox.Text.Length == 0)
            {
                findNextTool.Enabled = false;
                return;
            }

            findNextTool.Enabled = true;

            if (FindTextInPermitList(findTextBox.Text, 0, 0))
            {
                findTextBox.ForeColor = SystemColors.WindowText;
            }
            else
            {
                findTextBox.ForeColor = Color.Red;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private bool FindTextInPermitList(string text, int startRow, int startColumn)
        {
            int startColumnIndex = startColumn;
            int finishColumnIndex = dgvPermitList.Columns.Count;

            for (int i = startRow; i < dgvPermitList.Rows.Count; i++)
            {
                if (i > startRow) startColumnIndex = 0;

                for (int j = startColumnIndex; j < dgvPermitList.Columns.Count; j++)
                {
                    if (dgvPermitList[j, i].Value != null)
                    {
                        string valueText = dgvPermitList[j, i].Value.ToString().ToUpper();

                        if (valueText.Contains(text.ToUpper()))
                        {
                            dgvPermitList.CurrentCell = dgvPermitList[j, i];
                            return true;
                        }
                    }
                }
            }

            for (int i = 0; i <= startRow; i++)
            {
                if (i == startRow) finishColumnIndex = startColumn + 1;

                for (int j = 0; j < finishColumnIndex; j++)
                {
                    if (dgvPermitList[j, i].Value != null)
                    {
                        string valueText = dgvPermitList[j, i].Value.ToString().ToUpper();

                        if (valueText.Contains(text.ToUpper()))
                        {
                            dgvPermitList.CurrentCell = dgvPermitList[j, i];
                            return true;
                        }
                    }
                }
            }

            return false;

        }

        private void findNextTool_Click(object sender, EventArgs e)
        {
            if (findTextBox.Text.Length == 0)
            {
                return;
            }

            if (FindTextInPermitList(findTextBox.Text, 
                                        dgvPermitList.CurrentCell.RowIndex, 
                                        dgvPermitList.CurrentCell.ColumnIndex + 1))
            {
                findTextBox.ForeColor = SystemColors.WindowText;
            }
            else
            {
                findTextBox.ForeColor = Color.Red;
                System.Media.SystemSounds.Beep.Play();
            }
        }


        private void RefreshPlanAppointList()
        {
            RefreshParams args = new RefreshParams();
            args.database = Database;
            args.pageNumber = PlanAppointPage;
            args.dateStart = pickPlanAppointStart.Value;

            bgRefreshPlanAppointList.RunWorkerAsync(args);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            PlanAppointPage--;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            PlanAppointPage++;
        }

        private void RefreshPermitList()
        {
            RefreshParams args = new RefreshParams();
            args.database = Database;
            args.dateStart = pickDateStart.Value;
            args.dateFinish = pickDateFinish.Value;

            args.entryPoint = EntryPoint.Empty; //(EntryPoint)rboxEntryPoint.SelectedItem;
            args.defaultState = (EnumerationItem)cboxPermitType.SelectedItem;

            args.pageNumber = PermitListPage;

            bgRefreshPermitList.RunWorkerAsync(args);
        }

        private void btnPreviousPermitPage_Click(object sender, EventArgs e)
        {
            PermitListPage--;
        }

        private void btnNextPermitPage_Click(object sender, EventArgs e)
        {
            PermitListPage++;
        }

        private void pickPlanAppointStart_ValueChanged(object sender, EventArgs e)
        {
            if (isInitialized)
                RefreshPlanAppointList();
        }

        private void dgvPermitList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedPermit != null)
                EditPermit(SelectedPermit);
        }

        private void pickDateStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && e.Control)
                ClearSettings();
        }

        private void ClearSettings()
        {
            if (MessageBox.Show("Сбросить настройки приложения?", "ВНИМАНИЕ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Settings.Default.StartForm = 0;
                Settings.Default.Save();

                Environment.Exit(0);
            }

        }
    }
}

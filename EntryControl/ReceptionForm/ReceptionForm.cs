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
        #region Constructor

        private ReceptionForm()
            : base()
        {
            InitializeComponent();
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

            materialPermitTool.Image = EntryControl.Resources.Images.Document;

            dgvMoving.AutoGenerateColumns = false;
            dgvPointList.AutoGenerateColumns = false;

            rboxEntryPoint.Database = Database;

            InitializeFilterControls();
            InitializeMdFilterControls();
            //tboxComment.DataBindings.Add("Text", bsPlanAppointList, "Comment", true, DataSourceUpdateMode.OnPropertyChanged);
            //tboxPermitComment.DataBindings.Add("Text", bsPermitList, "Comment", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        #endregion

        #region Properties & fields


        #region PlanAppointPage - страница списка заявок на пропуск

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

        #endregion


        #region PermitListPage - страница списка пропусков

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

        #endregion

        #region MaterialDocumentListPage - страница списка материальных пропусков

        private int materialDocumentListPage = 1;

        public int MaterialDocumentListPage
        {
            get { return materialDocumentListPage; }
            set
            {
                materialDocumentListPage = value;
                RefreshMaterialDocumentList();
            }
        }

         #endregion

        #region Значения для отсчета времени

        private int secToUpdate = 0;
        private int startSeconds = 45;

        #endregion

        #region Даты внесения последних изменений в таблицы


        private DateTime lastPermitModifiedDate = DateTime.MinValue;
        private DateTime lastPlanAppouintModifiedDate = DateTime.MinValue;
        private DateTime lastMaterialDocumentModifiedDate = DateTime.MinValue;

        #endregion

        /// <summary>
        ///     признак "Контролы инициализированы"
        /// </summary>
        bool isInitialized = false;

        /// <summary>
        ///     признак "Выполняется обновление"
        /// </summary>
        private bool isRefreshing = false;


        #region Выбранные в списках документы

        /// <summary>
        ///     Пропуск
        /// </summary>
        public Permit SelectedPermit
        {
            get { return (Permit)bsPermitList.Current; }
            set { bsPermitList.Position = bsPermitList.IndexOf(value); }
        }

        /// <summary>
        ///     Заявка на пропуск
        /// </summary>
        public PlanAppoint SelectedPlanAppoint
        {
            get { return (PlanAppoint)bsPlanAppointList.Current; }
            set { bsPlanAppointList.Position = bsPlanAppointList.IndexOf(value); }
        }

        /// <summary>
        ///     Материальный пропуск
        /// </summary>
        public MaterialPermit SelectedMaterialDocument
        {
            get { return bsMaterialDocumentList.Current as MaterialPermit; }
            set { bsMaterialDocumentList.Position = bsMaterialDocumentList.IndexOf(value); }
        }

        #endregion

        BackgroundWorker temporaryBgWorker;
        Timer temporaryTimer;

        #endregion

        #region Структуры для выполнения фоновых задач

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

        #endregion

        #region Методы

        /// <summary>
        ///     инициализирует элементы управления фильтром
        /// </summary>
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

        private void InitializeMdFilterControls()
        {
            if (pnlMaterialPermitFilter.Controls.Count == 0)
                pnlMaterialPermitFilter.Height = 0;
        }



        /// <summary>
        ///     запускает обновление данных при наличии изменений в таблицах
        /// </summary>
        private void RefreshData()
        {
            if (isRefreshing) return;

            isRefreshing = true;
            refreshTimer.Stop();

            string refreshingText = "обновляем...";
            lblToRefresh.Text = refreshingText;
            lblToRefresh2.Text = refreshingText;
            lblToRefresh3.Text = refreshingText;

            bgLastUpdateDate.RunWorkerAsync(Database);
            bgLastPlanAppointDate.RunWorkerAsync(Database);
            bgLastMaterialDocumentDate.RunWorkerAsync(Database);
        }

        /// <summary>
        ///     обновляет список заявок на пропуск
        /// </summary>
        private void RefreshPlanAppointList()
        {
            RefreshParams args = new RefreshParams();
            args.database = Database;
            args.pageNumber = PlanAppointPage;
            args.dateStart = pickPlanAppointStart.Value;

            bgRefreshPlanAppointList.RunWorkerAsync(args);
        }

        /// <summary>
        ///     обновляет список пропусков
        /// </summary>
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

        private void RefreshMaterialDocumentList()
        {
            throw new NotImplementedException();
        }



        /// <summary>
        ///     принудительно обновляет данные
        /// </summary>
        private void ForceRefreshData()
        {
            if (isRefreshing) return;

            isRefreshing = true;
            refreshTimer.Stop();

            string refreshingText = "обновляем...";
            lblToRefresh.Text = refreshingText;
            lblToRefresh2.Text = refreshingText;
            lblToRefresh3.Text = refreshingText;

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

            parameters.dateStart = DateTime.MinValue;
            parameters.dateFinish = DateTime.MaxValue;
            parameters.pageNumber = MaterialDocumentListPage;

            bgRefreshMaterialDocumentList.RunWorkerAsync(parameters);
        }

        /// <summary>
        ///     возвращает список пропусков из БД
        /// </summary>
        /// <param name="database">соединение с БД</param>
        /// <param name="dateStart">период действия с</param>
        /// <param name="dateFinish">период действия по</param>
        /// <param name="entryPoint">п. пропуска</param>
        /// <param name="defaultState">фильтр состояния пропуска</param>
        /// <param name="pageNum">страница списка</param>
        /// <returns></returns>
        private List<Permit> LoadPermitList(Database database, DateTime dateStart, DateTime dateFinish,
                                                EntryPoint entryPoint, EnumerationItem defaultState, int pageNum)
        {
            return Permit.LoadList(database, dateStart, dateFinish, entryPoint, defaultState, pageNum);
        }

        /// <summary>
        ///     запускает таймер до следующего обновления
        /// </summary>
        private void StartTimer()
        {
            if (!bgRefreshPermitList.IsBusy
                && !bgRefreshPlanAppointList.IsBusy
                && !bgRefreshMaterialDocumentList.IsBusy)
            {
                isRefreshing = false;
                secToUpdate = startSeconds;
                refreshTimer.Start();
            }
        }

        #region PlanAppoint actions

        /// <summary>
        ///     создает пропуск на основе заявки
        /// </summary>
        /// <param name="planAppoint">Заявка на пропуск</param>
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

        /// <summary>
        ///     формирует отказ в удовлетворении заявки
        /// </summary>
        /// <param name="planAppoint"></param>
        private void LockPlanAppoint(PlanAppoint planAppoint)
        {
            if (MessageBox.Show("Отказать в проезде транспорта на территорию?",
                                planAppoint.ToString(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = EntryControl.Resources.Doc.PlanAppoint.SetPermitLocked;
                QueryParameters parameters = new QueryParameters("planAppoint", planAppoint.Id);
                Database.ExecuteQuery(query, parameters);
                ForceRefreshData();
            }
        }

        #endregion

        #region Permit actions

        /// <summary>
        ///     создает незаполненный пропуск и вызывает форму редактирования
        /// </summary>
        private void CreateEmptyPermit()
        {
            PermitItemForm form = new PermitItemForm(Database);
            form.ItemSaved += form_ItemSaved;
            form.Show();
        }

        /// <summary>
        ///     вызывает форму редактирования для пропуска
        /// </summary>
        /// <param name="permit">редактируемый документ</param>
        private void EditPermit(Permit permit)
        {
            PermitItemForm form = new PermitItemForm(Database);
            form.Permit = permit.LoadCopy(Database);
            form.ItemSaved += form_ItemSaved;
            form.Show();

        }

        /// <summary>
        ///     удаляет указынный пропуск
        /// </summary>
        /// <param name="permit">удаляемый документ</param>
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

        /// <summary>
        ///     отражает данные пропуска в панели информации
        /// </summary>
        /// <param name="permit"></param>
        private void ShowPermitInfo(Permit permit)
        {
            tboxPermitComment.Text = permit.GetComment(Database);

            dgvMoving.DataSource = permit.GetMovingList(Database);
            dgvPointList.DataSource = permit.GetAllowedPointList(Database);
        }

        /// <summary>
        ///     очищает панель информации
        /// </summary>
        private void ClearPermitInfo()
        {
            tboxPermitComment.Text = "";
            dgvPointList.DataSource = null;
            dgvPointList.DataSource = null;
        }

        /// <summary>
        ///     печатает список пропусков
        /// </summary>
        private void PrintPermitList()
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

        /// <summary>
        ///     ищет текст в таблице пропусков
        /// </summary>
        /// <param name="text">искомый текст</param>
        /// <param name="startRow">строка начала поиска</param>
        /// <param name="startColumn">столбец начала поиска</param>
        /// <returns></returns>
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



        #endregion

        /// <summary>
        ///     сбрасывает настройки приложения
        /// </summary>
        private void ClearSettings()
        {
            if (MessageBox.Show("Сбросить настройки приложения?", "ВНИМАНИЕ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Settings.Default.StartForm = 0;
                Settings.Default.Save();

                Environment.Exit(0);
            }

        }

        #endregion

        #region Event handlers

        /// <summary>
        ///     заполняет список для выбора пунктов пропуска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rboxEntryPoint_GetList(object sender, ReferenceBox.ReferenceBoxEventArgs e)
        {
            e.ItemList = EntryPoint.LoadList(Database);
        }

        /// <summary>
        ///     обработчик отсчета времени до обновления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            secToUpdate--;
            string timeToRefresh = secToUpdate.ToString() + " сек.";
            lblToRefresh.Text = timeToRefresh;
            lblToRefresh2.Text = timeToRefresh;
            lblToRefresh3.Text = timeToRefresh;

            if (secToUpdate <= 0)
                RefreshData();
        }

        /// <summary>
        ///     при изменении списка заявок на пропуск - меняем заголовок соответствующей таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsPlanAppointList_DataSourceChanged(object sender, EventArgs e)
        {
            pagePlanAppointList.Text = "Заявки (" + bsPlanAppointList.Count.ToString() + ")";
        }

        /// <summary>
        ///     при выборе строки заявки на пропуск - отражает комментарий документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        ///     при выборе строки пропуска - отражает информацию в правой панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsPermitList_CurrentChanged(object sender, EventArgs e)
        {
            if (bsPermitList.Current != null)
                ShowPermitInfo((Permit)bsPermitList.Current);
            else
                ClearPermitInfo();
        }



        #region ToolPanels

        #region PlanAppoint tools

        private void createPermitTool_Click(object sender, EventArgs e)
        {
            if (SelectedPlanAppoint != null)
                CreatePermitForPlanAppoint(SelectedPlanAppoint);

        }

        private void lockAppointTool_Click(object sender, EventArgs e)
        {
            if (SelectedPlanAppoint != null)
                LockPlanAppoint(SelectedPlanAppoint);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            PlanAppointPage--;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            PlanAppointPage++;
        }


        #endregion

        #region Permit tools

        /// <summary>
        ///     обновляет список пропусков при изменении параметров фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickDateStart_ValueChanged(object sender, EventArgs e)
        {
            if (isInitialized) ForceRefreshData();
        }

        //private void permitTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //    CreateEmptyPermit();
        //}

        private void editPermitTool_Click(object sender, EventArgs e)
        {
            if (SelectedPermit != null)
                EditPermit(SelectedPermit);
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

        private void refreshPermiListTool_Click(object sender, EventArgs e)
        {
            ForceRefreshData();
        }

        private void printPermitListTool_Click(object sender, EventArgs e)
        {
            PrintPermitList();
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

        private void btnPreviousPermitPage_Click(object sender, EventArgs e)
        {
            PermitListPage--;
        }

        private void btnNextPermitPage_Click(object sender, EventArgs e)
        {
            PermitListPage++;
        }



        #endregion

        #endregion

        /// <summary>
        ///     по сохранению объектов в дочерних формах - обновляет списки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void form_ItemSaved(object sender, EventArgs e)
        {
            ForceRefreshData();
        }

        /// <summary>
        ///     перед отрисовкой списка заявок - раскрашивает заявки с отказом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        ///     перед отрисовкой списка пропусков - раскрашивает пропуска по состоянию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        ///     вызывает форму изменения пароля пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(Database);
            form.CurrentUser = Database.ConnectedUser;
            form.ShowDialog();
        }

        /// <summary>
        ///     при изменении даты фильтра заявок - обновляет список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion


        #region Фоновые задания

        #region bgLastUpdateDate - Дата последних изменений в таблице пропусков

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
            else
            {
                StartTimer();
            }
        }

        #endregion

        #region bgRefresh - Список пропусков

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

            StartTimer();
        }

        #endregion

        #region bgLastPlanAppointDate - Дата последних изменений в таблице заявок на пропуск

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

        #endregion

        #region bgRefreshPlanAppointList - Список заявок на пропуска

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

        #endregion

        #region bgLastMaterialDocumentDate - Дата последних изменений в таблице материальных пропусков

        private void bgLastMaterialDocumentDate_DoWork(object sender, DoWorkEventArgs e)
        {
            Database database = (Database)e.Argument;

            string query = EntryControl.Resources.Doc.MaterialPermit.GetLastDate;
            object result = database.ExecuteScalar(query);
            e.Result = (result == null || DBNull.Value.Equals(result) ? DateTime.MinValue : (DateTime)result);
        }

        private void bgLastMaterialDocumentDate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DateTime lastDate = (DateTime)e.Result;

            if (lastDate > lastMaterialDocumentModifiedDate)
            {
                lastMaterialDocumentModifiedDate = lastDate;

                RefreshParams args = new RefreshParams();
                args.database = Database;
                args.pageNumber = materialDocumentListPage;
                args.dateStart = DateTime.MinValue;
                args.dateFinish = DateTime.MaxValue;

                bgRefreshMaterialDocumentList.RunWorkerAsync(args);
            }
            else
            {
                StartTimer();
            }
        }

        #endregion

        #region bgRefreshMaterialDocumentList - список материальных пропусков

        private void bgRefreshMaterialDocumentList_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshParams args = (RefreshParams)e.Argument;

            Database database = args.database;

            RefreshResult result = new RefreshResult();
            result.List = MaterialPermit.LoadList((EntryControlDatabase)database, args.dateStart, args.dateFinish);

            e.Result = result;
        }

        private void bgRefreshMaterialDocumentList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RefreshResult result = (RefreshResult)e.Result;

            List<MaterialPermit> materialDocumentList = (List<MaterialPermit>)result.List;
            bsMaterialDocumentList.DataSource = new BindingList<MaterialPermit>(materialDocumentList);

            pageMaterialDocumentLisy.Text = string.Format("Материальные пропуска ({0})", bsMaterialDocumentList.Count);
            StartTimer();
        }

        #endregion

        #endregion






        private void materialPermitTool_Click(object sender, EventArgs e)
        {
            ShowMaterialPermitList();
        }

        private void ShowMaterialPermitList()
        {
            MaterialPermitListForm form = new MaterialPermitListForm(Database);

            form.Show();
        }

        private void bsMaterialDocumentList_CurrentChanged(object sender, EventArgs e)
        {
            MaterialPermit materialDocument = bsMaterialDocumentList.Current as MaterialPermit;

            if (materialDocument != null)
                ShowMaterialDocumentInfo(materialDocument);
        }

        private void ShowMaterialDocumentInfo(MaterialPermit materialDocument)
        {
            if (temporaryBgWorker == null)
            {
                temporaryTimer = new Timer()
                {
                    Interval = 500
                };

                temporaryTimer.Start();
                temporaryTimer.Tick += MdLoadingTimer_Tick;
                pbarMdLoading.Visible = true;

                temporaryBgWorker = new BackgroundWorker();
                temporaryBgWorker.DoWork += MdLoadingBgWorker_DoWork;
                temporaryBgWorker.RunWorkerCompleted += MdLoadingBgWorker_RunWorkerCompleted;

                temporaryBgWorker.RunWorkerAsync(new LoadingDocumentParams()
                {
                    Database = Database,
                    DocumentId = materialDocument.Id
                });

            }
            
        }

        private void MdLoadingBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MaterialPermit materialDocument = e.Result as MaterialPermit;
            tboxMdPerson.Text = materialDocument.Person;
            tboxMdVehicleMark.Text = materialDocument.VehicleMark;
            tboxMdLicensePlate.Text = materialDocument.LicensePlate;
            tboxMdCreator.Text = materialDocument.Creator.ToString();
            pboxCreatedImage.Image = materialDocument.CreatedImage;
            tboxMdCreatedDate.Text = materialDocument.CreatedDate.ToString("dd.MM.yyyy HH:mm");

            temporaryTimer.Stop();
            temporaryTimer.Dispose();
            temporaryTimer = null;

            pbarMdLoading.Visible = false;

            temporaryBgWorker.Dispose();
            temporaryBgWorker = null;
        }

        private void MdLoadingBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadingDocumentParams parameters = e.Argument as LoadingDocumentParams;

            e.Result = MaterialPermit.Load(parameters.Database, parameters.DocumentId);
        }

        private class LoadingDocumentParams
        {
            public Database Database { get; set; }
            public int DocumentId { get; set; }
        }

        private void MdLoadingTimer_Tick(object sender, EventArgs e)
        {
            if (pbarMdLoading.Value++ == 100)
                pbarMdLoading.Value = 0;
        }
    }
}

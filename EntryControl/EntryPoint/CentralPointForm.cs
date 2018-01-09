using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EntryControl.Classes;
using EntryControl.Properties;
using System.IO;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace EntryControl
{
    public partial class EntryPointForm : EntryControlForm
    {
        private string rbtn1Text = "машины на территории";
        private string rbtn2Text = "заявки на пропуск";

        private string defaultText = "Дежурная часть ";

        private int refreshingInterval = 60;
        private int secondsToRefresh = 0;

        private NotifyIcon notifyIcon;

        private NewPlanAppointForm notifyForm = null;

        private EntryPointForm()
            : base()
        {
            InitializeComponent();
        }

        public EntryPointForm(Database database)
            : base(database)
        {
            InitializeComponent();

            notifyIcon = null;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            btnAlwaysNotify.Checked = ReadNotificationSettings().NotifyAlways;

            createPermitTool.Image = EntryControl.Resources.Images.Check2;
            staffTool.Image = EntryControl.Resources.Images.Staff;
            btnAlwaysNotify.Image = EntryControl.Resources.Images.Bell;
            btnNotifyProperties.Image = EntryControl.Resources.Images.Wrench;

            //if (enteredVehicleList.Count > 0)
            //    rbtn1.BackColor = Color.LightGreen;
            //else
            //    rbtn1.BackColor = SystemColors.Control;

            panelEnteredVehicles.Visible = rbtn1.Checked;
            panelPlanAppoints.Visible = rbtn2.Checked;
            panelHistoryReport.Visible = rbtn3.Checked;

            refreshTimer.Start();

            lboxStaff.DataSource = Staff.LoadCurrentList(Database);

            FillStaffList();
        }

        private NotifySettings ReadNotificationSettings()
        {
            return NotifySettings.ReadSettings();
        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            panelEnteredVehicles.Visible = rbtn1.Checked;
            panelPlanAppoints.Visible = rbtn2.Checked;
            panelHistoryReport.Visible = rbtn3.Checked;

            if (panelEnteredVehicles.Visible)
                bsEnteredVehicle_CurrentChanged(sender, e);

            if (panelPlanAppoints.Visible)
                bsPlanAppoint_CurrentChanged(sender, e);

            if (panelHistoryReport.Visible)
                bsHistoryReport_CurrentChanged(sender, e);
        }

        private void createPermitTool_Click(object sender, EventArgs e)
        {
            if (bsPlanAppoint.Current != null)
                CreatePermitForPlanAppoint((PlanAppoint)bsPlanAppoint.Current);

        }

        private void CreatePermitForPlanAppoint(PlanAppoint planAppoint)
        {
            try
            {
                PermitItemForm form = new PermitItemForm(Database);
                form.PlanAppoint = planAppoint;
                form.ItemSaved += new EventHandler(permitItemSaved);
                form.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }

        private void permitItemSaved(object sender, EventArgs e)
        {
            ForceRefresh();
        }


        private void bsPlanAppoint_CurrentChanged(object sender, EventArgs e)
        {
            createPermitTool.Enabled = (bsPlanAppoint.Current != null);
            if (panelPlanAppoints.Visible)
            {
                if (bsPlanAppoint.Current != null)
                {
                    PlanAppoint appoint = (PlanAppoint)bsPlanAppoint.Current;
                    ShowComment(appoint.GetComment(Database));
                    ShowCreator(appoint.CreationInfo);
                }
                else
                {
                    ShowComment("");
                    ShowCreator("");
                }
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            secondsToRefresh--;

            if (secondsToRefresh > 0)
            {
                Text = defaultText + "- " + secondsToRefresh.ToString() + " сек.";
            }
            else
            {
                ForceRefresh();
            }
        }

        private void ForceRefresh()
        {
            refreshTimer.Stop();

            Text = defaultText + " - обновление...";

            if (!bgEnteredRefresh.IsBusy)
                bgEnteredRefresh.RunWorkerAsync(Database);

            if (!bgPlanAppointRefresh.IsBusy)
                bgPlanAppointRefresh.RunWorkerAsync(Database);
        }

        private void bgEnteredRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = EnteredVehicle.LoadList((Database)e.Argument);
        }

        private void bgEnteredRefresh_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<EnteredVehicle> enteredVehicleList = (List<EnteredVehicle>)e.Result;

            rbtn1.Text = rbtn1Text + " (" + enteredVehicleList.Count + ")";
            bsEnteredVehicle.DataSource = enteredVehicleList;

            CheckRefreshEnded();
        }

        private void CheckRefreshEnded()
        {
            if (!bgEnteredRefresh.IsBusy && !bgPlanAppointRefresh.IsBusy)
            {
                secondsToRefresh = refreshingInterval;
                refreshTimer.Start();
            }
        }

        private void bgPlanAppointRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = PlanAppoint.LoadWoPermit(Database);
        }

        private void bgPlanAppointRefresh_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<PlanAppoint> planAppointList = (List<PlanAppoint>)e.Result;

            rbtn2.Text = rbtn2Text + " (" + planAppointList.Count + ")";
            bsPlanAppoint.DataSource = planAppointList;

            NotifyPlanAppointCount(planAppointList.Count);

            CheckRefreshEnded();
        }

        private void NotifyPlanAppointCount(int count)
        {
            if (count == 0 && notifyIcon != null && notifyIcon.Visible)
            {
                notifyIcon.Visible = false;
                if (notifyForm != null)
                    notifyForm.Close();
            }

            if (count > 0 && NeedNotify())
            {
                if (notifyIcon == null)
                    notifyIcon = CreateNotifyIcon();

                notifyIcon.Visible = true;
                string notificationText = EntryControl.Resources.Message.Notify.HasNewPlanAppoint.Replace("@count", count.ToString());
                notifyIcon.ShowBalloonTip(10000, EntryControl.Resources.Message.Notify.HasNewPlanAppointTitle, notificationText, ToolTipIcon.Warning);
                PlayNotifySound();

                ShowNotifyWindow();
            }
        }

        private void ShowNotifyWindow()
        {
            if (notifyForm == null && ReadNotificationSettings().ShowNotifyWindow)
            {
                notifyForm = new NewPlanAppointForm();
                notifyForm.Show();
                notifyForm.FormClosed += NotifyForm_FormClosed;
            }
        }

        private void NotifyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyForm = null;
        }

        private void PlayNotifySound()
        {
            string soundFile = NotifySettings.ReadSettings().NotifySoundFile;
            if (soundFile.Length > 0 && File.Exists(soundFile))
            {
                try
                {
                    using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFile))
                        player.Play();
                }
                catch
                {
                    System.Media.SystemSounds.Exclamation.Play();
                }
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private NotifyIcon CreateNotifyIcon()
        {
            NotifyIcon icon = new NotifyIcon();
            icon.Icon = EntryControl.Resources.Images.Incoming;

            return icon;
        }

        private void staffTool_Click(object sender, EventArgs e)
        {
            ShowStaffList();
        }

        private void ShowStaffList()
        {
            StaffListForm form = new StaffListForm(Database);
            form.Show();
        }

        private void FillStaffList()
        {
            List<EntryPoint> entryPointList = EntryPoint.LoadList(Database);

            List<Staff> staffList = Staff.LoadList(Database);
            Dictionary<int, Staff> dictionary = new Dictionary<int, Staff>();
            foreach (Staff staff in staffList)
                dictionary.Add(staff.Id, staff);


            foreach (EntryPoint entryPoint in entryPointList)
                if (entryPoint.Id > 0)
                    AddControl(entryPoint, dictionary);

        }

        private void AddControl(EntryPoint entryPoint, Dictionary<int, Staff> staffList)
        {
            EntryPointControl control = new EntryPointControl(entryPoint, Database, staffList);
            control.Dock = DockStyle.Top;
            panelEntryPointList.Controls.Add(control);
        }

        private void btnNotifyProperties_Click(object sender, EventArgs e)
        {
            ShowNotifySettings();
        }

        private void ShowNotifySettings()
        {
            NotifySettingsForm form = new NotifySettingsForm(Database);
            form.FormClosed += NotifySettingsForm_FormClosed;
            form.ShowDialog();
        }

        private void NotifySettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnAlwaysNotify.Checked = ReadNotificationSettings().NotifyAlways;
        }

        private void btnAlwaysNotify_CheckedChanged(object sender, EventArgs e)
        {
            NotifySettings settings = NotifySettings.ReadSettings();
            settings.NotifyAlways = btnAlwaysNotify.Checked;
            settings.SaveSettings();
        }

        private bool NeedNotify()
        {
            NotifySettings settings = NotifySettings.ReadSettings();

            if (settings.NotifyAlways
                || DateTime.Now.TimeOfDay <= settings.WorkdayStart.TimeOfDay
                || DateTime.Now.TimeOfDay >= settings.WorkdayFinish.TimeOfDay
                || DateTime.Now.DayOfWeek == DayOfWeek.Saturday
                || DateTime.Now.DayOfWeek == DayOfWeek.Sunday
                || settings.NotifyDays.Contains(DateTime.Today)
                || IsVacationDate(DateTime.Today))
                return true;
            else
                return false;
        }

        private bool IsVacationDate(DateTime date)
        {
            QueryParameters parameters = new QueryParameters("date", date);

            return ((short)Database.ExecuteScalar(EntryControl.Resources.Ref.Vacation.IsVacationDate, parameters) > 0);

        }

        private void panelHistoryReport_VisibleChanged(object sender, EventArgs e)
        {
            if (panelHistoryReport.Visible)
            {
                dtpDateTo.Value = DateTime.Now;
                dtpDateFrom.Value = DateTime.Now.AddDays(-1);

                List<Cargo> cargoList = Cargo.LoadList(Database);
                cargoList.Insert(0, new Cargo(0, "ВСЕ ГРУЗЫ"));
                cboxCargo.DataSource = cargoList;
            }
        }

        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            if (cboxCargo.SelectedItem != null)
            {
                Cargo cargo = (Cargo)cboxCargo.SelectedItem;

                bsHistoryReport.DataSource = HistoryMoving.LoadList(Database, dtpDateFrom.Value, dtpDateTo.Value, tboxVehicleMask.Text, cargo);
            }
        }

        private void dgvHistoryReport_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && bsHistoryReport.DataSource != null && bsHistoryReport.Count > e.RowIndex)
            {
                HistoryMoving row = (HistoryMoving)bsHistoryReport[e.RowIndex];
                dgvHistoryReport.Rows[e.RowIndex].DefaultCellStyle.ForeColor = row.Color;
                dgvHistoryReport.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = row.Color;
            }
        }

        private void btnPrintHistory_Click(object sender, EventArgs e)
        {
            PrintHistoryReport();
        }

        private void PrintHistoryReport()
        {
            StiReport report = new StiReport();

            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = Path.Combine(path, "Report");
            string fileName = Path.Combine(path, "MovingHistory.mrt");

            report.Load(fileName);

            report.Dictionary.Databases.Clear();
            report.Dictionary.Databases.Add(new StiFirebirdDatabase("FbConnection", Database.ConnectionString));
            report.Compile();

            report["dateFrom"] = dtpDateFrom.Value;
            report["dateTo"] = dtpDateTo.Value;
            report["vehicleMask"] = tboxVehicleMask.Text;
            report["cargo"] = ((Cargo)cboxCargo.SelectedItem).Id;

            report.Show();
        }

        private void bsEnteredVehicle_CurrentChanged(object sender, EventArgs e)
        {
            if (panelEnteredVehicles.Visible)
            {
                if (bsEnteredVehicle.Current != null)
                {
                    EnteredVehicle row = (EnteredVehicle)bsEnteredVehicle.Current;
                    ShowComment(row.GetComment(Database));
                    ShowCreator(row.GetCreator(Database));
                }
                else
                {
                    ShowComment("");
                    ShowCreator("");
                }
            }
        }

        private void ShowCreator(string v)
        {
            lblCreator.Text = v;
        }

        private void ShowComment(string v)
        {
            lblComment.Text = v;
        }

        private void bsHistoryReport_CurrentChanged(object sender, EventArgs e)
        {
            if (bsHistoryReport.Current != null && panelHistoryReport.Visible)
            {
                HistoryMoving historyMoving = (HistoryMoving)bsHistoryReport.Current;
                ShowComment(historyMoving.GetComment(Database));
                ShowCreator(historyMoving.GetPlanAppointCreator(Database));
            }
            else
            {
                ShowComment("");
                ShowCreator("");
            }
        }

        private void tboxVehicleMask_KeyDown(object sender, KeyEventArgs e)
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


using EPV.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EntryControl
{
    public partial class NotifySettingsForm : EntryControlForm
    {
        private NotifySettings settings;

        public bool IsSoundFill
        {
            get { return (tboxNotifySound.Text.Length > 0); }
        }

        private NotifySettingsForm()
            : base()
        {
            InitializeComponent();
        }

        public NotifySettingsForm(Database database)
            : base(database)
        {
            InitializeComponent();

            AddControlImages();

            settings = ReadSettings();
            BindComponent();
        }

        private void AddControlImages()
        {
            btnRemoveVacation.BackgroundImage = EntryControl.Resources.Images.Lock;
            btnAddVacation.BackgroundImage = EntryControl.Resources.Images.Add;

            btnAddAdvancedDate.BackgroundImage = EntryControl.Resources.Images.Add;
            btnRemoveAdvancedDate.BackgroundImage = EntryControl.Resources.Images.Lock;

            btnPlaySound.BackgroundImage = EntryControl.Resources.Images.Play;
        }

        private void BindComponent()
        {
            dtpVacation.Value = DateTime.Today.AddDays(1);
            dtpAdvancedDate.Value = DateTime.Today.AddDays(1);

            bsSettings.DataSource = settings;

            checkNotifyAlways.DataBindings.Add("Checked", bsSettings, "NotifyAlways");

            dtpWorkdayStart.DataBindings.Add("Value", bsSettings, "WorkdayStart");
            dtpWorkdayFinish.DataBindings.Add("Value", bsSettings, "WorkdayFinish");

            checkShowNotifyWindow.DataBindings.Add("Checked", bsSettings, "ShowNotifyWindow");

            tboxNotifySound.DataBindings.Add("Text", bsSettings, "NotifySoundFile", true, DataSourceUpdateMode.OnPropertyChanged);
            btnPlaySound.DataBindings.Add("Enabled", this, "IsSoundFill");

            bsAdvancedDates.DataSource = settings.NotifyDays;
            bsVacationDates.DataSource = GetVacationList();
        }

        private NotifySettings ReadSettings()
        {
            return NotifySettings.ReadSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            settings.SaveSettings();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void btnAddAdvancedDate_Click(object sender, EventArgs e)
        {
            AddDateToAdvancedDate(dtpAdvancedDate.Value.Date);
        }

        private void AddDateToAdvancedDate(DateTime date)
        {
            if (!bsAdvancedDates.Contains(date))
            {
                bsAdvancedDates.Add(date);
            }
        }

        private void btnRemoveAdvancedDate_Click(object sender, EventArgs e)
        {
            RemoveAdvancedDate(dtpAdvancedDate.Value.Date);
        }

        private void RemoveAdvancedDate(DateTime date)
        {
            if (bsAdvancedDates.Contains(date))
            {
                bsAdvancedDates.Remove(date);
            }
        }

        private void lboxAdvancedDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxAdvancedDates.SelectedItem != null)
                dtpAdvancedDate.Value = (DateTime)lboxAdvancedDates.SelectedItem;
        }

        private List<DateTime> GetVacationList()
        {
            List<DateTime> dateList = new List<DateTime>();

            using (DbDataReader reader = Database.ExecuteReader(EntryControl.Resources.Ref.Vacation.LoadList))
            {
                while (reader.Read())
                    dateList.Add((DateTime)reader["vacationDate"]);

                reader.Close();
            }

            return dateList;
        }

        private void lboxVacations_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lboxVacations.SelectedItem != null)
                dtpVacation.Value = (DateTime)lboxVacations.SelectedItem;
        }

        private void btnAddVacation_Click(object sender, EventArgs e)
        {
            AddVacation(dtpVacation.Value.Date);
        }

        private void AddVacation(DateTime date)
        {
            if (!IsVacationDate(date))
            {
                try
                {
                    QueryParameters parameters = new QueryParameters("date", date);
                    Database.ExecuteQuery(EntryControl.Resources.Ref.Vacation.Add, parameters);
                    bsVacationDates.Add(date);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка добавления даты: " + exc.Message);
                }
            }
        }

        private bool IsVacationDate(DateTime date)
        {
            QueryParameters parameters = new QueryParameters("date", date);

            return ((short)Database.ExecuteScalar(EntryControl.Resources.Ref.Vacation.IsVacationDate, parameters) > 0);

        }

        private void btnRemoveVacation_Click(object sender, EventArgs e)
        {
            RemoveVacationDate(dtpVacation.Value.Date);
        }

        private void RemoveVacationDate(DateTime date)
        {
            try
            {
                QueryParameters parameters = new QueryParameters("date", date);
                Database.ExecuteQuery(EntryControl.Resources.Ref.Vacation.Remove, parameters);
                bsVacationDates.Remove(date);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка удаления даты: " + exc.Message);
            }
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            if (openSoundFileDialog.ShowDialog() == DialogResult.OK)
            {
                tboxNotifySound.Text = openSoundFileDialog.FileName;
            }
        }

        private void btnPlaySound_Click(object sender, EventArgs e)
        {
            PlaySound(tboxNotifySound.Text);
        }

        private void PlaySound(string text)
        {
            if (text.Length > 0
                && File.Exists(text))
            {
                try
                {
                    using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(text))
                        player.Play();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Файл не может быть использован: " + exc.Message);
                }
            }


        }
    }
}

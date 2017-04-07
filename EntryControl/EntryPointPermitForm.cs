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
using System.Globalization;

namespace EntryControl
{
    public partial class EntryPointPermitForm : EntryControlForm
    {
        private EntryPointPermitForm()
            : base()
        {
            InitializeComponent();
        }

        public EntryPointPermitForm(Database database)
            : base(database)
        {
            InitializeComponent();

        }

        private Permit permit;

        public Permit Permit
        { 
            get { return permit; }
            set
            {
                permit = value;
                ShowPermitData();
                SetControlLocation();
            }
        }

        public EntryPoint EntryPoint { get; set; }

        private void ShowPermitData()
        {
            lblHeader.Text = Permit.Header;
            lblCargo.Text = Permit.Cargo.ToString();
            lblVehicle.Text = Permit.Vehicle.ToString();
            lblDriverName.Text = Permit.DriverName;
            lblEntryPoint.Text = Permit.EntryPoint.ToString();

            if (Permit.IsMultiEntry)
                lblMultiEntry.Text = "разрешен переезд через проходные";
            else
                lblMultiEntry.Text = "";

            if (!Permit.EntryPoint.Equals(EntryPoint.Empty)
                && !Permit.EntryPoint.Equals(EntryPoint))
            {
                lblEntryPoint.ForeColor = Color.Red;
                lblEntryPoint.Font = new Font(lblEntryPoint.Font, FontStyle.Bold);
                btnEntry.Enabled = false;
                btnExit.Enabled = false;
            }
        }

        private void SetControlLocation()
        {
            PermitMoving moving = Permit.LoadLastMoving(Database);

            if (moving == null
                || moving.Moving.Id == 1 || moving.Moving.Id == 3)
                SetEntryControlLocation();
            else if (moving.Moving.Id == 2)
                SetExitControlLocation();
            else
                MessagePermitIsClosed();

        }

        private void MessagePermitIsClosed()
        {
            MessageBox.Show(EntryControl.Resources.Message.Error.PermitIsClosed, Permit.ToString());
        }

        private void SetExitControlLocation()
        {
            SetPreferenceButton(btnExit);
            SetNotPreferenceButton(btnEntry);
        }

        private void SetEntryControlLocation()
        {
            SetPreferenceButton(btnEntry);
            SetNotPreferenceButton(btnExit);
        }

        private void SetPreferenceButton(Button btn)
        {
            //tblPanel.Controls.Remove(tblPanel.GetControlFromPosition(1, 0));
            tblPanel.Controls.Add(btn, 1, 0);
            btn.Font = new System.Drawing.Font(btn.Font.FontFamily, 28.0f);
            btn.TextImageRelation = TextImageRelation.ImageAboveText;
        }

        private void SetNotPreferenceButton(Button btn)
        {
            //tblPanel.Controls.Remove(tblPanel.GetControlFromPosition(0, 1));
            tblPanel.Controls.Add(btn, 1, 1);
            btn.Font = new Font(btn.Font.FontFamily, 16.0F);
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void PermitMovingForm_Shown(object sender, EventArgs e)
        {
            Text = Permit.ToString();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            /*------------------------------------
             *  1. Проверка на закрытый
             *  2. Проверка последней операции
             *  3. Проверка выдачи пропуска
             *      Проверка возможности проезда через пункт.
             *  4. Въезд
             *------------------------------------*/

            CreateEntry();
        }

        private void CreateEntry()
        {
            PermitMoving lastMoving = Permit.LoadLastMoving(Database);

            if (lastMoving == null
                || lastMoving.Moving.Id != 2
                || (lastMoving.Moving.Id == 2
                    && IgnoreMovingError(lastMoving)))
            {
                PermitMoving moving = PermitMoving.CreateEntry(Permit);
                moving.EntryPoint = EntryPoint;
                moving.User = Database.ConnectedUser;

                PermitMovingForm form = new PermitMovingForm(Database, moving);

                if (form.ShowDialog() == DialogResult.OK)
                    Close();
            }
        }

        private bool IgnoreMovingError(PermitMoving lastMoving)
        {
            IgnoreMovingErrorForm form = new IgnoreMovingErrorForm(lastMoving);
            return (form.ShowDialog() == DialogResult.OK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*------------------------------------
             *  1. Проверка на закрытый
             *  2. Проверка последней операции
             *  3. Выезд
             *  4. Вопрос о закрытии
             *------------------------------------*/

            CreateExit();
        }

        private void CreateExit()
        {
            PermitMoving lastMoving = Permit.LoadLastMoving(Database);

            if (lastMoving == null
                || lastMoving.Moving.Id != 3
                || (lastMoving.Moving.Id == 3
                    && IgnoreMovingError(lastMoving)))
            {
                PermitMoving moving = PermitMoving.CreateExit(Permit);
                moving.EntryPoint = EntryPoint;
                moving.User = Database.ConnectedUser;

                PermitMovingForm form = new PermitMovingForm(Database, moving);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    CheckClose();
                    Close();
                }
            }
        }

        private void CheckClose()
        {
            if (Permit.IsMultiEntry)
            {
                if (MessageBox.Show(EntryControl.Resources.Doc.Permit.PermitToClose, Permit.ToString(),
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClosePermit();
                }
            }
            else
            {
                ClosePermit();
            }
        }

        private void ClosePermit()
        {
            PermitMoving moving1 = Permit.Close(EntryPoint, Database.ConnectedUser);
            moving1.Save(Database);


            string message = EntryControl.Resources.Doc.Permit.PermitClose;
            message = message.Replace("@movingTime", moving1.MovingTime.ToString("dd.MM.yyyy HH:mm"));
            MessageBox.Show(message, Permit.ToString());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string fileName = Path.Combine(path, "Permit.mrt");

            report.Load(fileName);
            report.Dictionary.Databases.Clear();
            report.Dictionary.Databases.Add(new StiFirebirdDatabase("EntryDatabase", this.Database.ConnectionString));
            report.Compile();
            report["permitId"] = Permit.Id;
            report.Show();
        }
    }
}

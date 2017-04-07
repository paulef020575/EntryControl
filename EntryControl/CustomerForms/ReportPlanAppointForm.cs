using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;
using Stimulsoft.Report;
using System.IO;
using Stimulsoft.Report.Dictionary;

namespace EntryControl
{
    public partial class ReportPlanAppointForm : EntryControlForm
    {
        private ReportPlanAppointForm()
            : base()
        {
            InitializeComponent();
        }

        public ReportPlanAppointForm(EntryControlDatabase database)
            : base(database)
        {
            InitializeComponent();

            cboxCargo.DataSource = Cargo.LoadList(Database);
            pickPlanDate.Value = DateTime.Today.AddDays(1);
        }

        public StiReport LoadReport()
        {
            StiReport report = new StiReport();

            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = Path.Combine(path, "Report");
            string fileName = Path.Combine(path, "PlanAppoint.mrt");

            report.Load(fileName);

            report.Dictionary.Databases.Clear();
            report.Dictionary.Databases.Add(new StiFirebirdDatabase("EntryControlDatabase", Database.ConnectionString));
            report.Compile();

            report["cargoId"] = ((Cargo)cboxCargo.SelectedItem).Id;
            report["planDate"] = pickPlanDate.Value;

            return report;
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            LoadReport().Show();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            LoadReport().Print();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

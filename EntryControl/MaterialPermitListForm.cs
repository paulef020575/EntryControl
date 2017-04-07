using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;
using EPV.Database;

namespace EntryControl
{
    public partial class MaterialPermitListForm : EntryControlForm
    {
        private DateTime lastRefreshing;

        private bool isInitialized = false;

        private int refreshingPeriod = 60;
        private int secondsToRefresh = 0;

        private struct RefreshArgs
        {
            public EntryControlDatabase Database;
            public DateTime DateFrom;
            public DateTime DateTo;
        }

        private struct GetItemListArgs
        {
            public Database Database;
            public MaterialPermit Document;
        }

        private MaterialPermitListForm()
        {
            InitializeComponent();
        }

        public MaterialPermitListForm(EntryControlDatabase database)
            : base(database)
        {
            InitializeComponent();

            dgvItemList.AutoGenerateColumns = false;

            refreshButton.BackgroundImage = EntryControl.Resources.Images.Refresh;
            bsList.DataSource = new BindingList<MaterialPermit>();
            lastRefreshing = DateTime.MinValue;
            CheckRefreshing();
            isInitialized = true;

            AddBindings();
         }

        private void AddBindings()
        {
            tboxPerson.DataBindings.Add("Text", bsList, "Person");
            tboxVehicleMark.DataBindings.Add("Text", bsList, "VehicleMark");
            tboxLicensePlate.DataBindings.Add("Text", bsList, "LicensePlate");
            tboxBaseDocument.DataBindings.Add("Text", bsList, "BaseDocumentText");
            pboxCreatedImage.DataBindings.Add("Image", bsList, "CreatedImage");
            lblCreator.DataBindings.Add("Text", bsList, "Creator");
            pboxSignedImage.DataBindings.Add("Image", bsList, "SignedImage");
            lblSigner.DataBindings.Add("Text", bsList, "Signer");
        }

        private void CheckRefreshing()
        {
            refreshLabel.Text = "проверка обновлений...";
            bckGetChanges.RunWorkerAsync(Database);
        }

        private void bckGetChanges_DoWork(object sender, DoWorkEventArgs e)
        {
            Database database = (Database)e.Argument;

            string query = EntryControl.Resources.Doc.MaterialPermit.GetLastDate;

            e.Result = database.ExecuteScalar(query);
        }

        private void bckGetChanges_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null
                && (DateTime)e.Result > lastRefreshing)
            {
                lastRefreshing = (DateTime)e.Result;
                ForceRefreshing();
            }
            else
            {
                StartTimer();
            }
        }

        private void ForceRefreshing()
        {
            RefreshArgs args = new RefreshArgs();
            args.Database = Database;
            args.DateFrom = DateTime.Now.AddDays(-10);
            args.DateTo = DateTime.Now;

            refreshLabel.Text = "обновление...";
            bckRefresh.RunWorkerAsync(args);
        }

        private void bckRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshArgs args = (RefreshArgs)e.Argument;

            e.Result = MaterialPermit.LoadList(args.Database, args.DateFrom, args.DateTo);
        }

        private void bckRefresh_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bsList.DataSource = new BindingList<MaterialPermit>((List<MaterialPermit>)e.Result);
            StartTimer();
        }

        private void StartTimer()
        {
            secondsToRefresh = refreshingPeriod;
            refreshTimer.Start();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            secondsToRefresh--;
            if (secondsToRefresh == 0)
            {
                refreshTimer.Stop();
                CheckRefreshing();
            }
            else
            {
                refreshLabel.Text = secondsToRefresh.ToString();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ForceRefreshing();
        }

        private void bsList_CurrentChanged(object sender, EventArgs e)
        {
            if (isInitialized && bsList.Current != null)
                ShowDocumentInControl((MaterialPermit)bsList.Current);
        }

        private void ShowDocumentInControl(MaterialPermit materialPermit)
        {
            pnlProgress.Visible = true;

            if (bckGetItemList.IsBusy) bckGetItemList.CancelAsync();
            while (bckGetItemList.IsBusy)
                Application.DoEvents();

            GetItemListArgs args = new GetItemListArgs();
            args.Database = Database;
            args.Document = materialPermit;
            
            bckGetItemList.RunWorkerAsync(args);
        }

        private void bckGetItemList_DoWork(object sender, DoWorkEventArgs e)
        {
            GetItemListArgs args = (GetItemListArgs)e.Argument;

            e.Result = args.Document.GetItemList(args.Database);
        }

        private void bckGetItemList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlProgress.Visible = false;

            if (!e.Cancelled)
                dgvItemList.DataSource = new BindingList<MaterialPermitItem>((List<MaterialPermitItem>)e.Result);
        }


    }
}

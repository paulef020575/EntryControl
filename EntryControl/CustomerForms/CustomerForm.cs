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
    public partial class CustomerForm : EntryControlForm
    {
        #region Конструкторы

        private CustomerForm()
            : base()
        {
            InitializeComponent();

        }


        public CustomerForm(Database database)
            : base(database)
        {
            InitializeComponent();

            changePasswordTool.Image = EntryControl.Resources.Images.Password;
            printTool.Image = EntryControl.Resources.Images.Print;
            CreateImageList();

            dateStart = DateTime.Today.AddMonths(-1);
        }

        #endregion

        #region Свойства

        private PlanAppoint SelectedPlanAppoint
        {
            get { return appointListTree.SelectedNode.Tag as PlanAppoint; }
        }

        private DateTime lastModifiedDate = DateTime.MinValue;

        private int secondsToRefresh;

        private DateTime dateStart;

        private struct SeenParameters
        {
            public Database Database;
            public PlanAppoint PlanAppoint;
        }

        private struct LoadParameters
        {
            public Database Database;
            public DateTime DateStart;
            public string SearchingText;
        }

        #endregion


        #region Обработчики событий

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //lastModifiedDate = GetLastModifiedDate();
            //LoadPlanAppointList();

            RefreshData();
        }

        private DateTime GetLastModifiedDate(Database database)
        {
            string query = EntryControl.Resources.Doc.PlanAppoint.GetLastDateModified;

            object result = database.ExecuteScalar(query);

            if (result != null && !DBNull.Value.Equals(result))
                return (DateTime)result;

            return DateTime.Now;
        }

        private void StartTimer()
        {
            secondsToRefresh = 45;
            timer.Start();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StopTimer();
            PlanAppoint planAppoint = e.Node.Tag as PlanAppoint;
            if (planAppoint != null)
            {
                ShowPlanAppointControl(planAppoint);

                editCurrentTool.Enabled = !planAppoint.HasPermit;
                deleteCurrentTool.Enabled = !planAppoint.HasPermit;

            }
            else
            {
                editCurrentTool.Enabled = false;
                deleteCurrentTool.Enabled = false;
            }
        }


        #region Панель инструментов

        private void addNewTool_Click(object sender, EventArgs e)
        {
            CreateNewPlanAppoint();
        }

        private void editCurrentTool_Click(object sender, EventArgs e)
        {
            PlanAppoint appoint = appointListTree.SelectedNode.Tag as PlanAppoint;

            if (appoint != null)
            {
                EditCurrentAppoint(appoint);
            }
        }

        private void deleteCurrentTool_Click(object sender, EventArgs e)
        {
            string message = EntryControl.Resources.Message.Question.Delete;
            if (SelectedPlanAppoint != null
                && MessageBox.Show(message, SelectedPlanAppoint.ToString(), MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
            {
                PlanAppoint appoint = SelectedPlanAppoint;
                Delete(SelectedPlanAppoint);
            }

            ForceRefreshData();
        }

        #endregion

        void formItemSaved(object sender, EventArgs e)
        {
            PlanAppoint appoint = (PlanAppoint)sender;

            ForceRefreshData();
            foreach (TreeNode parentNode in appointListTree.Nodes)
            {
                KeyValuePair<DateTime, List<PlanAppoint>> pair = (KeyValuePair<DateTime, List<PlanAppoint>>)parentNode.Tag;
                DateTime date = pair.Key;
                if (date == appoint.DateFrom)
                {
                    parentNode.Expand();
                    SelectNode(parentNode, appoint);
                    break;
                }
            }
        }

        void planAppointItemSeen(object sender, EventArgs e)
        {
            if (SelectedPlanAppoint != null)
            {
                SeenParameters parameters = new SeenParameters();
                parameters.Database = Database;
                parameters.PlanAppoint = SelectedPlanAppoint;

                bgSetAppointSeen.RunWorkerAsync(parameters);
            }

            
            appointListTree.SelectedNode.NodeFont = new Font(appointListTree.SelectedNode.NodeFont, FontStyle.Regular);
        }

        #endregion

        #region Методы

        private void CreateNewPlanAppoint()
        {
            PlanAppointForm form = new PlanAppointForm(Database);
            form.ItemSaved += formItemSaved;
            form.Show();
        }

        private void EditCurrentAppoint(PlanAppoint appoint)
        {
            PlanAppointForm form = new PlanAppointForm(Database);
            form.PlanAppoint = appoint;
            form.ItemSaved += new EventHandler(formItemSaved);
            form.Show();
        }

        private void ShowPlanAppointControl(PlanAppoint planAppoint)
        {

            PlanAppointViewControl control = new PlanAppointViewControl(Database);
            control.PlanAppoint = planAppoint;
            control.ItemSeen += new EventHandler(planAppointItemSeen);
            splitContainer1.Panel2.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }


        private void SelectNode(DateTime dateTime)
        {
            foreach (TreeNode node in appointListTree.Nodes)
            {
                DateTime nodeDate = ((KeyValuePair<DateTime, List<PlanAppoint>>)node.Tag).Key;
                if (nodeDate == dateTime)
                {
                    appointListTree.SelectedNode = node;
                    break;
                }
            }
        }

        private void SelectNode(PlanAppoint appoint)
        {
            SelectNode(appoint.DateFrom);
            appointListTree.SelectedNode.Expand();
            foreach (TreeNode node in appointListTree.SelectedNode.Nodes)
            {
                if (appoint.Equals((PlanAppoint)node.Tag))
                {
                    appointListTree.SelectedNode = node;
                    break;
                }
            }
        }

        private void StopTimer()
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                ((ITimeredControl)splitContainer1.Panel2.Controls[0]).StopTimer();
                splitContainer1.Panel2.Controls.Clear();
            }
        }

        private void Delete(PlanAppoint appoint)
        {
            appoint.Delete();
            appoint.Save(Database);
        }

        #region Дерево


        private TreeNode CreateNode(PlanAppoint appoint)
        {
            TreeNode node = new TreeNode("");
            node.Tag = appoint;
            if (appoint.IsUpdated) node.NodeFont = new Font(appointListTree.Font, FontStyle.Bold);

            node.ForeColor = appointListTree.ForeColor;
            node.ImageKey = "Empty";


            if (appoint.HasPermit)
            {
                node.ForeColor = Color.Green;
                node.ImageKey = "Check";
            }

            if (appoint.PermitIsClosed)
            {
                node.ForeColor = SystemColors.GrayText;
                node.ImageKey = "Closed";
            }

            if (appoint.IsLocked || appoint.PermitState == 3)
            {
                node.ForeColor = Color.Red;
                node.ImageKey = "Lock";
            }

            node.Text = appoint.ToString();

            return node;
        }

        private SortedDictionary<DateTime, List<PlanAppoint>> CreateDictionary(List<PlanAppoint> appointList)
        {
            SortedDictionary<DateTime, List<PlanAppoint>> dictionary
                = new SortedDictionary<DateTime, List<PlanAppoint>>();
            foreach (PlanAppoint appoint in appointList)
            {
                if (!dictionary.ContainsKey(appoint.DateFrom))
                    dictionary.Add(appoint.DateFrom, new List<PlanAppoint>());
                dictionary[appoint.DateFrom].Add(appoint);
            }

            return dictionary;
        }

        private void SelectNode(TreeNode parentNode, PlanAppoint appoint)
        {
            foreach (TreeNode node in parentNode.Nodes)
            {
                PlanAppoint nodeAppoint = (PlanAppoint)node.Tag;
                if (nodeAppoint.Equals(appoint))
                {
                    appointListTree.SelectedNode = node;
                    break;
                }
            }
        }

        private void CreateImageList()
        {
            treeImageList.Images.Add("Empty", EntryControl.Resources.Images.Empty);
            treeImageList.Images.Add("Check", EntryControl.Resources.Images.Check2);
            treeImageList.Images.Add("Closed", EntryControl.Resources.Images.Checks);
            treeImageList.Images.Add("Lock", EntryControl.Resources.Images.Lock);
            treeImageList.Images.Add("Selected", EntryControl.Resources.Images.Right);

            appointListTree.SelectedImageKey = "Selected";
        }


        #endregion

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node.Tag is KeyValuePair<DateTime, List<PlanAppoint>>)
                DrawDateNode(e);
            else
                DrawAppointNode(e);
        }

        private void DrawAppointNode(DrawTreeNodeEventArgs e)
        {
            PlanAppoint appoint = (PlanAppoint)e.Node.Tag;

            Font font = appointListTree.Font;
            if (appoint.IsUpdated)
                font = new Font(font, FontStyle.Bold);
            e.Node.NodeFont = font;
            Brush foreBrush = new SolidBrush(e.Node.ForeColor),
                backBrush = new SolidBrush(appointListTree.BackColor);

            if ((e.State & TreeNodeStates.Selected) > 0)
            {
                e.Graphics.FillRectangle(foreBrush, NodeBounds(e.Node));
                e.Graphics.DrawString(appoint.ToString(), font, backBrush, 
                    NodeBounds(e.Node));
            }
            else
            {
                e.Graphics.DrawString(appoint.ToString(), font, foreBrush,  
                    NodeBounds(e.Node));
            }

        }

        

        private void DrawDateNode(DrawTreeNodeEventArgs e)
        {
            KeyValuePair<DateTime, List<PlanAppoint>> pair 
                = (KeyValuePair<DateTime, List<PlanAppoint>>)e.Node.Tag;

            string text = pair.Key.ToShortDateString() + "     ";
            text += pair.Value.Count;
            int countUpdated = GetUpdatedCount(pair.Value);

            Font font = appointListTree.Font;

            if (countUpdated > 0)
            {
                text += " / " + countUpdated;
                font = new Font(font, font.Style | FontStyle.Bold);
            }

            e.Node.NodeFont = font;

            Brush foreBrush = new SolidBrush(e.Node.ForeColor),
                backBrush = new SolidBrush(appointListTree.BackColor);
            
            if ((e.State & TreeNodeStates.Selected) > 0)
            {
                e.Graphics.FillRectangle(foreBrush, e.Node.Bounds);
                e.Graphics.DrawString(text, font, backBrush,
                                        NodeBounds(e.Node));
            }
            else
            {
                e.Graphics.DrawString(text, font, foreBrush,
                                        NodeBounds(e.Node));
            }
        }

        private int GetUpdatedCount(List<PlanAppoint> list)
        {
            int count = 0;
            foreach (PlanAppoint planAppoint in list)
                if (planAppoint.IsUpdated)
                    count++;

            return count;
        }

        private Rectangle NodeBounds(TreeNode node)
        {
            // Set the return value to the normal node bounds.
            Rectangle bounds = node.Bounds;
            string text = node.Text;

            
                Graphics g = appointListTree.CreateGraphics();
                int tagWidth = (int)g.MeasureString
                    (node.Tag.ToString(), node.NodeFont).Width + 6;

                // Adjust the node bounds using the calculated value.
                bounds.Offset(tagWidth / 2, 0);
                bounds = Rectangle.Inflate(bounds, tagWidth / 2, 0);
                g.Dispose();
            

            return bounds;

        }

          #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            secondsToRefresh--;
            lblSecToRefresh.Text = secondsToRefresh.ToString() + " сек";
            if (secondsToRefresh <= 0)
            {
                RefreshData();
            }

        }

        
        private void RefreshData()
        {
            timer.Stop();
            lblSecToRefresh.Text = "обновляем...";
            bgCheckLastModifiedDate.RunWorkerAsync(Database);
        }

        private void bgCheckLastModifiedDate_DoWork(object sender, DoWorkEventArgs e)
        {
            Database database = (Database)e.Argument;
            e.Result = GetLastModifiedDate(database);
        }

        private void bgCheckLastModifiedDate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DateTime date = (DateTime)e.Result;

            if (date > lastModifiedDate)
            {
                lastModifiedDate = date;
                ForceRefreshData();
            }
            else
            {
                StartTimer();
            }
        }

        private void ForceRefreshData()
        {
            timer.Stop();

            LoadParameters parameters = new LoadParameters();
            parameters.Database = Database;
            parameters.DateStart = dateStart;
            parameters.SearchingText = tboxSearch.Text;

            lblSecToRefresh.Text = "обновляем...";

            bgRefreshAppointList.RunWorkerAsync(parameters);

            StartTimer();
        }

        private void bgRefreshAppointList_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadParameters parameters = (LoadParameters)e.Argument;
            Database database = parameters.Database;
            DateTime DateStart = parameters.DateStart;
            string searchingText = parameters.SearchingText;

            List<PlanAppoint> planAppointList = PlanAppoint.LoadListForTree(database, DateStart);
            List<PlanAppoint> resultList = planAppointList;

            if (searchingText.Length > 0)
            {
                resultList = new List<PlanAppoint>();
                foreach (PlanAppoint planAppoint in planAppointList)
                {
                    if (planAppoint.ToString().ToLower().Contains(searchingText.ToLower()))
                        resultList.Add(planAppoint);
                }
            }

            e.Result = CreateDictionary(resultList);
        }

        private void bgRefreshAppointList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SortedDictionary<DateTime, List<PlanAppoint>> dictionary =
                (SortedDictionary<DateTime, List<PlanAppoint>>)e.Result;

            CreateTree(dictionary);
            
            if (appointListTree.Nodes.Count > 0)
                appointListTree.SelectedNode = appointListTree.Nodes[0];
        }

        private void CreateTree(SortedDictionary<DateTime, List<PlanAppoint>> dictionary)
        {
            object tag = null;

            if (appointListTree.SelectedNode != null)
                tag = appointListTree.SelectedNode.Tag;

            appointListTree.BeginUpdate();

            appointListTree.Nodes.Clear();

            foreach (KeyValuePair<DateTime, List<PlanAppoint>> pair in dictionary)
            {
                appointListTree.Nodes.Insert(0, CreateNode(pair));
            }

            appointListTree.EndUpdate();

            if (tag != null)
            {
                if (tag is PlanAppoint)
                {
                    SelectNode((PlanAppoint)tag);
                }
                else
                {
                    KeyValuePair<DateTime, List<PlanAppoint>> pair
                        = (KeyValuePair<DateTime, List<PlanAppoint>>)tag;

                    SelectNode(pair.Key);
                }
            }

            appointListTree.ExpandAll();
        }

        private TreeNode CreateNode(KeyValuePair<DateTime, List<PlanAppoint>> pair)
        {
            TreeNode node = new TreeNode("");

            string text = pair.Key.ToShortDateString();
            node.Text = text;

            foreach (PlanAppoint appoint in pair.Value)
                node.Nodes.Add(CreateNode(appoint));

            node.ForeColor = Color.Blue;
            node.Tag = pair;

            return node;
        }

        private void bgSetAppointSeen_DoWork(object sender, DoWorkEventArgs e)
        {
            SeenParameters parameters = (SeenParameters)e.Argument;

            parameters.PlanAppoint.SetSeen(parameters.Database);
        }

        private void refreshTool_Click(object sender, EventArgs e)
        {
            tboxSearch.Clear();
            ForceRefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ForceRefreshData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dateStart = dateStart.AddMonths(-1);
            if (dateStart <= EntryControlDatabase.MinimalDate)
                pnlNext.Visible = false;
            ForceRefreshData();
        }

        private void tboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSearch_Click(sender, EventArgs.Empty);
        }

        private void changePasswordTool_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(Database);
            form.ShowDialog();
        }

        private void printTool_Click(object sender, EventArgs e)
        {
            ReportPlanAppointForm form = new ReportPlanAppointForm(Database);
            form.Show();
        }

        



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EPV.DataItem;
using System.Reflection;

namespace EntryControl
{
    public partial class ListForm : EntryControlForm
    {
        #region Конструкторы      

        private ListForm()
            : base()
        {
            InitializeComponent();
        }

        public ListForm(Database database)
            : this(database, true)
        {
        }

        public ListForm(Database database, bool forSelection)
            : base(database)
        {
            InitializeComponent();
            isForSelection = forSelection;
        }

        #endregion

        #region Свойства

        private bool isForSelection;


        private DataItem selectedItem;

        public DataItem SelectedItem
        {
            get
            {
                if (bsList.DataSource != null)
                    return (DataItem)bsList.Current;

                return null;
            }

            set
            {
                selectedItem = value;
            }
        }

        public string EditItemForm { get; set; }

        #endregion

        #region Обработчики событий
        
        private void ListForm_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
        
            PreloadData();
            DisplayComponent();
            AddColumns();

            RefreshData();

            if (selectedItem != null)
                SetSelected(selectedItem);
        }

        private void SetSelected(DataItem item)
        {
            if (bsList.DataSource != null && bsList.Contains(item))
                bsList.Position = bsList.IndexOf(item);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RaiseItemSelected();
        }

        private void onItemSaved(object sender, EventArgs e)
        {
            RefreshData();
            SetSelected((DataItem)sender);
        }

        #region listTools

        private void toolAddItem_Click(object sender, EventArgs e)
        {
            CreateNewItem();
        }

        private void toolEditItem_Click(object sender, EventArgs e)
        {
            EditCurrentItem();
        }

        private void toolDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteCurrentItem();
        }

        private void toolRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        #endregion

        #endregion

        #region Методы

        protected void RefreshData()
        {
            DataItem item = SelectedItem;

            bsList.Clear();
            bsList.DataSource = LoadList();

            if (item != null)
                SetSelected(item);
        }

        private void DisplayComponent()
        {
            if (pnlTop.Controls.Count == 0)
                pnlTop.Height = 0;

            btnOK.Visible = isForSelection;

         }

        #region Методы, требующие переопределения
        
        protected virtual object LoadList()
        {
            throw new NotImplementedException("LoadList method");
        }

        protected virtual void AddColumns()
        {
            throw new NotImplementedException("AddColumns method");
        }

        protected virtual void PreloadData()
        {
        }

        #endregion

        protected virtual void CreateNewItem()
        {
            if (!string.IsNullOrEmpty(EditItemForm))
            {
                DataItemForm form = CreateForm(EditItemForm);
                if (form != null)
                {
                    form.Show();
                }
            }
            else
            {
                throw new NotImplementedException("EditItemForm property");
            }
        }

        private DataItemForm CreateForm(string EditItemForm)
        {
            Type type = Assembly.GetEntryAssembly().GetType(EditItemForm);


            if (type == null || (type.BaseType.Name != "DataItemForm"))
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongDataItemForm);

            ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(Database) });

            if (constructor != null)
            {
                DataItemForm form = (DataItemForm)constructor.Invoke(new object[] { Database });
                form.ItemSaved += onItemSaved;
                return form;
            }

            return null;
        }


        private void EditCurrentItem()
        {
            if (SelectedItem != null)
            {
                if (!string.IsNullOrEmpty(EditItemForm))
                {
                    DataItemForm form = CreateForm(EditItemForm);
                    if (form != null)
                    {
                        form.Item = (DataItem)CreateItemCopy(SelectedItem);
                        form.Show();
                    }
                }
                else
                {
                    throw new NotImplementedException("EditItemForm property");
                }
            }
        }

        private object CreateItemCopy(object item)
        {
            MethodInfo method = item.GetType().GetMethod("LoadCopy", new Type[] { typeof(Database) });

            if (method != null)
            {
                return (DataItem)method.Invoke(item, new object[] { Database });

            }
            else
            {
                return item;
            }
        }


        private void DeleteCurrentItem()
        {
            if (SelectedItem != null
                && MessageBox.Show(EntryControl.Resources.Message.Question.Delete,
                                    SelectedItem.ToString(), MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteItem(SelectedItem);
        }

        private void DeleteItem(DataItem item)
        {
            bsList.Remove(item);
            item.Delete();
            item.Save(Database);
        }

        #region Колонки

        protected DataGridViewColumn AddTextBoxColumn(string headerText, string dataProperty, int width)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = headerText;
            column.DataPropertyName = dataProperty;
            column.Width = width;
            column.Name = "Column" + dataProperty;

            dgvList.Columns.Add(column);

            return column;
        }

        protected DataGridViewColumn AddTextBoxColumn(string headerText, string dataProperty)
        {
            return AddTextBoxColumn(headerText, dataProperty, 100);
        }

        protected DataGridViewColumn AddCheckBoxColumn(string headerText, string dataProperty)
        {
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            column.HeaderText = headerText;
            column.DataPropertyName = dataProperty;
            column.Width = 25;
            column.Name = "Column" + dataProperty;

            dgvList.Columns.Add(column);

            return column;
        }

        #endregion

        #endregion

        private EventHandler onItemSelected;

        public event EventHandler ItemSelected
        {
            add { onItemSelected += value; }
            remove { onItemSelected -= value; }
        }

        private void RaiseItemSelected()
        {
            if (onItemSelected != null)
                onItemSelected(SelectedItem, EventArgs.Empty);

            Close();
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isForSelection)
                RaiseItemSelected();
            else
                EditCurrentItem();
        }

        private void dgvList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex < bsList.Count)
            {
                if (dgvList.CurrentCell != null
                    && dgvList.CurrentCell.ColumnIndex == e.ColumnIndex)
                {
                    e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
                    e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                }

                e.PaintBackground(e.ClipBounds, true);

                Brush searchedBrush = new SolidBrush(Color.LightGreen);
                if (searchingText.Length > 0
                    && e.Value != null
                    && e.Value.ToString().StartsWith(searchingText, StringComparison.InvariantCultureIgnoreCase))
                {
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    string text = e.Value.ToString().Substring(0, searchingText.Length);
                    Font font = e.CellStyle.Font;
                    StringFormat strfrmt = new StringFormat();
                    strfrmt = StringFormat.GenericTypographic;
                    strfrmt.FormatFlags = StringFormatFlags.MeasureTrailingSpaces; 
                    SizeF size = e.Graphics.MeasureString(text, font, new Point(0, 0), strfrmt);
                    e.Graphics.FillRectangle(searchedBrush, new RectangleF(e.CellBounds.X + 2, e.CellBounds.Y + 2, 
                                                                                    size.Width - 2, e.CellBounds.Height - 5));

                }

                Pen pen = new Pen(dgvList.DefaultCellStyle.SelectionBackColor);
                if (dgvList.CurrentCell != null
                    && dgvList.CurrentCell.ColumnIndex == e.ColumnIndex
                    && (e.State & DataGridViewElementStates.Selected) > 0)
                    e.Graphics.DrawRectangle(pen, new Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1,
                                                                        e.CellBounds.Width - 4, e.CellBounds.Height - 4));

                e.PaintContent(e.CellBounds);

                e.Handled = true;

            }
        }

        private void tboxSearchTool_TextChanged(object sender, EventArgs e)
        {
            if (tboxSearchTool.Text.Length > 0)
            {
               if (!FindTextInDgv(tboxSearchTool.Text))
               {
                   System.Media.SystemSounds.Exclamation.Play();
                   tboxSearchTool.ForeColor = Color.Red;
               }
               else
               {
                   tboxSearchTool.ForeColor = SystemColors.WindowText;
               }
            }
        }

        private bool FindTextInDgv(string text)
        {
            return FindTextInDgv(text, 0, 0);

        }

        private bool FindTextInDgv(string text, int startRow, int startColumn)
        {
            for (int i = startRow; i < dgvList.Rows.Count; i++)
            {
                int loopStart = 0;
                if (i == startRow) loopStart = startColumn + 1;


                for (int j = loopStart; j < dgvList.Columns.Count; j++)
                {
                if (!dgvList.Columns[j].Visible) continue;
                    if (dgvList[j, i].Value != null)
                    {
                        string cellText = dgvList[j, i].Value.ToString();
                        if (cellText.ToLower().Contains(text.ToLower()))
                        {
                            dgvList.CurrentCell = dgvList[j, i];
                            return true;
                        }
                    }
                }
            }

            for (int i = 0; i <= startRow; i++)
            {
                for (int j = 0; j < dgvList.Columns.Count; j++)
                {
                    if (dgvList[j, i].Value != null)
                    {
                        if (!dgvList.Columns[j].Visible) continue;

                        string cellText = dgvList[j, i].Value.ToString();
                        if (cellText.ToLower().Contains(text.ToLower()))
                        {
                            dgvList.CurrentCell = dgvList[j, i];
                            return true;
                        }
                    }
                }
            }

            return false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tboxSearchTool.Text.Length > 0)
            {
                if (!FindTextInDgv(tboxSearchTool.Text, dgvList.CurrentCell.RowIndex, dgvList.CurrentCell.ColumnIndex))
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    tboxSearchTool.ForeColor = Color.Red;
                }
                else
                {
                    tboxSearchTool.ForeColor = SystemColors.WindowText;
                }
            }
        }

        private string searchingText = "";
        private DataGridViewColumn searchedColumn;
        private DataGridViewCell searchedCell;

        private void dgvList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (searchedCell != dgvList[e.ColumnIndex, e.RowIndex])
            {
                searchedCell = null;
                searchingText = "";
                dgvList.Refresh();
            }

            searchedColumn = dgvList.Columns[e.ColumnIndex];
        }

        private void dgvList_KeyPress(object sender, KeyPressEventArgs e)
        {
            string newSearchingText = searchingText;
            
            if (dgvList.CurrentCell == null) return;
            if (e.KeyChar == (char)Keys.Back && searchingText.Length > 0)
                newSearchingText = newSearchingText.Substring(0, newSearchingText.Length - 1);
            else
                newSearchingText = newSearchingText + e.KeyChar;

            if (newSearchingText.Length == 0)
            {
                searchingText = "";
                dgvList.Refresh();
                return;
            }

            for (int i = dgvList.CurrentCell.RowIndex; i < dgvList.Rows.Count; i++)
            {
                if (dgvList[searchedColumn.Index, i].Value == null) continue;

                string cellText = dgvList[searchedColumn.Index, i].Value.ToString();
                if (cellText.StartsWith(newSearchingText, StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvList.CurrentCell = dgvList[searchedColumn.Index, 1];
                    searchingText = newSearchingText;
                    searchedCell = dgvList.CurrentCell;
                    dgvList.Refresh();
                    return;
                }
            }

            for (int i = 0; i < dgvList.CurrentCell.RowIndex; i++)
            {
                if (dgvList[searchedColumn.Index, i].Value == null) continue;

                string cellText = dgvList[searchedColumn.Index, i].Value.ToString();
                if (cellText.StartsWith(newSearchingText, StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvList.CurrentCell = dgvList[searchedColumn.Index, 1];
                    searchingText = newSearchingText;
                    searchedCell = dgvList.CurrentCell;
                    dgvList.Refresh();
                    return;
                }
            }

        }


    }
}

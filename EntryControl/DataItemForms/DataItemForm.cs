using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EPV.DataItem;

namespace EntryControl
{
    public partial class DataItemForm : EntryControlForm
    {
        #region Конструкторы

        private DataItemForm()
            : base()
        {
            InitializeComponent();
        }

        public DataItemForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        #endregion

        #region Поля и свойства

        public DataItem Item
        {
            get { return (DataItem)bsDataItem.DataSource; }
            set { bsDataItem.DataSource = value; }
        }

        #endregion

        #region Обработчики событий

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (SaveItem())
                Close();
        }

        private void DataItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Item.IsModified)
            {
                DialogResult result = MessageBox.Show(EntryControl.Resources.Message.Question.ItemIsModified,
                                                        Text, MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveItem();
                        e.Cancel = false;
                        break;

                    case DialogResult.No:
                        e.Cancel = false;
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void DataItemForm_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            PreloadData();

        }

        
       
        #endregion

        #region Методы

        protected virtual bool SaveItem()
        {
            WrapAction(Database, Item.Save);
            RaiseItemSaved();

            return true;
        }

        protected virtual DataItem CreateNewDataItem()
        {
            throw new NotImplementedException("CreateDataItem method");
        }

        protected virtual void PreloadData()
        {
        }

        protected virtual void CreateDataBindings()
        {
            btnOk.DataBindings.Add("Enabled", bsDataItem, "IsModified");
            btnSave.DataBindings.Add("Enabled", bsDataItem, "IsModified");

            Text = Item.ToString();
        }

        protected void MarkAsModified()
        {
            Item.MarkAsModified();
        }

        #endregion

        #region События 

        #region событие ItemSaved
        
        private EventHandler onItemSaved;

        public event EventHandler ItemSaved
        {
            add { onItemSaved += value; }
            remove { onItemSaved -= value; }
        }

        private void RaiseItemSaved()
        {
            if (onItemSaved != null)
                onItemSaved(Item, EventArgs.Empty);
        }

        #endregion

        private void DataItemForm_Shown(object sender, EventArgs e)
        {
            if (DesignMode) return;

            if (Item == null)
                Item = CreateNewDataItem();
            CreateDataBindings();
        }

        #endregion
    }
}

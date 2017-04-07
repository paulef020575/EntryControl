using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EPV.DataItem;
using System.Reflection;

namespace EntryControl
{
    public partial class ReferenceBox : UserControl, INotifyPropertyChanged
    {
        #region Конструктор
        
        public ReferenceBox()
        {
            InitializeComponent();
            tboxValue.DataBindings.Add("Text", this, "SelectedItem", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        #endregion

        #region Свойства и поля
        
        public Database Database
        {
            get;
            set;
        }

        private DataItem selectedObject;

        public DataItem SelectedItem
        {
            get { return selectedObject; }
            set
            {
                selectedObject = value;
                RaisePropertyChanged("SelectedItem");
                RaiseSelectedItemChanged();
            }
        }

        public object DataSource
        {
            get { return bsList.DataSource; }
            set
            {
                bsList.DataSource = value;
            }
        }

        public string ListForm { get; set; }

        #endregion

        private void RefreshAutoCompleteSource()
        {
            if (DataSource != null)
            {
                AutoCompleteStringCollection autoCompleteList = new AutoCompleteStringCollection();

                foreach (object item in bsList)
                    autoCompleteList.Add(item.ToString());

                tboxValue.AutoCompleteCustomSource = autoCompleteList;
            }
        }


        private void btnShowListForm_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(ListForm))
                {
                    ListForm form = CreateListForm(ListForm);
                    form.SelectedItem = SelectedItem;
                    RaiseShowListForm(form);
                    form.Show();
                }
                else
                {
                    throw new NotImplementedException("ListForm property");
                }
        }

        private ListForm CreateListForm(string formTypeName)
        {
            if (Database == null)
                throw new NotImplementedException("Database property");

            Type type = Assembly.GetEntryAssembly().GetType(formTypeName);


            if (type == null || (type.BaseType.Name != "ListForm"))
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongListForm);

            ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(Database) });

            if (constructor != null)
            {
                ListForm form = (ListForm)constructor.Invoke(new object[] { Database });
                form.ItemSelected += new EventHandler(formItemSelected);
                return form;
            }

            return null;
        }

        void formItemSelected(object sender, EventArgs e)
        {
            DataSource = RaiseGetList();
            SelectedItem = (DataItem)sender;
        }

        #region События

        public class ReferenceBoxEventArgs : EventArgs
        {
            public ReferenceBoxEventArgs() : base() { }

            public ReferenceBoxEventArgs(ListForm form)
                : base()
            {
                Form = form;
            }

            public object ItemList { get; set; }

            public ListForm Form { get; private set; }
        }

        private EventHandler<ReferenceBoxEventArgs> onGetList;

        public event EventHandler<ReferenceBoxEventArgs> GetList
        {
            add { onGetList += value; }
            remove { onGetList -= value; }
        }

        private object RaiseGetList()
        {
            if (onGetList != null)
            {
                ReferenceBoxEventArgs e = new ReferenceBoxEventArgs();
                onGetList(this, e);
                return e.ItemList;
            }

            return null;
        }

        private EventHandler<ReferenceBoxEventArgs> onShowListForm;

        public event EventHandler<ReferenceBoxEventArgs> ShowListForm
        {
            add { onShowListForm += value; }
            remove { onShowListForm -= value; }
        }

        private void RaiseShowListForm(ListForm form)
        {
            if (onShowListForm != null)
                onShowListForm(this, new ReferenceBoxEventArgs(form)); 
        }
            

        #endregion

        private void tboxValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tboxValue.Text))
            {
                SelectedItem = null;
                e.Cancel = false;
                return;
            }

            if (DataSource != null)
            {
                foreach (DataItem item in bsList)
                {
                    if (string.Equals(item.ToString(), tboxValue.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        SelectedItem = item;
                        e.Cancel = false;
                        return;
                    }
                }
            }

            if (SelectedItem != null)
                tboxValue.Text = SelectedItem.ToString();
            else
                tboxValue.Clear();
            e.Cancel = false;

        }

        private void ReferenceBox_Load(object sender, EventArgs e)
        {
            DataSource = RaiseGetList();
        }

        private void bsList_DataSourceChanged(object sender, EventArgs e)
        {
            RefreshAutoCompleteSource();
        }



        private PropertyChangedEventHandler onPropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (SelectedItem != null)
                tboxValue.Text = SelectedItem.ToString();
            else
                tboxValue.Clear();
            //if (onPropertyChanged != null)
            //    onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private EventHandler onSelectedItemChanged;

        public event EventHandler SelectedItemChanged
        {
            add { onSelectedItemChanged += value; }
            remove { onSelectedItemChanged -= value; }
        }

        private void RaiseSelectedItemChanged()
        {
            if (onSelectedItemChanged != null)
                onSelectedItemChanged(this, EventArgs.Empty);
        }
    }
}


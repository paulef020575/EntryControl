using EntryControl.Classes.Ref;
using EPV.Database;
using EPV.DataItem;

namespace EntryControl.DataItemForms
{
    public partial class BlackListItemForm : DataItemForm
    {
        public BlackListItemForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public BlackList BlackList
        {
            get => (BlackList)Item;
            set => Item = value;
        }

        protected override DataItem CreateNewDataItem()
        {
            return new BlackList();
        }

        protected override void CreateDataBindings()
        {
            base.CreateDataBindings();

            tboxText.DataBindings.Add(nameof(tboxText.Text), bsDataItem, nameof(BlackList.Text));
        }
    }
}

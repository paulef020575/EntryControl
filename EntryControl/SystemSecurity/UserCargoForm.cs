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
    public partial class UserCargoForm : EntryControlForm
    {
        private UserCargoForm()
            : base()
        {
            InitializeComponent();
        }

        public UserCargoForm(Database database)
            : base(database)
        {
            InitializeComponent();
        }

        public User User { get; set; }

        public BindingList<UserCargo> List { get { return (BindingList<UserCargo>)bsList.DataSource; } }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveList();
            Close();
        }

        private void SaveList()
        {
            Connection connection = Database.OpenConnection();

            foreach (UserCargo cargo in List)
                cargo.Save(connection);

            connection.Commit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserCargoForm_Load(object sender, EventArgs e)
        {
            Text = User.ToString();

            bsList.DataSource = UserCargo.LoadList(Database, User);
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (UserCargo cargo in List)
                cargo.IsIncluded = true;

            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (UserCargo cargo in List)
                cargo.IsIncluded = false;

            dataGridView1.Refresh();
        }
    }
}

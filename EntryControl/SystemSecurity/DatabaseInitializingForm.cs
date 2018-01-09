using EntryControl.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EntryControl
{
    public partial class DatabaseInitializingForm : Form
    {
        public DatabaseInitializingForm()
        {
            InitializeComponent();
        }

        private void DatabaseInitializingForm_Load(object sender, EventArgs e)
        {
            FillServerList();
            tboxServer.Text = Settings.Default.ServerName;
            tboxDatabase.Text = Settings.Default.Path;
        }

        private void FillServerList()
        {
            AutoCompleteStringCollection serverList = new AutoCompleteStringCollection();

            string fileName = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "servers.txt");

            if (File.Exists(fileName))
            {
                string[] list = File.ReadAllLines(fileName);

                foreach (string line in list)
                    serverList.Add(line);

                tboxServer.AutoCompleteCustomSource = serverList;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.Default.ServerName = tboxServer.Text;
            Settings.Default.Path = tboxDatabase.Text;

            Settings.Default.Save();
        }
    }
}

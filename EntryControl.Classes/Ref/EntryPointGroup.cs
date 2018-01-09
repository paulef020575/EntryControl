using EPV.Database;
using EPV.DataItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Text;

namespace EntryControl.Classes
{
    public class EntryPointGroup : INotifyPropertyChanged
    {
        #region Properties

        public string GroupName { get; private set; }

        public EntryPoint EntryPoint { get; private set; }

        private bool isIncluded;
        public bool IsIncluded
        {
            get { return isIncluded; }
            set
            {
                if (isIncluded != value)
                    isIncluded = value;
                OnPropertyChanged("IsIncluded");
            }
        }

        #endregion

        #region Constructor

        public EntryPointGroup(string groupName, DbDataReader reader)
        {
            GroupName = groupName;
            EntryPoint = new Classes.EntryPoint(reader);
            IsIncluded = !DBNull.Value.Equals(reader["groupName"]);
        }

        #endregion

        #region Methods

        public static List<string> LoadGroupList(Database database)
        {
            string query = EntryControl.Resources.Ref.EntryPoint.LoadGroups;

            List<string> groupList = new List<string>();

            using (DbDataReader reader = database.ExecuteReader(query))
            {
                while (reader.Read())
                    groupList.Add((string)reader["groupName"]);

                reader.Close();
            }

            return groupList;
        }

        public static List<EntryPointGroup> LoadGroup(Database database, string groupName)
        {
            string query = EntryControl.Resources.Ref.EntryPoint.LoadGroupList;
            QueryParameters parameters = new QueryParameters("groupName", groupName);

            List<EntryPointGroup> groupPointList = new List<Classes.EntryPointGroup>();

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    groupPointList.Add(new EntryPointGroup(groupName, reader));

                reader.Close();
            }

            return groupPointList;
        }

        public static void ClearGroup(Database database, string groupName)
        {
            string query = EntryControl.Resources.Ref.EntryPoint.ClearGroup;
            QueryParameters parameters = new QueryParameters("groupName", groupName);
            database.ExecuteQuery(query, parameters);
        }

        public static void Save(Database database, IEnumerable<EntryPointGroup> items)
        {
            using (Connection connection = database.OpenConnection())
            {
                string query = EntryControl.Resources.Ref.EntryPoint.SetPointGroup;
                QueryParameters parameters = new QueryParameters("groupName", "");
                parameters.Add("pointId", 0);
                parameters.Add("isIncluded", 0);

                foreach (EntryPointGroup item in items)
                {
                    parameters["groupName"] = item.GroupName;
                    parameters["pointId"] = item.EntryPoint.Id;
                    parameters["isIncluded"] = (item.IsIncluded ? 1 : 0);

                    connection.ExecuteQuery(query, parameters);
                }

                connection.Commit();
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        private PropertyChangedEventHandler onPropetyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { onPropetyChanged += value; }
            remove { onPropetyChanged -= value; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (onPropetyChanged != null)
                onPropetyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

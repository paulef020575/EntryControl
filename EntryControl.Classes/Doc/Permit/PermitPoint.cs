using EPV.Database;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Text;

namespace EntryControl.Classes
{
    public class PermitPoint : INotifyPropertyChanged
    {
        #region Свойства

        public Permit Permit { get; private set; }

        public EntryPoint Point { get; private set; }

        private bool isAllowed;


        public bool IsAllowed
        {
            get { return isAllowed; }
            set
            {
                if (isAllowed != value)
                {
                    isAllowed = value;
                    OnPropertyChanged("IsAllowed");
                }
            }
        }

        #endregion

        #region Конструкторы

        public PermitPoint(Permit permit, DbDataReader reader)
        {
            Permit = permit;
            Point = new Classes.EntryPoint((int)reader["pointid"], (string)reader["pointName"]);
            isAllowed = ((int)reader["isAllowed"]) > 0;
        }

        #endregion

        #region Методы

        public static List<PermitPoint> LoadPointList(Database database, Permit permit)
        {
            List<PermitPoint> pointList = new List<Classes.PermitPoint>();

            string query = EntryControl.Resources.Doc.Permit.GetPermitPointList;
            QueryParameters parameters = new QueryParameters("permit", permit.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    pointList.Add(new Classes.PermitPoint(permit, reader));

                reader.Close();
            }

            return pointList;

        }

        public static void SavePointList(Database database, List<PermitPoint> pointList)
        {
            string query = EntryControl.Resources.Doc.Permit.SetPermitPoint;

            using (FbConnection connection = new FbConnection(database.ConnectionString))
            {
                FbCommand command = new FbCommand(query, connection);
                command.Parameters.AddWithValue("permit", 0);
                command.Parameters.AddWithValue("point", 0);
                command.Parameters.AddWithValue("isAllowed", 0);

                connection.Open();
                FbTransaction transaction = connection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                try
                {
                    foreach (PermitPoint pp in pointList)
                    {
                        command.Parameters["permit"].Value = pp.Permit.Id;
                        command.Parameters["point"].Value = pp.Point.Id;
                        command.Parameters["isAllowed"].Value = (short)(pp.IsAllowed ? 1 : 0);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    connection.Close();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    connection.Close();
                    throw new Exception(EntryControl.Resources.Message.Error.SavingError);
                }

            }
        }

        public static void SavePointList(Connection connection, List<PermitPoint> pointList)
        {
            string query = EntryControl.Resources.Doc.Permit.SetPermitPoint;

            QueryParameters parameters = new QueryParameters("permit", 0);
            parameters.Add("point", 0);
            parameters.Add("isAllowed", 0);

            foreach (PermitPoint pp in pointList)
            {
                parameters["permit"] = pp.Permit.Id;
                parameters["point"] = pp.Point.Id;
                parameters["isAllowed"] = (short)(pp.IsAllowed ? 1 : 0);

                connection.ExecuteQuery(query, parameters);
            }
        }

        #endregion

        private PropertyChangedEventHandler onPropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (onPropertyChanged != null)
                onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

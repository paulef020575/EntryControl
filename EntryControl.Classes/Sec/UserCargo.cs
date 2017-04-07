using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using EPV.Database;
using System.ComponentModel;

namespace EntryControl.Classes
{
    public class UserCargo
    {
        public User User { get; private set; }

        public Cargo Cargo { get; private set; }

        public bool IsIncluded { get; set; }

        public UserCargo(User user, DbDataReader reader)
        {
            User = user;
            Cargo = new Cargo((int)reader["id"], (string)reader["name"]);
            IsIncluded = ((int)reader["cnt"] > 0);
        }

        public static BindingList<UserCargo> LoadList(Database database, User user)
        {
            BindingList<UserCargo> list = new BindingList<UserCargo>();

            string query = EntryControl.Resources.Sec.User.CargoLoadList;
            QueryParameters parameters = new QueryParameters("userId", user.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    list.Add(new UserCargo(user, reader));

                reader.Close();
            }

            return list;
        }

        public void Save(Connection connection)
        {
            if (IsIncluded)
                SaveIncluded(connection);
            else
                Delete(connection);
        }

        private void SaveIncluded(Connection connection)
        {
            string query = EntryControl.Resources.Sec.User.CargoSave;
            QueryParameters parameters = new QueryParameters("userId", User.Id);
            parameters.Add("cargoId", Cargo.Id);

            connection.ExecuteQuery(query, parameters);
        }

        private void Delete(Connection connection)
        {
            string query = EntryControl.Resources.Sec.User.CargoDelete;
            QueryParameters parameters = new QueryParameters("userId", User.Id);
            parameters.Add("cargoId", Cargo.Id);

            connection.ExecuteQuery(query, parameters);
        }
    }
}

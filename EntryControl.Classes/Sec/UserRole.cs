using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class UserRole
    {
        #region Поля и свойства

        private User User;

        public EnumerationItem Role { get; private set; }

        public bool IsIncluded { get; set; }

        #endregion

        #region Конструктор

        private UserRole() { }
    
        public UserRole(User user, Enumeration roleList, DbDataReader reader)
        {
            User = user;
            Role = roleList[(int)reader["id"]];
            IsIncluded = ((int)reader["cnt"] > 0);
        }

        #endregion

        #region Методы

        public static List<UserRole> LoadList(Database database, User user)
        {
            List<UserRole> list = new List<UserRole>();

            Enumeration roleList = new Enumeration(database, "userRole");

            string query = EntryControl.Resources.Sec.User.RoleLoadList;
            QueryParameters parameters = new QueryParameters("userId", user.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    list.Add(new UserRole(user, roleList, reader));

                reader.Close();
            }

            return list;
        }

        public void Save(Connection connection)
        {
            string query = EntryControl.Resources.Sec.User.RoleSave;

            if (!IsIncluded)
                query = EntryControl.Resources.Sec.User.RoleDelete;

            QueryParameters parameters = new QueryParameters("userId", User.Id);
            parameters.Add("userRole", Role.Id);

            connection.ExecuteQuery(query, parameters);
        }

        #endregion

    }
}

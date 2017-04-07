using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class User : DataItem
    {
        #region Поля и свойства

        private string lastname;
        /// <summary>
        ///     Фамилия
        /// </summary>
        [DataField("lastname")]
        public string Lastname
        {
            get { return lastname; }
            set { SetField("lastname", value, 50); }
        }

        private string firstname;
        /// <summary>
        ///     имя
        /// </summary>
        [DataField("firstname")]
        public string Firstname
        {
            get { return firstname; }
            set { SetField("firstname", value, 50); }
        }

        private string secondname;
        [DataField("secondname")]
        public string Secondname
        {
            get { return secondname; }
            set { SetField("secondname", value, 50); }
        }

        public string FullName
        {
            get
            {
                string fullName = Lastname;

                if (Firstname.Length > 0)
                {
                    fullName = fullName + " " + Firstname.Substring(0, 1) + ".";

                    if (Secondname.Length > 0)
                    {
                        fullName = fullName + " " + Secondname.Substring(0, 1) + ".";
                    }
                }

                return fullName;
            }
        }

        public DateTime DateRegistration { get; private set; }

        private short locked;
        [DataField("isLocked")]
        public short Locked
        {
            get { return locked; }
            set { SetField("locked", value); }
        }

        public bool IsLocked
        {
            get { return (Locked > 0); }
            set 
            {
                Locked = (short)(value ? 1 : 0);
                RaisePropertyChanged("IsLocked");
            }
        }




        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Sec.User.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Sec.User.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Sec.User.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Sec.User.Delete;
            }
        }

        protected override string LoadQuery
        {
            get
            {
                return EntryControl.Resources.Sec.User.Load;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Sec.User.LoadList;
            }
        }

        #endregion

        #region Доменная информация

        private string domainName;

        public string DomainName
        {
            get { return domainName; }
            set
            {
                SetField("domainName", value);
            }
        }


        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                SetField("userName", value);
            }
        }

        private bool isDomainUser;

        public bool IsDomainUser 
        {
            get { return isDomainUser; }
            set
            {
                isDomainUser = value;
                RaisePropertyChanged("IsDomainUser");
            }
        }

        #endregion

        private List<UserRole> roleList;

        public static User Empty { get { return new User(0, "Unknown"); } }

        #endregion

        #region Конструкторы

        public User() : base() { }

        public User(int id, string name) : base(id, name) { }

        public User(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        protected override void InitializeProperties()
        {
            lastname = "Фамилия";
            firstname = "Имя";
            secondname = "Отчество";
            locked = 0;
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            lastname = (string)reader["lastname"];
            firstname = (string)reader["firstname"];
            secondname = (string)reader["secondname"];
            locked = (short)reader["isLocked"];
        }

        protected override string StringDescription()
        {
            return FullName;
        }

        public static User LoadUser(Database database, int id)
        {
            User user = null;

            string query = EntryControl.Resources.Sec.User.Load;
            QueryParameters parameters = new QueryParameters("id", id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                    user = new User(reader);

                reader.Close();
            }

            if (user == null)
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return user;
        }

        public User LoadCopy(Database database)
        {
            return User.LoadUser(database, Id);
        }

        public static List<User> LoadList(Database database)
        {
            List<User> userList = new List<User>();

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    userList.Add(new User(reader));
            }

            return userList;
        }

        public static List<User> LoadList(Database database, Unit unit, int groupId)
        {
            List<User> userList = new List<User>();
            string query = EntryControl.Resources.Ref.Unit.UserList;
            QueryParameters parameters = new QueryParameters("unitId", unit.Id);
            parameters.Add("roleId", groupId);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    userList.Add(new User(reader));
                reader.Close();
            }

            return userList;
        }

        #endregion

        public void LoadDomainInfo(Database database)
        {
            string query = EntryControl.Resources.Sec.User.GetDomainUser;
            QueryParameters parameters = new QueryParameters("id", Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    isDomainUser = true;
                    domainName = (string)reader["domainName"];
                    userName = (string)reader["userName"];
                }
                else
                {
                    isDomainUser = false;
                    domainName = "";
                    userName = "";
                }

                NotifyDomainInfoChanged();

                reader.Close();
            }
        }

        private void NotifyDomainInfoChanged()
        {
            RaisePropertyChanged("IsDomainUser");
            RaisePropertyChanged("DomainName");
            RaisePropertyChanged("UserName");
        }

        public List<UserRole> GetRoleList(Database database)
        {
            if (roleList == null)
                roleList = UserRole.LoadList(database, this);

            return roleList;
        }

        protected override void SaveChildren(Connection connection)
        {
            SaveDomainInfo(connection);
            SaveRoleList(connection);
        }

        private void SaveDomainInfo(Connection connection)
        {
            if (IsDomainUser)
                SetDomainInfo(connection);
            else
                ClearDomainInfo(connection);
        }

        private void SetDomainInfo(Connection connection)
        {
            string query = EntryControl.Resources.Sec.User.SetDomainUser;
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("domainName", DomainName);
            parameters.Add("userName", UserName);

            connection.ExecuteQuery(query, parameters);
        }

        private void ClearDomainInfo(Connection connection)
        {
            string query = EntryControl.Resources.Sec.User.ClearDomainUser;
            QueryParameters parameters = new QueryParameters("id", Id);

            connection.ExecuteQuery(query, parameters);
        }

        private void SaveRoleList(Connection connection)
        {
            if (roleList != null)
                foreach (UserRole role in roleList)
                    role.Save(connection);
        }

        public static User GetDomainUser(Database database, string domainName, string userName)
        {
            string query = EntryControl.Resources.Sec.User.GetUserId;
            QueryParameters parameters = new QueryParameters("domainName", domainName);
            parameters.Add("userName", userName);

            object result = database.ExecuteScalar(query, parameters);
            if (result != null)
                return User.LoadUser(database, (int)result);
            else
                return null;
        }

        public bool CheckPassword(EntryControlDatabase database, string password)
        {
            string query = EntryControl.Resources.Sec.User.CheckPassword;
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("password", password);

            return (database.ExecuteScalar(query, parameters) != null);
        }

        public bool CheckRole(EntryControlDatabase database, int role)
        {
            string query = EntryControl.Resources.Sec.User.CheckRole;
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("role", role);

            return (database.ExecuteScalar(query, parameters) != null);
        }

        public void SetPassword(Database database, string newPassword)
        {
            string query = EntryControl.Resources.Sec.User.SetPassword;
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("password", newPassword);

            database.ExecuteQuery(query, parameters);
        }
    }
}

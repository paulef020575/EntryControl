using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class EntryPoint : DataItem
    {
        #region Поля и свойства

        private string name;
        [DataField("name")]
        public string Name
        {
            get { return name; }
            set { SetField("name", value, 50); }
        }

        private string phone;
        [DataField("phone")]
        public string Phone
        {
            get { return phone; }
            set { SetField("phone", value, 25); }
        }

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Ref.EntryPoint.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Ref.EntryPoint.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Ref.EntryPoint.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Ref.EntryPoint.Delete;
            }
        }

        public static string LoadQuery
        {
            get
            {
                return EntryControl.Resources.Ref.EntryPoint.Load;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Ref.EntryPoint.LoadList;
            }
        }

        #endregion

        public static EntryPoint Empty { get { return new EntryPoint(0, "ВСЕ"); } }

        private List<Staff> staffList;

        #endregion

        #region Конструкторы

        public EntryPoint() : base() { }

        public EntryPoint(int id, string descr) : base(id, descr) { }

        public EntryPoint(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        #region Переопределенные

        protected override void InitializeProperties()
        {
            name = "Пункт пропуска";
            phone = "";
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            name = (string)reader["name"];
            phone = (string)reader["phone"];
        }

        protected override string StringDescription()
        {
            return Name;
        }

        #endregion

        public EntryPoint LoadCopy(Database database)
        {
            return Load(database, Id);
        }

        public static List<EntryPoint> LoadList(Database database)
        {
            List<EntryPoint> list = new List<EntryPoint>();

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    list.Add(new EntryPoint(reader));

                reader.Close();
            }

            return list;
        }

        public static EntryPoint Load(Database database, int id)
        {
            EntryPoint entryPoint = null;

            QueryParameters parameters = new QueryParameters("id", id);

            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    entryPoint = new EntryPoint(reader);

                reader.Close();
            }

            if (entryPoint == null)
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return entryPoint;
        }

        public List<Staff> GetStaffList(Database connection, Dictionary<int, Staff> fullStaff)
        {
            if (staffList == null)
            {
                staffList = new List<Staff>();

                string query = EntryControl.Resources.Ref.EntryPoint.StaffList;
                QueryParameters parameters = new QueryParameters("entryPoint", this.Id);
                parameters.Add("date", DateTime.Now);

                using (DbDataReader reader = connection.ExecuteReader(query, parameters))
                {
                    while (reader.Read())
                    {
                        Staff staff = fullStaff[(int)reader["staff"]];
                        staffList.Add(staff);
                        fullStaff.Remove(staff.Id);
                    }

                    reader.Close();
                }
            }

            return staffList;
        }

        public void AddStaff(Connection connection, Staff staff, DateTime date)
        {
            if (staffList != null)
            {
                string query = EntryControl.Resources.Ref.EntryPoint.AddStaff;
                QueryParameters parameters = new QueryParameters("entryPoint", this.Id);
                parameters.Add("staff", staff.Id);
                parameters.Add("date", date);

                connection.ExecuteQuery(query, parameters);

                staffList.Add(staff);
            }
        }

        public void RemoveStaff(Connection connection, Staff staff, DateTime date)
        {
            if (staffList != null)
            {
                string query = EntryControl.Resources.Ref.EntryPoint.RemoveStaff;
                QueryParameters parameters = new QueryParameters("entryPoint", this.Id);
                parameters.Add("staff", staff.Id);
                parameters.Add("date", date);

                connection.ExecuteQuery(query, parameters);

                staffList.Remove(staff);
            }
        }

        public override void Save(Database database)
        {
            if (rowState == RowState.Deleted && Id == 0)
            {
                ClearModified();
                throw new ArgumentException("Этот элемент удалять нельзя!!!");
            }
            base.Save(database);
        }

        #endregion


    }
}

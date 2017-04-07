using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class Staff : DataItem
    {
        #region Поля и свойства

        private string code;
        [DataField("code")]
        public string Code
        {
            get { return code; }
            set { SetField("code", value, 10); }
        }

        private string lastname;
        [DataField("lastname")]
        public string Lastname
        {
            get { return lastname; }
            set { SetField("lastname", value, 100); }
        }

        private string firstname;
        [DataField("firstname")]
        public string Firstname
        {
            get { return firstname; }
            set { SetField("firstname", value, 100); }
        }

        private string secondname;
        [DataField("secondname")]
        public string Secondname
        {
            get { return secondname; }
            set { SetField("secondname", value, 100); }
        }

        [DataField("isFired")]
        public short Fired { get; private set; }

        public bool IsFired
        {
            get { return (Fired > 0); }
            set
            {
                if ((Fired == 0 && value) || (Fired > 0 && !value))
                {
                    Fired = (short)(value ? 1 : 0);
                    RaisePropertyChanged("IsFired");
                    MarkAsModified();
                }
            }
        }

        public string Fullname
        {
            get { return Lastname + " " + Firstname + " " + Secondname; }
        }

        public string Shortname
        {
            get
            {
                string shortname = Lastname;

                if (Firstname.Length > 0)
                {
                    shortname += " " + Firstname.Substring(0, 1) + ".";
                    if (Secondname.Length > 0)
                        shortname += " " + Secondname.Substring(0, 1) + ".";
                }

                return shortname;
            }
        }


        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Ref.Staff.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Staff.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Staff.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Staff.Delete;
            }
        }

        private static string LoadQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Staff.Load;
            }
        }

        private static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Staff.LoadList;
            }
        }

        #endregion

        #endregion

        #region Конструторы

        public Staff() : base() { }

        public Staff(int id, string descr) : base(id, descr) { }

        public Staff(DbDataReader reader) : base(reader) { }


        #endregion

        #region Методы

        protected override void InitializeProperties()
        {
            code = "";
            lastname = "Новый сотрудник";
            firstname = "";
            secondname = "";
            Fired = 0;

            Description = lastname;
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            code = (string)reader["code"];
            lastname = (string)reader["lastname"];
            firstname = (string)reader["firstname"];
            secondname = (string)reader["secondname"];
            Fired = (short)reader["isFired"];
        }

        protected override string StringDescription()
        {
            return Shortname;
        }

        public static Staff Load(Database database, int id)
        {
            Staff staff = null;

            QueryParameters parameters = new QueryParameters("id", id);
            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    staff = new Staff(reader);

                reader.Close();
            }
            if (staff == null)
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return staff;
        }

        public Staff LoadCopy(Database database)
        {
            return Staff.Load(database, Id);
        }

        public static List<Staff> LoadList(Database database)
        {
            List<Staff> staffList = new List<Staff>();

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    staffList.Add(new Staff(reader));

                reader.Close();
            }

            return staffList;
        }

        public static List<Staff> LoadCurrentList(Database database)
        {
            List<Staff> staffList = new List<Staff>();

            string query = EntryControl.Resources.Ref.Staff.LoadCurrentList;

            using (DbDataReader reader = database.ExecuteReader(query))
            {
                while (reader.Read())
                    staffList.Add(new Staff(reader));

                reader.Close();
            }

            return staffList;
        }


        
        #endregion
    }
}

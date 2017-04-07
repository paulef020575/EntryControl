using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class Unit : DataItem
    {
        #region Поля и свойства

        private string name;
        [DataField("name")]
        public string Name
        {
            get { return name; }
            set { SetField("name", value, 50); }
        }

        private string code;
        [DataField("code")]
        public string Code
        {
            get { return code; }
            set { SetField("code", value, 10); }
        }

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Ref.Unit.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Unit.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Unit.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Unit.Delete;
            }
        }

        public static string LoadQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Unit.Load;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Unit.LoadList;
            }
        }

        #endregion

        #endregion

        #region Конструкторы

        public Unit() : base() { }

        public Unit(int id, string descr) : base(id, descr) { }

        public Unit(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        #region Переопределенные

        protected override void InitializeProperties()
        {
            Id = 0;
            name = "Новое подразделение";
            code = "";
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            Id = (int)reader["id"];
            name = (string)reader["name"];
            code = (string)(DBNull.Value.Equals(reader["code"]) ? "" : reader["code"]);
        }

        protected override string StringDescription()
        {
            string text = code;
            while (text.Length < 5)
                text += " ";

            return text + "  " + name;
        }

        #endregion

        public static Unit Load(Database database, int id)
        {
            Unit unit = null;

            QueryParameters parameters = new QueryParameters("id", id);
            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    unit = new Unit(reader);
                reader.Close();
            }

            if (unit == null)
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return unit;
        }

        public Unit LoadCopy(Database database)
        {
            return Load(database, Id);
        }

        public static List<Unit> LoadList(Database database)
        {
            List<Unit> unitList = new List<Unit>();
            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    unitList.Add(new Unit(reader));
                reader.Close();
            }

            return unitList;
        }

        public List<User> GetUserList(Database database, int groupId)
        {
            return User.LoadList(database, this, groupId);
        }

        #endregion
    }
}

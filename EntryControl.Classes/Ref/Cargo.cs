using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    /// <summary>
    ///     Класс "Вид груза"
    /// </summary>
    public class Cargo : DataItem
    {
        #region Свойства

        private string name;
        /// <summary>
        ///     Наименование группы
        /// </summary>
        [DataField("name")]
        public string Name
        {
            get { return name; }
            set { SetField("name", value, 50); }
        }

        #region Запросы

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Cargo.Insert;
            }
        }

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Ref.Cargo.GeneratorName;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Cargo.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Cargo.Delete;
            }
        }

        protected override string LoadQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Cargo.Load;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Cargo.LoadList;
            }
        }

        #endregion

        public static Cargo Empty { get { return new Cargo(1, "За бумагой"); } }

        #endregion

        #region Конструкторы

        public Cargo() : base() { }

        public Cargo(int id, string name) : base(id, name) { }

        public Cargo(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        protected override void InitializeProperties()
        {
            name = "Новый вид груза";
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            name = (string)reader["name"];
        }

        protected override string StringDescription()
        {
            return Name;
        }

        public Cargo LoadCopy(Database database)
        {
            Cargo cargo = Cargo.Empty;

            QueryParameters parameters = new QueryParameters("id", Id);

            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    cargo = new Cargo(reader);

                reader.Close();
            }

            if (cargo.Equals(Cargo.Empty))
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return cargo;
        }

        public static List<Cargo> LoadList(Database database)
        {
            List<Cargo> cargoList = new List<Cargo>();

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    cargoList.Add(new Cargo(reader));

                reader.Close();
            }

            return cargoList;
        }

        public static List<Cargo> LoadListForEntryPoint(Database database)
        {
            string query = EntryControl.Resources.Ref.Cargo.LoadListForEntryPoint;
            QueryParameters parameters = new QueryParameters("groupId", EntryControlDatabase.EntryPointEnabledCargoGroup);

            List<Cargo> cargoList = new List<Cargo>();

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    cargoList.Add(new Cargo(reader));

                reader.Close();
            }

            return cargoList;
        }

        #endregion
    }
}

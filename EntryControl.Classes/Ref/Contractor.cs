using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    /// <summary>
    ///     Класс "Контрагент"
    /// </summary>
    public class Contractor : DataItem
    {
        #region Поля и свойства

        private string name;
        /// <summary>
        ///     наименование
        /// </summary>
        [DataField("name")]
        public string Name
        {
            get { return name; }
            set { SetField("name", value, 300); }
        }

        private string shortName;
        /// <summary>
        ///     краткое наименование 
        /// </summary>
        [DataField("shortName")]
        public string ShortName
        {
            get { return shortName; }
            set { SetField("shortName", value, 100); }
        }

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Ref.Contractor.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Contractor.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Contractor.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Contractor.Delete;
            }
        }

        protected override string LoadQuery
        {
            get
            {

                return EntryControl.Resources.Ref.Contractor.Load;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Contractor.LoadList;
            }
        }

        #endregion

        public static Contractor Empty
        {
            get { return new Contractor(0, "Не указан"); }
        }

        #endregion

        #region Конструкторы

        public Contractor() : base() { }

        public Contractor(int id, string name) : base(id, name) { }

        public Contractor(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        protected override void InitializeProperties()
        {
            name = "ООО Новый контрагент";
            shortName = "Новый контрагент ООО";
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            name = (string)reader["name"];
            shortName = (string)reader["shortName"];
        }

        public override string ToString()
        {
            return ShortName;
        }

        public Contractor LoadCopy(Database database)
        {
            Contractor contractor = Contractor.Empty;

            QueryParameters parameters = new QueryParameters("id", Id);

            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    contractor = new Contractor(reader);

                reader.Close();
            }

            if (contractor.Equals(Contractor.Empty))
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return contractor;
        }

        public static List<Contractor> LoadList(Database database)
        {
            List<Contractor> contractorList = new List<Contractor>();

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    contractorList.Add(new Contractor(reader));
                reader.Close();
            }

            return contractorList;
        }

        #endregion
    }
}

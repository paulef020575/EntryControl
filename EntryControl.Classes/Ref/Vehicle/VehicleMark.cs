using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class VehicleMark : DataItem
    {
        #region Свойства

        private string name;
        /// <summary>
        ///     Наименование марки
        /// </summary>
        [DataField("name")]
        public string Name
        {
            get { return name; }
            set { SetField("name", value, 100); }
        }

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.MarkGeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.MarkInsert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.MarkUpdate;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.MarkDelete;
            }
        }

        protected override string LoadQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.MarkLoad;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.MarkLoadList;
            }
        }

        #endregion

        public static VehicleMark Empty
        {
            get
            {
                return new VehicleMark(0, "Автомобиль");
            }
        }

        #endregion

        #region Конструкторы

        public VehicleMark() : base() { }

        public VehicleMark(int id, string name) : base(id, name) { }

        public VehicleMark(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        protected override void InitializeProperties()
        {
            name = "Новая марка т/с";
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            name = (string)reader["name"];
        }

        protected override string StringDescription()
        {
            return Name;
        }

        public VehicleMark LoadCopy(Database database)
        {
            VehicleMark mark = VehicleMark.Empty;

            QueryParameters parameters = new QueryParameters("id", Id);

            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    mark = new VehicleMark(reader);

                reader.Close();
            }

            if (mark.Equals(VehicleMark.Empty))
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return mark;
        }

        public static List<VehicleMark> LoadList(Database database)
        {
            List<VehicleMark> markList = new List<VehicleMark>();

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    markList.Add(new VehicleMark(reader));

                reader.Close();
            }

            return markList;
        }

        #endregion
    }
}

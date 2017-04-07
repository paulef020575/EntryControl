using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class VehicleOwner : DataItem
    {
        #region Свойства

        [DataField("vehicle", "Id")]
        public Vehicle Vehicle { get; set; }

        private Contractor contractor;
        [DataField("contractor", "Id")]
        public Contractor Contractor
        {
            get { return contractor; }
            set { SetField("contractor", value); }
        }

        private DateTime dateFrom;
        [DataField("dateFrom")]
        public DateTime DateFrom
        {
            get { return dateFrom; }
            set { SetField("dateFrom", value); }
        }

        private DateTime dateTo;
        [DataField("dateTo")]
        public DateTime DateTo
        {
            get { return dateTo; }
            set { SetField("dateTo", value); }
        }

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.OwnerGeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.OwnerInsert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.OwnerUpdate;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.OwnerDelete;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.OwnerLoadList;
            }
        }

        #endregion

        #endregion

        #region Конструкторы

        public VehicleOwner(Vehicle vhcl, Contractor owner, DateTime dtFrom)
            : base()
        {
            Vehicle = vhcl;
            contractor = owner;
            dateFrom = dtFrom;
        }

        public VehicleOwner(Vehicle vhcl)
            : this(vhcl, Contractor.Empty, DateTime.Today)
        { }

        public VehicleOwner(Vehicle vhcl, DbDataReader reader)
            : base(reader)
        {
            Vehicle = vhcl;
        }

        #endregion

        #region Методы

        protected override void InitializeProperties()
        {
            Vehicle = Vehicle.Empty;
            contractor = Contractor.Empty;
            dateFrom = DateTime.Today;
            dateTo = new DateTime(2100, 1, 1);
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            contractor = new Contractor((int)reader["contractor"], (string)reader["contractorName"]);
            dateFrom = (DateTime)reader["dateFrom"];
            dateTo = (DateTime)reader["dateTo"];
        }

        public static List<VehicleOwner> LoadList(Database database, Vehicle vhcl)
        {
            List<VehicleOwner> ownerList = new List<VehicleOwner>();

            string query = EntryControl.Resources.Ref.Vehicle.OwnerLoadList;
            QueryParameters parameters = new QueryParameters("vehicle", vhcl.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    ownerList.Add(new VehicleOwner(vhcl, reader));

                reader.Close();
            }

            return ownerList;
        }

        protected override string StringDescription()
        {
            return Contractor.ToString();
        }
        #endregion


    }
}

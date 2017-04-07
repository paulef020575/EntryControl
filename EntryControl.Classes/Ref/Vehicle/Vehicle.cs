using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;
using System.ComponentModel;

namespace EntryControl.Classes
{
    public class Vehicle : DataItem
    {
        #region ПОля и свойства

        private DataItem vehicleMark;
        /// <summary>
        ///     марка тс
        /// </summary>
        [DataField("vehicleMark", "Id")]
        public DataItem VehicleMark
        {
            get { return vehicleMark; }
            set { SetField("vehicleMark", value); }
        }

        private string licensePlate;

        [DataField("licensePlate")]
        public string LicensePlate
        {
            get { return licensePlate; }
            set { SetField("licensePlate", value.ToLower(), 25); }
        }

        public DataItem Owner { get; private set; }

        private BindingList<VehicleOwner> ownerList;

        private List<VehicleOwner> removedItems;

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.Delete;
            }
        }

        protected override string LoadQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.Load;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Ref.Vehicle.LoadList;
            }
        }

        #endregion

        public static Vehicle Empty { get { return new Vehicle(0, "Выберите Т/С"); } }

        #endregion

        #region Конструкторы

        public Vehicle() : base() { }

        public Vehicle(int id, string name) : base(id, name) { }

        public Vehicle(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        #region Переопределенные

        protected override void InitializeProperties()
        {
            vehicleMark = EntryControl.Classes.VehicleMark.Empty;
            licensePlate = "";
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            vehicleMark = new VehicleMark((int)reader["vehicleMark"], (string)reader["nameMark"]);
            licensePlate = (string)reader["licensePlate"];
            if (DBNull.Value.Equals(reader["contractor"]))
                Owner = Contractor.Empty;
            else 
                Owner = new Contractor((int)reader["contractor"], (string)reader["contractorName"]);
        }

        protected override string StringDescription()
        {
            return VehicleMark.ToString() + " " + LicensePlate;
        }

        #endregion

        public Vehicle LoadCopy(Database database)
        {
            Vehicle vehicle = Vehicle.Empty;

            using (DbDataReader reader = database.ExecuteReader(LoadQuery, new QueryParameters("id", Id)))
            {
                if (reader.Read())
                    vehicle = new Vehicle(reader);

                reader.Close();
            }

            if (vehicle.Equals(Vehicle.Empty))
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return vehicle;
        }

        public static List<Vehicle> LoadList(Database database)
        {
            return LoadList(database, null, null, "");
        }

        public static List<Vehicle> LoadList(Database database, Contractor owner, VehicleMark mark, string license)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            QueryParameters parameters = new QueryParameters();

            if (owner == null || owner.Equals(Contractor.Empty))
                parameters.Add("owner", null);
            else
                parameters.Add("owner", owner.Id);

            if (mark == null || mark.Equals(EntryControl.Classes.VehicleMark.Empty))
                parameters.Add("mark", null);
            else
                parameters.Add("mark", mark.Id);

            parameters.Add("license", license);

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery, parameters))
            {
                while (reader.Read())
                    vehicleList.Add(new Vehicle(reader));

                reader.Close();
            }

            return vehicleList;
        }

        public BindingList<VehicleOwner> GetOwnerList(Database database)
        {
            if (ownerList == null)
                ownerList = new BindingList<VehicleOwner>(VehicleOwner.LoadList(database, this));
            return ownerList;
        }

        protected override void SaveChildren(Connection connection)
        {
            if (ownerList != null)
            {
                SortOwnerList();
                foreach (VehicleOwner owner in ownerList)
                    owner.Save(connection);

                if (removedItems != null)
                {
                    foreach (VehicleOwner owner in removedItems)
                    {
                        owner.Delete();
                        owner.Save(connection);
                    }

                    removedItems.Clear();
                }
            }
        }

        private void SortOwnerList()
        {
            BindingList<VehicleOwner> newOwnerList = new BindingList<VehicleOwner>();

            foreach (VehicleOwner owner in ownerList)
            {
                int i = 0;

                while (i < newOwnerList.Count && owner.DateFrom > newOwnerList[i].DateFrom)
                    i++;

                newOwnerList.Insert(i, owner);
            }

            for (int i = 0; i < newOwnerList.Count - 1; i++)
                newOwnerList[i].DateTo = newOwnerList[i + 1].DateFrom.AddDays(-1);

            if (newOwnerList.Count > 0)
                newOwnerList[newOwnerList.Count - 1].DateTo = new DateTime(2100, 12, 31);

            ownerList = newOwnerList;
        }

        #endregion

        public void RemoveOwner(VehicleOwner vehicleOwner)
        {
            if (removedItems == null)
                removedItems = new List<VehicleOwner>();

            removedItems.Add(vehicleOwner);
            ownerList.Remove(vehicleOwner);
        }

        public void AddOwner(Contractor contractor)
        {
            Owner = contractor;

            if (ownerList == null)
                ownerList = new BindingList<VehicleOwner>();

            DateTime dateFrom = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            VehicleOwner owner = new VehicleOwner(this, contractor, dateFrom);
            ownerList.Add(owner);
        }

        public string GetMark(EntryControlDatabase database)
        {
            string query = EntryControl.Resources.Ref.Vehicle.GetVehicleMark;
            QueryParameters parameters = new QueryParameters("id", Id);

            return (string)database.ExecuteScalar(query, parameters);
        }
    }
}

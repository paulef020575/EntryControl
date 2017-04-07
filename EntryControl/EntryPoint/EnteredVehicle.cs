using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using EPV.Database;
using EntryControl.Classes;

namespace EntryControl
{
    internal class EnteredVehicle
    {
        public int PermitId { get; private set; }

        public DateTime EntryTime { get; private set; }

        public string VehicleMark { get; private set; }

        public string LicensePlate { get; private set; }

        public string Cargo { get; private set; }

        public string DriverName { get; private set; }

        public string Contact { get; private set; }

        public string EntryPoint { get; private set; }

        #region Поля для отображения

        public string EntryInfo
        {
            get { return EntryTime.ToString("dd.MM HH:mm") + "\n" + EntryPoint; }
        }

        public string VehicleInfo
        {
            get { return VehicleMark + " " + LicensePlate; }
        }

        public string DriverInfo
        {
            get { return DriverName + "\n" + Contact; }
        }

        #endregion

        public EnteredVehicle(DbDataReader reader)
        {
            PermitId = (int)reader["id"];
            EntryTime = (DateTime)reader["lastTime"];
            VehicleMark = (string)reader["vehicleMark"];
            LicensePlate = (string)reader["licensePlate"];
            Cargo = (string)reader["cargoName"];
            DriverName = (string)reader["driverName"];
            Contact = (string)reader["contact"];
            EntryPoint = (string)(DBNull.Value.Equals(reader["entryPoint"]) ? "" : reader["entryPoint"]);
        }

        public static List<EnteredVehicle> LoadList(Database database)
        {
            List<EnteredVehicle> vehicleList = new List<EnteredVehicle>();

            string query = EntryControl.Resources.Doc.Permit.GetEnteredVehicles;

            using (DbDataReader reader = database.ExecuteReader(query))
            {
                while (reader.Read())
                    vehicleList.Add(new EnteredVehicle(reader));

                reader.Close();
            }

            return vehicleList;
        }

        public string GetComment(Database database)
        {
            return Permit.GetComment(database, PermitId);
        }

        public string GetCreator(Database database)
        {
            //Permit permit = Permit.Load(database, PermitId);

            //return permit.Creator.ToString() + " (" + permit.CreateDate.ToShortDateString() + ")";

            return Permit.GetPlanAppointCreator(database, PermitId);

        }
    }
}

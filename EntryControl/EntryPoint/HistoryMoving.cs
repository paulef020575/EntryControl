using EntryControl.Classes;
using EPV.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Text;

namespace EntryControl
{
    public class HistoryMoving
    {
        public DateTime MovingTime { get; private set; }

        public EntryPoint EntryPoint { get; private set; }

        public Vehicle Vehicle { get; private set; }

        public string DriverName { get; private set; }

        public int PermitId { get; private set; }

        public string PermitNumber { get; private set; }

        public EnumerationItem Moving { get; private set; }

        public Cargo Cargo { get; private set; }

        public Color Color
        {
            get
            {
                switch (Moving.Id)
                {
                    case 2:
                        return Color.Green;

                    case 3:
                        return Color.Red;

                    case 4:
                        return Color.Gray;

                    default:
                        return SystemColors.WindowText;
                }
            }
        }

        public HistoryMoving(DbDataReader reader)
        {
            MovingTime = (DateTime)reader["movingTime"];
            EntryPoint = new EntryPoint((int)reader["entryPoint"], (string)reader["entryPointName"]);
            Vehicle = new Vehicle((int)reader["vehicle"], (string)reader["vehicleName"]);
            DriverName = (string)reader["driverName"];
            PermitId = (int)reader["permit"];
            int period = (int)reader["period"];
            int docNumber = (int)reader["docNumber"];
            PermitNumber = period.ToString() + "-" + docNumber.ToString();
            Moving = new EnumerationItem((int)reader["moving"], (string)reader["movingName"]);
            Cargo = new Cargo((int)reader["cargo"], (string)reader["cargoName"]);
        }

        public static List<HistoryMoving> LoadList(Database database, DateTime dateFrom, DateTime dateTo, string vehicleMask)
        {
            List<HistoryMoving> reportList = new List<EntryControl.HistoryMoving>();

            QueryParameters parameters = new QueryParameters("dateFrom", dateFrom);
            parameters.Add("dateTo", dateTo);
            parameters.Add("vehicleMask", vehicleMask);

            using (DbDataReader reader = database.ExecuteReader(EntryControl.Resources.Doc.Permit.HistoryMoving, parameters))
            {
                while (reader.Read())
                    reportList.Add(new EntryControl.HistoryMoving(reader));

                reader.Close();
            }

            return reportList;
        }

        internal string GetComment(Database database)
        {
            return Permit.GetComment(database, PermitId);
        }

        internal string GetPlanAppointCreator(Database database)
        {
            return Permit.GetPlanAppointCreator(database, PermitId);
        }
    }
}

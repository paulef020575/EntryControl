using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class MaterialPermit
    {
        public int Id { get; private set; }

        public Unit Unit { get; private set; }

        public string DocNumber { get; private set; }

        public DateTime DocDate { get; private set; }

        public string Person { get; private set; }

        public string VehicleMark { get; private set; }

        public string LicensePlate { get; private set; }

        public short CreatedFlag { get; private set; }

        public Image CreatedImage
        {
            get
            {
                switch (CreatedFlag)
                {
                    case -1:
                        return EntryControl.Resources.Images.Failed;

                    case 1:
                        return EntryControl.Resources.Images.Check;

                    default:
                        return EntryControl.Resources.Images.Quest;
                }
            }
        }

        public User Creator { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public short SignedFlag { get; private set; }

        public Image SignedImage
        {
            get
            {
                switch (SignedFlag)
                {
                    case -1:
                        return EntryControl.Resources.Images.Failed;

                    case 1:
                        return EntryControl.Resources.Images.Check;

                    default:
                        return EntryControl.Resources.Images.Quest;
                }
            }
        }

        public User Signer { get; private set; }

        public DateTime SignedDate { get; private set; }

        public bool CanExit { get { return (CreatedFlag > 0 && SignedFlag > 0); } }

        public short EntryFlag;

        public Image EntryImage
        {
            get
            {
                switch (EntryFlag)
                {
                    case -1:
                        return EntryControl.Resources.Images.Failed;

                    case 1:
                        return EntryControl.Resources.Images.Check;

                    default:
                        return EntryControl.Resources.Images.Quest;
                }
            }
        }

        public EntryPoint EntryPoint { get; private set; }

        public DateTime EntryDate { get; private set; }

        public string Comment { get; private set; }

        public int PermitId { get; private set; }

        public string BaseDocument { get; private set; }

        public string BaseDocNumber { get; private set; }

        public DateTime BaseDocDate { get; private set; }

        public string BaseDocumentText
        {
            get
            {

                if (string.IsNullOrEmpty(BaseDocument))
                    return "";
                else
                    return BaseDocument + " № " + BaseDocNumber + " от " + BaseDocDate.ToShortDateString();
            }
        }

        public MaterialPermit(DbDataReader reader)
        {
            Id = (int)reader["id"];
            Unit = new Unit((int)reader["unitId"], (string)reader["unitName"]);
            DocNumber = (string)reader["docNumber"];
            DocDate = (DateTime)reader["docDate"];
            Person = (string)reader["person"];
            VehicleMark = (string)reader["vehicleMark"];
            LicensePlate = (string)reader["licensePlate"];

            CreatedFlag = (short)reader["createFlag"];

            if (!DBNull.Value.Equals(reader["creator"]))
            {
                Creator = new User((int)reader["creator"], (string)reader["creatorName"]);
                CreatedDate = (DateTime)reader["createDate"];
            }
            else
            {
                Creator = User.Empty;
                CreatedDate = DateTime.MinValue;
            }

            SignedFlag = (short)reader["signedFlag"];

            if (!DBNull.Value.Equals(reader["signer"]))
            {
                Signer = new User((int)reader["signer"], (string)reader["signerName"]);
                SignedDate = (DateTime)reader["signDate"];
            }
            else
            {
                Signer = User.Empty;
                SignedDate = DateTime.MinValue;
            }

            EntryFlag = (short)reader["entryFlag"];

            if (!DBNull.Value.Equals(reader["entryPoint"]))
            {
                EntryPoint = new EntryPoint((int)reader["entryPoint"], (string)reader["entryPointName"]);
            }
            else
            {
                EntryPoint = EntryPoint.Empty;
            }
            
            if (!DBNull.Value.Equals(reader["entryDate"]))
            {
                EntryDate = (DateTime)reader["entryDate"];
            }
            else
            {
                EntryDate = DateTime.MinValue;
            }

            if (!DBNull.Value.Equals(reader["autoPermit"]))
            {
                PermitId = (int)reader["autoPermit"];
            }
            else
            {
                PermitId = 0;
            }

            if (!DBNull.Value.Equals(reader["comment"]))
            {
                Comment = (string)reader["comment"];
            }
            else
            {
                Comment = "";
            }

            BaseDocument = (DBNull.Value.Equals(reader["baseDocument"]) ? "" : (string)reader["baseDocument"]);
            BaseDocNumber = (DBNull.Value.Equals(reader["baseDocNumber"]) ? "" : (string)reader["baseDocNumber"]);
            BaseDocDate = (DBNull.Value.Equals(reader["baseDocDate"]) ? DateTime.Today : (DateTime)reader["baseDocDate"]);
        }

        public static MaterialPermit Load(Database database, int id)
        {
            string query = EntryControl.Resources.Doc.MaterialPermit.Load;
            QueryParameters parameters = new QueryParameters("id", id);

            MaterialPermit materialPermit = null;

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                    materialPermit = new MaterialPermit(reader);

                reader.Close();
            }

            if (materialPermit == null)
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return materialPermit;
        }

        public MaterialPermit LoadCopy(Database database)
        {
            return Load(database, Id);
        }

        public static List<MaterialPermit> LoadList(EntryControlDatabase database, Unit unit, DateTime dateFrom, DateTime dateTo)
        {
            List<MaterialPermit> documentList = new List<MaterialPermit>();

            string query = EntryControl.Resources.Doc.MaterialPermit.LoadList;
            QueryParameters parameters = new QueryParameters("unitId", unit.Id);
            parameters.Add("dateFrom", dateFrom);
            parameters.Add("dateTo", dateTo);
            parameters.Add("userId", database.ConnectedUser.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    documentList.Add(new MaterialPermit(reader));
                reader.Close();
            }
            return documentList;
        }

        public static List<MaterialPermit> LoadList(EntryControlDatabase database, DateTime dateFrom, DateTime dateTo)
        {
            return LoadList(database, new Unit(0, ""), dateFrom, dateTo);
        }

        public List<MaterialPermitItem> GetItemList(Database database)
        {
            return MaterialPermitItem.LoadList(database, this);
        }

        public override string ToString()
        {
            return "№ " + DocNumber + " от " + DocDate.ToShortDateString();
        }

        public void SetEntry(EntryControlDatabase database, EntryPoint entryPoint, DateTime date)
        {
            string query = EntryControl.Resources.Doc.MaterialPermit.SetEntry;
            QueryParameters parameters = new QueryParameters("entryPoint", entryPoint.Id);
            parameters.Add("entryDate", date);
            parameters.Add("userId", -1);
            parameters.Add("id", Id);

            database.ExecuteQuery(query, parameters);
        }


    }
}

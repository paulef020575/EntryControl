using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class Permit : DataItem
    {
        #region Поля и свойства

        [DataField("creator", "Id")]
        public User Creator { get; set; }

        [DataField("createDate")]
        public DateTime CreateDate { get; private set; }

        public string CreateInfo
        {
            get { return Creator.ToString() + " " + CreateDate.ToString("dd.MM.yyyy HH:mm"); }
        }

        private int period;
        [DataField("period")]
        public int Period
        {
            get { return period; }
            set { SetField("period", value); }
        }

        private int docNumber;
        [DataField("docNumber")]
        public int DocNumber
        {
            get { return docNumber; }
            set { SetField("docNumber", value); }
        }

        public int FullNumber
        {
            get { return period * 1000000 + docNumber; }
        }

        public string ShortNumber
        {
            get { return period.ToString() + "-" + docNumber.ToString(); }
        }

        public DateTime DocDate
        {
            get { return CreateDate.Date; }
        }

        public string Header
        {
            get { return ShortNumber + " от " + DocDate.ToShortDateString(); }
        }

        private EnumerationItem permitState;
        [DataField("permitState", "Id")]
        public EnumerationItem PermitState
        {
            get { return permitState; }
            set { SetField("permitState", value); }
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

        public string ActivePeriod
        {
            get { return DateFrom.ToShortDateString() + " - " + DateTo.ToShortDateString(); }
        }

        private Cargo cargo;
        [DataField("cargo", "Id")]
        public Cargo Cargo
        {
            get { return cargo; }
            set { SetField("cargo", value); }
        }


        private Vehicle vehicle;
        [DataField("vehicle", "Id")]
        public Vehicle Vehicle
        {
            get { return vehicle; }
            set { SetField("vehicle", value); }
        }

        private string driverName;
        [DataField("driverName")]
        public string DriverName
        {
            get { return driverName; }
            set { SetField("driverName", value, 100); }
        }

        private string contact;
        [DataField("contact")]
        public string Contact
        {
            get { return contact; }
            set { SetField("contact", value, 100); }
        }

        private EntryPoint entryPoint;
        [DataField("entryPoint", "Id")]
        public EntryPoint EntryPoint
        {
            get { return entryPoint; }
            set { SetField("entryPoint", value); }
        }

        private short multiEntry;
        [DataField("multiEntry")]
        public short MultiEntry
        {
            get { return multiEntry; }
            set
            {
                SetField("multiEntry", value);
                RaisePropertyChanged("IsMultiEntry");
            }
        }

        public bool IsMultiEntry
        {
            get { return (multiEntry > 0); }
            set { MultiEntry = (short)(value ? 1 : 0); }
        }

        private string comment;
        [DataField("comment")]
        public string Comment
        {
            get { return comment; }
            set { SetField("comment", value); }
        }

        private PlanAppoint planAppoint;

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.Delete;
            }
        }

        public static string LoadQuery
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.Load;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.LoadList;
            }
        }

        #endregion



        #endregion

        #region Конструкторы

        public Permit() : base() { }

        public Permit(int id, string descr) : base(id, descr) { }

        public Permit(DbDataReader reader) : base(reader) { }

        public Permit(PlanAppoint appoint)
            : base()
        {
            PermitState = EntryControlDatabase.OneTimePermitState;

            DateFrom = appoint.DateFrom.AddDays(-1);
            DateTo = appoint.DateTo.AddDays(1);

            Cargo = (Cargo)appoint.Cargo;
            Vehicle = (Vehicle)appoint.Vehicle;
            DriverName = appoint.DriverName;
            Contact = appoint.Contact;

            MultiEntry = 0;

            planAppoint = appoint;

            comment = appoint.Comment;
        }

        #endregion

        #region Методы

        public static int GetPermitNumber(Database database, int prd)
        {
            string query = EntryControl.Resources.Doc.Permit.GetPermitNumber;
            QueryParameters parameters = new QueryParameters("period", prd);

            return (int)database.ExecuteScalar(query, parameters);
        }

        protected override void InitializeProperties()
        {
            Creator = User.Empty;
            CreateDate = DateTime.Now;

            period = DateTime.Today.Year;

            permitState = EntryControlDatabase.ConstantPermitState;

            dateFrom = DateTime.Today;
            dateTo = new DateTime(dateFrom.Year, 12, 31);

            cargo = Cargo.Empty;
            vehicle = Vehicle.Empty;
            driverName = "ФИО водителя";
            contact = "Контактная информация";

            entryPoint = EntryPoint.Empty;
            multiEntry = 1;

            comment = "";
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("---> HH:mm:ss.fff"));

                Creator = new User((int)reader["creator"], (string)reader["creatorName"]);
                CreateDate = (DateTime)reader["createDate"];

                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));

                period = (int)reader["period"];
                docNumber = (int)reader["docNumber"];
                permitState = new EnumerationItem((int)reader["permitState"], (string)reader["permitStateName"]);

                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));

                dateFrom = (DateTime)reader["dateFrom"];
                dateTo = (DateTime)reader["dateTo"];

                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));

                cargo = new Cargo((int)reader["cargo"], (string)reader["cargoName"]);
                vehicle = new Vehicle((int)reader["vehicle"], (string)reader["vehicleName"]);
                driverName = (string)reader["driverName"];
                contact = (string)reader["contact"];

                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));

                entryPoint = new EntryPoint((int)reader["entryPoint"], (string)reader["entryPointName"]);
                multiEntry = (short)reader["multiEntry"];

                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));

                comment = "";
                //if (DBNull.Value.Equals(reader["comment"]))
                //    comment = "";
                //else
                //    comment = (string)reader["comment"];
                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override string StringDescription()
        {
            return Header;
        }

        public static Permit Load(Database database, int id)
        {
            QueryParameters parameters = new QueryParameters("permitId", id);

            Permit permit = null;

            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    permit = new Permit(reader);

                reader.Close();
            }

            if (permit == null)
                throw new ArgumentException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return permit;
        }

        public Permit LoadCopy(Database database)
        {
            return Load(database, Id);
        }

        public static List<Permit> LoadList(Database database, DateTime dateStart, DateTime dateFinish,
                                            EntryPoint entryPoint)
        {
            return LoadList(database, dateStart, dateFinish, entryPoint, new EnumerationItem(0, ""));
        }

        public static List<Permit> LoadList(Database database, DateTime dateStart, DateTime dateFinish,
                                            EntryPoint entryPoint, EnumerationItem defaultState)
        {
            return LoadList(database, dateStart, dateFinish, entryPoint, defaultState, 1);
        }

        public static List<Permit> LoadList(Database database, DateTime dateStart, DateTime dateFinish,
                                            EntryPoint entryPoint, EnumerationItem defaultState, int page)
        {
            QueryParameters parameters = new QueryParameters("dateStart", dateStart);
            parameters.Add("dateFinish", dateFinish);
            parameters.Add("entryPoint", (entryPoint != null ? entryPoint.Id : 0));
            parameters.Add("defaultState", defaultState.Id);
            parameters.Add("page", page);

            List<Permit> permitList = new List<Permit>();
            using (DbDataReader reader = database.ExecuteReader(LoadListQuery, parameters))
            {
                while (reader.Read())
                    permitList.Add(new Permit(reader));
                reader.Close();
            }

            return permitList;
        }

        protected override void SaveChildren(Connection connection)
        {
            if (planAppoint != null)
                SavePlanAppointPermit(connection);
        }

        private void SavePlanAppointPermit(Connection connection)
        {
            string query = EntryControl.Resources.Doc.PlanAppoint.SetPermit;
            QueryParameters parameters = new QueryParameters("permit", Id);
            parameters.Add("planAppoint", planAppoint.Id);

            connection.ExecuteQuery(query, parameters);
        }

        #endregion

        public static Permit LoadByNumber(EntryControlDatabase database, string fullNumber)
        {
            int period = DateTime.Today.Year;
            int docNumber = 0;

            if (!int.TryParse(fullNumber.Substring(0, 4), out period))
                throw new FormatException(EntryControl.Resources.Message.Error.WrongPermitNumber);

            if (!int.TryParse(fullNumber.Substring(4, 8), out docNumber))
                throw new FormatException(EntryControl.Resources.Message.Error.WrongPermitNumber);

            Permit permit = null;

            string query = EntryControl.Resources.Doc.Permit.LoadByNum;
            QueryParameters parameters = new QueryParameters("period", period);
            parameters.Add("docNumber", docNumber);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                    permit = new Permit(reader);

                reader.Close();
            }

            if (permit == null)
                throw new ArgumentException(EntryControl.Resources.Message.Error.PermitNumberNotFound);

            return permit;
        }

        public static List<Permit> LoadByNumber(EntryControlDatabase database, int shortNumber)
        {
            List<Permit> permitList = new List<Permit>();

            string query = EntryControl.Resources.Doc.Permit.LoadByNum;
            QueryParameters parameters = new QueryParameters("period", DBNull.Value);
            parameters.Add("docNumber", shortNumber);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                permitList.Add(new Permit(reader));

                reader.Close();
            }

            return permitList;
        }

        public static List<Permit> LoadForVehicle(Database database, string vehicleLicensePlate)
        {
            List<Permit> permitList = new List<Permit>();
            string query = EntryControl.Resources.Doc.Permit.LoadByVehicle;
            QueryParameters parameters = new QueryParameters("licensePlate", vehicleLicensePlate);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    permitList.Add(new Permit(reader));

                reader.Close();
            }

            return permitList;
        }

        public PermitMoving LoadLastMoving(Database database)
        {
            PermitMoving moving = null;

            string query = EntryControl.Resources.Doc.Permit.GetLastMoving;
            QueryParameters parameters = new QueryParameters("permit", Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                    moving = new PermitMoving(this, reader);

                reader.Close();
            }

            return moving;
        }


        public bool CheckClosed(Database database)
        {
            string query = EntryControl.Resources.Doc.Permit.CheckClosed;
            QueryParameters parameters = new QueryParameters("id", Id);

            object result = database.ExecuteScalar(query, parameters);

            return (result != null);
        }


        public bool CheckEntryPoint(Classes.EntryPoint EPoint)
        {
            return (EntryPoint.Equals(EntryPoint.Empty)
                        || EntryPoint.Equals(EPoint));
        }

        public bool CheckPeriod()
        {
            return (DateFrom <= DateTime.Now && DateTo >= DateTime.Today);
        }

        public PermitMoving Close(EntryPoint entryPoint, User closer)
        {
            PermitMoving permitMoving = PermitMoving.CreateClose(this);
            permitMoving.EntryPoint = entryPoint;
            permitMoving.User = closer;

            return permitMoving;
        }

        public MaterialPermit GetMaterialPermit(Database database)
        {
            string query = EntryControl.Resources.Doc.MaterialPermit.GetMaterialPermitId;
            QueryParameters parameters = new QueryParameters("autoPermit", Id);
            object result = database.ExecuteScalar(query, parameters);

            if (result == null || DBNull.Value.Equals(result))
                return null;

            return MaterialPermit.Load(database, (int)result);

        }

        public static List<Permit> LoadList(Database database, Cargo cargo, VehicleMark mark, string licensePlate)
        {
            string query = EntryControl.Resources.Doc.Permit.LoadPrevious;
            QueryParameters parameters = new QueryParameters("cargo", cargo.Id);
            if (mark != null)
                parameters.Add("mark", mark.Id);
            else
                parameters.Add("mark", DBNull.Value);
            parameters.Add("licensePlate", licensePlate);

            List<Permit> permitList = new List<Permit>();

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    permitList.Add(new Permit(reader));
                reader.Close();
            }

            return permitList;
        }


        public void SetProperties(Permit previousPermit)
        {
            Vehicle = previousPermit.Vehicle;
            DriverName = previousPermit.DriverName;
            Contact = previousPermit.Contact;
        }

        public List<PermitMoving> GetMovingList(Database database)
        {
            return PermitMoving.LoadList(database, this);
        }

        public static int GetCount(Database database, DateTime dateStart, DateTime dateFinish,
                                            EntryPoint entryPoint, EnumerationItem defaultState)
        {
            string query = EntryControl.Resources.Doc.Permit.GetCount;

            QueryParameters parameters = new QueryParameters("dateStart", dateStart);
            parameters.Add("dateFinish", dateFinish);
            parameters.Add("entryPoint", entryPoint.Id);
            parameters.Add("defaultState", defaultState.Id);

            object result = database.ExecuteScalar(query, parameters);

            if (result != null && !DBNull.Value.Equals(result))
            {
                return (int)result;
            }

            return 0;
        }

        public string GetComment(Database database)
        {
            string query = EntryControl.Resources.Doc.Permit.GetComment;
            QueryParameters parameters = new QueryParameters("id", Id);

            object result = database.ExecuteScalar(query, parameters);

            string textComment = "";
            if (result == null && DBNull.Value.Equals(result))
                textComment = "";
            else
                textComment = (string)result;

            comment = textComment;

            return comment;
        }

        public static string GetComment(Database database, int permitId)
        {
            string query = EntryControl.Resources.Doc.Permit.GetComment;
            QueryParameters parameters = new QueryParameters("id", permitId);

            object result = database.ExecuteScalar(query, parameters);

            string textComment = "";
            if (result == null && DBNull.Value.Equals(result))
                textComment = "";
            else
                textComment = (string)result;

            return textComment;
        }

        public static string GetPlanAppointCreator(Database database, int permitId)
        {
            try
            {
                string query = EntryControl.Resources.Doc.Permit.AppointCreator;
                QueryParameters parameters = new QueryParameters("permitId", permitId);

                string result = "";

                using (DbDataReader reader = database.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        result = ((DateTime)reader["createDate"]).ToString("dd.MM.yyyy HH:mm") + " / ";
                        result += (string)reader["creator"];
                    }
                    else
                    {
                        result = EntryControl.Resources.Message.Error.CannotGetData;
                    }


                    reader.Close();
                }
                return result;
            }
            catch (Exception)
            {
                return EntryControl.Resources.Message.Error.CannotGetData;
            }
        }
    }
}

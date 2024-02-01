using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;
using System.Collections.ObjectModel;
using EntryControl.Classes.Ref;

namespace EntryControl.Classes
{
    public class PlanAppoint : DataItem
    {
        #region Поля и свойство

        private DataItem creator;
        /// <summary>
        ///     Пользователь-инициализатор
        /// </summary>
        [DataField("creator", "Id")]
        public DataItem Creator
        {
            get { return creator; }
            set { SetField("creator", value); }
        }

        private DateTime createDate;
        /// <summary>
        ///     Дата изготовления
        /// </summary>
        [DataField("createDate")]
        public DateTime CreateDate
        {
            get { return createDate; }
            set { SetField("createDate", value); }
        }

        /// <summary>
        ///     текстовая информация о создании
        /// </summary>
        public string CreationInfo
        {
            get { return CreateDate.ToString("dd.MM.yyyy HH:mm") + " / " + Creator.ToString(); }
        }

        private DataItem cargo;
        /// <summary>
        ///     Груз
        /// </summary>
        [DataField("cargo", "Id")]
        public DataItem Cargo
        {
            get { return cargo; }
            set { SetField("cargo", value); }
        }

        private DataItem vehicle;
        
        [DataField("vehicle", "Id")]
        public DataItem Vehicle
        {
            get { return vehicle; }
            set { SetField("vehicle", value); }
        }

        public static string DefaultDriverName { get { return "ФИО водителя"; } }

        private string driverName;
        [DataField("driverName")]
        public string DriverName
        {
            get { return driverName; }
            set { SetField("driverName", value, 100); }
        }

        private string contact;
        /// <summary>
        ///     контактная информация водителя
        /// </summary>
        [DataField("contact")]
        public string Contact
        {
            get { return contact; }
            set { SetField("contact", value, 100); }
        }

        private string whereTo;
        [DataField("whereTo")]
        public string WhereTo
        {
            get { return whereTo; }
            set { SetField("whereTo", value, 300); }
        }

        private DateTime dateFrom;
        [DataField("dateFrom")]
        public DateTime DateFrom
        {
            get { return dateFrom; }
            set
            {
                SetField("dateFrom", value);
                if (DateTo < DateFrom)
                    DateTo = DateFrom.AddDays(1);
            }
        }

        private DateTime dateTo;
        [DataField("dateTo")]
        public DateTime DateTo
        {
            get { return dateTo; }
            set { SetField("dateTo", value); }
        }

        private string comment;
        [DataField("comment")]
        public string Comment
        {
            get { return comment; }
            set { SetField("comment", value); }
        }



        [DataField("userId", "Id")]
        public User User { get; private set; }

        public DateTime DateModified { get; private set; }

        public DateTime DateSeen { get; private set; }

        public bool IsUpdated { get { return (DateModified > DateSeen); } }

        private int permitId;

        public bool HasPermit { get { return (permitId > 0); } }

        public bool IsLocked { get { return (permitId < 0); } }

        public int PermitState { get; private set; }

        public bool PermitIsClosed
        {
            get { return (PermitState == EntryControlDatabase.ClosedPermitState.Id); }
        }

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Doc.PlanAppoint.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Doc.PlanAppoint.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Doc.PlanAppoint.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Doc.PlanAppoint.Delete;
            }
        }

        protected override string LoadQuery
        {
            get
            {
                return EntryControl.Resources.Doc.PlanAppoint.Load;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return EntryControl.Resources.Doc.PlanAppoint.LoadList;
            }
        }

        #endregion

        #endregion

        #region Конструкторы

        public PlanAppoint() : base() { }

        public PlanAppoint(int id, string name) : base() { }

        public PlanAppoint(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        protected override void InitializeProperties()
        {
            creator = User.Empty;
            createDate = DateTime.Now;
            cargo = EntryControl.Classes.Cargo.Empty;
            vehicle = EntryControl.Classes.Vehicle.Empty;
            driverName = DefaultDriverName;
            contact = "Контактная информация";
            whereTo = "Пункт отправления/назначения";
            dateFrom = DateTime.Today;
            dateTo = DateTime.Today.AddDays(1);

            comment = "";

            DateModified = DateTime.Now;
            DateSeen = DateTime.Now;


            permitId = 0;
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            creator = new User((int)reader["creator"], (string)reader["creatorName"]);
            createDate = (DateTime)reader["createDate"];
            cargo = new Cargo((int)reader["cargo"], (string)reader["cargoName"]);
            vehicle = new Vehicle((int)reader["vehicle"], (string)reader["vehicleName"]);
            driverName = (string)reader["driverName"];
            contact = (string)reader["contact"];
            whereTo = (string)reader["whereTo"];
            dateFrom = (DateTime)reader["dateFrom"];
            dateTo = (DateTime)reader["dateTo"];

            comment = ""; // (string)(DBNull.Value.Equals(reader["comment"]) ? "" : reader["comment"]);

            DateModified = (DateTime)reader["dateModified"];
            DateSeen = (DateTime)(DBNull.Value.Equals(reader["dateSeen"]) ? DateTime.MinValue : reader["dateSeen"]);
            permitId = (int)reader["permit"];
        }

        protected override string  StringDescription()
        {
            return Vehicle.ToString() + " (" + driverName + ")";
        }

        public PlanAppoint LoadCopy(Database database)
        {
            PlanAppoint planAppoint = null;

            string query = EntryControl.Resources.Doc.PlanAppoint.Load;
            QueryParameters parameters = new QueryParameters("id", Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                    planAppoint = new PlanAppoint(reader);

                reader.Close();
            }

            if (planAppoint == null)
                throw new ArgumentOutOfRangeException(EntryControl.Resources.Message.Error.WrongIdentifier);

            return planAppoint;
        }

        public static List<PlanAppoint> LoadList(Database database, DateTime dateStart)
        {
            List<PlanAppoint> appointList = new List<PlanAppoint>();

            string query = EntryControl.Resources.Doc.PlanAppoint.LoadList;
            QueryParameters parameters = CreateParametersForList();

            if (database is EntryControlDatabase)
                parameters["creator"] = ((EntryControlDatabase)database).ConnectedUser.Id;
            parameters.Add("DateStart", dateStart);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    appointList.Add(new PlanAppoint(reader));

                reader.Close();
            }

            return appointList;
        }

        public static List<PlanAppoint> LoadListForTree(Database database, DateTime dateStart)
        {
            List<PlanAppoint> appointList = new List<PlanAppoint>();

            string query = EntryControl.Resources.Doc.PlanAppoint.LoadList;
            QueryParameters parameters = CreateParametersForList();

            if (database is EntryControlDatabase)
                parameters["creator"] = ((EntryControlDatabase)database).ConnectedUser.Id;
            parameters.Add("DateStart", dateStart);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    PlanAppoint appoint = new PlanAppoint(reader);
                    appoint.PermitState = (int)reader["permitState"];
                    appointList.Add(appoint);
                }

                reader.Close();
            }

            return appointList;
        }

        public static List<PlanAppoint> LoadWoPermit(Database database)
        {
            return LoadWoPermit(database, DateTime.Today.AddDays(-7), 1);
        }

        public static List<PlanAppoint> LoadWoPermit(Database database, DateTime dateStart, int pageNum)
        {
            List<PlanAppoint> appointList = new List<PlanAppoint>();

            string query = EntryControl.Resources.Doc.PlanAppoint.LoadWoPermit;

            QueryParameters parameters = new QueryParameters("page", pageNum);
            parameters.Add("dateStart", dateStart);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    appointList.Add(new PlanAppoint(reader));
                reader.Close();
            }

            return appointList;
        }

        public static int GetNumberWOPermit(Database database, DateTime dateStart)
        {
            QueryParameters parameters = new QueryParameters("dateStart", dateStart);
            object result = database.ExecuteScalar(EntryControl.Resources.Doc.PlanAppoint.GetCountWoPermit, parameters);

            if (result != null && !DBNull.Value.Equals(result))
                return (int)result;

            return 0;
        }

        private static QueryParameters CreateParametersForList()
        {
            QueryParameters parameters = new QueryParameters("creator", DBNull.Value);

            return parameters;
        }

        public override void Save(Database database)
        {
            EntryControlDatabase dbase = (EntryControlDatabase)database;
            User = dbase.ConnectedUser;

            base.Save(database);
        }

        public void SetSeen(Database database)
        {
            DateSeen = DateTime.Now;
            EntryControlDatabase dbase = (EntryControlDatabase)database;

            string query = EntryControl.Resources.Doc.PlanAppoint.SetSeen;
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("userId", dbase.ConnectedUser.Id);
            parameters.Add("dateSeen", DateTime.Now);

            database.ExecuteQuery(query, parameters);
        }

        public void GetDriverInfo(Database database)
        {
            if ((string.Equals(DefaultDriverName, DriverName)
                 || string.IsNullOrEmpty(DriverName)) 
                && Vehicle != null)
            {
                string query = EntryControl.Resources.Doc.PlanAppoint.GetDriverInfo;
                QueryParameters parameters = new QueryParameters("vehicle", Vehicle.Id);

                using (DbDataReader reader = database.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        DriverName = (string)reader["driverName"];
                        Contact = (string)reader["contact"];
                    }

                    reader.Close();
                }
            }
        }

        public Permit LoadPermit(Database database)
        {
            return Permit.Load(database, permitId);
        }

        #endregion

        public string GetComment(Database database)
        {
            string query = EntryControl.Resources.Doc.PlanAppoint.GetComment;
            QueryParameters parameters = new QueryParameters("id", Id);

            object result = database.ExecuteScalar(query, parameters);

            if (result == null || DBNull.Value.Equals(result))
                comment = "";
            else
                comment = (string)result;

            return Comment;
        }

        #region CheckBlackList

        public string CheckBlackList(Database database)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>
            {
                { "Водитель", DriverName },
                { "Автомобиль", Vehicle.Description },
                { "Телефон", Contact }
            };

            string result = "";

            foreach (string key in properties.Keys)
            {
                if (BlackList.CheckText(database, properties[key]))
                    result += (string.IsNullOrEmpty(result) ? "" : ", ") + key;
            }

            return result;

        }

        #endregion

    }
}

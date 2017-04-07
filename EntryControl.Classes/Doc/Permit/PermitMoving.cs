using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class PermitMoving : DataItem
    {
        #region Поля и свойства

        [DataField("permit", "Id")]
        public Permit Permit { get; private set; }


        private EnumerationItem moving;
        [DataField("moving", "Id")]
        public EnumerationItem Moving
        {
            get { return moving; }
            set { SetField("moving", value); }
        }


        private EntryPoint entryPoint;
        [DataField("entryPoint", "Id")]
        public EntryPoint EntryPoint
        {
            get { return entryPoint; }
            set { SetField("entryPoint", value); }
        }


        private User user;
        [DataField("userId", "Id")]
        public User User
        {
            get { return user; }
            set { SetField("user", value); }
        }


        private DateTime movingTime;
        [DataField("movingTime")]
        public DateTime MovingTime
        {
            get { return movingTime; }
            set { SetField("movingTime", value); }
        }

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.MovingGenerator; 
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.MovingInsert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.MovingUpdate;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return EntryControl.Resources.Doc.Permit.MovingDelete;
            }
        }

        public static string LoadListQuery
        {
            get 
            {
                return EntryControl.Resources.Doc.Permit.MovingLoadList;
            }
        }

        #endregion

        #endregion

        #region Конструкторы

        private PermitMoving() : base() { }

        public PermitMoving(Permit permit) : this() 
        { 
            Permit = permit;
        }

        private PermitMoving(DbDataReader reader) : base(reader) { }

        public PermitMoving(Permit permit, DbDataReader reader) : this(reader) 
        {
            Permit = permit;
        }

        public static PermitMoving CreateEntry(Permit permit)
        {
            PermitMoving moving = new PermitMoving(permit);
            moving.Moving = EntryControlDatabase.EntryMovingType;

            return moving;
        }

        public static PermitMoving CreateExit(Permit permit)
        {
            PermitMoving moving = new PermitMoving(permit);
            moving.Moving = EntryControlDatabase.ExitMovingType;

            return moving;
        }

        public static PermitMoving CreateClose(Permit permit)
        {
            PermitMoving moving = new PermitMoving(permit);
            moving.Moving = EntryControlDatabase.CloseMovingType;

            return moving;
        }

        #endregion

        #region Методы

        #region Переопределенные

        protected override void InitializeProperties()
        {
            moving = new EnumerationItem(1, "Выдан");
            user = User.Empty;
            entryPoint = EntryPoint.Empty;
            movingTime = DateTime.Now;
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            moving = new EnumerationItem((int)reader["moving"], (string)reader["movingName"]);
            user = User.Empty;// new User((int)reader["userId"], (string)reader["userName"]);
            entryPoint = new EntryPoint((int)reader["entryPoint"], (string)reader["entryPointName"]);
            movingTime = (DateTime)reader["movingTime"];
        }

        protected override string StringDescription()
        {
            return Moving.ToString() + " - " + MovingTime.ToString("dd.MM.yyyy HH:mm");
        }

        #endregion

        public static List<PermitMoving> LoadList(Database database, Permit permit)
        {
            List<PermitMoving> permitMovingList = new List<PermitMoving>();

            QueryParameters parameters = new QueryParameters("permit", permit.Id);

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery, parameters))
            {
                while (reader.Read())
                    permitMovingList.Add(new PermitMoving(permit, reader));

                reader.Close();
            }

            return permitMovingList;
        }

        public string AskToIgnore()
        {
            string message = "";
            switch (Moving.Id)
            {
                case 2:
                    message = EntryControl.Resources.Doc.Permit.PermitIn;
                    break;

                case 3:
                    message = EntryControl.Resources.Doc.Permit.PermitOut;
                    break;
            }
            message = message.Replace("@dateMoving", MovingTime.ToString("dd.MM.yyyy HH:mm"));

            return message;
        }

        #endregion

    }
}

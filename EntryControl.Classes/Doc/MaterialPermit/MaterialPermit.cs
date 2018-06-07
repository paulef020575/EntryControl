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
        #region Properties

        /// <summary>
        ///     идентификатор
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        ///     подразделение предпрития
        /// </summary>
        [Caption("Цех/отдел")]
        public Unit Unit { get; private set; }

        /// <summary>
        ///     номер документа
        /// </summary>
        [Caption("Номер документа")]
        public string DocNumber { get; private set; }

        /// <summary>
        ///     дата документа
        /// </summary>
        [Caption("Дата документа")]
        public DateTime DocDate { get; private set; }


        /// <summary>
        ///     предъявитель документа
        /// </summary>
        [Caption("Предъявитель")]
        public string Person { get; private set; }

        /// <summary>
        ///     вывозящее ТС
        /// </summary>
        public string VehicleMark { get; private set; }

        /// <summary>
        ///     гос. номер вывозящего ТС
        /// </summary>
        public string LicensePlate { get; private set; }

        [Caption("Т/средство")]
        public string Vehicle => string.Format("{0} {1}", VehicleMark, LicensePlate);

        /// <summary>
        ///     признак подтверждения инициатором
        /// </summary>
        public short CreatedFlag { get; private set; }

        /// <summary>
        ///     иконка подтверждения
        /// </summary>
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

        /// <summary>
        ///     инициатор
        /// </summary>
        public User Creator { get; private set; }

        /// <summary>
        ///     дата создания
        /// </summary>
        public DateTime CreatedDate { get; private set; }

        /// <summary>
        ///     признак утверждения СБ
        /// </summary>
        public short SignedFlag { get; private set; }

        /// <summary>
        ///     иконка утверждения
        /// </summary>
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

        /// <summary>
        ///     утвердивший пользователь
        /// </summary>
        public User Signer { get; private set; }

        /// <summary>
        ///     дата утверждения
        /// </summary>
        public DateTime SignedDate { get; private set; }

        /// <summary>
        ///     разрешение на вывоз
        /// </summary>
        public bool CanExit { get { return (CreatedFlag > 0 && SignedFlag > 0); } }

        /// <summary>
        ///     признак вывоза
        /// </summary>
        public short EntryFlag { get; set; }

        /// <summary>
        ///     иконка выезда
        /// </summary>
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

        /// <summary>
        ///     выпустивший пункт пропуска
        /// </summary>
        public EntryPoint EntryPoint { get; private set; }

        /// <summary>
        ///     дата выезда
        /// </summary>
        public DateTime EntryDate { get; private set; }

        /// <summary>
        ///     комментарий
        /// </summary>
        public string Comment { get; private set; }

        /// <summary>
        ///     идентификатор автомобильного пропуска, к которому привязан документ
        /// </summary>
        public int PermitId { get; private set; }

        /// <summary>
        ///     документ-основание
        /// </summary>
        public string BaseDocument { get; private set; }

        /// <summary>
        ///     номер документа-основания
        /// </summary>
        public string BaseDocNumber { get; private set; }

        /// <summary>
        ///     дата документа основания
        /// </summary>
        public DateTime BaseDocDate { get; private set; }

        /// <summary>
        ///     описание документа основания
        /// </summary>
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

        #endregion

        #region Конструктор

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

        public MaterialPermit()
        {
        }

        #endregion

        #region Methods

        #region Loading from DB

        /// <summary>
        ///     возвращает объект по идентификатору
        /// </summary>
        /// <param name="database">объект БД</param>
        /// <param name="id">идентификатор документа</param>
        /// <returns>объект документа</returns>
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

        /// <summary>
        ///     возвращает загруженную из БД копию объекта
        /// </summary>
        /// <param name="database">объект БД</param>
        /// <returns>копия объекта документа</returns>
        public MaterialPermit LoadCopy(Database database)
        {
            return Load(database, Id);
        }

        /// <summary>
        ///     возвращает список документов, соответствующий заданному фильтру
        /// </summary>
        /// <param name="database">объект БД</param>
        /// <param name="unit">подразделение предприятия</param>
        /// <param name="dateFrom">начало периода</param>
        /// <param name="dateTo">окончания периода</param>
        /// <returns>список объектов документов</returns>
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

        /// <summary>
        ///     возвращает список документов, соответствующий заданному фильтру
        /// </summary>
        /// <param name="database">объект БД</param>
        /// <param name="dateFrom">начало периода</param>
        /// <param name="dateTo">окончания периода</param>
        /// <returns>список объектов документов</returns>
        public static List<MaterialPermit> LoadList(EntryControlDatabase database, DateTime dateFrom, DateTime dateTo)
        {
            return LoadList(database, new Unit(0, ""), dateFrom, dateTo);
        }

        #endregion

        /// <summary>
        ///     возвращает список включенных в документ материалов
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        public List<MaterialPermitItem> GetItemList(Database database)
        {
            return MaterialPermitItem.LoadList(database, this);
        }

        /// <summary>
        ///     возвращает строковое описание объекта
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "№ " + DocNumber + " от " + DocDate.ToShortDateString();
        }

        /// <summary>
        ///     устанавливает признак вывоза ТМЦ
        /// </summary>
        /// <param name="database">объект БД</param>
        /// <param name="entryPoint">пункт пропуска</param>
        /// <param name="date">момент вывоза</param>
        public void SetEntry(EntryControlDatabase database, EntryPoint entryPoint, DateTime date)
        {
            string query = EntryControl.Resources.Doc.MaterialPermit.SetEntry;
            QueryParameters parameters = new QueryParameters("entryPoint", entryPoint.Id);
            parameters.Add("entryDate", date);
            parameters.Add("userId", -1);
            parameters.Add("id", Id);

            database.ExecuteQuery(query, parameters);
        }

        
        public void SetSigned(EntryControlDatabase database, MaterialPermitFlag signedFlag, DateTime date)
        {
            string query = EntryControl.Resources.Doc.MaterialPermit.SetSigned;
            QueryParameters parameters = new QueryParameters("signedFlag", (short)signedFlag);
            parameters.Add("signDate", date);
            parameters.Add("signer", database.ConnectedUser.Id);
            parameters.Add("modifier", database.ConnectedUser.Id);
            parameters.Add("id", Id);

            database.ExecuteQuery(query, parameters);
        }

        public override bool Equals(object obj)
        {
            MaterialPermit otherDocument = obj as MaterialPermit;
            if (otherDocument != null)
                return Id.Equals(otherDocument.Id);

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        #endregion

        public enum MaterialPermitFlag
        {
            Failed = -1,    
            Unknown = 0,
            Confirmed = 1
        }
    }
}

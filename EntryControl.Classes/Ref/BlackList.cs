using EPV.Database;
using EPV.DataItem;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace EntryControl.Classes.Ref
{
    /// <summary>
    ///     Строка Черного списка
    /// </summary>
    public class BlackList : DataItem
    {
        #region Properties

        #region Text

        private string text;
        /// <summary>
        ///     Текст строки
        /// </summary>
        [DataField("Text")]
        public string Text
        {
            get { return text; }
            set { SetField(nameof(text), value, 100); }
        }

        #endregion

        #region Queries

        #region GeneratorName

        /// <summary>
        ///     имя генератора
        /// </summary>
        protected override string GeneratorName => EntryControl.Resources.Ref.BlackList.GeneratorName;

        #endregion

        #region DeleteQuery

        protected override string DeleteQuery => EntryControl.Resources.Ref.BlackList.Delete;

        #endregion

        #region InsertQuery

        protected override string InsertQuery => EntryControl.Resources.Ref.BlackList.Insert;

        #endregion

        #region LoadQuery

        public static string LoadQuery => EntryControl.Resources.Ref.BlackList.Load;

        #endregion

        #region LoadListQuery

        public static string LoadListQuery => EntryControl.Resources.Ref.BlackList.LoadList;

        #endregion

        #region UpdateQuery

        protected override string UpdateQuery => EntryControl.Resources.Ref.BlackList.Update;

        #endregion

        #endregion

        #endregion

        #region Ctors

        public BlackList() : base() { }

        public BlackList(int id, string descr) : base(id, descr) { }

        public BlackList(DbDataReader reader) : base(reader) { }

        #endregion

        #region Methods

        #region InitializeProperties

        protected override void InitializeProperties()
        {
            text = "черный список";
        }

        #endregion

        #region ReadProperties

        protected override void ReadProperties(DbDataReader reader)
        {
            text = (string)reader["text"];
        }

        #endregion

        #region StringDescription

        protected override string StringDescription() => Text;

        #endregion

        #region LoadList

        public static List<BlackList> LoadList(Database database)
        {
            List<BlackList> blackListItems = new List<BlackList>();

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    blackListItems.Add(new BlackList(reader));

                reader.Close();
            }

            return blackListItems;
        }

        #endregion

        #region Save

        public override void Save(Database database)
        {
            if (string.IsNullOrEmpty(Text) && (rowState == RowState.Inserted || rowState == RowState.Updated))
            {
                ClearModified();
                throw new ArgumentException("Нельзя добавить в черный список пустой элемент");
            }
            base.Save(database);
        }

        #endregion

        #region CheckText

        public static bool CheckText(Database database, string text)
        {
            QueryParameters parameters = new QueryParameters("text", text);
            int isInList = (int)database.ExecuteScalar(EntryControl.Resources.Ref.BlackList.CheckText, parameters);

            return (isInList > 0);
        }

        #endregion

        #endregion
    }
}

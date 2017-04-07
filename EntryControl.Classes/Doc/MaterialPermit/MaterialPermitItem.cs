using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class MaterialPermitItem
    {
        public int Id { get; private set; }

        public MaterialPermit Document { get; private set; }

        public string Material { get; private set; }

        public string MaterialUnit { get; private set; }

        public decimal Quantity { get; private set; }

        public decimal Tonnage { get; private set; }

        public MaterialPermitItem(DbDataReader reader, MaterialPermit document)
        {
            Id = (int)reader["id"];
            Document = document;
            Material = (string)reader["material"];
            MaterialUnit = (string)reader["materialUnit"];
            Quantity = (decimal)reader["quantity"];
            Tonnage = (decimal)reader["tonnage"];
        }

        public static List<MaterialPermitItem> LoadList(Database database, MaterialPermit document)
        {
            List<MaterialPermitItem> itemList = new List<MaterialPermitItem>();

            string query = EntryControl.Resources.Doc.MaterialPermit.LoadItemList;
            QueryParameters parameters = new QueryParameters("id", document.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    itemList.Add(new MaterialPermitItem(reader, document));
                reader.Close();
            }

            return itemList;
        }
    }
}

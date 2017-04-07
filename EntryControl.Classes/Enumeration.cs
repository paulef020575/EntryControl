using System;
using System.Collections.Generic;
using System.Text;
using EPV.Database;
using System.Data.Common;

namespace EntryControl.Classes
{
    public class Enumeration : Dictionary<int, EnumerationItem>
    {
        private string EnumerationName;

        private Enumeration() { }

        public Enumeration(Database database, string enumerationName)
            : base()
        {
            EnumerationName = enumerationName;

            string query = EntryControl.Resources.Query.EnumerationLoad;
            QueryParameters parameters = new QueryParameters("enumerationName", EnumerationName);

               using (DbDataReader reader = database.ExecuteReader(query, parameters))
                {
                    while (reader.Read())
                    {
                        Add((int)reader["id"], new EnumerationItem(reader));
                    }

                    reader.Close();
                }
            

        }

    }
}

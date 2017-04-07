using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class ContractorContact
    {
        private Contractor Contractor;

        public EnumerationItem ContactType { get; private set; }

        public string ContactValue { get; set; }

        private bool IsEmpty
        {
            get 
            {
                return (ContactValue == null || ContactValue.Trim().Length == 0);
            }
        }

        private ContractorContact() { }

        public ContractorContact(Contractor contractor, Enumeration typeList, DbDataReader reader)
        {
            Contractor = contractor;
            ContactType = typeList[(int)reader["id"]];
            ContactValue = (DBNull.Value.Equals(reader["contactValue"]) ? "" : (string)reader["contactValue"]);
        }

        public void Save(Connection connection)
        {
            if (IsEmpty)
                DeleteContact(connection);
            else
                SaveContact(connection);
        }

        private void SaveContact(Connection connection)
        {
            string query = EntryControl.Resources.Ref.Contractor.ContactInsert;
            QueryParameters parameters = new QueryParameters("contractor", Contractor.Id);
            parameters.Add("contactType", ContactType.Id);
            parameters.Add("contactValue", ContactValue);

            connection.ExecuteQuery(query, parameters);
        }

        private void DeleteContact(Connection connection)
        {
            string query = EntryControl.Resources.Ref.Contractor.ContactDelete;
            QueryParameters parameters = new QueryParameters("contractor", Contractor.Id);
            parameters.Add("contactType", ContactType.Id);

            connection.ExecuteQuery(query, parameters);
        }

        public static List<ContractorContact> LoadList(Database database, Contractor contractor)
        {
            Enumeration contactTypeList = new Enumeration(database, "contactType");

            List<ContractorContact> contactList = new List<ContractorContact>();

            string query = EntryControl.Resources.Ref.Contractor.ContactLoadList;
            QueryParameters parameters = new QueryParameters("contractor", contractor.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    contactList.Add(new ContractorContact(contractor, contactTypeList, reader));
                }
                reader.Close();
            }

            return contactList;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using EPV.Database;

namespace EntryControl.Classes
{
    public class ContractorGroup
    {
        private Contractor Contractor;

        public EnumerationItem Group { get; private set; }

        public bool IsIncluded { get; set; }

        private ContractorGroup() { }

        public ContractorGroup(Contractor contractor, Enumeration groupList, DbDataReader reader)
        {
            Contractor = contractor;
            Group = groupList[(int)reader["id"]];
            IsIncluded = ((int)reader["cnt"]) > 0;
        }

        public void Save(Connection connection)
        {
            if (IsIncluded)
                SaveGroup(connection);
            else
                DeleteGroup(connection);
        }

        private void DeleteGroup(Connection connection)
        {
            string query = EntryControl.Resources.Ref.Contractor.GroupDelete;
            QueryParameters parameters = new QueryParameters("contractor", Contractor.Id);
            parameters.Add("contractorGroup", Group.Id);

            connection.ExecuteQuery(query, parameters);
        }

        private void SaveGroup(Connection connection)
        {
            string query = EntryControl.Resources.Ref.Contractor.GroupInsert;
            QueryParameters parameters = new QueryParameters("contractor", Contractor.Id);
            parameters.Add("contractorGroup", Group.Id);

            connection.ExecuteQuery(query, parameters);
        }

        public static List<ContractorGroup> LoadList(Database database, Contractor contractor)
        {
            List<ContractorGroup> contractorGroupList = new List<ContractorGroup>();

            Enumeration groupList = new Enumeration(database, "contractorGroup");

            string query = EntryControl.Resources.Ref.Contractor.GroupLoadList;
            QueryParameters parameters = new QueryParameters("contractor", contractor.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    contractorGroupList.Add(new ContractorGroup(contractor, groupList, reader));

                reader.Close();
            }

            return contractorGroupList;
        }
    }
}

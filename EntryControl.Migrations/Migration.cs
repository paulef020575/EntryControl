using EPV.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntryControl.Migrations
{
    public abstract class Migration
    {
        public abstract int Id { get; }
        public abstract void Up(FbDatabase database);
        public abstract void Down(FbDatabase database);

        public void Apply(string connectionString)
        {
            FbDatabase database = new FbDatabase(connectionString);

            Up(database);

            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("dateMigration", DateTime.Now);
            database.ExecuteQuery(Common.InsertMigrationInfo, parameters);
        }
    }
}

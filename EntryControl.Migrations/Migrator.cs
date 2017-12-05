using EPV.Database;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EntryControl.Migrations
{
    public class Migrator
    {
        private string ConnectionString { get; set; }

        public Migrator(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void UpdateToLatest()
        {
            int version = GetCurrentDbVersion();

            IEnumerable<Type> typeList = Assembly.GetAssembly(typeof(Migration)).GetTypes();
            SortedDictionary<int, Migration> migrationList = new SortedDictionary<int, Migration>();
            foreach (Type type in typeList)
            {
                if (type.IsSubclassOf(typeof(Migration)))
                {
                    Migration migration = (Migration)Activator.CreateInstance(type);
                    if (migration.Id > version)
                        migrationList.Add(migration.Id, migration);
                }
            }

            foreach (Migration migration in migrationList.Values)
                migration.Apply(ConnectionString);
        }

        private int GetCurrentDbVersion()
        {
            FbDatabase database = new FbDatabase(ConnectionString);

            int isReadyForMigration = (int)database.ExecuteScalar(Common.CheckMigrationReady);

            if (isReadyForMigration == 0)
            {
                PrepareDatabase(database);
            }

            object lastId = database.ExecuteScalar(Common.GetLastMigrationId);

            return (lastId == null || DBNull.Value.Equals(lastId) ? 0 : (int)lastId);

        }

        private void PrepareDatabase(FbDatabase database)
        {
            database.ExecuteQuery(Common.CreateMigrationTable);
        }
    }
}

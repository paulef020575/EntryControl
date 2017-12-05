using System;
using System.Collections.Generic;
using System.Text;
using EPV.Database;

namespace EntryControl.Migrations
{
    public class M2017112501_CreateDocPermitPoint : Migration
    {
        public override int Id => 2017112501;

        public override void Down(FbDatabase database)
        {
            throw new NotImplementedException();
        }

        public override void Up(FbDatabase database)
        {
            database.ExecuteQuery(Scripts.M2017112501.CreateTable);
            database.ExecuteQuery(Scripts.M2017112501.CreatePermitFk);
            database.ExecuteQuery(Scripts.M2017112501.CreatePointFK);
            database.ExecuteQuery(Scripts.M2017112501.FillTable);
        }
    }
}

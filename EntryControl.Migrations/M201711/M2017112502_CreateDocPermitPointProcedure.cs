using System;
using System.Collections.Generic;
using System.Text;
using EPV.Database;

namespace EntryControl.Migrations
{
    public class M2017112502_CreateDocPermitPointProcedure : Migration
    {
        public override int Id => 2017112502;

        public override void Down(FbDatabase database)
        {
            throw new NotImplementedException();
        }

        public override void Up(FbDatabase database)
        {
            database.ExecuteQuery(Scripts.M2017112502.CreateProcedure);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using EPV.Database;

namespace EntryControl.Migrations
{
    public class M2017122301 : Migration
    {
        public override int Id => 2017122301;

        public override void Down(FbDatabase database)
        {
            throw new NotImplementedException();
        }

        public override void Up(FbDatabase database)
        {
            //database.ExecuteQuery(Scripts.M2017122301.CreateTable);
            //database.ExecuteQuery(Scripts.M2017122301.CreateIndex);
            //database.ExecuteQuery(Scripts.M2017122301.CreateForeignKey);
            database.ExecuteQuery(Scripts.M2017122301.CreateProcedure);
        }
    }
}

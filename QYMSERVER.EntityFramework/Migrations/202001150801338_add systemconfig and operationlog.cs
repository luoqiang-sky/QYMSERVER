namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addsystemconfigandoperationlog : DbMigration
    {
        //public override void Up()
        //{
        //    RenameTable(name: "dbo.OPERATIONLOG", newName: "SYS_OPERATIONLOG");
        //    RenameTable(name: "dbo.SYSTEMCONFIG", newName: "SYS_CONFIG");
        //}

        //public override void Down()
        //{
        //    RenameTable(name: "dbo.SYS_CONFIG", newName: "SYSTEMCONFIG");
        //    RenameTable(name: "dbo.SYS_OPERATIONLOG", newName: "OPERATIONLOG");
        //}
        public override void Up()
        {
            CreateTable(
                "dbo.SYS_OPERATIONLOG",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ITEMNAME = c.String(),
                    LASTVALUE = c.String(),
                    VALUE = c.String(),
                    MODIFYTYPE = c.String(),
                    MODIFYOPERATOR = c.String(),
                    MODIFYTIME = c.DateTime(),
                    REMARK = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.SYS_CONFIG",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    KEY = c.String(),
                    VALUE = c.String(),
                })
                .PrimaryKey(t => t.Id);

            //DropTable("dbo.TestEntity");
        }

        public override void Down()
        {
            CreateTable(
            "dbo.TestEntity",
            c => new
            {
                Id = c.Int(nullable: false, identity: true),
                AAA = c.Int(),
                BBB = c.String(),
                CCC = c.String(),
                DDD = c.String(),
                EEE = c.String(),
            })
            .PrimaryKey(t => t.Id);

            DropTable("dbo.SYSTEMCONFIG");
            DropTable("dbo.OPERATIONLOG");
        }
    }
}

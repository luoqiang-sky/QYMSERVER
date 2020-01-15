namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADD_MACHINE_TABLE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.H_MACHINES",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NAME = c.String(),
                        EQUIPMENTID = c.String(),
                        CATEGORY = c.String(),
                        WRKCTRID = c.String(),
                        WRKCTRGROUP = c.String(),
                        TOBOTSITE = c.String(),
                        STATUS = c.String(),
                        DATEOFPEODUCTION = c.DateTime(),
                        MANUFACTURER = c.String(),
                        CHARGEPERSON = c.String(),
                        EMERGENCYPERSON = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.H_MACHINES");
        }
    }
}

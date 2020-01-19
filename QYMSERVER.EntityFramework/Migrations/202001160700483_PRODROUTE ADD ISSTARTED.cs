namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PRODROUTEADDISSTARTED : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PRODROUTE", "ISSTARTED", c => c.Int(nullable: false,defaultValue:0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PRODROUTE", "ISSTARTED");
        }
    }
}

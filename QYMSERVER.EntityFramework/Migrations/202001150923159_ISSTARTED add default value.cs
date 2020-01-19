namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ISSTARTEDadddefaultvalue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PRODTABLE", "ISSTARTED", c => c.Int(nullable: false,defaultValue:0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PRODTABLE", "ISSTARTED", c => c.Int());
        }
    }
}

namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Machinesadddefaultvalue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.H_MACHINES", "STATUS", c => c.Int(nullable: false,defaultValue:0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.H_MACHINES", "STATUS", c => c.String());
        }
    }
}

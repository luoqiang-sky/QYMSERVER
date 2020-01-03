namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTsetEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestEntity", "EEE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TestEntity", "EEE");
        }
    }
}

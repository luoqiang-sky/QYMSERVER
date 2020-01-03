namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Test_Entity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AAA = c.Int(),
                        BBB = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestEntity");
        }
    }
}

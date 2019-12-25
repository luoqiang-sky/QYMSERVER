namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitSQL : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.AbpSettings", new[] { "TenantId" });
            CreateTable(
                "dbo.TaskKs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssignePersonId = c.Long(),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AbpUsers", t => t.AssignePersonId)
                .Index(t => t.AssignePersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskKs", "AssignePersonId", "dbo.AbpUsers");
            DropIndex("dbo.TaskKs", new[] { "AssignePersonId" });
            DropTable("dbo.TaskKs");
            CreateIndex("dbo.AbpSettings", "TenantId");
        }
    }
}

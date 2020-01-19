namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pdodrouteadddefaultvalue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PRODJOURNALROUTE", "ERRORCAUSE", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "CANCELLED", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "RECVERSION", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "RECID", c => c.Long());
            AlterColumn("dbo.PRODJOURNALROUTE", "OPRNUM", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "JOBTYPE", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "OPRFINISHED", c => c.Int(defaultValue:0));
            AlterColumn("dbo.PRODJOURNALROUTE", "EXECUTEDPCT", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODJOURNALROUTE", "JOBFINISHED", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "OPRPRIORITY", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "FROMTIME", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "TOTIME", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "PRODREPORTFINISHED", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "PRODPICKLIST", c => c.Int());
            AlterColumn("dbo.PRODJOURNALROUTE", "IWS_WRKSTATUS", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "ISSTARTED", c => c.Int(defaultValue:0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PRODROUTE", "ISSTARTED", c => c.Int(nullable: false,defaultValue:0));
            AlterColumn("dbo.PRODJOURNALROUTE", "IWS_WRKSTATUS", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "PRODPICKLIST", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "PRODREPORTFINISHED", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "TOTIME", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "FROMTIME", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "OPRPRIORITY", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "JOBFINISHED", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "EXECUTEDPCT", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODJOURNALROUTE", "OPRFINISHED", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "JOBTYPE", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "OPRNUM", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "RECID", c => c.Long(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "RECVERSION", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "CANCELLED", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODJOURNALROUTE", "ERRORCAUSE", c => c.Int(nullable: false));
        }
    }
}

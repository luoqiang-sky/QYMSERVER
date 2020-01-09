namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_AllEntity_V2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PRODROUTE", "OPRNUM", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "LEVEL_", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "OPRNUMNEXT", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "QUEUETIMEBEFORE", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "SETUPTIME", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "PROCESSTIME", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "PROCESSPERQTY", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "TRANSPTIME", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "QUEUETIMEAFTER", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "OVERLAPQTY", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "ERRORPCT", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "ACCERROR", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "TOHOURS", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "TRANSFERBATCH", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "OPRFINISHED", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "FORMULAFACTOR1", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "ROUTETYPE", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "BACKORDERSTATUS", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "FROMDATE", c => c.DateTime());
            AlterColumn("dbo.PRODROUTE", "FROMTIME", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "TODATE", c => c.DateTime());
            AlterColumn("dbo.PRODROUTE", "TOTIME", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "CALCQTY", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "CALCSETUP", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "CALCPROC", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "WRKCTRTASKDEMAND", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "OPRPRIORITY", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "WRKCTRLOADPCT", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "WRKCTRNUMOF", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "FORMULA", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "LINKTYPE", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "OPRSTARTEDUP", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "EXECUTEDPROCESS", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "EXECUTEDSETUP", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "CONSTANTRELEASED", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "PHANTOMBOMFACTOR", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "RECVERSION", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "QY_OPRLEVEL", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "QY_FROMDATETIME", c => c.DateTime());
            AlterColumn("dbo.PRODROUTE", "QY_FROMDATETIMETZID", c => c.Int());
            AlterColumn("dbo.PRODROUTE", "QY_TODATETIME", c => c.DateTime());
            AlterColumn("dbo.PRODROUTE", "QY_TODATETIMETZID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PRODROUTE", "QY_TODATETIMETZID", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "QY_TODATETIME", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODROUTE", "QY_FROMDATETIMETZID", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "QY_FROMDATETIME", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODROUTE", "QY_OPRLEVEL", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "RECVERSION", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "PHANTOMBOMFACTOR", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "CONSTANTRELEASED", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "EXECUTEDSETUP", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "EXECUTEDPROCESS", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "OPRSTARTEDUP", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "LINKTYPE", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "FORMULA", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "WRKCTRNUMOF", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "WRKCTRLOADPCT", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "OPRPRIORITY", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "WRKCTRTASKDEMAND", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "CALCPROC", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "CALCSETUP", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "CALCQTY", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "TOTIME", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "TODATE", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODROUTE", "FROMTIME", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "FROMDATE", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODROUTE", "BACKORDERSTATUS", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "ROUTETYPE", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "FORMULAFACTOR1", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "OPRFINISHED", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "TRANSFERBATCH", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "TOHOURS", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "ACCERROR", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "ERRORPCT", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "OVERLAPQTY", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "QUEUETIMEAFTER", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "TRANSPTIME", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "PROCESSPERQTY", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "PROCESSTIME", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "SETUPTIME", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "QUEUETIMEBEFORE", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODROUTE", "OPRNUMNEXT", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "LEVEL_", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODROUTE", "OPRNUM", c => c.Int(nullable: false));
        }
    }
}

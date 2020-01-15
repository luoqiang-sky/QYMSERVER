namespace QYMSERVER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PRODIDTABLENULLABLE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PRODROUTE", "ROBOTTARGET", c => c.String());
            AddColumn("dbo.PRODROUTE", "STANDARDTIME", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "PRODSTATUS", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "PRODPRIO", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "PRODLOCKED", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "PRODTYPE", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "SCHEDSTATUS", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "SCHEDDATE", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "QTYSCHED", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "QTYSTUP", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "DLVDATE", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "FINISHEDDATE", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "SCHEDSTART", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "SCHEDEND", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "BOMDATE", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "BACKORDERSTATUS", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "DLVTIME", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_SCRAPRESEND", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_PRODUCTIONTYPE", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_LINETYPE", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_ISSUSPEND", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_DIAODUDATETIME", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "IWS_DIAODUDATETIMETZID", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_ISNEWPRODUCTION", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_TOTALLENGTH", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_MINLINEWIDTHINMARKET", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_CDACCURACY", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_LINEWIDEFROM", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "SHIPPINGDATEREQUESTED", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "IWS_SPECIFICATIONS", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_SPECIFICATIONS2_", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_SPECIFICATIONS3_", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_SALESORDERDATE", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "IWS_SALESORDERDATETZID", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_SUPERVISETYPE", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "IWS_PLANDLVFLAG", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "CREATEDDATETIME", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "QY_ISCAMNEEDEDAOI", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "AOICREATEDDATETIME", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "AOICREATEDDATETIMETZID", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "QY_PREPUTINDATE", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "QY_PREPUTINDATETZID", c => c.Int());
            AlterColumn("dbo.PRODTABLE", "QY_PREEXPOSEDATE", c => c.DateTime());
            AlterColumn("dbo.PRODTABLE", "QY_PREEXPOSEDATETZID", c => c.Int());
            DropColumn("dbo.PRODROUTE", "PROCESSPERQTY");
            DropColumn("dbo.PRODROUTE", "TRANSPTIME");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PRODROUTE", "TRANSPTIME", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.PRODROUTE", "PROCESSPERQTY", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "QY_PREEXPOSEDATETZID", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "QY_PREEXPOSEDATE", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "QY_PREPUTINDATETZID", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "QY_PREPUTINDATE", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "AOICREATEDDATETIMETZID", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "AOICREATEDDATETIME", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "QY_ISCAMNEEDEDAOI", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "CREATEDDATETIME", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_PLANDLVFLAG", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_SUPERVISETYPE", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_SALESORDERDATETZID", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_SALESORDERDATE", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_SPECIFICATIONS3_", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_SPECIFICATIONS2_", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_SPECIFICATIONS", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "SHIPPINGDATEREQUESTED", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_LINEWIDEFROM", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_CDACCURACY", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_MINLINEWIDTHINMARKET", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "IWS_TOTALLENGTH", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_ISNEWPRODUCTION", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_DIAODUDATETIMETZID", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_DIAODUDATETIME", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_ISSUSPEND", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_LINETYPE", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_PRODUCTIONTYPE", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "IWS_SCRAPRESEND", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "DLVTIME", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "BACKORDERSTATUS", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "BOMDATE", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "SCHEDEND", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "SCHEDSTART", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "FINISHEDDATE", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "DLVDATE", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "QTYSTUP", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "QTYSCHED", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PRODTABLE", "SCHEDDATE", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PRODTABLE", "SCHEDSTATUS", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "PRODTYPE", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "PRODLOCKED", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "PRODPRIO", c => c.Int(nullable: false));
            AlterColumn("dbo.PRODTABLE", "PRODSTATUS", c => c.Int(nullable: false));
            DropColumn("dbo.PRODROUTE", "STANDARDTIME");
            DropColumn("dbo.PRODROUTE", "ROBOTTARGET");
        }
    }
}

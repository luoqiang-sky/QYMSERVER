using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using QYMSERVER.Authorization.Roles;
using QYMSERVER.Authorization.Users;
using QYMSERVER.Entities.BOM;
using QYMSERVER.Entities.Checkout;
using QYMSERVER.Entities.Equipment;
using QYMSERVER.Entities.Equipment.Alarm;
using QYMSERVER.Entities.Equipment.Maintain;
using QYMSERVER.Entities.Equipment.Parameter;
using QYMSERVER.Entities.IWS;
using QYMSERVER.Entities.Product;
using QYMSERVER.Entities.ProductReport;
using QYMSERVER.Entities.SystemConfig;
using QYMSERVER.MultiTenancy;

namespace QYMSERVER.EntityFramework
{
    public class QYMSERVERDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public DbSet<PRODBOM> PRODBOMs { get; set; }
        public DbSet<PRODJOURNALBOM> PRODJOURNALBOMs { get; set; }

        public DbSet<QY_CHECK_CDTABLE> QY_CHECK_CDTABLEs { get; set; }
        public DbSet<QY_CHECK_TPTABLE> QY_CHECK_TPTABLEs { get; set; }
        public DbSet<IWS_CHECK_AOITABLE> IWS_CHECK_AOITABLEs { get; set; }
        public DbSet<IWS_CHECK_INNERPACKTABLE> IWS_CHECK_INNERPACKTABLEs { get; set; }
        public DbSet<IWS_CHECK_LONGSIZETABLE> IWS_CHECK_LONGSIZETABLEs { get; set; }
        public DbSet<IWS_CHECK_PELLICLETABLE> IWS_CHECK_PELLICLETABLEs { get; set; }
        public DbSet<IWS_CHECK_REPAIRTABLE> IWS_CHECK_REPAIRTABLEs { get; set; }
        public DbSet<IWS_CHECK_WASHTABLE> IWS_CHECK_WASHTABLEs { get; set; }

        public DbSet<H_EQUIPMENTALARM> H_EQUIPMENTALARMs { get; set; }
        public DbSet<H_EQUIPMENT_PHOTOETCHING> H_EQUIPMENT_PHOTOETCHINGs { get; set; }
        public DbSet<H_EQUIPMENT_REPAIR> H_EQUIPMENT_REPAIRs { get; set; }

        public DbSet<IWS_CAMCRAFTCMDEQPCONFIGTABLE> IWS_CAMCRAFTCMDEQPCONFIGTABLEs { get; set; }
        public DbSet<IWS_CAMCRAFTCMDMATERIALTABLE> IWS_CAMCRAFTCMDMATERIALTABLEs { get; set; }
        public DbSet<IWS_CAMCRAFTCMDTRADETABLE> IWS_CAMCRAFTCMDTRADETABLEs { get; set; }
        public DbSet<IWS_CAMDESIGNPARAMTABLE> IWS_CAMDESIGNPARAMTABLEs { get; set; }
        public DbSet<IWS_CUSTPARATRADETABLE> IWS_CUSTPARATRADETABLEs { get; set; }
        public DbSet<IWS_JINGDUQUEXIANPARAMETER> IWS_JINGDUQUEXIANPARAMETERs { get; set; }
        public DbSet<IWS_PRODUCTPARAMETER> IWS_PRODUCTPARAMETERs { get; set; }
        public DbSet<ROUTEOPRTABLE> ROUTEOPRTABLEs { get; set; }
        public DbSet<WRKCTRTABLE> WRKCTRTABLEs { get; set; }

        public DbSet<PRODROUTE> PRODROUTEs { get; set; }
        public DbSet<PRODTABLE> PRODTABLEs { get; set; }

        public DbSet<PRODJOURNALROUTE> PRODJOURNALROUTEs { get; set; }

        public DbSet<Machines> Machines { get; set; }
        public DbSet<SYS_OPERATIONLOG> OPERATIONLOGs { get; set; }
        public DbSet<SYS_CONFIG> SYSTEMCONFIGs { get; set; }


        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public QYMSERVERDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in QYMSERVERDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of QYMSERVERDbContext since ABP automatically handles it.
         */
        public QYMSERVERDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public QYMSERVERDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public QYMSERVERDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}

using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.IWS
{
    /// <summary>
    /// 修补
    /// </summary>
    [Table("IWS_CHECK_REPAIRTABLE")]
    public class IWS_CHECK_REPAIRTABLE:Entity
    {
        public string PRODID { get; set; }
        public int REPAIRZAPBLACKNUM { get; set; }
        public int REPAIRZAPBURRNUM { get; set; }
        public int REPAIRZAPLINKNUM { get; set; }
        public int REPAIRZAPTOTALNUM { get; set; }
        public int REPAIRZAPRBLACKNUM { get; set; }
        public int REPAIRZAPRBURRNUM { get; set; }
        public int REPAIRZAPRLINKNUM { get; set; }
        public int REPAIRZAPRTOTALNUM { get; set; }
        public int REPAIRZAPBUGID { get; set; }
        public string REPAIRZAPCRAFTNAME { get; set; }
        public string REPAIRZAPPICNAME { get; set; }
        public string REPAIRZAPOTHERS { get; set; }
        public string REPAIRCVDTRY { get; set; }
        public int REPAIRCVDHOLENUM { get; set; }
        public int REPAIRCVDHOLLOWNUM { get; set; }
        public int REPAIRCVDCUTNUM { get; set; }
        public int REPAIRCVDTOTALNUM { get; set; }
        public int REPAIRCVDRHOLENUM { get; set; }
        public int REPAIRCVDRHOLLOWNUM { get; set; }
        public int REPAIRCVDRCUTNUM { get; set; }
        public int REPAIRCVDRTOTALNUM { get; set; }
        public int REPAIRCVDBUGID { get; set; }
        public string REPAIRCVDCRAFTNAME { get; set; }
        public string REPAIRCVDPICNAME { get; set; }
        public string REPAIRCVDOTHERS { get; set; }
        public string REPAIRDOZAP { get; set; }
        public string REPAIRDOZAPREMARKS { get; set; }
        public string REPAIRCVDPHOTIC { get; set; }
        public string REPAIRSURFACE { get; set; }
        public string REPAIRCONFIRM { get; set; }
        public string REPAIRBUGTYPE { get; set; }
        public string REPAIRBUGNO { get; set; }
        public string REPAIRTYPE { get; set; }
        public string REPAIRSURFACERE { get; set; }
        public string REPAIRCONFIRMRE { get; set; }
        public int REPAIRBLACKTOTALNUM { get; set; }
        public int REPAIRBURRTOTALNUM { get; set; }
        public int REPAIRLINKTOTALNUM { get; set; }
        public int REPAIRHOLETOTALNUM { get; set; }
        public int REPAIRHOLLOWTOTALNUM { get; set; }
        public int REPAIRCUTTOTALNUM { get; set; }
        public int REPAIRZAPOK1 { get; set; }
        public int REPAIRZAPOK2 { get; set; }
        public int REPAIRZAPOK3 { get; set; }
        public int REPAIRZAPOK4 { get; set; }
        public int REPAIRZAPOK5 { get; set; }
        public int REPAIRZAPOK6 { get; set; }
        public int REPAIRZAPOK7 { get; set; }
        public int REPAIRZAPOK8 { get; set; }
        public int REPAIRSURFACEOK { get; set; }
        public int REPAIRCONFIRMOK { get; set; }
        public int REPAIRREOK1 { get; set; }
        public int REPAIRREOK2 { get; set; }
        public int REPAIRREOK3 { get; set; }
        public int REPAIRREOK4 { get; set; }
        public int REPAIRREOK5 { get; set; }
        public int REPAIRBUGTOTALNUMOK { get; set; }
        public string REPAIROPERATOR { get; set; }
        public System.DateTime REPAIRTIME { get; set; }
        public int REPAIRTIMETZID { get; set; }
        public int INVALID { get; set; }
        public string PRODSERIAL { get; set; }
        public string OPRID { get; set; }
        public string REPAIRINK { get; set; }
        public string REPAIRLCVD { get; set; }
        public string REPAIRAFILM { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public System.DateTime MODIFIEDDATETIME { get; set; }
        public System.DateTime CREATEDDATETIME { get; set; }
        public string MODIFIEDBY { get; set; }
        public string CREATEDBY { get; set; }
        public int ISSHIPMENTREPORT { get; set; }
        public string ZAPOPERATOR { get; set; }
        public string CVDOPERATOR { get; set; }
    }
}

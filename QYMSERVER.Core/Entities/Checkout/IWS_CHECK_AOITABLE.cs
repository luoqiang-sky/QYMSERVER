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
    /// AOI检验
    /// </summary>
    [Table("IWS_CHECK_AOITABLE")]
    public class IWS_CHECK_AOITABLE : Entity
    {
        public int INVALID { get; set; }
        public string PRODSERIAL { get; set; }
        public string PRODID { get; set; }
        public string AOIEQUIPMENT { get; set; }
        public int AOIDIETODIE { get; set; }
        public int AOIDIELOWSLOW { get; set; }
        public int AOIDIELOWFAST { get; set; }
        public int AOIDIESFAST { get; set; }
        public int AOIDIEHIGHSLOW { get; set; }
        public int AOIDIEHIGHFAST { get; set; }
        public int AOIDIETRANS { get; set; }
        public int AOIDIEREVER { get; set; }
        public int AOIDIESHIELD1 { get; set; }
        public int AOIDIESHIELD2 { get; set; }
        public int AOIDIESHIELD3 { get; set; }
        public int AOIDIESHIELD4 { get; set; }
        public string AOIDIESTATO { get; set; }
        public string AOIDIEFILENAME { get; set; }
        public int AOIDIEBLACKBUGNUM { get; set; }
        public int AOIDIEWHITEBUGNUM { get; set; }
        public int AOIDIEDIRTHNUM { get; set; }
        public string AOIDIETODIERESULT { get; set; }
        public string AOIDIEOPERATOR { get; set; }
        public int AOIDIETODB { get; set; }
        public int AOIDBLOWSLOW { get; set; }
        public int AOIDBLOWFAST { get; set; }
        public int AOIDBHIGHSLOW { get; set; }
        public int AOIDBHIGHFAST { get; set; }
        public int AOIDBTRANS { get; set; }
        public int AOIDBREVER { get; set; }
        public string AOIDBV { get; set; }
        public string AOIDBH { get; set; }
        public string AOIDBCONVO { get; set; }
        public int AOIDBREVERSE { get; set; }
        public int AOIDBCORNERCUT { get; set; }
        public int AOIDBHALFTONE { get; set; }
        public string AOIDBSTATO { get; set; }
        public string AOISCALEX { get; set; }
        public string AOISCALEY { get; set; }
        public decimal AOIDBSPEC { get; set; }
        public string AOIDBFILENAME { get; set; }
        public int AOIDBBLACKBUGNUM { get; set; }
        public int AOIDBWHITEBUGNUM { get; set; }
        public int AOIDBDIRTHNUM { get; set; }
        public string AOIDBTODIERESULT { get; set; }
        public string AOIDBOPERATOR { get; set; }
        public string AOIBUGTYPE1 { get; set; }
        public string AOIBUGTYPE2 { get; set; }
        public string AOIBUGTYPE3 { get; set; }
        public string AOIBUGTYPE4 { get; set; }
        public string AOIBUGTYPE5 { get; set; }
        public string AOIBUGTYPE6 { get; set; }
        public string AOIBUGTYPE7 { get; set; }
        public string AOIBUGTYPE8 { get; set; }
        public System.DateTime AOIOPERATETIME { get; set; }
        public int AOIOPERATETIMETZID { get; set; }
        public string AOIBUGPOSX1 { get; set; }
        public string AOIBUGPOSX2 { get; set; }
        public string AOIBUGPOSX3 { get; set; }
        public string AOIBUGPOSX4 { get; set; }
        public string AOIBUGPOSX5 { get; set; }
        public string AOIBUGPOSX6 { get; set; }
        public string AOIBUGPOSX7 { get; set; }
        public string AOIBUGPOSX8 { get; set; }
        public string AOIBUGPOSSIZE1 { get; set; }
        public string AOIBUGPOSSIZE2 { get; set; }
        public string AOIBUGPOSSIZE3 { get; set; }
        public string AOIBUGPOSSIZE4 { get; set; }
        public string AOIBUGPOSSIZE5 { get; set; }
        public string AOIBUGPOSSIZE6 { get; set; }
        public string AOIBUGPOSSIZE7 { get; set; }
        public string AOIBUGPOSSIZE8 { get; set; }
        public string AOIBUGPOSY1 { get; set; }
        public string AOIBUGPOSY2 { get; set; }
        public string AOIBUGPOSY3 { get; set; }
        public string AOIBUGPOSY4 { get; set; }
        public string AOIBUGPOSY5 { get; set; }
        public string AOIBUGPOSY6 { get; set; }
        public string AOIBUGPOSY7 { get; set; }
        public string AOIBUGPOSY8 { get; set; }
        public string OPRID { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public System.DateTime MODIFIEDDATETIME { get; set; }
        public System.DateTime CREATEDDATETIME { get; set; }
        public string MODIFIEDBY { get; set; }
        public string CREATEDBY { get; set; }
        public string OPRNAME { get; set; }
        public int ISSHIPMENTREPORT { get; set; }
        public string ZAPOPERATOR { get; set; }
        public string CVDOPERATOR { get; set; }
        public string AOIWRKCTRNAME { get; set; }
        public string AOIEQUIPMENT1 { get; set; }
        public string AOIEQUIPMENT2 { get; set; }
        public string AOIEQUIPMENT3 { get; set; }
        public string AOIWRKCTRNAME1 { get; set; }
        public string AOIWRKCTRNAME2 { get; set; }
        public string AOIWRKCTRNAME3 { get; set; }
        public int AOIBLACKBUGNUM1 { get; set; }
        public int AOIWHITEBUGNUM1 { get; set; }
        public int AOIWHITEBUGNUM2 { get; set; }
        public int AOIBLACKBUGNUM2 { get; set; }
        public int AOIWHITEBUGNUM3 { get; set; }
        public int AOIBLACKBUGNUM3 { get; set; }
        public int AOIWHITEBUGNUM4 { get; set; }
        public int AOIBLACKBUGNUM4 { get; set; }
        public int ISCHECKBYAREA { get; set; }
        public Nullable<int> Completion { get; set; }
    }
}

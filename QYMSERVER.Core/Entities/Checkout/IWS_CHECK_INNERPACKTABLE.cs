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
    /// 内包装
    /// </summary>
    [Table("IWS_CHECK_INNERPACKTABLE")]
    public class IWS_CHECK_INNERPACKTABLE : Entity
    {
        public string PRODID { get; set; }
        public int PACKBOXSIZE { get; set; }
        public int PACKBOXCLEANYES { get; set; }
        public int PACKBOXCLEANNO { get; set; }
        public int PACKBOXSTATICYES { get; set; }
        public int PACKBOXSTATICNO { get; set; }
        public string PACKMETHOD { get; set; }
        public string PACKOPERATOR1 { get; set; }
        public string PACKOPERATOR2 { get; set; }
        public string PACKOPERATOR3 { get; set; }
        public int PACKRESULT { get; set; }
        public string PACKREMARKS { get; set; }
        public System.DateTime PACKTIME { get; set; }
        public int PACKTIMETZID { get; set; }
        public string FQCCUSTOMER { get; set; }
        public string FQCMASKTITLE { get; set; }
        public string FQCLAYERNAME { get; set; }
        public string FQCMASKSIZE { get; set; }
        public string FQCMATERIAL { get; set; }
        public string FQCSUPERMASKLOT { get; set; }
        public string SHIPCUSTOMER { get; set; }
        public string SHIPMASKSIZE { get; set; }
        public string SHIPMATERIAL { get; set; }
        public string SHIPQTY { get; set; }
        public string SHIPNO { get; set; }
        public string SHIPCARTONNO { get; set; }
        public string FQCDATE { get; set; }
        public string SHIPDATE { get; set; }
        public int INVALID { get; set; }
        public string PRODSERIAL { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public System.DateTime MODIFIEDDATETIME { get; set; }
        public System.DateTime CREATEDDATETIME { get; set; }
        public string MODIFIEDBY { get; set; }
        public string CREATEDBY { get; set; }
        public int ISSHIPMENTREPORT { get; set; }
        public int PACKFOGNUM { get; set; }
        public int PACKBUTTNUM { get; set; }
        public int PACKCORNERNUM { get; set; }
        public int PACKDESTROYNUM { get; set; }
        public int PACKLINENUM { get; set; }
        public string PACKBOXMATERIALNO { get; set; }
        public string PACKBOXMATERIALBATCHNO { get; set; }
        public decimal PACKBOXUSENUM { get; set; }
        public string QUALITYRESULT { get; set; }
        public string ISSTRIPE6 { get; set; }
        public string ISSTRIPE5 { get; set; }
        public string ISSTRIPE4 { get; set; }
        public string ISSTRIPE3 { get; set; }
        public string ISSTRIPE2 { get; set; }
        public string ISSTRIPE1 { get; set; }
    }
}

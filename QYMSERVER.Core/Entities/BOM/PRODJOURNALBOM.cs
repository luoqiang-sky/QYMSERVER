using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.BOM
{
    /// <summary>
    /// 生产领料
    /// </summary>
    [Table("PRODJOURNALBOM")]
    public class PRODJOURNALBOM : Entity
    {
        public string JOURNALID { get; set; }
        public string VOUCHER { get; set; }
        public decimal LINENUM { get; set; }
        public string PRODID { get; set; }
        public System.DateTime TRANSDATE { get; set; }
        public string ITEMID { get; set; }
        public string PROJID { get; set; }
        public string INVENTTRANSID { get; set; }
        public string POSITION { get; set; }
        public decimal INVENTCONSUMP { get; set; }
        public decimal BOMCONSUMP { get; set; }
        public string BOMUNITID { get; set; }
        public decimal INVENTPROPOSAL { get; set; }
        public decimal BOMPROPOSAL { get; set; }
        public decimal BOMSCRAP { get; set; }
        public int ERRORCAUSE { get; set; }
        public string DIMENSION { get; set; }
        public string DIMENSION2_ { get; set; }
        public string DIMENSION3_ { get; set; }
        public int ENDCONSUMP { get; set; }
        public string INVENTDIMID { get; set; }
        public string INVENTTRANSCHILDREFID { get; set; }
        public int INVENTTRANSCHILDTYPE { get; set; }
        public int INVENTRETURNFLAG { get; set; }
        public int INVENTCONTROLPROPOSAL { get; set; }
        public string ACTIVITYNUMBER { get; set; }
        public string PROJCATEGORYID { get; set; }
        public string PROJLINEPROPERTYID { get; set; }
        public string PROJTRANSID { get; set; }
        public decimal PROJCOSTPRICE { get; set; }
        public decimal PROJCOSTAMOUNT { get; set; }
        public string PROJSALESCURRENCYID { get; set; }
        public decimal PROJSALESPRICE { get; set; }
        public string PROJTAXGROUPID { get; set; }
        public string PROJTAXITEMGROUPID { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public int OPRNUM { get; set; }
        public string IWS_INVENTSERIALID { get; set; }
    }
}

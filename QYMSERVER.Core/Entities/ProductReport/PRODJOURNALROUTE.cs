using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.ProductReport
{
    /// <summary>
    /// 生产报工
    /// </summary>
    [Table("PRODJOURNALROUTE")]
    public class PRODJOURNALROUTE : Entity
    {
        public string JOURNALID { get; set; }
        public string VOUCHER { get; set; }
        public decimal LINENUM { get; set; }
        public System.DateTime TRANSDATE { get; set; }
        public string PRODID { get; set; }
        public string WRKCTRID { get; set; }
        public decimal HOURPRICE { get; set; }
        public decimal QTYGOOD { get; set; }
        public decimal QTYERROR { get; set; }
        public int? ERRORCAUSE { get; set; }
        public string EMPLID { get; set; }
        public string DIMENSION { get; set; }
        public string DIMENSION2_ { get; set; }
        public string DIMENSION3_ { get; set; }
        public int? CANCELLED { get; set; }
        public string PRODINVENTDIMID { get; set; }
        public string PRODPICKLISTJOURNALID { get; set; }
        public string PRODREPORTFINISHEDJOURNALID { get; set; }
        public string DATAAREAID { get; set; }
        public int? RECVERSION { get; set; }
        public long? RECID { get; set; }
        public int? OPRNUM { get; set; }
        public int? JOBTYPE { get; set; }
        public decimal HOURS { get; set; }
        public string CATEGORYHOURSID { get; set; }
        public decimal QTYPRICE { get; set; }
        public int? OPRFINISHED { get; set; }
        public string CATEGORYQTYID { get; set; }
        public decimal? EXECUTEDPCT { get; set; }
        public int? JOBFINISHED { get; set; }
        public int? OPRPRIORITY { get; set; }
        public int? FROMTIME { get; set; }
        public int? TOTIME { get; set; }
        public string JOBID { get; set; }
        public string OPRID { get; set; }
        public int? PRODREPORTFINISHED { get; set; }
        public int? PRODPICKLIST { get; set; }
        public int? IWS_WRKSTATUS { get; set; }
        public decimal IWS_HOURS { get; set; }
        public decimal IWS_IPCAMOUNT { get; set; }
        public decimal IWS_SHEETGOOD { get; set; }
        public decimal IWS_SHEETERROR { get; set; }
        public decimal IWS_WEIGHTS { get; set; }
        public string IWS_EMPLNAME { get; set; }
        public System.DateTime CREATEDDATETIME { get; set; }
        public decimal QY_MINUTE { get; set; }
    }
}

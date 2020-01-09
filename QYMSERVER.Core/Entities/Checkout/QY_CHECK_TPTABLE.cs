using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.Checkout
{
    /// <summary>
    /// TP测量数据
    /// </summary>
    [Table("QY_CHECK_TPTABLE")]
    public class QY_CHECK_TPTABLE : Entity
    {
        public string DEVY { get; set; }
        public string DEVX { get; set; }
        public string NOMY { get; set; }
        public string NOMX { get; set; }
        public string ZCORRECTION { get; set; }
        public string ORTHO { get; set; }
        public string YSCALE { get; set; }
        public string XSCALE { get; set; }
        public string OPRID { get; set; }
        public int INVALID { get; set; }
        public string PRODSERIAL { get; set; }
        public string PRODID { get; set; }
        public System.DateTime CREATEDDATETIME { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
    }
}

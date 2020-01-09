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
    /// CD测量数据
    /// </summary>
    [Table("QY_CHECK_CDTABLE")]
    public class QY_CHECK_CDTABLE : Entity
    {
        public string Num { get; set; }
        public string CHECKDATA { get; set; }
        public string COORDINATEY { get; set; }
        public string COORDINATEX { get; set; }
        public string SPEC { get; set; }
        public string LINETYPE { get; set; }
        public string CDTYPE { get; set; }
        public string METHOD { get; set; }
        public string DESIGN { get; set; }
        public int GROUPID { get; set; }
        public string PRODID { get; set; }
        public string PRODSERIAL { get; set; }
        public int INVALID { get; set; }
        public string OPRID { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }

    }
}

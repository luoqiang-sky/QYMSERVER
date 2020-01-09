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
    /// 长尺寸测量
    /// </summary>
    [Table("IWS_CHECK_LONGSIZETABLE")]
    public class IWS_CHECK_LONGSIZETABLE:Entity
    {
        public string PRODID { get; set; }
        public decimal LONGCENTERTOLE { get; set; }
        public decimal LONGCENTERDESIGNX1 { get; set; }
        public decimal LONGCENTERDESIGNX2 { get; set; }
        public decimal LONGCENTERDESIGNX12 { get; set; }
        public decimal LONGCENTERDESIGNX22 { get; set; }
        public decimal LONGCENTERDESIGNY1 { get; set; }
        public decimal LONGCENTERDESIGNY2 { get; set; }
        public decimal LONGCENTERDESIGNY12 { get; set; }
        public decimal LONGCENTERDESIGNY22 { get; set; }
        public decimal LONGCENTERCHECKX1 { get; set; }
        public decimal LONGCENTERCHECKX2 { get; set; }
        public decimal LONGCENTERCHECKX12 { get; set; }
        public decimal LONGCENTERCHECKX22 { get; set; }
        public decimal LONGCENTERCHECKY1 { get; set; }
        public decimal LONGCENTERCHECKY2 { get; set; }
        public decimal LONGCENTERCHECKY12 { get; set; }
        public decimal LONGCENTERCHECKY22 { get; set; }
        public decimal LONGCENTERTOLEX1 { get; set; }
        public decimal LONGCENTERTOLEX2 { get; set; }
        public decimal LONGCENTERTOLEX12 { get; set; }
        public decimal LONGCENTERTOLEX22 { get; set; }
        public decimal LONGCENTERTOLEY1 { get; set; }
        public decimal LONGCENTERTOLEY2 { get; set; }
        public decimal LONGCENTERTOLEY12 { get; set; }
        public decimal LONGCENTERTOLEY22 { get; set; }
        public string LONGSIZECODE { get; set; }
        public string LONGSIZERESULT { get; set; }
        public System.DateTime LONGOPERATETIME { get; set; }
        public int LONGOPERATETIMETZID { get; set; }
        public string LONGREMARKS { get; set; }
        public int INVALID { get; set; }
        public string PRODSERIAL { get; set; }
        public string OPRID { get; set; }
        public decimal LONGSIZEDESIGNX1 { get; set; }
        public decimal LONGSIZEDESIGNX2 { get; set; }
        public decimal LONGSIZEDESIGNY1 { get; set; }
        public decimal LONGSIZEDESIGNY2 { get; set; }
        public decimal LONGSIZECHECKX1 { get; set; }
        public decimal LONGSIZECHECKX2 { get; set; }
        public decimal LONGSIZECHECKY1 { get; set; }
        public decimal LONGSIZECHECKY2 { get; set; }
        public decimal LONGSIZETOLEX1 { get; set; }
        public decimal LONGSIZETOLEX2 { get; set; }
        public decimal LONGSIZETOLEY1 { get; set; }
        public decimal LONGSIZETOLEY2 { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public decimal LONGSIZETOLE { get; set; }
        public System.DateTime MODIFIEDDATETIME { get; set; }
        public System.DateTime CREATEDDATETIME { get; set; }
        public string MODIFIEDBY { get; set; }
        public string CREATEDBY { get; set; }
        public decimal LONGCENTERDESIGNG { get; set; }
        public decimal LONGCENTERDESIGNH { get; set; }
        public decimal LONGCENTERCHECKG { get; set; }
        public decimal LONGCENTERCHECKH { get; set; }
        public decimal LONGCENTERTOLEG { get; set; }
        public decimal LONGCENTERTOLEH { get; set; }
        public int ISSHIPMENTREPORT { get; set; }
        public int ISLONGCENTERDESIGNADD { get; set; }
    }
}

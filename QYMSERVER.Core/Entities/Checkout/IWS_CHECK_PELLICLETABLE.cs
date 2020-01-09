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
    /// 贴膜
    /// </summary>
    [Table("IWS_CHECK_PELLICLETABLE")]
    public class IWS_CHECK_PELLICLETABLE : Entity
    {
        public string PRODID { get; set; }
        public string PRODSERIAL { get; set; }
        public int INVALID { get; set; }
        public decimal GUIDESPEC { get; set; }
        public decimal GUIDEDESIGN { get; set; }
        public decimal GUIDEMEASUREX1 { get; set; }
        public decimal GUIDEMEASUREX2 { get; set; }
        public decimal GUIDEMEASUREY1 { get; set; }
        public decimal GUIDEMEASUREY2 { get; set; }
        public decimal GUIDEERRORX1 { get; set; }
        public decimal GUIDEERRORX2 { get; set; }
        public decimal GUIDEERRORY1 { get; set; }
        public decimal GUIDEERRORY2 { get; set; }
        public string PELLICLEMATERIALNO1 { get; set; }
        public string PELLICLEBATCHNO1 { get; set; }
        public decimal PELLICLEUSENUM1 { get; set; }
        public string PELLICLEMATERIALNO2 { get; set; }
        public string PELLICLEBATCHNO2 { get; set; }
        public decimal PELLICLEUSENUM2 { get; set; }
        public string PELLICLEOPERATOR { get; set; }
        public System.DateTime PELLICLEOPTIME { get; set; }
        public int PELLICLEOPTIMETZID { get; set; }
        public string GUIDEOPERATOR { get; set; }
        public System.DateTime GUIDEOPTIME { get; set; }
        public int GUIDEOPTIMETZID { get; set; }
        public string OPRID { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public string PELLICLEMATRIALTYPE1 { get; set; }
        public string PELLICLEMATRIALTYPE2 { get; set; }
        public System.DateTime MODIFIEDDATETIME { get; set; }
        public System.DateTime CREATEDDATETIME { get; set; }
        public string MODIFIEDBY { get; set; }
        public string CREATEDBY { get; set; }
        public int ISSHIPMENTREPORT { get; set; }
        public string PELLICLEOPERATOR1 { get; set; }
        public string PELLICLEOPERATOR2 { get; set; }
        public string PELLICLEOPERATOR3 { get; set; }
        public string PELLICLEREMARKS { get; set; }
        public int ISPELLICLEDISPOSED1 { get; set; }
        public int ISPELLICLEDISPOSED2 { get; set; }
    }
}

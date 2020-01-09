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
    /// 品质标准-客户其他要求
    /// </summary>
    [Table("IWS_CUSTPARATRADETABLE")]
    public class IWS_CUSTPARATRADETABLE : Entity
    {
        public int CUSTTRADEREPORTAREA { get; set; }
        public int CUSTTRADEREPORTTYPE { get; set; }
        public int MEASUREREPORT { get; set; }
        public int MAKEOUTDEFECT { get; set; }
        public int BARCODE { get; set; }
        public int LABLE { get; set; }
        public int LABLETYPE { get; set; }
        public int DEFECTTYPE { get; set; }
        public int CUSTTRADEREPORTADDRESS { get; set; }
        public string SPECIALDESC { get; set; }
        public int DELIVERTYPE { get; set; }
        public string DELEVEROTHERDESC { get; set; }
        public int DELIVERYDOC { get; set; }
        public int LOGISTICALDOC { get; set; }
        public string LOGISTICALOTHERDESC { get; set; }
        public int MAKEUPORDERNUM { get; set; }
        public int PRINTPRICE { get; set; }
        public int ROHS { get; set; }
        public int DELIVERYDOCOTHER { get; set; }
        public string DELIVERYDOCOTHERDESC { get; set; }
        public string WASHWAY { get; set; }
        public int TUXINGYAOQIU { get; set; }
        public string KEHUBAOGUANGJIMODEL { get; set; }
        public decimal BAOGUANGWENDU { get; set; }
        public int PACKINGDEMANDINNER { get; set; }
        public int JIECHUSHIBAOZHTYPE { get; set; }
        public int XIAOBANJINGHUATYPE { get; set; }
        public int JIAODAIMIFENG { get; set; }
        public int JIAODAIYOUWU { get; set; }
        public int JINGHUADAI { get; set; }
        public int JINGHUADAITYPE { get; set; }
        public int LEIXING { get; set; }
        public int FENGZHLEIX { get; set; }
        public int FENGZHOTHER { get; set; }
        public string FENGZHOTHERDESC { get; set; }
        public int PACKINGDEMANDOUTER { get; set; }
        public int BIAOMINGZHMXH { get; set; }
        public int BIAOMIANTZH { get; set; }
        public int YAOQIUOTHER { get; set; }
        public string YAOQIUOTHERDESC { get; set; }
        public string ITEMID { get; set; }
        public string CUSTACCOUNT { get; set; }
        public int ICSHIPPINGREPORT { get; set; }
        public int OTHERREPORT { get; set; }
        public int PRINTREMAND { get; set; }
        public string OTHERREPORTVALUE { get; set; }
        public int BIGVERSIONBOX { get; set; }
        public int RETICLEABS { get; set; }
        public int NOTRETICLEABS { get; set; }
        public int PPBOXCHINA { get; set; }
        public int PPBOXFOREIGN { get; set; }
        public int ENVIRREQ { get; set; }
        public int CLEANPACKAGESINGLE { get; set; }
        public int CLEANPACKAGEDOUBLE { get; set; }
        public int MANUALFILMPACKAGE { get; set; }
        public int PACKAGECLEANREQ { get; set; }
        public int VACUUMPACKAGE { get; set; }
        public int FILMMACHINEPACKAGE { get; set; }
        public int OTHERPACKAGE { get; set; }
        public string OTHERPACKAGEVALUE { get; set; }
        public int C5DELIVERYREPORT { get; set; }
        public string DELIVERYSPECIALDESC { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public int ICSHIPPINGREPORTCOM { get; set; }
        public int QY_ISPACKBOXSUPPORTOR { get; set; }
        public int QY_PB_GUDENG { get; set; }
        public int QY_PB_SEYANG { get; set; }
        public int QY_PB_POZZETTA { get; set; }
        public int QY_PB_GUOHUA { get; set; }
        public int QY_PB_KEHU { get; set; }
        public int QY_PB_OTHERS { get; set; }
        public string QY_PB_OTHERSVALUE { get; set; }
    }
}

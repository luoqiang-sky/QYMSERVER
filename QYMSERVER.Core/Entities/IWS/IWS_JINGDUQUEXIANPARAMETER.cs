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
    /// 品质标准-精度缺陷
    /// </summary>
    [Table("IWS_JINGDUQUEXIANPARAMETER")]
    public class IWS_JINGDUQUEXIANPARAMETER : Entity
    {
        public string ITEMID { get; set; }
        public decimal XFLESS { get; set; }
        public decimal XFRANGE { get; set; }
        public decimal XFMORE { get; set; }
        public string CUSTACCOUNT { get; set; }
        public int XFLESSMATHSYMBOL { get; set; }
        public int XFGREATERMATHSYMBOL { get; set; }
        public int XIANFENGOTHER { get; set; }
        public string XIANFENGOTHERVALUE { get; set; }
        public int XIANFENG { get; set; }
        public int TAOHE { get; set; }
        public int TAOHEOTHER { get; set; }
        public string TAOHEOTHERVALUE { get; set; }
        public decimal THVALUE { get; set; }
        public decimal THRANGE { get; set; }
        public int ZONGCHANG { get; set; }
        public int ZONGCHANGOTHER { get; set; }
        public string ZONGCHANGOTHERVALUE { get; set; }
        public decimal ZONGCHANGVALUE { get; set; }
        public decimal ZONGCHANGRANGE { get; set; }
        public int CHUIZHIDU { get; set; }
        public int CHUIZHIDUOTHER { get; set; }
        public string CHUIZHIDUOTHERVALUE { get; set; }
        public decimal CHUIZHIDUVALUE { get; set; }
        public decimal CHUIZHIDURANGE { get; set; }
        public string QXDYAREA { get; set; }
        public string QXDYAREAF { get; set; }
        public int BUYUNXUCHAOCU { get; set; }
        public int BUYUNXUCHAOCUF { get; set; }
        public string TESUYAOQIU { get; set; }
        public string TESUYAOQIUF { get; set; }
        public int CHANPINYAOQIU { get; set; }
        public string CHANPINYAOQIUVALUE { get; set; }
        public string MAOCIXIUBUVALUE { get; set; }
        public int MAOCIXIUBU { get; set; }
        public int ZHENKONGAOXIANSHULIANG { get; set; }
        public decimal ZHENKONGAOXIANSHULIANGVALUE { get; set; }
        public int ZHENKONGAOXIANGAODU { get; set; }
        public decimal ZHENKONGAOXIANGAODUVALUE { get; set; }
        public int QITACAILIAO { get; set; }
        public string QITACAILIAOVALUE { get; set; }
        public int JINSHUYE { get; set; }
        public int YOUMO { get; set; }
        public int HONGTU { get; set; }
        public int AXINGJIAO { get; set; }
        public int LCVD { get; set; }
        public int XIANTIAOZHILIANG { get; set; }
        public string XIANTIAOZHILIANGVALUE { get; set; }
        public string ZHENGBANTIAOWENVALUE { get; set; }
        public int ZHENGBANTIAOWEN { get; set; }
        public int ZHENYUANDU { get; set; }
        public string ZHENYUANDUVALUE { get; set; }
        public decimal XIANFENGCELIANGVALUE { get; set; }
        public int CHANGCHICUNCELIANG { get; set; }
        public string CHANGCHICUNCELIANGVALUE { get; set; }
        public int SHUJUFENXIYAOQIU { get; set; }
        public string SHUJUFENXIYAOQIUVALUE { get; set; }
        public string COPYOFCHANPINYAOQIUVALUE { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public decimal MAXBUGSIZE { get; set; }
    }
}

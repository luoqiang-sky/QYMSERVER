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
    /// 品质标准-产品参数
    /// </summary>
    [Table("IWS_PRODUCTPARAMETER")]
    public class IWS_PRODUCTPARAMETER : Entity
    {
        public string ITEMID { get; set; }
        public int BANCAITYPE { get; set; }
        public string BANCAIDESC { get; set; }
        public decimal SIZE1X { get; set; }
        public decimal SIZE1Y { get; set; }
        public decimal HOU11 { get; set; }
        public int WUCHATYPE { get; set; }
        public int PINGZHENGDUYAOQIU { get; set; }
        public string PINGZHENGDUYAOQIUDESC { get; set; }
        public decimal QIEGEJINGDU { get; set; }
        public int DAOJIAOYAOQIU { get; set; }
        public decimal DAOJIAOSIZE { get; set; }
        public int BENGBIANYAOQIU { get; set; }
        public string BENGBIANOTHERVALUE { get; set; }
        public decimal WUCHAVALUE { get; set; }
        public int PELLICLEYAOQIU { get; set; }
        public int PELLICLEYAOQIUTYPE { get; set; }
        public string PELLICLEMODEL { get; set; }
        public decimal PELLICLEJINGDU { get; set; }
        public int GUIDEYAOQIU { get; set; }
        public int GUIDETIEHETPYE { get; set; }
        public string CUSTACCOUNT { get; set; }
        public decimal JUZHONGYAOQIU { get; set; }
        public string SECTIONALQUALITYVALUE { get; set; }
        public int SECTIONALQUALITY { get; set; }
        public string SCRATCH { get; set; }
        public string CUSTCLEANWAY { get; set; }
        public string OUTSIDESTAIN { get; set; }
        public string DAOJIAOSIZEVALUE { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
    }
}

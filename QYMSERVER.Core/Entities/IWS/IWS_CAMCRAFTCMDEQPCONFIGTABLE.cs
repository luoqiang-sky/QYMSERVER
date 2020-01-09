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
    /// 设备配置指令单
    /// </summary>
    [Table("IWS_CAMCRAFTCMDEQPCONFIGTABLE")]
    public class IWS_CAMCRAFTCMDEQPCONFIGTABLE : Entity
    {
        public string SHEBEIPEIZHIZHILINGID { get; set; } //编号
        public int MASKBORDER { get; set; }               //版边效果
        public decimal GRAPH2MASKUPLIMIT { get; set; }    //图形距边上限
        public decimal GRAPH2MASKDWLIMIT { get; set; }    //图形距边下限
        public int MASKTYPE { get; set; }                 //版材类型
        public int MASKSIZETYPE { get; set; }             //大小版
        public int MINLSAREA { get; set; }                //最小线缝区域
        public decimal MINLSUPLIMIT { get; set; }         //最小线缝上限
        public decimal MINLSDWLIMIT { get; set; }         //最小线缝下限
        public decimal CDUPLIMIT { get; set; }            //CD上限
        public decimal CDDWLIMIT { get; set; }            //CD下限
        public string EMULTYPE { get; set; }              //胶型
        public string WRKCTRID { get; set; }              //工作中心ID
        public int OBJECT { get; set; }                   //对象
        public int TOVERIFY { get; set; }                 //审核
        public int INVALID { get; set; }                  //作废
        public string VERIFYER { get; set; }              //审核人
        public string RECORDER { get; set; }              //记录人
        public int EFFECTTIMELIMIT { get; set; }          //生效期限
        public System.DateTime APPOINTDAY { get; set; }   //指定日期
        public int APPOINTDAYTZID { get; set; }           //指定日期
        public System.DateTime TOVERIFYTIME { get; set; }
        public int TOVERIFYTIMETZID { get; set; }
        public System.DateTime TOEFFECTTIME { get; set; }
        public int TOEFFECTTIMETZID { get; set; }
        public System.DateTime RECORDTIME { get; set; }
        public int RECORDTIMETZID { get; set; }
        public string SENDDEPARTMENT { get; set; }
        public string ACCEPTDEPARTMENT { get; set; }
        public string TECHNUM { get; set; }
        public string TECHNAME { get; set; }
        public string TECHTARGET { get; set; }
        public int TECHTYPE { get; set; }
        public string MINLSTYPE { get; set; }
        public string TRADEID { get; set; }
        public string CUSTACCOUNT { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public int MINLINETYPE { get; set; }
    }
}

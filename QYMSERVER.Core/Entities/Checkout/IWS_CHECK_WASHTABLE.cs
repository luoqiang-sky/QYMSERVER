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
    /// 清洗
    /// </summary>
    [Table("IWS_CHECK_WASHTABLE")]
    public class IWS_CHECK_WASHTABLE:Entity
    {
        public string PRODID { get; set; }                      //订单号
        public long RECID { get; set; }                         //工序号
        public string MRECIPENAME { get; set; }                 //膜面
        public string JRECIPENAME { get; set; }                 //镜面
        public byte RESULT { get; set; }                        //检验结果
        public string OPERATOR { get; set; }                    //操作员
        public int BENGBIAN { get; set; }                       //崩边数
        public int BENGJIAO { get; set; }                       //崩角数
        public int HUASHANG { get; set; }                       //划伤数
        public int LIEWEN { get; set; }                         //裂纹
        public int DIRTYPOINT { get; set; }                     //脏点
        public int STREAK { get; set; }                         //条纹
        public string UNUSUALMESSAGE { get; set; }              //异常信息
        public System.DateTime STARTTIME { get; set; }          //开始时间
        public System.DateTime ENDTIME { get; set; }            //结束时间
        public int TIMESNUM { get; set; }
    }
}

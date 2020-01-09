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
    /// 行业匹配表
    /// </summary>
    [Table("IWS_CAMCRAFTCMDTRADETABLE")]
    public class IWS_CAMCRAFTCMDTRADETABLE : Entity
    {
        public string HANGYEPIPEIID { get; set; }                        //编号
        public string WRKCTRID { get; set; }                             //工作中心ID
        public string TRADEID { get; set; }                              //行业
        public int TOVERIFY { get; set; }                                //
        public int INVALID { get; set; }                                 //
        public string VERIFYER { get; set; }                             //
        public string RECORDER { get; set; }                             //
        public int EFFECTTIMELIMIT { get; set; }                         //
        public System.DateTime APPOINTDAY { get; set; }                  //
        public int APPOINTDAYTZID { get; set; }                          //
        public System.DateTime TOVERIFYTIME { get; set; }                //
        public int TOVERIFYTIMETZID { get; set; }                        //
        public System.DateTime TOEFFECTTIME { get; set; }                //
        public int TOEFFECTTIMETZID { get; set; }                        //
        public System.DateTime RECORDTIME { get; set; }                  //
        public int RECORDTIMETZID { get; set; }                          //
        public string SENDDEPARTMENT { get; set; }                       //
        public string ACCEPTDEPARTMENT { get; set; }                     //
        public string TECHNUM { get; set; }                              //
        public string TECHNAME { get; set; }                             //
        public string TECHTARGET { get; set; }                           //
        public int TECHTYPE { get; set; }                                //
        public string DATAAREAID { get; set; }                           //
        public int RECVERSION { get; set; }                              //
        public long RECID { get; set; }                                  //
        public decimal MURAVALUE { get; set; }                           //
    }
}

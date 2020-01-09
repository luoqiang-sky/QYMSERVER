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
    /// 版材匹配表
    /// </summary>
    [Table("IWS_CAMCRAFTCMDMATERIALTABLE")]
    public class IWS_CAMCRAFTCMDMATERIALTABLE : Entity
    {
        public string BANCAIPIPEIID { get; set; }               //编号
        public string WRKCTRID { get; set; }                    //工作中心ID
        public int TOVERIFY { get; set; }                       //工作中心名称
        public int INVALID { get; set; }                        //物料编号
        public string VERIFYER { get; set; }                    //
        public string RECORDER { get; set; }                    //
        public int EFFECTTIMELIMIT { get; set; }                //
        public System.DateTime APPOINTDAY { get; set; }         //
        public int APPOINTDAYTZID { get; set; }                 //
        public System.DateTime TOVERIFYTIME { get; set; }       //
        public int TOVERIFYTIMETZID { get; set; }               //
        public System.DateTime TOEFFECTTIME { get; set; }       //
        public int TOEFFECTTIMETZID { get; set; }               //
        public System.DateTime RECORDTIME { get; set; }         //
        public int RECORDTIMETZID { get; set; }                 //
        public string SENDDEPARTMENT { get; set; }              //
        public string TECHNUM { get; set; }                     //
        public string TECHNAME { get; set; }                    //
        public string TECHTARGET { get; set; }                  //
        public int TECHTYPE { get; set; }                       //
        public string ITEMID { get; set; }                      //
        public string ACCEPTDEPARTMENT { get; set; }            //
        public string ACCEPTDEPARTMENT2_ { get; set; }          //
        public string ACCEPTDEPARTMENT3_ { get; set; }          //
        public string ACCEPTDEPARTMENT4_ { get; set; }          //
        public string ACCEPTDEPARTMENT5_ { get; set; }          //
        public string ACCEPTDEPARTMENT6_ { get; set; }          //
        public string DATAAREAID { get; set; }                  //
        public int RECVERSION { get; set; }                     //
        public long RECID { get; set; }                         //
    }
}

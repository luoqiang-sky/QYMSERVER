using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.Product
{
    /// <summary>
    /// 生产工艺路线
    /// </summary>
    [Table("PRODROUTE")]
    public class PRODROUTE : Entity
    {
        public string PRODID { get; set; }                          //生产单号
        public string OPRID { get; set; }                           //工序ID
        public int? OPRNUM { get; set; }                            //工序编号
        public int? LEVEL_ { get; set; }                            //等级（或者叫执行顺序）
        public int? OPRNUMNEXT { get; set; }                        //下一工序编号
        public string WRKCTRID { get; set; }                        //工作中心ID
        public string ROBOTTARGET { get; set; }                     //机器人送货地址
        public string TASKGROUPID { get; set; }                     //任务工作组ID
        public decimal? QUEUETIMEBEFORE { get; set; }               //之前的排队时间
        public decimal? QUEUETIMEAFTER { get; set; }                //之后的排队时间
        public decimal? SETUPTIME { get; set; }                     //准备时间
        public decimal? PROCESSTIME { get; set; }                   //运行时间
        public decimal? STANDARDTIME { get; set; }                  //标准工时（单位分钟）
        public decimal? OVERLAPQTY { get; set; }                    //
        public decimal? ERRORPCT { get; set; }                      //
        public decimal? ACCERROR { get; set; }                      //
        public decimal? TOHOURS { get; set; }                       //
        public decimal? TRANSFERBATCH { get; set; }                 //
        public string SETUPCATEGORYID { get; set; }                 //
        public string PROCESSCATEGORYID { get; set; }               //
        public int? OPRFINISHED { get; set; }                       //工序是否完成（工序完成状态 1：完成 0：未完成）
        /// <summary>
        /// 标记工序已经开始 1已经开始，2已经结束，0没有开始，默认为0
        /// </summary>
        public int? ISSTARTED { get; set; }                          //
        public decimal? FORMULAFACTOR1 { get; set; }                //
        public int? ROUTETYPE { get; set; }                         //
        public int? BACKORDERSTATUS { get; set; }                   //
        public string PROPERTYID { get; set; }                      //
        public string ROUTEGROUPID { get; set; }                    //
        public string QTYCATEGORYID { get; set; }                   //
        public System.DateTime? FROMDATE { get; set; }              //
        public int? FROMTIME { get; set; }                          //
        public System.DateTime? TODATE { get; set; }                //
        public int? TOTIME { get; set; }                            //
        public decimal? CALCQTY { get; set; }                       //
        public decimal? CALCSETUP { get; set; }                     //
        public decimal? CALCPROC { get; set; }                      //
        public decimal? WRKCTRTASKDEMAND { get; set; }              //
        public int? OPRPRIORITY { get; set; }                       //
        public decimal? WRKCTRLOADPCT { get; set; }                 //
        public decimal? WRKCTRNUMOF { get; set; }                   //
        public string DIMENSION { get; set; }                       //
        public string DIMENSION2_ { get; set; }                     //
        public string DIMENSION3_ { get; set; }                     //
        public int? FORMULA { get; set; }                           //
        public long ROUTEOPRREFRECID { get; set; }                  //
        public int? LINKTYPE { get; set; }                          //
        public int? OPRSTARTEDUP { get; set; }                      //
        public decimal? EXECUTEDPROCESS { get; set; }               //
        public decimal? EXECUTEDSETUP { get; set; }                 //
        public int? CONSTANTRELEASED { get; set; }                  //
        public decimal? PHANTOMBOMFACTOR { get; set; }              //
        public string DATAAREAID { get; set; }                      //
        public int? RECVERSION { get; set; }                        //
        public long RECID { get; set; }                             //
        public string IWS_COSTCATEGORYGROUPID { get; set; }         //
        public string IWS_TIMECATEGORYGROUPID { get; set; }         //
        public int? QY_OPRLEVEL { get; set; }                       //
        public System.DateTime? QY_FROMDATETIME { get; set; }       //
        public int? QY_FROMDATETIMETZID { get; set; }               //
        public System.DateTime? QY_TODATETIME { get; set; }         //
        public int? QY_TODATETIMETZID { get; set; }                 //
    }
}

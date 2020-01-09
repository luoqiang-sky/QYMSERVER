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
    /// 工作中心表
    /// </summary>
    [Table("WRKCTRTABLE")]
    public class WRKCTRTABLE : Entity
    {
        public string WRKCTRGROUPID { get; set; }               //工作中心组
        public string WRKCTRID { get; set; }                    //工作中心ID
        public string NAME { get; set; }                        //工作中心名称
        public int WRKCTRTYPE { get; set; }                     //类型
        public decimal WRKCTRNUMOF { get; set; }                //工作中心数量
        public decimal EFFECTIVITYPCT { get; set; }             //
        public decimal OPERATIONSCHEDPCT { get; set; }          //
        public decimal CAPACITY { get; set; }                   //
        public int CAPUNIT { get; set; }                        //
        public string VENDID { get; set; }                      //
        public System.DateTime CREATED { get; set; }            //
        public decimal TOHOURS { get; set; }                    //
        public string DIMENSION { get; set; }                   //
        public string DIMENSION2_ { get; set; }                 //
        public string DIMENSION3_ { get; set; }                 //
        public int ISGROUP { get; set; }                        //是否是工作中心组
        public string PRODUNITID { get; set; }                  //
        public string SITEID { get; set; }                      //
        public int BOTTLENECKRESOURCE { get; set; }             //
        public string WMSLOCATIONID { get; set; }               //
        public string EMPLID { get; set; }                      //
        public string CALENDARID { get; set; }                  //
        public int CAPLIMITED { get; set; }                     //
        public string INVENTLOCATIONID { get; set; }            //
        public decimal CAPACITYBATCH { get; set; }              //
        public int EXCLUSIVE { get; set; }                      //
        public string DATAAREAID { get; set; }                  //
        public int RECVERSION { get; set; }                     //
        public long RECID { get; set; }                         //
        public string ACCOUNTWRKCTRISSUE { get; set; }          //
        public string ACCOUNTWIPVALUATION { get; set; }         //
        public decimal QUEUETIMEBEFORE { get; set; }            //
        public decimal SETUPTIME { get; set; }                  //
        public decimal PROCESSTIME { get; set; }                //
        public decimal PROCESSPERQTY { get; set; }              //
        public decimal TRANSPTIME { get; set; }                 //
        public decimal QUEUETIMEAFTER { get; set; }             //
        public decimal TRANSFERBATCH { get; set; }              //
        public decimal ERRORPCT { get; set; }                   //
        public string SETUPCATEGORYID { get; set; }             //
        public string PROCESSCATEGORYID { get; set; }           //
        public string ACCOUNTWIPISSUE { get; set; }             //
        public string TASKGROUPID { get; set; }                 //
        public decimal WRKCTRTASKDEMAND { get; set; }           //
        public int PROPERTYLIMITED { get; set; }                //
        public string QTYCATEGORYID { get; set; }               //
        public string ROUTEGROUPID { get; set; }                //
        public string ACCOUNTWRKCTRISSUEOFFSET { get; set; }    //
        public int IWS_DEFAULTPRIORITY { get; set; }            //
        public string IWS_JIXING { get; set; }                  //
        public string IWS_BEIZHU { get; set; }                  //
        public string IWS_PEIZHI { get; set; }                  //
        public string IWS_SENSITIVITY { get; set; }             //
        public string IWS_JIXINGXINGHAO { get; set; }           //
        public int IWS_VISIBLE { get; set; }                    //
        public string IWS_LOCATIONIDEXPORT { get; set; }        //
        public string IWS_TIMECATEGORYGROUPID { get; set; }     //
        public string IWS_COSTCATEGORYGROUPID { get; set; }     //
        public int IWS_CAMENABLED { get; set; }                 //
        public int IWS_MACHINETYPE { get; set; }                //
        public int QY_MAINMACHINE { get; set; }                 //
        public int QY_WRKQTY { get; set; }                      //
        public int QY_ISSTOP { get; set; }                      //
    }
}

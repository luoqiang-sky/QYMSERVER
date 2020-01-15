using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.ClientService.MPS
{
   public class PRODTABLEDto:EntityDto
    {
        public string ITEMID { get; set; }
        public string NAME { get; set; }
        public int PRODSTATUS { get; set; }
        public string DATAAREAID { get; set; }
        public int PRODPRIO { get; set; }
        public int PRODLOCKED { get; set; }
        //public int PRODTYPE { get; set; }
        //public int SCHEDSTATUS { get; set; }
        //public System.DateTime SCHEDDATE { get; set; }
        //public decimal QTYSCHED { get; set; }
        //public decimal QTYSTUP { get; set; }
        //public System.DateTime DLVDATE { get; set; }
        //public System.DateTime FINISHEDDATE { get; set; }
        //public System.DateTime SCHEDSTART { get; set; }
        //public System.DateTime SCHEDEND { get; set; }
        //public string INVENTTRANSID { get; set; }
        //public string DIMENSION { get; set; }
        //public string DIMENSION2_ { get; set; }
        //public System.DateTime BOMDATE { get; set; }
        //public int BACKORDERSTATUS { get; set; }
        //public string BOMID { get; set; }
        //public string ROUTEID { get; set; }
        //[Required]
        //public string PRODID { get; set; }
        //public string REALTIMEOPRID { get; set; }
        //public string INVENTDIMID { get; set; }
        //public int DLVTIME { get; set; }
        //public string IWS_WRKCTRID { get; set; }
        //public int IWS_SCRAPRESEND { get; set; }
        //public int IWS_PRODUCTIONTYPE { get; set; }
        //public int IWS_LINETYPE { get; set; }
        //public int IWS_ISSUSPEND { get; set; }
        //public System.DateTime IWS_DIAODUDATETIME { get; set; }
        //public int IWS_DIAODUDATETIMETZID { get; set; }
        //public string IWS_OTHERREQUEST { get; set; }
        //public string IWS_MATERIALREMARKS { get; set; }
        //public string IWS_DIAODUSHIREMARKS { get; set; }
        //public string IWS_DESIGNREAMRKS { get; set; }
        //public int IWS_ISNEWPRODUCTION { get; set; }
        //public int IWS_TOTALLENGTH { get; set; }
        //public decimal IWS_MINLINEWIDTHINMARKET { get; set; }
        //public string IWS_SALESNAME { get; set; }
        //public string IWS_MODELNUMBER { get; set; }
        //public string IWS_ITEMMIDDLETYPENAME { get; set; }
        //public decimal IWS_CDACCURACY { get; set; }
        //public decimal IWS_LINEWIDEFROM { get; set; }
        //public System.DateTime SHIPPINGDATEREQUESTED { get; set; }
        //public decimal IWS_SPECIFICATIONS { get; set; }
        //public decimal IWS_SPECIFICATIONS2_ { get; set; }
        //public decimal IWS_SPECIFICATIONS3_ { get; set; }
        //public string IWS_CUSTNAMESEND { get; set; }
        //public string IWS_MARKETREMARKS { get; set; }
        //public string SALESID { get; set; }
        //public System.DateTime IWS_SALESORDERDATE { get; set; }
        //public int IWS_SALESORDERDATETZID { get; set; }
        //public string IWS_BANBIANXIAOGUO { get; set; }
        //public string IWS_TUXINGJUBIAN { get; set; }
        //public string IWS_TUXINGTEZENG { get; set; }
        //public string IWS_BANCAITYPENAME { get; set; }
        //public int IWS_SUPERVISETYPE { get; set; }
        //public string IWS_EXAMBILLSREMARK { get; set; }
        //public string IWS_WRKCTRGRP { get; set; }
        //public int IWS_PLANDLVFLAG { get; set; }
        //public string IWS_CRAFTREMARKS { get; set; }
        //public string MODIFIEDBY { get; set; }
        //public string MODIFIEDTRANSACTIONID { get; set; }
        //public System.DateTime CREATEDDATETIME { get; set; }
        //public string CREATEDBY { get; set; }
        //public int QY_ISCAMNEEDEDAOI { get; set; }
        //public System.DateTime AOICREATEDDATETIME { get; set; }
        //public int AOICREATEDDATETIMETZID { get; set; }
        //public System.DateTime QY_PREPUTINDATE { get; set; }
        //public int QY_PREPUTINDATETZID { get; set; }
        //public System.DateTime QY_PREEXPOSEDATE { get; set; }
        //public int QY_PREEXPOSEDATETZID { get; set; }
        //public Nullable<int> PROCESS { get; set; }
        //public Nullable<int> ISSTARTED { get; set; }
        //public Nullable<System.DateTime> STARTDATE { get; set; }
        //public Nullable<System.DateTime> DUEDATE { get; set; }
    }
}

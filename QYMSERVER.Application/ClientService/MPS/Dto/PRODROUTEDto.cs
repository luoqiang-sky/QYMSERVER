using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.ClientService.MPS
{
   public class PRODROUTEDto: EntityDto
    {
        public string PRODID { get; set; }
        public int OPRNUM { get; set; }
        public int LEVEL_ { get; set; }
        public int OPRNUMNEXT { get; set; }
        public string OPRID { get; set; }
        public string WRKCTRID { get; set; }
        public string TASKGROUPID { get; set; }
        public decimal QUEUETIMEBEFORE { get; set; }
        public decimal SETUPTIME { get; set; }
        public decimal PROCESSTIME { get; set; }
        public decimal PROCESSPERQTY { get; set; }
        public decimal TRANSPTIME { get; set; }
        public decimal QUEUETIMEAFTER { get; set; }
        public decimal OVERLAPQTY { get; set; }
        public decimal ERRORPCT { get; set; }
        public decimal ACCERROR { get; set; }
        public decimal TOHOURS { get; set; }
        public decimal TRANSFERBATCH { get; set; }
        public string SETUPCATEGORYID { get; set; }
        public string PROCESSCATEGORYID { get; set; }
        public int OPRFINISHED { get; set; }
        public decimal FORMULAFACTOR1 { get; set; }
        public int ROUTETYPE { get; set; }
        public int BACKORDERSTATUS { get; set; }
        public string PROPERTYID { get; set; }
        public string ROUTEGROUPID { get; set; }
        public string QTYCATEGORYID { get; set; }
        public System.DateTime FROMDATE { get; set; }
        public int FROMTIME { get; set; }
        public System.DateTime TODATE { get; set; }
        public int TOTIME { get; set; }
        public decimal CALCQTY { get; set; }
        public decimal CALCSETUP { get; set; }
        public decimal CALCPROC { get; set; }
        public decimal WRKCTRTASKDEMAND { get; set; }
        public int OPRPRIORITY { get; set; }
        public decimal WRKCTRLOADPCT { get; set; }
        public decimal WRKCTRNUMOF { get; set; }
        public string DIMENSION { get; set; }
        public string DIMENSION2_ { get; set; }
        public string DIMENSION3_ { get; set; }
        public int FORMULA { get; set; }
        public long ROUTEOPRREFRECID { get; set; }
        public int LINKTYPE { get; set; }
        public int OPRSTARTEDUP { get; set; }
        public decimal EXECUTEDPROCESS { get; set; }
        public decimal EXECUTEDSETUP { get; set; }
        public int CONSTANTRELEASED { get; set; }
        public decimal PHANTOMBOMFACTOR { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public string IWS_COSTCATEGORYGROUPID { get; set; }
        public string IWS_TIMECATEGORYGROUPID { get; set; }
        public int QY_OPRLEVEL { get; set; }
        public System.DateTime QY_FROMDATETIME { get; set; }
        public int QY_FROMDATETIMETZID { get; set; }
        public System.DateTime QY_TODATETIME { get; set; }
        public int QY_TODATETIMETZID { get; set; }
    }
}

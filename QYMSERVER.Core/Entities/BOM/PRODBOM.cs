using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.BOM
{
    /// <summary>
    /// 生产BOM
    /// </summary>
    [Table("PRODBOM")]
    public class PRODBOM : Entity
    {
        public string PRODID { get; set; }                  //
        public decimal LINENUM { get; set; }                //
        public int PRODLINETYPE { get; set; }               //
        public int BOMCONSUMP { get; set; }                 //
        public string ITEMID { get; set; }                  //材料编号
        public decimal BOMQTY { get; set; }                 //数量
        public decimal DIM1 { get; set; }                   //
        public decimal DIM2 { get; set; }                   //
        public decimal DIM3 { get; set; }                   //
        public decimal DIM4 { get; set; }                   //
        public decimal DIM5 { get; set; }                   //
        public int ROUNDUP { get; set; }                    //
        public decimal ROUNDUPQTY { get; set; }             //
        public string POSITION { get; set; }                //
        public decimal QTYBOMCALC { get; set; }             //
        public decimal REMAINBOMPHYSICAL { get; set; }      //
        public decimal REMAINBOMFINANCIAL { get; set; }     //
        public decimal QTYINVENTCALC { get; set; }          //
        public int PRODFLUSHINGPRINCIP { get; set; }        //
        public int RESERVATION { get; set; }                //
        public string INVENTTRANSID { get; set; }           //
        public System.DateTime RAWMATERIALDATE { get; set; }//
        public decimal REMAININVENTPHYSICAL { get; set; }   //
        public string DIMENSION { get; set; }               //
        public string DIMENSION2_ { get; set; }             //
        public string DIMENSION3_ { get; set; }             //
        public int INVENTREFTYPE { get; set; }              //
        public string INVENTREFID { get; set; }             //
        public string INVENTREFTRANSID { get; set; }        //
        public string VENDID { get; set; }                  //
        public string UNITID { get; set; }                  //
        public int BACKORDERSTATUS { get; set; }            //
        public int CALCULATION { get; set; }                //
        public decimal QTYINVENTSTUP { get; set; }          //
        public decimal QTYBOMSTUP { get; set; }             //
        public string BOMID { get; set; }                   //
        public int FORMULA { get; set; }                    //
        public long BOMREFRECID { get; set; }               //
        public decimal BOMQTYSERIE { get; set; }            //
        public string ITEMBOMID { get; set; }               //
        public string INVENTDIMID { get; set; }             //
        public string REQPOID { get; set; }                 //
        public string REQPLANIDSCHED { get; set; }          //
        public decimal SCRAPVAR { get; set; }               //
        public decimal SCRAPCONST { get; set; }             //
        public int CONSTANTRELEASED { get; set; }           //
        public int ENDCONSUMP { get; set; }                 //
        public string PROJCATEGORYID { get; set; }          //
        public string ACTIVITYNUMBER { get; set; }          //
        public string PROJTRANSID { get; set; }             //
        public System.DateTime PROJTRANSDATE { get; set; }  //
        public string PROJLINEPROPERTYID { get; set; }      //
        public decimal PROJCOSTPRICE { get; set; }          //
        public decimal PROJCOSTAMOUNT { get; set; }         //
        public string PROJSALESCURRENCYID { get; set; }     //
        public decimal PROJSALESPRICE { get; set; }         //
        public string PROJTAXGROUPID { get; set; }          //
        public string PROJTAXITEMGROUPID { get; set; }      //
        public string PROJID { get; set; }                  //
        public int PROJSETSUBPRODTOCONSUMED { get; set; }   //
        public string DATAAREAID { get; set; }              //
        public int RECVERSION { get; set; }                 //
        public long RECID { get; set; }                     //
        public int OPRNUM { get; set; }                     //
        public int WRKCTRCONSUMPTION { get; set; }          //
        public string ITEMROUTEID { get; set; }             //
        public int RAWMATERIALTIME { get; set; }            //
        public int ENDSCHEDCONSUMP { get; set; }            //
        public string IWS_REPLACEITEMID { get; set; }       //
    }
}

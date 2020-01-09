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
    /// CAM参数
    /// </summary>
    [Table("IWS_CAMDESIGNPARAMTABLE")]
    public class IWS_CAMDESIGNPARAMTABLE : Entity
    {
        public string PRODID { get; set; }
        public string INVENTREFID { get; set; }
        public string INVENTREFTRANSID { get; set; }
        public string INVENTDIMID { get; set; }
        public string CDPRECISION { get; set; }
        public string MINLSWIDTH { get; set; }
        public string MINLSTYPE { get; set; }
        public string GRAPH2EDGE { get; set; }
        public string GRAPHFEATRUES { get; set; }
        public string MASKOUTLINE { get; set; }
        public string WRKCTRID { get; set; }
        public string MACHINENAME { get; set; }
        public string LENS { get; set; }
        public string QYBARCODE { get; set; }
        public string CLIENTBARCODE { get; set; }
        public int INVERT { get; set; }
        public int ROTATE { get; set; }
        public int MIRROR { get; set; }
        public int CPMASKMIRROR { get; set; }
        public int LASTMIRROR { get; set; }
        public int ISDELMASKMARK { get; set; }
        public string NETPTDENSITY { get; set; }
        public string NETPTANGLE { get; set; }
        public string APERTURERATIO { get; set; }
        public int X1STEP { get; set; }
        public int Y1STEP { get; set; }
        public int X2STEP { get; set; }
        public int Y2STEP { get; set; }
        public decimal MASKSIZEX { get; set; }
        public decimal MASKSIZEY { get; set; }
        public decimal MASKSIZEZ { get; set; }
        public int TEMPERATUREXPPB { get; set; }
        public int TEMPERATUREYPPB { get; set; }
        public int GRAPHSCALEXPPB { get; set; }
        public int GRAPHSCALEYPPB { get; set; }
        public int CRAFTSCALEXPPB { get; set; }
        public int CRAFTSCALEYPPB { get; set; }
        public int CRAFTSCALEORTHOPPB { get; set; }
        public int DESIGNLASTSCALEXPPB { get; set; }
        public int DESIGNLASTSCALEYPPB { get; set; }
        public decimal DESIGNLASTSCALEX { get; set; }
        public decimal DESIGNLASTSCALEY { get; set; }
        public string CRFIELDNAME1 { get; set; }
        public string CRFIELDNAME2 { get; set; }
        public string CRFIELDNAME3 { get; set; }
        public string CRFIELDNAME4 { get; set; }
        public string CRATIO1 { get; set; }
        public string CRATIO2 { get; set; }
        public string CRATIO3 { get; set; }
        public string CRATIO4 { get; set; }
        public string DESIGNFORMAT { get; set; }
        public string TOPCELL { get; set; }
        public string LAYLOGICALS { get; set; }
        public string CELLPITCHX { get; set; }
        public string CELLPITCHY { get; set; }
        public string MEBENAME { get; set; }
        public string STRIPEWIDTH { get; set; }
        public string PIXELSIZE { get; set; }
        public string STETCHMODE { get; set; }
        public string ADDITIONALPIXEL { get; set; }
        public string BIDIRECTION { get; set; }
        public string LICBUFFERSIZE { get; set; }
        public string OVERLAP { get; set; }
        public string YSPEED { get; set; }
        public string RESOLUTION { get; set; }
        public string BIASX { get; set; }
        public string BIASY { get; set; }
        public string PROCESS { get; set; }
        public string ORIGINTYPE { get; set; }
        public string MEASURECDAMOUNT { get; set; }
        public string MURAFUNCTION { get; set; }
        public string PIXELPITCHX { get; set; }
        public string PIXELPITCHY { get; set; }
        public string CRAFTLAYERNAME { get; set; }
        public string ADDEXPOSALAMOUNT { get; set; }
        public string EXPOSELOCATION { get; set; }
        public string OFFSETUP { get; set; }
        public string OFFSETDW { get; set; }
        public string OFFSETLE { get; set; }
        public string OFFSETRI { get; set; }
        public string CONVERTFORMAT { get; set; }
        public string DESIGNNAME { get; set; }
        public string JOBNAME { get; set; }
        public string JOBID { get; set; }
        public string CONVERTNAME { get; set; }
        public string REBACKREMARK { get; set; }
        public string CAMREMARK { get; set; }
        public int WRKSTATUS { get; set; }
        public int INVENTREFTYPE { get; set; }
        public string OPRID { get; set; }
        public string ITEMID { get; set; }
        public int SAVETYPE { get; set; }
        public string X1VALUE { get; set; }
        public string Y1VALUE { get; set; }
        public string X2VALUE { get; set; }
        public string Y2VALUE { get; set; }
        public string GRAPHSIZEX { get; set; }
        public string GRAPHSIZEY { get; set; }
        public int CONVERTSCALEXPPB { get; set; }
        public int CONVERTSCALEYPPB { get; set; }
        public int CONVERTSCALEORTHOPPB { get; set; }
        public string CONVERTDESIGNNAME { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public long RECID { get; set; }
        public string LICBUFFERSIZE1 { get; set; }
        public string LAYERNAMEALIAS { get; set; }
        public string CAMTOOL { get; set; }
        public string EXPOSESIZEX { get; set; }
        public string EXPOSESIZEY { get; set; }
        public string MURAVALUE { get; set; }
        public decimal Y_NOEXPOSESIZE { get; set; }
        public int SDIST { get; set; }
        public string GRAPHCD { get; set; }
        public string GRAPHBIAS { get; set; }
        public int DISTORTION { get; set; }
        public int LARGESTLENGTH { get; set; }
        public int TOTALLENGTH { get; set; }
        public decimal LICUNITTIME { get; set; }
        public int PPO { get; set; }
        public string AOITYPE { get; set; }
        public int PARAMINDETERMINACY { get; set; }
        public int XOR { get; set; }
        public int ISSOURCEAOI { get; set; }
        public string AOILAYER { get; set; }
        public string AOITOPCELL { get; set; }
        public string AOISOURCENAME { get; set; }
        public Nullable<int> RESOULT { get; set; }
        public Nullable<int> Completion { get; set; }
    }
}

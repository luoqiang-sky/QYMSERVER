using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.DoWork.MainProduct.Dto
{
    public class ROUTEOPRTABLEDto:EntityDto
    {
        public string NAME { get; set; }                          //工序名称
        public string OPRID { get; set; }                         //工序编号
        public Nullable<int> IWS_ROUTEOPRTYPE { get; set; }       //工序类型

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.MainWork.MPS.Dto
{
    public class SendToRobotDto
    {
        public string OPRID { get; set; }//工序ID
        public int? OPRNUM { get; set; }  //工序编号
        public int? OPRNUMNEXT { get; set; } //下一道工序编号
        public string WRKCTRID { get; set; }//工作中心ID
    }
}

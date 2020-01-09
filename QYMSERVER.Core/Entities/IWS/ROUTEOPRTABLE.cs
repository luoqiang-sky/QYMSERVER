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
    /// 生产工序种类表
    /// </summary>
    [Table("ROUTEOPRTABLE")]
    public class ROUTEOPRTABLE : Entity
    {
        public string OPRID { get; set; }                         //工序编号
        public string NAME { get; set; }                          //工序名称
        public string DATAAREAID { get; set; }                    //
        public Nullable<int> RECVERSION { get; set; }             //
        public Nullable<long> RECID { get; set; }                 //
        public Nullable<int> IWS_PRODSHOW { get; set; }           //生产显示
        public Nullable<int> IWS_ROUTEOPRTYPE { get; set; }       //工序类型
        public Nullable<int> IWS_ROUTEOPRNUM { get; set; }        //工序顺序  CAM用, 生产不用理会
        public string IWS_ADDITIONALOPRID { get; set; }           //附加工序
    }
}

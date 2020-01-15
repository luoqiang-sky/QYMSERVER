using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.SystemConfig
{
    /// <summary>
    /// 操作记录表
    /// </summary>
    [Table("SYS_OPERATIONLOG")]
    public class SYS_OPERATIONLOG : Entity
    {
        public string ITEMNAME { get; set; }//名称
        public string LASTVALUE { get; set; }//前值
        public string VALUE { get; set; }//值
        public string MODIFYTYPE { get; set; }//操作类型
        public string MODIFYOPERATOR { get; set; }//操作者
        public DateTime? MODIFYTIME { get; set; }//操作时间
        public string REMARK { get; set; }//备注


    }
}

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
    /// 系统配置表
    /// </summary>
    [Table("SYS_CONFIG")]
    public class SYS_CONFIG : Entity
    {
        //public bool AUTOSYSTEM { get; set; }//是否自动下发任务（整个系统而言）
        //public bool AUTOAOICHECK { get; set; }//AOI自动检测
        //public bool AUTOCDCHECK { get; set; }//CD自动检测

        public string KEY { get; set; }//名称
        public string VALUE { get; set; }//值

    }
}

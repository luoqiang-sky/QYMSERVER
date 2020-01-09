using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.Equipment.Alarm
{
    /// <summary>
    /// 设备报警记录表
    /// </summary>
    [Table("H_EQUIPMENTALARM")]
    public class H_EQUIPMENTALARM : Entity
    {
        public int EquipmentID { get; set; }
        public string AlarmType { get; set; }
        public Nullable<System.DateTime> AlarmStartTime { get; set; }
        public Nullable<System.DateTime> AlarmEndTime { get; set; }
        public string AlarmDiscription { get; set; }
    }
}

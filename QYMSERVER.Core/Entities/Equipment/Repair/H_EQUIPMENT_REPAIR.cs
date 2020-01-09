using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.Equipment.Maintain
{
    /// <summary>
    /// 设备维修记录表
    /// </summary>
    [Table("H_EQUIPMENT_REPAIR")]
    public class H_EQUIPMENT_REPAIR : Entity
    {
        public string EquipmentID { get; set; }
        public string MaintenanceType { get; set; }
        public Nullable<System.DateTime> MaintenanceDate { get; set; }
        public string MaintenanceOperatior { get; set; }
        public string MaintenanceUsedTime { get; set; }
    }
}

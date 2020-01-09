using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.Equipment.Parameter
{
    /// <summary>
    /// 光刻机记录表
    /// </summary>
    [Table("H_EQUIPMENT_PHOTOETCHING")]
    public class H_EQUIPMENT_PHOTOETCHING : Entity
    {
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public decimal EquipmentStatus { get; set; }
        public string EquipmentSchedule { get; set; }
    }
}

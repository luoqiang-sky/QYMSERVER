using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.Equipment
{
    /// <summary>
    /// 定义车间机器编号、工作中心名称、状态等，作为服务器掌握车间设备信息的基础表
    /// </summary>
    [Table("H_MACHINES")]
    public class Machines : Entity
    {
        public string NAME { get; set; }        //设备名称
        public string EQUIPMENTID { get; set; } //设备编号
        public string CATEGORY { get; set; }    //设备类别
        public int PLANT { get; set; }      //放置厂房
        public string WRKCTRID { get; set; }    //工作中心 （不同配置下可做为不同工作中心）
        public string WRKCTRGROUP { get; set; }  //工作中心组 （设备编号，特定的名字比如LP,工作中心在此名字的基础上扩展，如LP-001）
        public string TOBOTSITE { get; set; }   //设备地址（给机器人识别的位置）
        /// <summary>
        /// 状态 （0：空闲  1：正在加工  2：故障报警  3:保养  4：优检）
        /// </summary>
        public int STATUS { get; set; }      //状态 （0：空闲  1：正在加工  2：故障报警  3:保养  4：优检）
        public DateTime? DATEOFPEODUCTION { get; set; }//出厂日期
        public string MANUFACTURER { get; set; }//制造商
        public string CHARGEPERSON { get; set; }//负责人
        public string EMERGENCYPERSON { get; set; }//联系人


    }
}

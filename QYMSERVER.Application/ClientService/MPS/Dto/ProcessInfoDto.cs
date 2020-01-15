using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.ClientService.MPS.Dto
{
    public class ProcessInfoDto
    {
        public int? LEVEL { get; set; }                            //等级（或者叫执行顺序）
        public string ProcessName { get; set; }
        public string WorkCenter { get; set; }
        public string Informations { get; set; }
        public ProcessStatus Result { get; set; }
    }
    public enum ProcessStatus
    {
        [Display(Name = "等待")]
        等待 = 0,
        [Display(Name = "完成")]
        进行中 = 1,
        [Display(Name = "进行中")]
        完成 = 2,
        [Display(Name = "警告")]
        警告 = 3,
        [Display(Name = "返工")]
        返工 = 4
    }
}

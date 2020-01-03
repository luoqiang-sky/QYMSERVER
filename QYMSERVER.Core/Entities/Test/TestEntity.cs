using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Entities.Test
{
    [Table("TestEntity")]
    public class TestEntity:Entity
    {
        public virtual int? AAA
        {
            get;set;
        }
        public virtual string BBB
        {
            get;set;
        }
        public virtual string CCC
        {
            get; set;
        }
        public virtual string DDD
        {
            get; set;
        }
        public virtual string EEE
        {
            get; set;
        }
    }
}

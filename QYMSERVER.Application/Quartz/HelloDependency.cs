﻿using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.Quartz
{
    public class HelloDependency : IHelloDependency, ISingletonDependency
    {
        public int ExecutionCount { get; set; }
    }
}

using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.AX
{
    public interface IFeedBackAXWorkManger : IDomainService
    {
        void FeedBackAX(string prodid);//报工方法
    }
}

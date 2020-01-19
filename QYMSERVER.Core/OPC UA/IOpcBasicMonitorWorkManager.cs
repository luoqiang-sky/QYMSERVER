using Abp.Domain.Services;
using Opc.Ua;
using OpcUaHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.OPC_UA
{
    public interface IOpcBasicMonitorWorkManager : IDomainService
    {
        //此接口实现OPC基础(监控)逻辑：1、订阅机器人完工等信号。2、订阅机器人功能逻辑 3、向机器人发送执行工序的动作和参数   PS：鉴于订阅后处理逻辑可能耗时，此处或统一使用single订阅模式

        void A_MultipleSubscription(String[] nodes); //订阅A各种Robot的信号，并做响应处理
        void B_MultipleSubscription( String[] nodes);//订阅B各种Robot的信号，并做响应处理
        void C_MultipleSubscription( String[] nodes);//订阅C各种Robot的信号，并做响应处理
        void SingleSubscription(OpcUaClient opcUaClient, String nodes);      //订阅单一Robot的信号，并做响应处理
        Task ReadNodesAsync(OpcUaClient opcUaClient, NodeId[] tags);//异步读取大量opc nodes,不用返回给调用方法，直接在内部对读取到的nodeids进行处理。



        //订阅设备的信号呢？设备参数什么的比较多，这里只是监控设备的状态信号，作为判断依据。（检测设备的结果也是从这里来做的吧，这样的话，基本可以代替所有SCADA的功能了。。。）

    }
}

using Abp.Domain.Services;
using Hangfire;
using Opc.Ua;
using Opc.Ua.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core.Logging;

namespace QYMSERVER.OPC_UA
{
    public class AssignWorkManager : DomainService, IAssignWorkManager
    {
        // 给机器人下发订单任务主程序接口（订单分解，订单发送，订单信息接收等功能）

        public AssignWorkManager()
        {
        }
        private string[] MonitorNodeTags = null;// 缓存的批量订阅的节点
        /// <summary>
        /// 分发任务给机器人
        /// </summary>
        public void AssignTaskToRobot()
        {
            //QYMSERVERCoreModule.m_OpcUaClient;
            throw new NotImplementedException();
        }
        List<NodeId> NodeIds = new List<NodeId>();
        public void ReadMultipleNode(string[] nodeIds)
        {
            try
            {
                // 添加所有的读取的节点，此处的示例是类型不一致的情况

                NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));

                // dataValues按顺序定义的值，每个值里面需要重新判断类型
                List<DataValue> dataValues = QYMSERVERCoreModule.m_OpcUaClient.ReadNodes(NodeIds.ToArray());

                //// 如果你批量读取的值的类型都是一样的，比如float，那么有简便的方式
                //List<string> tags = new List<string>();
                //tags.Add("ns=2;s=Devices/分厂一/车间二/ModbusTcp客户端/风俗");
                //tags.Add("ns=2;s=Devices/分厂一/车间二/ModbusTcp客户端/转速");

                //// 按照顺序定义的值
                //List<float> values = QYMSERVERCoreModule.m_OpcUaClient.ReadNodes<float>(tags.ToArray());
                if (dataValues.Count > 0)
                {
                    foreach(var value in dataValues)
                    {
                        Logger.Info(value.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                //ClientUtils.HandleException(this.Text, ex);
                Logger.Error(ex.Message);
            }
        }

        public void ReadSingleNode(NodeId nodeId)
        {
            DataValue dataValue = QYMSERVERCoreModule.m_OpcUaClient.ReadNode(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
        }

        public void RemoveRobotMultipleSubscription()
        {
            Logger.Info("666");
            //QYMSERVERCoreModule.m_OpcUaClient.RemoveSubscription("Multiple");
        }
        public void RobotMultipleSubscription()
        {
            // 多个节点的订阅
            MonitorNodeTags = new string[]
            {
                "ns=2;s=Machines/Machine A/TestValueFloat",
                "ns=2;s=Machines/Machine B/TestValueFloat",
                "ns=2;s=Machines/Machine C/TestValueFloat",
            };
            QYMSERVERCoreModule.m_OpcUaClient.AddSubscription("Multiple", MonitorNodeTags, SubCallback);
        }
        public void SubCallback(string key, MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs args)
        {
            //if (InvokeRequired)
            //{
            //    Invoke(new Action<string, MonitoredItem, MonitoredItemNotificationEventArgs>(SubCallback), key, monitoredItem, args);
            //    return;
            //}

            if (key == "Single")
            {
                // 如果有多个的订阅值都关联了当前的方法，可以通过key和monitoredItem来区分
                MonitoredItemNotification notification = args.NotificationValue as MonitoredItemNotification;
                if (notification != null)
                {
                    var Text = notification.Value.WrappedValue.Value.ToString();
                }
            }
            else if (key == "Multiple")
            {
                // 需要区分出来每个不同的节点信息
                MonitoredItemNotification notification = args.NotificationValue as MonitoredItemNotification;
                if (monitoredItem.StartNodeId.ToString() == MonitorNodeTags[0])
                {
                    var Text = notification.Value.WrappedValue.Value.ToString();
                    Logger.Info(Text.ToString());
                }
                else if (monitoredItem.StartNodeId.ToString() == MonitorNodeTags[1])
                {
                    var Text = notification.Value.WrappedValue.Value.ToString();
                    Logger.Info(Text.ToString());
                }
                else if (monitoredItem.StartNodeId.ToString() == MonitorNodeTags[2])
                {
                    var Text = notification.Value.WrappedValue.Value.ToString();
                    Logger.Info(Text.ToString());
                }
            }
        }
    }
}

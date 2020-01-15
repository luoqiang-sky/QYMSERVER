using Abp.Domain.Services;
using Abp.Events.Bus;
using Opc.Ua;
using Opc.Ua.Client;
using OpcUaHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QYMSERVER.OPC_UA
{
    //QYMSERVERCoreModule中初始化  程序启动即开始服务（监控三个Robot的信号变化，变化之后使用领域事件执行相关动作）
    public class OpcBasicMonitorWorkManager : DomainService, IOpcBasicMonitorWorkManager
    {
        public IEventBus EventBus { get; set; }
        public  OpcBasicMonitorWorkManager()
        {
            EventBus = NullEventBus.Instance;
            // 多个节点的订阅
            MonitorNodeTags = new string[]
            {
                "ns=2;s=Machines/Machine A/TestValueFloat",
                "ns=2;s=Machines/Machine B/TestValueFloat",
                "ns=2;s=Machines/Machine C/TestValueFloat",
            };
            A_MultipleSubscription(MonitorNodeTags);
        }

        private string[] MonitorNodeTags = null;// 缓存的批量订阅的节点
        public void A_MultipleSubscription(string[] nodes)
        {
            QYMSERVERCoreModule.A_OpcUaClient.AddSubscription("Multiple", MonitorNodeTags, A_SubCallback);
        }

        public void B_MultipleSubscription(string[] nodes)
        {
            // 多个节点的订阅
            MonitorNodeTags = new string[]
            {
                "ns=2;s=Machines/Machine A/TestValueFloat",
                "ns=2;s=Machines/Machine B/TestValueFloat",
                "ns=2;s=Machines/Machine C/TestValueFloat",
            };
            QYMSERVERCoreModule.B_OpcUaClient.AddSubscription("Multiple", MonitorNodeTags, B_SubCallback);
        }

        public void C_MultipleSubscription( string[] nodes)
        {
            // 多个节点的订阅
            MonitorNodeTags = new string[]
            {
                "ns=2;s=Machines/Machine A/TestValueFloat",
                "ns=2;s=Machines/Machine B/TestValueFloat",
                "ns=2;s=Machines/Machine C/TestValueFloat",
            };
            QYMSERVERCoreModule.C_OpcUaClient.AddSubscription("Multiple", MonitorNodeTags, C_SubCallback);
        }

        public void SingleSubscription(OpcUaClient opcUaClient, string nodes)
        {
            throw new NotImplementedException();
        }
        public void A_SubCallback(string key, MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs args)
        {
            if (key == "Single")
            {
                // 如果有多个的订阅值都关联了当前的方法，可以通过key和monitoredItem来区分
                MonitoredItemNotification notification = args.NotificationValue as MonitoredItemNotification;
                if (notification != null)
                {
                    string value = notification.Value.WrappedValue.Value.ToString();
                    if (value == "True")
                    {
                        DataValue dataValue = QYMSERVERCoreModule.A_OpcUaClient.ReadNode(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                    }
                }
            }
            else if (key == "Multiple")
            {
                // 需要区分出来每个不同的节点信息
                MonitoredItemNotification notification = args.NotificationValue as MonitoredItemNotification;
                if (monitoredItem.StartNodeId.ToString() == MonitorNodeTags[0])
                {
                    var value = notification.Value.WrappedValue.Value.ToString();
                    //if (value == "True")
                    {
                        List<NodeId> NodeIds = new List<NodeId>();
                        NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                        NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                        NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                        NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                        NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                        NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                        NodeIds.Add(new NodeId("ns=2;s=Machines/Machine A/TestValueFloat"));
                        //ReadNodesAsync(QYMSERVERCoreModule.A_OpcUaClient, NodeIds.ToArray());
                        Task.Run(() => {

                            List<DataValue> dataValues= QYMSERVERCoreModule.A_OpcUaClient.ReadNodes(NodeIds.ToArray());
                            while (true)
                            {
                                Thread.Sleep(1000);
                                Logger.Debug("A_SubCallback.............................. ");
                            }
                        });
                    }
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
        public void B_SubCallback(string key, MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs args)
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
        public void C_SubCallback(string key, MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs args)
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
        #region Async方法
        public async Task ReadNodesAsync(OpcUaClient opcUaClient, NodeId[] tags)
        {
            List<DataValue> t = await Task.Run(() => {

               return QYMSERVERCoreModule.A_OpcUaClient.ReadNodes(tags);

             });
            foreach(var value in t)
            {
                Logger.Info(value.ToString());//do something
            }
        }
        #endregion
        #region 领域事件

        #endregion
    }
}

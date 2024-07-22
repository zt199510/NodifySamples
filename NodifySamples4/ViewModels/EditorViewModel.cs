using NodifySamples4.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodifySamples4.ViewModels
{
    public class EditorViewModel
    {
        public ObservableCollection<NodeViewModel> Nodes { get; } = new ObservableCollection<NodeViewModel>();
        public ObservableCollection<ConnectionViewModel> Connections { get; } = new ObservableCollection<ConnectionViewModel>();


        public PendingConnectionViewModel PendingConnection { get; }
        public EditorViewModel()
        {


            PendingConnection  = new PendingConnectionViewModel(this);
            var welcome = new NodeViewModel
            {
                Title = "我的第一个节点",
                Input = new ObservableCollection<ConnectorViewModel>
            {
                new ConnectorViewModel
                {
                    Title = "输入"
                }
            },
                Output = new ObservableCollection<ConnectorViewModel>
            {
                new ConnectorViewModel
                {
                    Title = "输出"
                }
            }
            };
       

            var nodify = new NodeViewModel
            {
                Title = "节点1",
                Input = new ObservableCollection<ConnectorViewModel>
            {
                new ConnectorViewModel
                {
                    Title = "输入"
                }
            }
            };
            Nodes.Add(welcome);
            Nodes.Add(nodify);


           
           
        }


        public void Connect(ConnectorViewModel source, ConnectorViewModel target)
        {
            var newConnection = new ConnectionViewModel(source, target);

            // 检查是否已经存在相同的连接
            if (!Connections.Contains(newConnection))
            {
                Connections.Add(newConnection);
            }
        }
    }
}

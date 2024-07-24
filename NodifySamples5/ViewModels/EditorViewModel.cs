using NodifySamples5.Common;
using NodifySamples5.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NodifySamples5.ViewModels
{
    public class EditorViewModel
    {
        public ObservableCollection<NodeViewModel> Nodes { get; } = new ObservableCollection<NodeViewModel>();
        public ObservableCollection<ConnectionViewModel> Connections { get; } = new ObservableCollection<ConnectionViewModel>();

        public ICommand DisconnectConnectorCommand { get; }
        public PendingConnectionViewModel PendingConnection { get; }
        public EditorViewModel()
        {
            DisconnectConnectorCommand = new DelegateCommand<ConnectorViewModel>(connector =>
            {
                var connection = Connections.First(x => x.Source == connector || x.Target == connector);
                connection.Source.IsConnected = false; ///将连接器属性设为false
            connection.Target.IsConnected = false;
                Connections.Remove(connection);
            });

            PendingConnection  = new PendingConnectionViewModel(this);
            var welcome = new NodeViewModel
            {
                Location=new System.Windows.Point(100,100),
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
                Location = new System.Windows.Point(500, 100),
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

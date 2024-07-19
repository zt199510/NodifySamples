using NodifySamples2.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodifySamples2.ViewModels
{
    public class EditorViewModel
    {
        public ObservableCollection<NodeViewModel> Nodes { get; } = new ObservableCollection<NodeViewModel>();
        public ObservableCollection<ConnectionViewModel> Connections { get; } = new ObservableCollection<ConnectionViewModel>();
        public EditorViewModel()
        {
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
                Title = "To Nodify",
                Input = new ObservableCollection<ConnectorViewModel>
            {
                new ConnectorViewModel
                {
                    Title = "In"
                }
            }
            };
            Nodes.Add(welcome);
            Nodes.Add(nodify);


            Connections.Add(new ConnectionViewModel(welcome.Output[0], nodify.Input[0]));
           
        }
    }
}

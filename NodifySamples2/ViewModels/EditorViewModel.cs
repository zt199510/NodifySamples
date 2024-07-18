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

        public EditorViewModel()
        {
      
            Nodes.Add(new NodeViewModel
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
            });
        }
    }
}

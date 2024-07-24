using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodifySamples5.Models
{
    public class NodeViewModel : NotifyPropertyBase
    {
        public string Title { get; set; }

        private Point _location;
        public Point Location
        {
            get => _location;
            set => Set(ref _location, value);
        }
        public ObservableCollection<ConnectorViewModel> Input { get; set; } = new ObservableCollection<ConnectorViewModel>();
        public ObservableCollection<ConnectorViewModel> Output { get; set; } = new ObservableCollection<ConnectorViewModel>();
    }
}

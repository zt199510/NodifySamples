using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodifySamples5.Models
{
    public class ConnectorViewModel: NotifyPropertyBase
    {
        public string Title { get; set; }

        private Point _anchor;
        public Point Anchor
        {
            get => _anchor;
            set => Set(ref _anchor, value);
        }

        private bool _isConnected;
        public bool IsConnected
        {
            get => _isConnected;
            set => Set(ref _isConnected, value);
        }
    }
}

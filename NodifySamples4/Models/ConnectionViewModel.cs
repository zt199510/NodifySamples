﻿using NodifySamples4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodifySamples4.Models
{
    public class ConnectionViewModel
    {

        public ConnectionViewModel(ConnectorViewModel source, ConnectorViewModel target)
        {
            Source = source;
            Target = target;

            Source.IsConnected = true;
            Target.IsConnected = true;
        }

        public ConnectionViewModel()
        {
         

        }
        public ConnectorViewModel Source { get; }
        public ConnectorViewModel Target { get; }
    }
}

﻿using NodifySamples4.Common;
using NodifySamples4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NodifySamples4.ViewModels
{
    public class PendingConnectionViewModel : ObservableObject
    {
        private readonly EditorViewModel _editor;
        private ConnectorViewModel _source;

        public PendingConnectionViewModel(EditorViewModel editor)
        {
            _editor = editor;
            StartCommand = new DelegateCommand<ConnectorViewModel>(source => _source = source);
            FinishCommand = new DelegateCommand<ConnectorViewModel>(target =>
            {
                if (target != null)
                    _editor.Connect(_source, target);
            });
        }

        public ICommand StartCommand { get; }
        public ICommand FinishCommand { get; }
    }
}

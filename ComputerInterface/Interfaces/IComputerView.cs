﻿using ComputerInterface.ViewLib;
using System;
using System.ComponentModel;

namespace ComputerInterface.Interfaces
{
    public interface IComputerView : INotifyPropertyChanged
    {
        string Text { get; set; }

        Type CallerViewType { get; set; }

        void OnKeyPressed(EKeyboardKey key);

        void OnShow(object[] args);

        event ComputerViewSwitchEventHandler OnViewSwitchRequest;

        event ComputerViewChangeBackgroundEventHandler OnChangeBackgroundRequest;
    }
}
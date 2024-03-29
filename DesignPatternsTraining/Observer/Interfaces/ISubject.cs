﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interfaces
{
    public interface ISubject
    {
        event PriceThresholdAlert PriceThresholdAlertEvent;

        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers();
    }
}

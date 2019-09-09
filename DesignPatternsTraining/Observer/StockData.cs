using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer
{
    public delegate void PriceThresholdAlert(double price);

    /// <summary>
    /// The subject
    /// </summary>
    public class StockData : ISubject
    {        
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price == value) return;
                _price = value;
                NotifyObservers();

                if (PriceThresholdAlertEvent != null)
                {
                    PriceThresholdAlertEvent(_price);
                }
            }
        }

        private readonly IList<IObserver> _observers;

        private double _price;

        public StockData()
        {
            _observers = new List<IObserver>();
        }

        public event PriceThresholdAlert PriceThresholdAlertEvent;

        public void RegisterObserver(IObserver observer)
        {
           _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(Price);
            }
        }
    }
}

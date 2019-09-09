using System;
using Observer.Interfaces;

namespace Observer
{
    /// <summary>
    /// The observer
    /// </summary>
    public class Dashboard : IObserver, IDisplayElement
    {
        private const double Threshold = 100.0;

        private double _price;

        private readonly ISubject _subject;

        public Dashboard(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);

            // subscribe to event
            _subject.PriceThresholdAlertEvent += PriceAlert;
        }

        public void Update(double price)
        {
            _price = price;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Price after update: {_price:C}");
        }

        private void PriceAlert(double price)
        {
            if (price > Threshold)
            {
                Console.WriteLine($"Threshold {Threshold} was exceeded");
            }
        }
    }
}

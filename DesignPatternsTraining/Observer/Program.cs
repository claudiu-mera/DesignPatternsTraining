using System;
using Observer.Interfaces;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's subscribe to some stock price changes!");

            var stockData = new StockData
            {
                Price = 10.0
            };

            IObserver dashboard = new Dashboard(stockData);

            stockData.Price = 20.0;

            stockData.Price = 150.0;

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Facade.Components
{
    public class Radio
    {
        private readonly Dictionary<string, double> _channels = 
            new Dictionary<string, double>
            {
                { "Pop Music", 100.5 },
                { "Rock Music", 80.6 },
                { "Latin Music", 90.2 },
                { "Classical Music", 85.0 },
            };

        public void Start()
        {
            Console.WriteLine("Starting radio");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping radio");
        }

        public double GetFrequency(string channelTitle)
        {
            return _channels[channelTitle];
        }

        public void Tune(double frequency)
        {
            Console.WriteLine($"Searching {frequency}");
        }
    }
}

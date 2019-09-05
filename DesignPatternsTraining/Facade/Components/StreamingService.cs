using System;

namespace Facade.Components
{
    public class StreamingService
    {
        public void StartMovie(string title)
        {
            Console.WriteLine($"Starting movie {title}");
        }

        public void StopMovie(string title)
        {
            Console.WriteLine($"Stopping movie {title}");
        }
    }
}

using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to watch something on TV");

            ISmartTvFacade smartTv = new SmartTvFacade();

            smartTv.Watch(10, string.Empty);

            smartTv.Watch(0, "The Internship");

            smartTv.ListenRadio("Pop Music");

            Console.ReadKey();
        }
    }
}

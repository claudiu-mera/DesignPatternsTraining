using System;

namespace Singleton
{
    public class Loader
    {
        private static int counter = 0;

        private static Loader _instance;

        public static Loader Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Loader();
                }

                return _instance;
            }
        }
        private Loader()
        {
            counter++;
            Console.WriteLine($"Loader Counter value: {counter}");
        }
    }
}

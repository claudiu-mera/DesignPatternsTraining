using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Loader firstInstance = Loader.Instance;
            Loader secondInstance = Loader.Instance;

            Console.WriteLine($"First instance equals second instance {firstInstance.Equals(secondInstance)}");

            LazyLoader firstLazyInstance = LazyLoader.Instance;
            LazyLoader secondLazyInstance = LazyLoader.Instance;

            Console.WriteLine($"First lazy instance equals second lazy instance {firstInstance.Equals(secondInstance)}");

            Console.ReadKey();
        }
    }
}

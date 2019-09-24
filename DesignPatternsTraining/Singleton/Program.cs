using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintDetails(),
                () => PrintDetails());

            Loader firstInstance = Loader.Instance;
            Loader secondInstance = Loader.Instance;

            Console.WriteLine($"First instance equals second instance {firstInstance.Equals(secondInstance)}");

            LazyLoader firstLazyInstance = LazyLoader.Instance;
            LazyLoader secondLazyInstance = LazyLoader.Instance;

            Console.WriteLine($"First lazy instance equals second lazy instance {firstLazyInstance.Equals(secondLazyInstance)}");

            Console.ReadKey();
        }

        private static void PrintDetails()
        {
            // replace with LazyLoader
            //LazyLoader instance = LazyLoader.Instance;
            Loader instance = Loader.Instance;

            Console.WriteLine("Print details");
        }
    }
}

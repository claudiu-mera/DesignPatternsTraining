using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype example");

            Prototype first = new ConcretePrototype
            {
                Name = "test name",
                Description = "test description"
            };
            Console.WriteLine(first.ToString());

            Prototype second = first.Clone();
            Console.WriteLine(second.ToString());

            Console.ReadKey();
        }
    }
}

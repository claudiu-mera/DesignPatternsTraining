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
                Id = 1,
                Description = new PrototypeDescription
                {
                    Name = "test name",
                    Details = "test details"
                }
            };
            Console.WriteLine($"First:{first}");

            Prototype second = first.ShallowCopy();
            second.Id = 2;
            second.Description.Details = "new details";
            Console.WriteLine($"Second:{second}");
            Console.WriteLine($"First:{first}");

            Prototype third = first.DeepCopy();
            third.Id = 3;
            third.Description.Details = "very new details";
            Console.WriteLine($"Third:{third}");
            Console.WriteLine($"First:{first}");

            Console.ReadKey();
        }
    }
}

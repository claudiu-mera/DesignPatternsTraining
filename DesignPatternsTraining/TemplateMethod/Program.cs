using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's make some tea and coffee!");

            Console.WriteLine("Preparing the tea...");
            var tea = new Tea();
            tea.Prepare();

            Console.WriteLine("Preparing the coffee...");
            var coffee = new Coffee();
            coffee.Prepare();

            Console.ReadKey();
        }
    }
}

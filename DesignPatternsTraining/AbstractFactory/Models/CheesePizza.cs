using System;

namespace AbstractFactory.Models
{
    public class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing pizza with lots of cheese...");
        }
    }
}

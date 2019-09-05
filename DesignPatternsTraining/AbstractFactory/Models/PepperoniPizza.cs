using System;

namespace AbstractFactory.Models
{
    public class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Adding a little bit of pepper to the pizza...");
        }
    }
}

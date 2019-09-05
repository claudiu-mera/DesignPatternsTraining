using System;

namespace AbstractFactory.Models
{
    public class VeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing pizza with loads of vegetables...");
        }
    }
}

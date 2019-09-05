using System;

namespace AbstractFactory.Models
{
    public abstract class Pizza
    {
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking pizza...");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza...");
        }
    }
}

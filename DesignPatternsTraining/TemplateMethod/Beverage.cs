using System;

namespace TemplateMethod
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling some water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring in cup");
        }

        public abstract void Brew();

        public abstract void AddCondiments();
    }
}

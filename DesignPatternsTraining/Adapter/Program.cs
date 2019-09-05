using System;
using Adapter.Interfaces;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new WildDuck();

            duck.Quack();
            duck.Fly();

            ITurkey turkey = new Turkey();

            turkey.Gobble();
            turkey.Fly();

            TurkeyAdapter adapter = new TurkeyAdapter(turkey);

            adapter.Quack();
            adapter.Fly();

            Console.ReadKey();
        }
    }
}

using System;
using Adapter.Interfaces;

namespace Adapter
{
    public class WildDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I believe I can fly, I believe I can touch the sky!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}

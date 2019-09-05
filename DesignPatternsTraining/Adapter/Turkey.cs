using System;
using Adapter.Interfaces;

namespace Adapter
{
    public class Turkey: ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble!");
        }

        public void Fly()
        {
            Console.WriteLine("Flying on short distance");
        }
    }
}

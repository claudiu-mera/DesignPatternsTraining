using System;
using State.States;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to process some messages");

            Message message = new Message();

            message.Init();
            message.Load();
            message.Process();
            message.Revert();

            message.Init();
            message.Load();
            message.Process();
            message.Publish();

            Console.ReadKey();
        }
    }
}

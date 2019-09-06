using System;

namespace Command.Models
{
    public class Light
    {
        /// <summary>
        /// Receiver of command
        /// </summary>
        public void On()
        {
            Console.WriteLine("Turning light on...");
        }

        public void Off()
        {
            Console.WriteLine("Turning light off...");
        }
    }
}

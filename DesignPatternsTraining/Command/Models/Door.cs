using System;

namespace Command.Models
{
    public class Door
    {
        /// <summary>
        /// Receiver of command
        /// </summary>
        public void Open()
        {
            Console.WriteLine("Opening the door...");
        }
    }
}

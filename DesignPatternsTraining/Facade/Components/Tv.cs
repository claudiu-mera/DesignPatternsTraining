using System;

namespace Facade.Components
{
    public class Tv
    {
        public void On()
        {
            Console.WriteLine("Turning TV on");
        }

        public void Off()
        {
            Console.WriteLine("Turning TV off");
        }

        public void MoveToChannel(int channelId)
        {
            Console.WriteLine($"Moving to channel {channelId}");
        }
    }
}

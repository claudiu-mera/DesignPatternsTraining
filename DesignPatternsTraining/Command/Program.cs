using System;
using Command.Models;

namespace Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to test our remote control...");

            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();
            LightOnCommand lightCommand = new LightOnCommand(light);

            remoteControl.SetCommand(lightCommand);
            remoteControl.PressButton();

            Door door = new Door();
            OpenDoorCommand openDoorCommand = new OpenDoorCommand(door);

            remoteControl.SetCommand(openDoorCommand);
            remoteControl.PressButton();

            Console.ReadKey();
        }
    }
}

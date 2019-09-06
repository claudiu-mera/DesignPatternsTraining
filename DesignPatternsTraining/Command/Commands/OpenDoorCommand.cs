using System;
using Command.Models;

namespace Command.Commands
{
    public class OpenDoorCommand : ICommand
    {
        private readonly Door _door;

        public OpenDoorCommand(Door door)
        {
            this._door = door;
        }

        public void Execute()
        {
            _door.Open();
        }

        public void Undo()
        {
            Console.WriteLine("An open door should always remain open");
        }
    }
}

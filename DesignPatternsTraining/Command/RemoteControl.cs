using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    /// <summary>
    /// The Invoker class
    /// </summary>
    public class RemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand command)
        {
            this._slot = command;
        }

        public void PressButton()
        {
            _slot.Execute();
        }

        public void Revert()
        {
            _slot.Undo();
        }
    }
}

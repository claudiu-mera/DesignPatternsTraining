using System;

namespace State.States
{
    public class InitializeState : IState
    {
        private readonly Message _message;

        public InitializeState(Message message)
        {
            _message = message;
        }

        public void InitializeMessage()
        {
            Console.WriteLine("Initializing message");

            _message.State = _message.LoadState;
        }

        public void LoadMessage()
        {
            throw new NotSupportedException();
        }

        public void ProcessMessage()
        {
            throw new NotSupportedException();
        }

        public void PublishMessage()
        {
            throw new NotSupportedException();
        }

        public void ResetMessage()
        {
            throw new NotSupportedException();
        }
    }
}

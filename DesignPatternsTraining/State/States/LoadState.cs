using System;

namespace State.States
{
    public class LoadState : IState
    {
        private readonly Message _message;

        public LoadState(Message message)
        {
            _message = message;
        }

        public void InitializeMessage()
        {
            throw new NotSupportedException();
        }

        public void LoadMessage()
        {           
            Console.WriteLine("Loading message");

            _message.State = _message.ProcessedState;
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
            _message.State = _message.InitializedState;

            Console.WriteLine("Message state reverted to: Initialized");
        }
    }
}

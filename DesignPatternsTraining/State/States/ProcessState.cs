using System;

namespace State.States
{
    public class ProcessState : IState
    {
        private readonly Message _message;

        public ProcessState(Message message)
        {
            _message = message;
        }

        public void InitializeMessage()
        {
            throw new NotSupportedException();
        }

        public void LoadMessage()
        {
            throw new NotSupportedException();
        }

        public void ProcessMessage()
        {            
            Console.WriteLine("Processing message");

            _message.State = _message.PublishedState;
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

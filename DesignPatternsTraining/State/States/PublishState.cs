using System;

namespace State.States
{
    public class PublishState : IState
    {
        private readonly Message _message;

        public PublishState(Message message)
        {
            _message = message;
        }

        public void InitializeMessage()
        {
            throw new NotSupportedException();
        }

        public void LoadMessage()
        {
            throw  new NotSupportedException();
        }

        public void ProcessMessage()
        {
            throw new NotSupportedException();
        }

        public void PublishMessage()
        {
            Console.WriteLine("Publishing message");
        }

        public void ResetMessage()
        {
            _message.State = _message.InitializeState;

            Console.WriteLine("Message state reverted to: Initialized");
        }
    }
}

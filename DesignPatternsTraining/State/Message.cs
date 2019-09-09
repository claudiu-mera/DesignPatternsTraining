using State.States;

namespace State
{
    public class Message
    {
        public IState State { get; set; }

        public IState InitializedState { get; set; }

        public IState LoadedState { get; set; }

        public IState ProcessedState { get; set; }

        public IState PublishedState { get; set; }

        public Message()
        {
            InitializedState = new InitializeState(this);
            LoadedState = new LoadState(this);
            ProcessedState = new ProcessState(this);
            PublishedState = new PublishState(this);

            State = InitializedState;
        }

        public void Init()
        {
            State.InitializeMessage();
        }

        public void Load()
        {
            State.LoadMessage();
        }

        public void Process()
        {
            State.ProcessMessage();
        }

        public void Publish()
        {
            State.PublishMessage();
        }

        public void Revert()
        {
            State.ResetMessage();
        }
    }
}

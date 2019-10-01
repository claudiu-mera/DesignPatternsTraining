using State.States;

namespace State
{
    public class Message
    {
        public IState State { get; set; }

        public IState InitializeState { get; set; }

        public IState LoadState { get; set; }

        public IState ProcessState { get; set; }

        public IState PublishState { get; set; }

        public Message()
        {
            InitializeState = new InitializeState(this);
            LoadState = new LoadState(this);
            ProcessState = new ProcessState(this);
            PublishState = new PublishState(this);

            State = InitializeState;
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

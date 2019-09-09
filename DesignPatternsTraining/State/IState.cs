namespace State
{
    public interface IState
    {
        void InitializeMessage();

        void LoadMessage();

        void ProcessMessage();

        void PublishMessage();

        void ResetMessage();
    }
}
namespace Facade
{
    public interface ISmartTvFacade
    {
        void Watch(int channelId, string title);

        void WatchMovie(string title);

        void EndMovie(string title);

        void ListenRadio(string channel);
    }
}
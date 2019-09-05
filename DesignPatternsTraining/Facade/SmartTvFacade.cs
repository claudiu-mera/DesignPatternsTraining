using Facade.Components;

namespace Facade
{
    public class SmartTvFacade : ISmartTvFacade
    {
        private readonly Tv _tv;

        private readonly Radio _radio;

        private readonly StreamingService _streamingService;

        public SmartTvFacade()
        {
            _tv = new Tv();
            _radio = new Radio();
            _streamingService = new StreamingService();
        }

        public void Watch(int channelId, string title)
        {
            _tv.On();

            if (channelId > 0)
            {
                _tv.MoveToChannel(channelId);
            }
            else
            {
                _streamingService.StartMovie(title);
            }
        }

        public void WatchMovie(string title)
        {
            _tv.On();
            _streamingService.StartMovie(title);
        }

        public void EndMovie(string title)
        {
            _streamingService.StopMovie(title);
            _tv.Off();
        }

        public void ListenRadio(string channel)
        {
            _tv.On();
            _radio.Start();

            double channelFrequency = _radio.GetFrequency(channel);
            _radio.Tune(channelFrequency);
        }
    }
}

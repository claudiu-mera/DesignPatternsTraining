namespace Singleton
{
    public class Loader
    {
        private static Loader _instance;

        public static Loader Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Loader();
                }

                return _instance;
            }
        }
        private Loader()
        {
        }
    }
}

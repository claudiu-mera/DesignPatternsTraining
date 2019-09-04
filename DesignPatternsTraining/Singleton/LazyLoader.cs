using System;

namespace Singleton
{
    public class LazyLoader
    {
        private static readonly Lazy<LazyLoader> lazy = new Lazy<LazyLoader>(() => new LazyLoader());

        public static LazyLoader Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private LazyLoader()
        {

        }
    }
}

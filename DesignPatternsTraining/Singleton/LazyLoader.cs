﻿using System;

namespace Singleton
{
    public class LazyLoader
    {
        private static readonly Lazy<LazyLoader> lazy = new Lazy<LazyLoader>(() => new LazyLoader());

        private static int counter = 0;

        public static LazyLoader Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private LazyLoader()
        {
            counter++;

            Console.WriteLine($"LazyLoader Counter value: {counter}");
        }
    }
}

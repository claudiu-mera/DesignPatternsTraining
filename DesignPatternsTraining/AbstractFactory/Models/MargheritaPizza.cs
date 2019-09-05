﻿using System;

namespace AbstractFactory.Models
{
    public class MargheritaPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing the one and only Margherita pizza...");
        }
    }
}

using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Stores
{
    public class ClujPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch(type.ToLower())
            {
                case "cheese":
                    return new CheesePizza();
                case "margherita":
                    return new MargheritaPizza();
                case "veggie":
                    return new VeggiePizza();
                default:
                    return null;
            }
        }
    }
}

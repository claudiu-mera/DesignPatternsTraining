using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Stores
{
    public class BucharestPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch(type.ToLower())
            {
                case "cheese":
                    return new CheesePizza();
                case "margherita":
                    return new MargheritaPizza();
                case "peperroni":
                    return new PeperroniPizza();
                default:
                    return null;
            }
        }
    }
}

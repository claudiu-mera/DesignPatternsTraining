using AbstractFactory.Models;

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
                case "pepperoni":
                    return new PepperoniPizza();
                default:
                    return null;
            }
        }
    }
}

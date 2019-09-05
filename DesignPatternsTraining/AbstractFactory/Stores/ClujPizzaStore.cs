using AbstractFactory.Models;

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

using System;
using AbstractFactory.Stores;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coming to Cluj...");

            PizzaStore pizzaStore = new ClujPizzaStore();

            pizzaStore.OrderPizza("veggie");

            var pizza = pizzaStore.OrderPizza("pepperoni");

            if (pizza == null)
            {
                Console.WriteLine("Sorry, pizza not available here. Please visit another store.");
            }

            Console.WriteLine("Going to Bucharest...");

            pizzaStore = new BucharestPizzaStore();

            pizzaStore.OrderPizza("pepperoni");

            pizzaStore.OrderPizza("margherita");

            Console.ReadKey();
        }
    }
}

using System;
using Decorator.Components;
using Decorator.Decorators;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's make our own salad!");

            Salad mySalad = new CaesarSalad();
            Console.WriteLine($"Initial cost: {mySalad.ComputeCost()}");

            IngredientDecorator firstIngredient = new CornDecorator(mySalad);
            Console.WriteLine($"Cost after adding corn: {firstIngredient.ComputeCost()}");

            IngredientDecorator secondIngredient = new SauceDecorator(firstIngredient);
            Console.WriteLine($"Cost after adding sauce: {secondIngredient.ComputeCost()}");

            Console.ReadKey();
        }
    }
}

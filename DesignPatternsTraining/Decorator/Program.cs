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

            IngredientDecorator saladWithFirstIngredient = new CornDecorator(mySalad);
            Console.WriteLine($"Cost after adding corn: {saladWithFirstIngredient.ComputeCost()}");

            IngredientDecorator saladWithSecondIngredient = new SauceDecorator(saladWithFirstIngredient);
            Console.WriteLine($"Cost after adding sauce: {saladWithSecondIngredient.ComputeCost()}");

            Console.ReadKey();
        }
    }
}

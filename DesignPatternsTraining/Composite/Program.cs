using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looking into the menu...");

            Menu mainMenu = new Menu("Menu", "Main Menu");

            // add breakfast menu
            Menu breakfastMenu = new Menu("Breakfast", "Breakfast sub-menu");
            breakfastMenu.Add(new MenuItem("eggs", "scrambled eggs", true, 5.0));
            breakfastMenu.Add(new MenuItem("yoghurt", "fruits yoghurt", true, 3.0));

            mainMenu.Add(breakfastMenu);

            // add dinner menu
            Menu dinnerMenu = new Menu("Dinner", "Dinner sub-menu");
            dinnerMenu.Add(new MenuItem("steak", "t-bone steak", false, 20.0));
            dinnerMenu.Add(new MenuItem("fish and chips", "fish with chips and salad", false, 12.0));

            mainMenu.Add(dinnerMenu);

            // and a small desert...
            mainMenu.Add(new MenuItem("cheesecake", "classic cheesecake", true, 10.0));

            mainMenu.Print();

            Console.ReadKey();
        }
    }
}

using System;

namespace Composite
{
    public class MenuItem : MenuComponent
    {
        public override string Name { get; set; }

        public override string Description { get; set; }

        public override bool IsVegetarian { get; set; }

        public override double Price { get; set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.IsVegetarian = isVegetarian;
            this.Price = price;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name}, Vegetarian {IsVegetarian}, Price {Price:C} -- {Description}");
        }
    }
}

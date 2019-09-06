using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Menu : MenuComponent
    {
        public override string Name { get; set; }

        public override string Description { get; set; }

        private readonly IList<MenuComponent> _menuComponents;

        public Menu(string name, string description)
        {
            this.Name = name;
            this.Description = description;

            _menuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            return _menuComponents.ElementAt(index);
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} -- {Description}");

            foreach (var menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }
    }
}

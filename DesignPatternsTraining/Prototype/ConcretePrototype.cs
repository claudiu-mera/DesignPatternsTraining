using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class ConcretePrototype : Prototype
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Name:{this.Name}, Description:{this.Description}";
        }
    }
}

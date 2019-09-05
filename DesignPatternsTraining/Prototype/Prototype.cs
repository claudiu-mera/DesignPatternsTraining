using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class Prototype
    {
        public int Id { get; set; }

        public PrototypeDescription Description { get; set; }

        public abstract Prototype ShallowCopy();

        public abstract Prototype DeepCopy();

        public override string ToString()
        {
            return $"Id:{Id}, Description:{this.Description}";
        }
    }
}

using System;


namespace Composite
{
    public abstract class MenuComponent
    {
        public abstract string Name { get; set; }

        public abstract string Description { get; set; }

        public virtual bool IsVegetarian { get; set; }

        public virtual double Price { get; set; }

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}

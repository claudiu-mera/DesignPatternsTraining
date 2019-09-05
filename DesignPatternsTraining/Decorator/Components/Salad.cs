namespace Decorator.Components
{
    public abstract class Salad
    {
        public string Description { get; set; }

        public abstract double ComputeCost();
    }
}

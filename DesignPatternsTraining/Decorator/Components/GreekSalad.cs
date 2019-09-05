namespace Decorator.Components
{
    public class GreekSalad : Salad
    {
        public GreekSalad()
        {
            Description = "Greek Salad";
        }

        public override double ComputeCost()
        {
            return 12.0;
        }
    }
}

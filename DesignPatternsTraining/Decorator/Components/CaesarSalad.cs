namespace Decorator.Components
{
    public class CaesarSalad : Salad
    {
        public CaesarSalad()
        {
            Description = "Caesar Salad";
        }

        public override double ComputeCost()
        {
            return 10.0;
        }
    }
}

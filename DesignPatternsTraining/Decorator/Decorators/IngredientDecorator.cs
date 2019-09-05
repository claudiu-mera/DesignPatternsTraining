using Decorator.Components;

namespace Decorator.Decorators
{
    public abstract class IngredientDecorator : Salad
    {
        protected Salad Salad { get; set; }

        public IngredientDecorator(Salad salad)
        {
            this.Salad = salad;
            this.Description = "Ingredient";
        }
    }
}

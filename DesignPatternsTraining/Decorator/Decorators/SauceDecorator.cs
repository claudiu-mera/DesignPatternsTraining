using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Components;

namespace Decorator.Decorators
{
    public class SauceDecorator : IngredientDecorator
    {
        public SauceDecorator(Salad salad) : base(salad)
        {
            this.Description = $"Sauce {base.Description}";
        }

        public override double ComputeCost()
        {
            return 3.0 + Salad.ComputeCost();
        }
    }
}

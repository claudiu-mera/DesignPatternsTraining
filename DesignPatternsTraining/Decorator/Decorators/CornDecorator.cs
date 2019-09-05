using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Components;

namespace Decorator.Decorators
{
    public class CornDecorator : IngredientDecorator
    {
        public CornDecorator(Salad salad) : base(salad)
        {
        }

        public override double ComputeCost()
        {
            return 2.0 + Salad.ComputeCost();
        }
    }
}

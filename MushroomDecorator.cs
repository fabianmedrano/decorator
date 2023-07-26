using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class MushroomDecorator: ToppingDecorator
    {
        public MushroomDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Mushroom";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 1.50;
        }

    }
}

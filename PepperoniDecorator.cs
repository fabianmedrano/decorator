using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class PepperoniDecorator:ToppingDecorator
    {
        public PepperoniDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Pepperoni";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 2.00;
        }
    }
}

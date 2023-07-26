using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class ToppingDecorator :Pizza
    {
        protected Pizza _pizza;
        public ToppingDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }
        public override double GetCost()
        {
            return _pizza.GetCost();
        }
        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}

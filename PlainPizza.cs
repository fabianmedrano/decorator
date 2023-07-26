using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class PlainPizza : Pizza
    {
        public override string GetDescription()
        {
            return "plain pizza";
        }
        public override double GetCost()
        {
            return 4.00;
        }

    }
}

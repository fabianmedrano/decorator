using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public abstract class Pizza
    {
        public abstract string GetDescription();
        public abstract double GetCost();
    }
}

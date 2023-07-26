using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new PlainPizza();

            pizza = new PepperoniDecorator(pizza);
            pizza = new MushroomDecorator(pizza);

            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());
            Console.ReadLine();
        }
    }
}

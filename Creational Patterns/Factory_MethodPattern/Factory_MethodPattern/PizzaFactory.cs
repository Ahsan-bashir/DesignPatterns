using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodPattern
{
    internal class PizzaFactory
    {
        private Pizza pizza = null;
        public Pizza CreatePizza(String type)
        {
            if (type.Equals("special pizza"))
                pizza = new SpecialPizza();
            else if (type.Equals("chicken tikka"))
                pizza = new ChickenTikka();

            return pizza;

        }
    }
}

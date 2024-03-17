using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodPattern
{
    /*
    This class plays a crucial role in the Factory Method pattern.
    It has a method CreatePizza(String type) that takes a pizza type as input.
    Based on the type, it creates an instance of the corresponding concrete class (e.g., SpecialPizza for "special pizza").
    This way, the client code doesn't need to know the specifics of creating each pizza type.
    */

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

using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Xml.Linq;

namespace Factory_MethodPattern
{
        /*
        This class defines the blueprint for all concrete pizza types.
        It has member variables for name, dough, sauce, and a list of toppings.
        It also defines methods for preparing, baking, cutting, and boxing the pizza (common functionalities for all pizzas).
        */
    internal abstract class Pizza
    {
        protected String name;
        protected String dough;
        protected String sauce;
        protected List<String> toppings=new List<string>();

        public void Prepare()
        {
            Console.WriteLine("{0} is Preparing",name);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Dough :\t {0}", dough);
            Console.WriteLine("Sauce :\t {0}", sauce);
            Console.WriteLine("Toppings : ");
            Console.WriteLine("##############");
            foreach (String item in toppings)
                Console.WriteLine("@ {0}",item);
        }

        public void Bake()
        {
            Console.WriteLine("{0} is Baking ... ",name);
        }

        public void Cut()
        {
            Console.WriteLine("{0} is Cutting ... ", name);
        }
        public void Box()
        {
            Console.WriteLine("^^^^ Dear Customer , your order for {0} is ready ...Enjoy !!! ", name);
            Console.WriteLine();
        }

    }
}

using System;
using System.Collections.Generic;

namespace Factory_MethodPattern
{
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

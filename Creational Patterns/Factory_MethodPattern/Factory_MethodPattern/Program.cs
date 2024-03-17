using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodPattern
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new PizzaFactory();
            PizzaStore store= new PizzaStore(factory);
            store.OrderPizza("special pizza");
            store.OrderPizza("chicken tikka");
        }
    }
}

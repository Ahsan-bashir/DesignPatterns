using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodPattern
{
    internal class PizzaStore
    {
        PizzaFactory factory = null;
        public PizzaStore(PizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(String type)
        {
            Pizza pizza=factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }


    }
}

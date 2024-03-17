using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodPattern
{
    internal class SpecialPizza : Pizza
    {
        public SpecialPizza() {
            name = " Special Pizza";
            dough = "Crust";
            sauce = "Chilli Garlic Sauce";
            toppings.Add("Olives");
            toppings.Add("Mashrooms");
            toppings.Add("BBQ Chicken Slices");
        }
    }
}

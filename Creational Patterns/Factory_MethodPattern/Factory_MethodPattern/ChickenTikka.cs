using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodPattern
{
    internal class ChickenTikka : Pizza
    {
        public ChickenTikka()
        {
            name = "Chicken Tikka Pizza";
            dough= "Normal Crust";
            sauce = "Tikka Fast Sauce";
            toppings.Add("Garlic");
            toppings.Add("Mayonees");
            toppings.Add("Baked Tikka Boti");
        }
    }
}

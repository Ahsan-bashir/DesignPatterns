using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern
{
    internal class Singelton
    {
        private static Singelton instance;
        private Singelton()
        {
            Console.WriteLine("Created Successfully");

        }

    }
}

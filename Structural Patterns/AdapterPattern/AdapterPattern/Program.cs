using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RichCompound water = new RichCompound("Water");
            water.Display();

            RichCompound benzene = new RichCompound("Benzene");
            benzene.Display();

            RichCompound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern
{
     class Program
    {
        static void Main(string[] args)
        {
            Singelton.CreateInstance();  // Should Create Instace  
            Singelton.CreateInstance();  // Should NOT Create Instance
            Singelton.CreateInstance();  // Should NOT Create Instance

        }
    }
}

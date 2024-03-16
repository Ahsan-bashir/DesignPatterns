using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern
{
    class Singelton
    {
        private static Singelton instance;  // static is to ensure only 1 instance
        private static readonly object s1 = new object();   // to implement Sunchronization
        private Singelton()
        {
            Console.WriteLine("Instance Created !!!");
        }
        public static Singelton CreateInstance()
        {   //  Double Lock
            if (instance == null)
            {
                //  Single Lock
                lock (s1)   //  synchronization ==> decread=se performance 100 times
                {
                    if (instance == null) { return instance = new Singelton(); }
                    else { Console.WriteLine("Don't try to create multiple times !!!"); }
                }
            }
                return instance;
        }
    }
}

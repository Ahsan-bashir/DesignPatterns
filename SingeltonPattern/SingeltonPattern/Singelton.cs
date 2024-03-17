using System;
using System.Threading.Tasks;

namespace SingeltonPattern
{
    class Singelton
    {
        private static Singelton instance;  // static is to ensure only 1 instance
        private static readonly object s1 = new object(); // lock object holded by 1 thread at a time ==> to implement Sunchronization
        private Singelton() // private keyword is to discourage multiple instance outside of class
        {
            Console.WriteLine("Instance Created !!!");
        }
        public static Singelton CreateInstance()
        {   //  Double Lock ==> solution of performance issue
            if (instance == null)
            {
                //  Single Lock
                lock (s1)   //  synchronization ==> decrease performance 100 times but ensures thread-safety
                {
                    if (instance == null) { return instance = new Singelton(); }
                    else { Console.WriteLine("Don't try to create instance multiple times !!!"); }
                }
            }
                return instance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // this class is out Target class ,also base class with which the user will interact 
    // which in turn interact with adapter ==> RichCompound which will interact with adaptee==> ChemicalBank
    internal class Compound
    {
        protected String chemicalName;
        protected float boilingPoint;
        protected String molecularFormulae;

        public Compound(String chemicalName)
        {
            this.chemicalName = chemicalName;
        }

        public virtual void Display()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Chemical Name : \t{0}", chemicalName.ToUpper());
            Console.WriteLine("-------------------------------------------");
        }
    }
}

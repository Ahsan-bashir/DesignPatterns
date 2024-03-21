using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // this class act as an adapter to get data from our legacy system ==> ChemicalBank
     class RichCompound:Compound 
    {
        private ChemicalBank bank=new ChemicalBank();
        public RichCompound(String chemicalName):base(chemicalName)
        {            
        } 
        public override void Display()
        {
            boilingPoint = bank.GetBoilingPoint(chemicalName);
            molecularFormulae=bank.GetMolecularFormulae(chemicalName);

            base.Display();
            Console.WriteLine("Boiling Point :\t {0} ",boilingPoint);
             Console.WriteLine("Molecular Formulae :\t {0} ", molecularFormulae);

            Console.WriteLine();
            Console.WriteLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
     class ChemicalBank
    {   // This class represents our legacy system==> old chemicals database
        public float GetBoilingPoint(String chemical)
        {
            switch (chemical.ToLower()) {
                case "water": return 100.0f;
                case "benzene": return 5.5f;
                case "ethanol": return -114.1f;
                default: return 0.0f;
            }
        }

        public String GetMolecularFormulae(String chemical)
        {
             switch(chemical.ToLower())
            {
                case "water": return "H2O";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "un-identified";
            }
        }
    }
}

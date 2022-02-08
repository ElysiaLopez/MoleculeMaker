using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolMakerLB
{
    public class AtomData
    {
        public string Name { get; }
        public string Symbol { get; }
        public int NumOfBondingSites { get; }
        /// <summary>
        /// Electronegativity
        /// </summary>
        public float EN { get; }

        public AtomData(string name, string symbol, int numofBondingSites, float electronegativity)
        {
            Name = name;
            Symbol = symbol;
            NumOfBondingSites = numofBondingSites;
            EN = electronegativity;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

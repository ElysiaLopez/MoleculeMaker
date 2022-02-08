using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolMakerLB
{
    public class BondData
    {
        public AtomData[] Atoms { get; }
        public float ENDiff { get; }

        public BondData(AtomData first, AtomData second)
        {
            Atoms = new AtomData[] { first, second };
            ENDiff = Math.Abs(first.EN - second.EN);
        }
    }
}

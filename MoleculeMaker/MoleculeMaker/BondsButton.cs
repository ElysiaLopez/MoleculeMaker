using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoleculeMaker
{
    internal class BondsButton : Button
    {
        public BondTypes BondType { get; set; }

        public BondsButton(BondTypes bondType)
        {
            BondType = bondType;
        }
    }
}

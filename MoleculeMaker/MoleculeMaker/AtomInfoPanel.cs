using System;
using MolMakerLB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoleculeMaker
{
    class AtomInfoPanel : Panel
    {
        public AtomData Data { get; set; }
        
        private Label Text { get; set; }
        /// <summary>
        /// Deprotonate
        /// </summary>
        private Button DeprotButton { get; set; }
        public AtomInfoPanel(AtomData data)
        {
            Data = data;
        }
    }
}

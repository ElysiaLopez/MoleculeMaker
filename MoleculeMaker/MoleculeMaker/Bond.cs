using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MolMakerLB;

namespace MoleculeMaker
{
    class Bond
    {
        public BondData Data { get; set; }
        public Point point1 { get; set; }
        public Point point2 { get; set; }
        public int NumOfBonds { get; }
        
        private Bitmap bitmap;
        private Graphics graphics;

        public Bond(Atom atom1, Atom atom2, int numOfBonds)   
        {
            Point pos1 = atom1.Location;
            Point pos2 = atom2.Location;

            //midpoints of each atom
            Point mid1 = new Point(pos1.X + atom1.Width / 2, pos1.Y + atom1.Height / 2);
            Point mid2 = new Point(pos2.X + atom2.Width / 2, pos2.Y + atom2.Height / 2);

            point1 = mid1;
            point2 = mid2;

            NumOfBonds = numOfBonds;
        }

    }
}

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
        public Point[] PointsA { get; private set; }
        public Point[] PointsB { get; private set; }
        public int NumOfBonds { get; }
        public Bond(Atom atom1, Atom atom2, int numOfBonds)   
        {
            Point pos1 = atom1.Location;
            Point pos2 = atom2.Location;

            PointsA = new Point[numOfBonds];
            PointsB = new Point[numOfBonds];

            bool vertical = pos1.X == pos2.Y;

            int spacing = vertical ? atom1.Height / (numOfBonds + 1) : atom1.Width / (numOfBonds + 1);

            for (int i = 0; i < numOfBonds; i++)
            {
                int currSpacing = spacing * (i + 1);
                Point pointA = new Point(pos1.X + currSpacing, pos1.Y + currSpacing);
                Point pointB = new Point(pos2.X + currSpacing, pos2.Y + currSpacing);

                PointsA[i] = pointA;
                PointsB[i] = pointB;
            }
            NumOfBonds = numOfBonds;
        }

    }
}

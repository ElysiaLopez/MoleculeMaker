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
    class Bond : PictureBox
    {
        BondData Data { get; set; }
        
        private Bitmap bitmap;
        private Graphics graphics;

        public Bond(Atom atom1, Atom atom2, int numOfBonds)   
        {
            Point pos1 = atom1.Location;
            Point pos2 = atom2.Location;

            //midpoints of each atom
            Point mid1 = new Point(pos1.X + atom1.Width / 2, pos1.Y + atom1.Height / 2);
            Point mid2 = new Point(pos2.X + atom2.Width / 2, pos2.Y + atom2.Height / 2);

            int PBX = Math.Min(mid1.X - 2, mid2.X - 2);
            int PBY = Math.Min(mid1.Y - 2, mid2.Y - 2);

            int width = Math.Abs(pos1.X - pos2.X) + 5;
            int height = Math.Abs(pos1.Y - pos2.Y) + 5;

            Location = new Point(PBX, PBY);
            Size = new Size(width, height);

            bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(bitmap);

            graphics.DrawLine(new Pen(Color.Red, 5), new Point(pos1.X - PBX + atom1.Width / 2, pos1.Y - PBY + atom1.Height / 2), new Point(pos2.X - PBX + atom2.Width / 2, pos2.Y - PBY + atom2.Height / 2));

            Image = bitmap;
        }

    }
}

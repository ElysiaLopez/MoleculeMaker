using MolMakerLB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoleculeMaker
{
    class Atom : Button
    {
        public AtomData Data { get; set; }
        public List<Bond> ConnectedAtoms { get; }
        public int NumOfHs { get; set; }
        //public int CurrCharge
        //{
        //    get
        //    {
        //        int numConnected = NumOfHs;
        //        foreach(var bond in ConnectedAtoms)
        //        {
        //            numConnected += bond.NumOfBonds;
        //        }
        //        numC
        //    }
        //}
        public Atom(string name, string symbol, int bondsAmt, float en, Point pos) 
            : this(new AtomData(name, symbol, bondsAmt, en), pos) { }

        public Atom(AtomData data, Point pos)
        {
            Data = data;
            Location = pos;
            Size = new Size(35, 35);
            Text = data.Symbol;
            BackColor = Color.White;
            NumOfHs = data.NumOfBondingSites;
        }
    }
}

using MolMakerLB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoleculeMaker
{
    public partial class Form1 : Form
    {
        List<Atom> Atoms;
        List<Atom> selectedAtoms;
        List<AtomData> atomDatas;

        BondSelectForm bondsForm;
        List<Bond> bonds;

        Bitmap bitmap;
        Graphics graphics;

        Point cellSize = new Point(40, 40);

        public Form1()
        {
            InitializeComponent();

            InfoLabel.Text = "";

            bitmap = new Bitmap(Board.Width, Board.Height);
            graphics = Graphics.FromImage(bitmap);
            //boardPB.BackColor = Color.Blue;
            //graphics.DrawEllipse(new Pen(Brushes.Black, 5), new Rectangle(0, 0, 50, 50));
            Board.Image = bitmap;

            bonds = new List<Bond>();

            Atoms = new List<Atom>();

            atomDatas = new List<AtomData>()
            {
                new AtomData("Carbon", "C", 4, 2.5f),
                new AtomData("Nitrogen", "N", 3, 3.0f), 
            };

            MolsComboBox.Items.AddRange(atomDatas.ToArray());

            bondsForm = new BondSelectForm();

            bondsForm.ButtonClick += BondTypeSelected;

            selectedAtoms = new List<Atom>();

            MolsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            Focus();
            this.KeyPreview = true;

            Board.Click += BoardClicked;

            DrawGrid();
        }

        private void DrawGrid()
        {
            Point gridSize = new Point(Board.Width / cellSize.X, Board.Height / cellSize.Y);
            Pen color = Pens.Gray;

            for(int x = 1; x <= gridSize.X; x++)
            {
                graphics.DrawLine(color, new Point(cellSize.X * x, 0), new Point(cellSize.X * x, Board.Height));
            }

            for(int y = 0; y <= gridSize.Y; y++)
            {
                graphics.DrawLine(color, new Point(0, cellSize.Y * y), new Point(Board.Width, cellSize.Y * y));
            }

            Board.Image = bitmap;
        }

        private void AddMolButton_Click(object sender, EventArgs e)
        {
            if (MolsComboBox.SelectedIndex == -1 || dragInterval.Enabled) return;
            var selectedAtomData = (AtomData)MolsComboBox.SelectedItem;
            
            Atom atom = new Atom(selectedAtomData.Name, selectedAtomData.Symbol, selectedAtomData.NumOfBondingSites, selectedAtomData.EN, MousePosition);
            Board.Controls.Add(atom);
            atom.BringToFront();

            selectedAtoms.Add(atom);
            Atoms.Add(atom);
            
            dragInterval.Enabled = true;

            atom.Click += AtomClicked;
        }
        private void SetInfoText(Atom atom)
        {
            InfoLabel.Text = $"Name: {atom.Data.Name}\n";
            InfoLabel.Text += $"Symbol: {atom.Data.Symbol}\n";
            InfoLabel.Text += $"EN: {atom.Data.EN}\n";
            InfoLabel.Text += $"# of bonding sites: {atom.Data.NumOfBondingSites}\n";
        }
        private void AtomClicked(object sender, EventArgs e)
        {
            Atom atom = (Atom)sender;

            if (dragInterval.Enabled)
            {
                dragInterval.Enabled = false;
                UnselectAtoms();
            }

            if (selectedAtoms.Contains(atom)) return;

            SelectAtom(atom);

            atom.ForeColor = Color.Red;

            if (selectedAtoms.Count <= 1)
            {
                return;
            }
            bondsForm.Show();
        }
        private void BondTypeSelected(object sender, BondsEventArgs e)
        {
            bondsForm.Hide();

            if (selectedAtoms.Count < 2) throw new Exception("Need to select two atoms");

            if (e.BondType == BondTypes.None)
            {
                UnselectAtoms();
                return;
            }

            Bond bond = null;

            switch(e.BondType)
            {
                case BondTypes.Single:
                    bond = new Bond(selectedAtoms[0], selectedAtoms[1], 1);
                    break;
                case BondTypes.Double:
                    bond = new Bond(selectedAtoms[0], selectedAtoms[1], 2);
                    break;
                case BondTypes.Triple:
                    bond = new Bond(selectedAtoms[0], selectedAtoms[1], 3);
                    break;
            }

            for(int i = 0; i < bond.NumOfBonds; i++)
            {
                graphics.DrawLine(new Pen(Color.Black, 2), bond.PointsA[i], bond.PointsB[i]);
            }

            bonds.Add(bond);
            Board.Image = bitmap;

            UnselectAtoms();
        }
        private void dragInterval_Tick(object sender, EventArgs e)
        {
            var atom = selectedAtoms.Last();
            int x = Board.PointToClient(MousePosition).X / cellSize.X * cellSize.X + (cellSize.X / 2 - atom.Width / 2);
            int y = Board.PointToClient(MousePosition).Y / cellSize.Y * cellSize.Y + (cellSize.Y / 2 - atom.Height / 2);
            Point gridLocation = new Point(x, y);
            atom.Location = gridLocation;
            Text = $"pos: {selectedAtoms.Last().Location}, ms: {MousePosition}";
        }

        private void BoardClicked(object sender, EventArgs e)
        {
            dragInterval.Enabled = false;
            UnselectAtoms();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Board.Controls.Clear();
            graphics.Clear(Board.BackColor);
            DrawGrid();
        }
        private void SelectAtom(Atom atom)
        {
            selectedAtoms.Add(atom);
            SetInfoText(atom);
        }
        private void UnselectAtoms()
        {
            foreach(var atom in selectedAtoms)
            {
                atom.ForeColor = Color.Black;
            }
            selectedAtoms.Clear();
            InfoLabel.Text = "";
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

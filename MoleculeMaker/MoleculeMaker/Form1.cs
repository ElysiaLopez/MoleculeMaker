﻿using MolMakerLB;
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

        BondsForm bondsForm;
        List<Bond> bonds;

        Bitmap bitmap;
        Graphics graphics;

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

            bondsForm = new BondsForm();

            bondsForm.ButtonClick += BondTypeSelected;

            selectedAtoms = new List<Atom>();

            MolsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            Focus();
            this.KeyPreview = true;

            Board.Click += BoardClicked;
        }

        private void AddMolButton_Click(object sender, EventArgs e)
        {
            if (MolsComboBox.SelectedIndex == -1 || dragInterval.Enabled) return;
            var selectedAtomData = (AtomData)MolsComboBox.SelectedItem;
            
            Atom atom = new Atom(selectedAtomData.Name, selectedAtomData.Symbol, selectedAtomData.NumOfBondingSites, selectedAtomData.EN, MousePosition);
            Board.Controls.Add(atom);
            atom.BringToFront();

            UnselectAtoms();
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

            SetInfoText(atom);

            if (selectedAtoms.Contains(atom)) return;

            selectedAtoms.Add(atom);
            atom.ForeColor = Color.Red;

            if (selectedAtoms.Count <= 1)
            {
                return;
            }
            bondsForm.Show();
        }
        private void BondTypeSelected(object sender, EventArgs e)
        {
            bondsForm.Hide();

            

            if (selectedAtoms.Count < 2) throw new Exception("Need to select two atoms");

            

            Bond bond = new Bond(selectedAtoms[0], selectedAtoms[1], 1);
            graphics.DrawLine(new Pen(Color.Black, 2), bond.point1, bond.point2);
            //boardPB.BringToFront();
            Board.Image = bitmap;

            bonds.Add(bond);

            switch(bondsForm.SelectedButtonText)
            {
                case "Single":
                    break;
                case "Double":
                    break;
                case "Triple":
                    break;
                case "Cancel":
                    break;
            }
            UnselectAtoms();
        }
        private void dragInterval_Tick(object sender, EventArgs e)
        {
            selectedAtoms.Last().Location = Board.PointToClient(new Point(MousePosition.X + 1, MousePosition.Y + 1));
            Text = $"pos: {selectedAtoms.Last().Location}, ms: {MousePosition}";
        }

        private void BoardClicked(object sender, EventArgs e)
        {
            dragInterval.Enabled = false;
            UnselectAtoms();

            InfoLabel.Text = "";
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Board.Controls.Clear();
            graphics.Clear(Board.BackColor);
            Board.Image = bitmap;
        }
        private void UnselectAtoms()
        {
            foreach(var atom in selectedAtoms)
            {
                atom.ForeColor = Color.Black;
            }
            selectedAtoms.Clear();
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

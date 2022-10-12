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
    public class BondsEventArgs : EventArgs
    {
        public BondTypes BondType { get; set; }

        public BondsEventArgs(BondTypes bondType)
        {
            BondType = bondType;
        }
    }
    public partial class BondSelectForm : Form
    {
        public event EventHandler<BondsEventArgs> ButtonClick;
        public string SelectedButtonText { get; private set; }
        public BondSelectForm()
        {
            InitializeComponent();

            SingleButton.Click += ButtonClicked;
            DoubleButton.Click += ButtonClicked;
            TripleButton.Click += ButtonClicked;
            CancelButton.Click += ButtonClicked;
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            BondsButton button = (BondsButton)sender;
            ButtonClick?.Invoke(this, new BondsEventArgs(button.BondType));
        }
    }
}

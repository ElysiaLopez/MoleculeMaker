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
    public partial class BondsForm : Form
    {
        public event EventHandler ButtonClick;
        public string SelectedButtonText { get; private set; }
        public BondsForm()
        {
            InitializeComponent();

            SingleButton.Click += ButtonClicked;
            DoubleButton.Click += ButtonClicked;
            TripleButton.Click += ButtonClicked;
            CancelButton.Click += ButtonClicked;
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            SelectedButtonText = button.Text;
            ButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}

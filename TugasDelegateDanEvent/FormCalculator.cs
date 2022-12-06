using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasDelegateDanEvent
{
    public partial class FormCalculator : Form
    {
        public delegate void CalculatorEventHandler(int index, int a, int b);
        public event CalculatorEventHandler OnPerhitungan;

        public FormCalculator()

        {
            InitializeComponent();

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int NilaiA = int.Parse(txtNilaiA.Text);
            int NilaiB = int.Parse(txtNilaiB.Text);

            if (comboBoxOperasi.SelectedIndex == 0)
            {
                OnPerhitungan(0, NilaiA, NilaiB);
            }
            else if (comboBoxOperasi.SelectedIndex == 1)
            {
                OnPerhitungan(1, NilaiA, NilaiB);
            }
            else if (comboBoxOperasi.SelectedIndex == 2)
            {
                OnPerhitungan(2, NilaiA, NilaiB);
            }
            else
            {
                OnPerhitungan(3, NilaiA, NilaiB);
            }
        }
    }
}

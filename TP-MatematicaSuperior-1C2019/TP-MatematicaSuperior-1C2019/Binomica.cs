using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MatematicaSuperior_1C2019
{
    public partial class Binomica : Form
    {
        public Binomica()
        {
            InitializeComponent();
        }

        private void Binomica_Load(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            Complex C = parser.parsearBinomica(textBox1.Text);
            label8.Text = "[" + Convert.ToString(Complex.Abs(C)) + ";" + Convert.ToString(C.Phase) + "]";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            Complex C = parser.parsearPolar(textBox2.Text);
            label9.Text = "(" + Convert.ToString(C.Real) + ";" + Convert.ToString(C.Imaginary) + ")";
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}

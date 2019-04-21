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



        private void button7_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            if (parser.FormatoBinomicoCorrecto(textBox1.Text))
            {
                Complex C = parser.ParsearBinomica(textBox1.Text);
                label8.Text = "[" + Convert.ToString(Complex.Abs(C)) + ";" + Convert.ToString(C.Phase) + "]";
            }
            else
            {
                MessageBox.Show("El valor ingresado no tiene el formato correcto.\n" +
                    "Para la notacion binomica introducir un numero de la forma (a;b)\n" +
                    "siendo 'a' la parte real y 'b' la parte imaginaria");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            if (parser.FormatoPolarCorrecto(textBox2.Text))
            {
                Complex C = parser.ParsearPolar(textBox2.Text);
                label9.Text = "(" + Convert.ToString(C.Real) + ";" + Convert.ToString(C.Imaginary) + ")";
            }
            else
            {
                MessageBox.Show("El valor ingresado no tiene el formato correcto.\n" +
                    "Para la notacion polar introducir un numero de la forma [a;b]\n" +
                    "siendo 'a' el modulo del numero y 'b' el angulo de giro");
            }
        }
    }
}

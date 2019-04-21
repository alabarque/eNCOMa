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
<<<<<<< HEAD

        private void Binomica_Load(object sender, EventArgs e)
=======
        private double modulo(double a ,double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        private double argumento(double a, double b)
        {
            return Math.Atan(b/a) * 180 / Math.PI;
        }
        private void button1_Click(object sender, EventArgs e)
>>>>>>> ff1ec29ce788ea9cf8c638fbfb8fb54dc25855fa
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
<<<<<<< HEAD

        }

        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

=======
            double z, x, a, b, c, d;
            a = Convert.ToDouble(textBox1.Text);
            c = Convert.ToDouble(textBox3.Text);
            b = Convert.ToDouble(textBox2.Text);
            d = Convert.ToDouble(textBox4.Text);
            z = (a * c - (b *(-1)* d)) / (Math.Pow(c,2)+Math.Pow(d,2));
            x = (a *(-1) * d) + (c * b) / (Math.Pow(c, 2) + Math.Pow(d, 2));
            label8.Text = "(" + Convert.ToString(z) + "," + Convert.ToString(x) + ")";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            label8.Text = "[" + Convert.ToString(modulo(a,b)) + "," + Convert.ToString(argumento(a,b)) + "]";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox3.Text);
            b = Convert.ToDouble(textBox4.Text);
            label8.Text = "[" + Convert.ToString(modulo(a, b)) + "," + Convert.ToString(argumento(a, b)) + "]";
>>>>>>> ff1ec29ce788ea9cf8c638fbfb8fb54dc25855fa
        }
    }
}

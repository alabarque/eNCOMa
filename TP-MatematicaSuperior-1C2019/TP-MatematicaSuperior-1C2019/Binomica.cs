using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
            textBox4.Text = "1";
        }
        private double modulo(double a ,double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        private double argumento(double a, double b)
        {
            return Math.Atan(b/a) * 180 / Math.PI;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double z, x;
            z = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox3.Text);
            x = Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox4.Text);
            label8.Text = "(" + Convert.ToString(z) + "," + Convert.ToString(x) + ")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double z, x;
            z = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox3.Text);
            x = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox4.Text);
            label8.Text = "(" + Convert.ToString(z) + "," + Convert.ToString(x) + ")";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double z, x;
            z = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text)) - (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox4.Text));
            x = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox4.Text)) + (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox2.Text));
            label8.Text = "(" + Convert.ToString(z) + "," + Convert.ToString(x) + ")";
        }
        private void button4_Click(object sender, EventArgs e)
        {
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
        }
    }
}

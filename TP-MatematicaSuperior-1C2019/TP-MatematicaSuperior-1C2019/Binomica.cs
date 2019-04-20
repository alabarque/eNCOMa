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
            double z, x;
            z = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text)) - (Convert.ToDouble(textBox2.Text) *(-1)* Convert.ToDouble(textBox4.Text)) / (Math.Pow(Convert.ToDouble(textBox3.Text),2)+Math.Pow(Convert.ToDouble(textBox4.Text),2));
            x = (Convert.ToDouble(textBox1.Text) *(-1) * Convert.ToDouble(textBox4.Text)) + (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox2.Text)) / (Math.Pow(Convert.ToDouble(textBox3.Text), 2) + Math.Pow(Convert.ToDouble(textBox4.Text), 2));
            label8.Text = "(" + Convert.ToString(z) + "," + Convert.ToString(x) + ")";
        }

    }
}

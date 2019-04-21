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
    public partial class Fasores : Form
    {
        public Fasores()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            Operaciones operador = new Operaciones();

            Complex C1 = parser.ParseadorTexto(textBox1.Text);
            Complex C2 = parser.ParseadorTexto(textBox2.Text);

            label8.Text = Convert.ToString(operador.Suma(C1, C2));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            Operaciones operador = new Operaciones();

            Complex C1 = parser.ParseadorTexto(textBox1.Text);
            Complex C2 = parser.ParseadorTexto(textBox2.Text);

            label8.Text = Convert.ToString(operador.Resta(C1, C2));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            Operaciones operador = new Operaciones();

            Complex C1 = parser.ParseadorTexto(textBox1.Text);
            Complex C2 = parser.ParseadorTexto(textBox2.Text);

            label8.Text = Convert.ToString(operador.Multiplicar(C1, C2));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            Operaciones operador = new Operaciones();

            Complex C1 = parser.ParseadorTexto(textBox1.Text);
            Complex C2 = parser.ParseadorTexto(textBox2.Text);

            label8.Text = Convert.ToString(operador.Dividir(C1, C2));
        }

        private void Fasores_Load(object sender, EventArgs e)
        {

        }
    }
}

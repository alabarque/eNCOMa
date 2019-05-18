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
    public partial class Polar : Form
    {
        public Polar()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            Operaciones operador = new Operaciones();

            Complex c1 = parser.ParseadorTexto(textBox1.Text);
            Complex c2 = parser.ParseadorTexto(textBox2.Text);

            Complex resultado = operador.Elevar(c1, c2);

            label1.Text = Convert.ToString(resultado);
        }

        private void Polar_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            Operaciones operador = new Operaciones();

            Complex c1 = parser.ParseadorTexto(textBox1.Text);
            Int16 raiz;
            bool resultado = Int16.TryParse(textBox7.Text, out raiz);
            if (resultado)
            {
                dataGridView1.Rows.Clear();
                List<Complex> raices = operador.Raices(c1, raiz);
                int i = 0;
                foreach (Complex unaRaiz in raices)
                {
                    dataGridView1.Rows.Add(new string[] {unaRaiz.ToString(), operador.esPrimitiva(i, raiz).ToString()});
                    i++;
                }
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) //si es un caracter o backspace u otros de control
            {
                e.Handled = true;
            }
        }
    }
}

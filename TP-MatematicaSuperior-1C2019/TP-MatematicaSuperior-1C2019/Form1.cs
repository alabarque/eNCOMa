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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Binomica formulario = new Binomica();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Polar formulario = new Polar();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fasores formulario = new Fasores();
            formulario.Show();
        }
    }
}

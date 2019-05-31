using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MatematicaSuperior_1C2019
{
    public partial class SumaFasores : Form
    {
        public SumaFasores()
        {
            InitializeComponent();

            listBox1.SetSelected(0, true);
            listBox2.SetSelected(0, true);
            listBox3.SetSelected(0, true);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Operaciones operador = new Operaciones();
            FuncionTrigonometrica primerFasor;
            FuncionTrigonometrica segundoFasor;
            double fase;

            this.setearFasores(out primerFasor, out segundoFasor, out fase);

            String resultadoDeseado = listBox3.Text;

            label10.Text = operador.OperarFasores(primerFasor, segundoFasor, resultadoDeseado, fase, new Operaciones().Suma);
        }


        private void setearFasores(out FuncionTrigonometrica primerFasor, out FuncionTrigonometrica segundoFasor, out double fase)
        {
            double Amplitud1;
            double Desplazamiento1;
            Double.TryParse(textBox4.Text, out Amplitud1);
            Double.TryParse(textBox2.Text, out Desplazamiento1);
            String Funcion1 = listBox1.Text;
            primerFasor = new FuncionTrigonometrica(funcion: Funcion1, amplitud: Amplitud1, desplazamiento: Desplazamiento1);

            double Amplitud2;
            double Desplazamiento2;
            Double.TryParse(textBox5.Text, out Amplitud2);
            Double.TryParse(textBox7.Text, out Desplazamiento2);
            String Funcion2 = listBox2.Text;
            segundoFasor = new FuncionTrigonometrica(funcion: Funcion2, amplitud: Amplitud2, desplazamiento: Desplazamiento2);

            Double.TryParse(textBox1.Text, out fase);
        }

        

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Operaciones operador = new Operaciones();
            FuncionTrigonometrica primerFasor;
            FuncionTrigonometrica segundoFasor;
            double fase;

            this.setearFasores(out primerFasor, out segundoFasor, out fase);

            String resultadoDeseado = listBox3.Text;

            label10.Text = operador.OperarFasores(primerFasor, segundoFasor, resultadoDeseado, fase, new Operaciones().Resta);
        }
    }
}

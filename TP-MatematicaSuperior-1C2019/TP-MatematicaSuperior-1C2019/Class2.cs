using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatematicaSuperior_1C2019
{
    public class Parser
    {
        public Complex parsearBinomica(string numeroBinomico)
        {
            string[] numeros = numeroBinomico.Split(';');
            string parteReal = numeros[0].Replace("(", "");
            string parteImaginaria = numeros[1].Replace(")", "");
            double real = double.Parse(parteReal);
            double imaginario = double.Parse(parteImaginaria);
            Complex C = new Complex(real, imaginario);
            return C;
        }

        public Complex parsearPolar(string numeroPolar)
        {
            string[] numeros = numeroPolar.Split(';');
            string parteRadio = numeros[0].Replace("[", "");
            string parteAngulo = numeros[1].Replace("]", "");
            double radio = double.Parse(parteRadio);
            double angulo = double.Parse(parteAngulo);
            Operaciones operador = new Operaciones();
            Complex C = operador.ObtenerBinomicoDePolar(radio, angulo);
            return C;
        }

        public Complex parseadorTexto(string numero)
        {
            if(Char.Equals(numero[0], '(') && Char.Equals(numero.Last<char>(), ')'))
            {
                return parsearBinomica(numero);
            }else if(Char.Equals(numero[0], '[') && Char.Equals(numero.Last<char>(), ']'))
            {
                return parsearPolar(numero);
            }
            else
            {
                return new Complex();
            }
        }
    }
}

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
        public Complex ParsearBinomica(string numeroBinomico)
        {
            string[] numeros = numeroBinomico.Split(';');
            string parteReal = numeros[0].Replace("(", "");
            string parteImaginaria = numeros[1].Replace(")", "");
            double real = double.Parse(parteReal);
            double imaginario = double.Parse(parteImaginaria);
            Complex C = new Complex(real, imaginario);
            return C;
        }

        public Complex ParsearPolar(string numeroPolar)
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

        public Complex ParseadorTexto(string numero)
        {
            if(FormatoBinomicoCorrecto(numero))
            {
                return ParsearBinomica(numero);
            }
            else if(FormatoPolarCorrecto(numero))
            {
                return ParsearPolar(numero);
            }
            else
            {
                return new Complex();
            }
        }

        public Boolean FormatoCorrecto(string numero)
        {
            return FormatoBinomicoCorrecto(numero) || FormatoPolarCorrecto(numero);
        }

        public Boolean FormatoBinomicoCorrecto(string numero)
        {
            Boolean formato = false;
            if (numero.StartsWith("(") && numero.Count(x => (x == '(')) == 1)
            {
                if (numero.EndsWith(")") && numero.Count(x => (x == ')')) == 1)
                {
                    formato = this.FormatoNumeroCorrecto(numero, '(', ')');
                }
            }
            return formato;
        }

        public Boolean FormatoPolarCorrecto(string numero)
        {
            Boolean formato = false;
            if (numero.StartsWith("[") && numero.Count(x => (x == '[')) == 1)
            {
                if (numero.EndsWith("]") && numero.Count(x => (x == ']')) == 1)
                {
                    formato = this.FormatoNumeroCorrecto(numero, '[', ']');
                }
            }
            return formato;
        }

        public Boolean FormatoNumeroCorrecto(string numero, char inicioString, char finalString)
        {
            Boolean formato = false;
            if (numero.Contains(";"))
            {
                string[] elementos = numero.Split(';');
                if (elementos.Count() == 2)
                {
                    double result1;
                    double result2;
                    string primerElemento = elementos[0].Replace(inicioString.ToString(), "");
                    string segundoElemento = elementos[1].Replace(finalString.ToString(), ""); 
                    if (double.TryParse(primerElemento, out result1) && double.TryParse(segundoElemento, out result2))
                    {
                        formato = true;
                    }
                }
            }
            return formato;
        }
    }
}

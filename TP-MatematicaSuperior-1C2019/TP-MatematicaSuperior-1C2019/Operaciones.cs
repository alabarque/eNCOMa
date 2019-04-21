using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;

public class Operaciones
{
    public Operaciones()
    {
    }

    public Complex Suma(Complex c1, Complex c2)
    {
        return Complex.Add(c1, c2);
    }

    public Complex Resta(Complex c1, Complex c2)
    {
        return Complex.Subtract(c1, c2);
    }

    public Complex Multiplicar(Complex c1, Complex c2)
    {
        return Complex.Multiply(c1, c2);
    }

    public Complex Dividir(Complex c1, Complex c2)
    {
        return Complex.Divide(c1, c2);
    }

    public Complex Elevar(Complex c1, double potencia)
    {
        return Complex.Pow(c1, potencia);
    }

    public List<Complex> Raices(Complex c1, double raiz)
    {
        List<Complex> raices = new List<Complex>();

            for (int i = 1; i <= raiz; i++)
            {
                double real = Math.Pow(Complex.Abs(c1), 1/raiz) * (Math.Cos(2 * Math.PI * i / raiz));
                double imaginario = Math.Pow(Complex.Abs(c1), 1/raiz) * (Math.Sin(2 * Math.PI * i / raiz));
                Complex aux = new Complex(real, imaginario);
                raices.Add(raiz);
            }
            return raices;
    }

    public Complex ObtenerBinomicoDePolar(double radio, double angulo)
    {
        double real = radio * Math.Cos(angulo);
        double imaginario = radio * Math.Sin(angulo);
        Complex C = new Complex(real, imaginario);
        return C;
    }
}


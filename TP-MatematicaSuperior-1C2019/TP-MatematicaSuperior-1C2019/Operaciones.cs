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

    public Complex Elevar(Complex c1, Complex potencia)
    {
        return Complex.Pow(c1, potencia);
    }

    public List<Complex> Raices(Complex c1, double raiz)
    {
        List<Complex> raices = new List<Complex>();
        double raizNdelModulo = Math.Pow(Complex.Abs(c1), 1 / raiz); // absoluto ^ 1/n

            for (int i = 1; i <= raiz; i++)
            {
                double anguloRaiz = (c1.Phase + 2 * Math.PI * i) / raiz;
                Console.WriteLine("(" + c1.Phase.ToString() + " + 2 " + "* " + Math.PI.ToString() + " * " + i.ToString() + ") / " + raiz.ToString());
                double real = raizNdelModulo * this.Coseno(anguloRaiz); // abs^1/n * (Cos((desplazamiento + 2*k*pi) / n)
                double imaginario = raizNdelModulo * this.Seno(anguloRaiz); // abs^1/n * (Sen((desplazamiento + 2*k*pi) / n)
                Complex aux = new Complex(real, imaginario);
                raices.Add(aux);
            }   
            return raices;
    }

    public Complex ObtenerBinomicoDePolar(double radio, double angulo)
    {
        return Complex.FromPolarCoordinates(radio, angulo);
    }

    internal object esPrimitiva(int i, short raiz)
    {
        bool esPrimitiva = false;
        int mcd = this.Mcd(i, raiz);
        if(mcd == 1) esPrimitiva = true;
        return esPrimitiva;
    }

    /*
     * algoritmo de MCD
     */
    int Mcd(int a, int b)
    {

        // Everything divides 0  
        if (a == 0)
            return b;
        if (b == 0)
            return a;

        // base case 
        if (a == b)
            return a;

        // a is greater 
        int c, d;
        if (a > b)
        {
            c = b;
            d = b;
            while(true)
            {
                c = c * 2;
                if(c < a)
                {
                    d = c;
                }
                else
                {
                    break;
                }
            }
            return Mcd(a - d, b);
        }
        else
        {
            c = a;
            d = a;
            while (true)
            {
                c = c * 2;
                if (c < b)
                {
                    d = c;
                }
                else
                {
                    break;
                }
            }
            return Mcd(a, b - d);

        }

    }

    //Cree esto porque increiblemente hacer Math.Sin(Math.Pi) no devuelve 0, devuelve algo como 1.222897837E-16
    double Seno(double numero)
    {
        double resultado;
        if(numero % Math.PI == 0.0)
        {
            resultado = 0.0;
        }
        else
        {
            resultado = Math.Sin(numero);
        }
        return resultado;
    }

    //Cree esto porque increiblemente hacer Math.Cos(Math.Pi /2) no devuelve 0, devuelve algo como 1.222897837E-16
    double Coseno(double numero)
    {
        double resultado;
        if(numero % Math.PI == 0.0)
        {
            resultado = Math.Cos(numero);
        }
        else if (numero % (Math.PI / 2.0) == 0.0)
        {
            resultado = 0.0;
        }
        else
        {
            resultado = Math.Cos(numero);
        }
        return resultado;
    }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;
using TP_MatematicaSuperior_1C2019;

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


    /*
        *	Defino cada numero como una clase con los valores: Amplitud, Desplazamiento, Funcion
        *	La fase la tengo a parte ya que es igual para ambas y no cambia en ninguna cuenta
        *	Usando la fase, quedaria represantado como: numero = Amplitud * Funcion(Fase*t + Desplazamiento)
        *
        *
        */

    public String OperarFasores(FuncionTrigonometrica numero1, FuncionTrigonometrica numero2, String resultadoDeseado, double W, Func<Complex, Complex, Complex> operacion)
    {
        String cos = "Coseno";
        String sen = "Seno";
        FuncionTrigonometrica nro1;
        FuncionTrigonometrica nro2;
        Operaciones operador = new Operaciones();

        if(numero1.getAmplitud() <= 0 && numero2.getAmplitud() <= 0)
        {
            return "0";
        }

        if (resultadoDeseado == cos)
        {
            nro1 = pasar(numero1, cos);
            nro2 = pasar(numero2, cos);
        }
        else if (resultadoDeseado == sen)
        {
            nro1 = pasar(numero1, sen);
            nro2 = pasar(numero2, sen);
        }
        else
        {
            return "0";
        }

        Complex n1 = operador.ObtenerBinomicoDePolar(nro1.getAmplitud(), nro1.getDesplazamiento());
        Complex n2 = operador.ObtenerBinomicoDePolar(nro2.getAmplitud(), nro2.getDesplazamiento());

        Complex n3 = operacion(n1, n2);

        if(n3.Magnitude == 0)
        {
            return "0";
        }

        return n3.Magnitude.ToString() + "*" + resultadoDeseado + "(" + W.ToString() + " * t + " + n3.Phase.ToString() + ")";
    }

    public FuncionTrigonometrica pasar(FuncionTrigonometrica numero, String unaFuncion)
    {
        String cos = "Coseno";
        String sen = "Seno";
        if (unaFuncion == cos && numero.getFuncion() == sen)
        {
            numero.setDesplazamiento(numero.getDesplazamiento() + Math.PI / 2);
            numero.setFuncion(cos);
        }
        else if (unaFuncion == sen && numero.getFuncion() == cos)
        {
            numero.setDesplazamiento(numero.getDesplazamiento() - Math.PI / 2);
            numero.setFuncion(sen);
        }
        return numero;
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatematicaSuperior_1C2019
{
    public class FuncionTrigonometrica
    {
        String Funcion;
        double Amplitud;
        double Desplazamiento;

        public void setFuncion(String funcion)
        {
            Funcion = funcion;
        }
        public String getFuncion()
        {
            return Funcion;
        }
        public void setAmplitud(double amplitud)
        {
            Amplitud = amplitud;
        }
        public double getAmplitud()
        {
            return Amplitud;
        }
        public void setDesplazamiento(double desplazamiento)
        {
            Desplazamiento = desplazamiento;
        }
        public double getDesplazamiento()
        {
            return Desplazamiento;
        }

        public FuncionTrigonometrica(String funcion, double amplitud, double desplazamiento)
        {
            Funcion = funcion;
            Amplitud = amplitud;
            Desplazamiento = desplazamiento;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_EjerciciosLibro.Capitulo_10
{
    public class Ejercicios10_4
    {

        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }

        public Ejercicios10_4()
        {

        }

        public Ejercicios10_4(double perimetro, double apotema)
        {
            Perimetro = perimetro;
            Apotema = apotema;
        }

        public double CalcularArea()
        {
            Perimetro = 20; Apotema = 4.25;

            return Perimetro * Apotema / 2;
        }

    }
}

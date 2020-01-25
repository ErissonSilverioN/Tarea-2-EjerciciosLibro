using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_EjerciciosLibro.Capitulo_10
{
    public class Ejercios10_5
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }

        public Ejercios10_5()
        {

        }

        public Ejercios10_5(double perimetro, double apotema)
        {
            Perimetro = perimetro;
            Apotema = apotema;
        }

        public double CalcularArea()
        {
            Perimetro = 20; Apotema = 4.25;

            return Perimetro * Apotema / 2;
        }

        public static void menu()
        {
            Ejercios10_5 ps = new Ejercios10_5();
            Console.WriteLine(ps.ToString());
        }
    }
}

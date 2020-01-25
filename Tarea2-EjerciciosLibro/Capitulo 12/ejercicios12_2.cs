using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_EjerciciosLibro.Capitulo_12
{
    public class ejercicios12_2
    {
        public ejercicios12_2()
        {

        }

        public static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                Console.WriteLine(fact);
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
            Console.ReadKey();

        }

    }
}

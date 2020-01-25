using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_EjerciciosLibro.Capitulo_12
{
    public class ejercicios12_1
    {

        public ejercicios12_1()
        {

        }

        public static int factorial()
        {
            int num = 0, res = 1;
            Console.Write("Digite Numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
                return num;

            for (int i = 1; i <= num; ++i)
                res *= i;

            Console.WriteLine("El Factorial de {0} es {1} ", num, res);
            Console.WriteLine();
            return num;
        }

    }
}

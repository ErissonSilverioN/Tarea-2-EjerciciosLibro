using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_EjerciciosLibro.Capitulo_10
{
   public class Ejercicios10_1
    {
        public int ProductoId { get; set; }
        public double CostoUnidad { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCompra { get; set; }
        public double Ganacias { get; set; }
        public double TotalGanancias { get; set; }

        public Ejercicios10_1()
        {
            ProductoId = 0;
            CostoUnidad = 0;
            PrecioCompra = 0;
            PrecioVenta = 0;
            Ganacias = 0;
            TotalGanancias = 0;
        }
    }
}

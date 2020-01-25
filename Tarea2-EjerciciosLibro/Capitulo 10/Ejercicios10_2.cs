using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_EjerciciosLibro.Capitulo_10
{
    public class Ejercicios10_2
    {

        public int Matricula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string NombrePadre { get; set; }
        public string ApellidoPadre { get; set; }
        public int CedulaPadre { get; set; }
        public string NombreMadre { get; set; }
        public string ApellidoMadre { get; set; }
        public int CedulaMadre { get; set; }
        public string NombreTutor { get; set; }
        public string ApellidoTutor { get; set; }
        public int CedulaTutor { get; set; }

        public Ejercicios10_2()
        {
            Matricula = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            FechaNacimiento = DateTime.Now;
            Direccion = string.Empty;
            Telefono = 0;
            NombrePadre = string.Empty;
            ApellidoPadre = string.Empty;
            CedulaPadre = 0;
            NombreMadre = string.Empty;
            ApellidoMadre = string.Empty;
            CedulaMadre = 0;
            NombreTutor = string.Empty;
            ApellidoTutor = string.Empty;
            CedulaTutor = 0;

        }

    }
}

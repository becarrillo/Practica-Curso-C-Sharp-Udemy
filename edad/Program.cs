using System;
using System.Collections.Generic;

namespace App2_curso_Udemy_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona() { fechaNacimiento = new DateTime(1980, 1, 5) };
            Console.WriteLine($"La edad de la persona es {persona1.Edad}");
        }
    }

    public class Persona
    {
        public Persona()
        {
            Console.WriteLine("constructor Persona");
            Telefonos = new List<string>();
        }

        private DateTime _fechaNacimiento;
        public int Edad { get { return UtilidadesDeFechas.CalcularEdad(fechaNacimiento); } }
        public List<string> Telefonos { get; set; }
        public DateTime fechaNacimiento {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
    }
}

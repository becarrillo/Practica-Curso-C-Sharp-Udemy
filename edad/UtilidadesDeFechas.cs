using System;
using System.Collections.Generic;
using System.Text;

namespace App2_curso_Udemy_Csharp
{
    public static class UtilidadesDeFechas
    {
        public static int CalcularEdad(DateTime fechaNacimiento)        // Método estático
        {
            var edad = DateTime.Today.Year - fechaNacimiento.Year;
            var temp = new DateTime(DateTime.Today.Year,
                fechaNacimiento.Month, fechaNacimiento.Day);
            
            if (temp > DateTime.Today)
            {
                edad--;
            }
            return edad;
        }
    }
}

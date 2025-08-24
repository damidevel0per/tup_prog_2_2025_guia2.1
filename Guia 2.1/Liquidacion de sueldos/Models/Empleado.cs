using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liquidacion_de_sueldos.Models
{
    internal class Empleado
    {
        public int DNI { get; }
        public string Apellido { get; }
        public string Nombre { get; }
        public string ApellidoNombre { get
            {
                return Nombre + Apellido;
            } 
        }
        public int AñoContratado { get; }
        public double MontoBasicoNominal { get; set; }
        public int HorasExtras50 { get; set; }
        public int HorasExtras100 { get; set; }

        public Empleado(string apellido, string nombre, int añoContratado)
        {
            Apellido = apellido;
            Nombre = nombre;
            AñoContratado = añoContratado;
            HorasExtras100 = 4;
            HorasExtras50 = 5;
        }

    }
}

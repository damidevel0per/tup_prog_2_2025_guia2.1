using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Automotor.Models
{
    internal class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; }

        public Persona(string nombre, string dni)
        {
            Nombre = nombre;
            DNI = dni;
        }
    }
}

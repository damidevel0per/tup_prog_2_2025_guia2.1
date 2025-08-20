using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Automotor.Models
{
    internal class RegistroVehiculo
    {
        public Persona propietario;

        public string Patente {  get; set; }
        public string Serie {  get; set; }

        public RegistroVehiculo(string pat, Persona propiet, int serie) 
        {
            Patente = pat;
            propietario = propiet;
            Serie = serie.ToString("000");
        }

        public string VerDetalle()
        {
            return $@"{Patente} - {Serie} - {propietario.Nombre + propietario.DNI}";
        }


    }
}

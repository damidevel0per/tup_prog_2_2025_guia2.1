using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Automotor.Models
{
    internal class DepartamentoVehicular
    {
        public int CantidadRegistros { get
            {
                return registros.Count;
            }
        }
        private ArrayList registros = new ArrayList();
        private RegistroVehiculo reg;
        Random rnd = new Random();

        int serie = 0;

        public RegistroVehiculo RegistrarVehiculo(Persona pro)
        {
            string patente = GenerarPatente();
            reg = new RegistroVehiculo(patente, pro, serie);
            serie++;
            registros.Add(reg);
            return reg;
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            return registros[idx] as RegistroVehiculo;
        }

        private string GenerarPatente()
        {
            char letra1 = (char)rnd.Next('A', 'Z' + 1);
            char letra2 = (char)rnd.Next('A', 'Z' + 1);

            return $@"{letra1}{letra2}{serie.ToString("000")}";
        }
    }
}

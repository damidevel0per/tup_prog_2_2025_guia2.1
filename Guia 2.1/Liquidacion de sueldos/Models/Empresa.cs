using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liquidacion_de_sueldos.Models
{
    internal class Empresa
    {
        public int AñoActual { get { return 2025; } }
        private ArrayList empleados = new ArrayList();
        private ArrayList liquidaciones = new ArrayList();
        private Empleado e;

        public int Liquidaciones { get { return liquidaciones.Count; }}


        public Empleado RegistrarEmpleado(string apelli, string nom)
        {
            e = new Empleado(apelli, nom, 2020);
            empleados.Add(e);
            return e;
        }

        public void GenerarLiquidaciones(int mes, int año)
        {
            Liquidacion li;
            for (int i = 0; i < empleados.Count; i++)
            {
                li = new Liquidacion(empleados[i] as Empleado, año, mes);
                liquidaciones.Add(li);
            }
        }
        public ArrayList ListarLiquidaciones(int mes, int año)
        {
            ArrayList liq = new ArrayList();

            for (int i = 0; i < liquidaciones.Count; i++)
            {
                Liquidacion l = liquidaciones[i] as Liquidacion;
                if (l.Año == año && l.Mes == mes)
                {
                    liq.Add(l as Liquidacion);
                }
            }

            return liq;
        }
    }
}

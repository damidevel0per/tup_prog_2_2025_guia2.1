using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liquidacion_de_sueldos.Models
{
    internal class Liquidacion
    {
        Empleado empleado;

        public int Año { get; }
        public int Mes { get; }
        public double MontoBasico { get { return 4000;} }
        public double PorcAntiguedad { get { return (MontoBasico * 10) / 100; } }
        public double HorasExtras50 { get { return empleado.HorasExtras50; } }
        public double MontoExtras50 { get { return ((MontoBasico/40) * HorasExtras50) * 1.5; } }
        public double HorasExtras100 { get { return empleado.HorasExtras100; } }
        public double MontoExtras100 { get { return ((MontoBasico / 40) * HorasExtras100) * 2; } }
        public double Nominal { get { return MontoBasico + PorcAntiguedad + MontoExtras50 + MontoExtras100; } }
        public double PorcObraSocial { get { return Nominal * 0.03; } set { PorcObraSocial = value; } }
        public double MontoJubilado { get { return Nominal * 0.18; } }
        public double PorcGremiales { get { return Nominal * 0.015; } set { PorcGremiales = value; } }
        public double MontoGremial { get { return PorcObraSocial + PorcGremiales + MontoJubilado; } }
        public double Neto { get { return (Nominal + Productividad); } }
        public double Productividad { get { return (Nominal - PorcObraSocial - MontoJubilado - PorcGremiales) * 30 / 100; } }
        public double ACobrar { get { return (MontoBasico + PorcAntiguedad + MontoExtras50 + MontoExtras100 + Productividad) - MontoGremial; } }

        public Liquidacion(Empleado e, int año, int mes)
        {
            empleado = e;
            Año = año;
            Mes = mes;
        }

        public string VerImpreso()
        {
            return $"Empleado: {empleado.ApellidoNombre}\r\n" +
                   $"Año: {Año}\r\n" +
                   $"Mes: {Mes}\r\n" +
                   $"Monto Básico: {MontoBasico:C}\r\n" +
                   $"Antigüedad (10%): {PorcAntiguedad:C}\r\n" +
                   $"Horas Extras 50%: {HorasExtras50} (Monto: {MontoExtras50:C})\r\n" +
                   $"Horas Extras 100%: {HorasExtras100} (Monto: {MontoExtras100:C})\r\n" +
                   $"Nominal: {Nominal:C}\r\n" +
                   $"Obra Social (3%): {PorcObraSocial:C}\r\n" +
                   $"Jubilación (18%): {MontoJubilado:C}\r\n" +
                   $"Aporte Gremial (1.5%): {PorcGremiales:C}\r\n" +
                   $"Total Descuentos: {MontoGremial:C}\r\n" +
                   $"Productividad (30%): {Productividad:C}\r\n" +
                   $"Neto: {Neto:C}\r\n" +
                   $"A Cobrar: {ACobrar:C}";
        }
    }
}

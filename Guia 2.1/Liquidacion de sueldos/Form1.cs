using Liquidacion_de_sueldos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liquidacion_de_sueldos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa empresa = new Empresa();
        private void button1_Click(object sender, EventArgs e)
        {
            empresa.RegistrarEmpleado("Perez", "Damian");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empresa.GenerarLiquidaciones(10, 2020);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList l = new ArrayList();
            l = empresa.ListarLiquidaciones(10, 2020);
            for (int i = 0; i < empresa.Liquidaciones; i++)
            {
                Liquidacion liq = l[i] as Liquidacion;
                textBox1.Text += liq.VerImpreso();
            }

        }
    }
}

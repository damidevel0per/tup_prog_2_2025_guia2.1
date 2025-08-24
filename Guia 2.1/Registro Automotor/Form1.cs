using Registro_Automotor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Automotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DepartamentoVehicular depto = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DatosPersona formDato = new DatosPersona();

            formDato.ShowDialog();

            string dni = formDato.txtDNI.Text;
            string nom = formDato.txtNOMBRE.Text;

            if (formDato.DialogResult == DialogResult.OK)
            {
                listBox1.Items.Clear();
                Persona persona = new Persona(nom, dni);
                depto.RegistrarVehiculo(persona);
                MessageBox.Show("Registro exitoso");
                listBox1.Items.Add(depto.RegistrarVehiculo(persona).Patente);
                listBox1.Items.Add(depto.RegistrarVehiculo(persona).Serie);
                listBox1.Items.Add(persona.Nombre + " " + persona.DNI);
            }
        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            for (int i = 0; i < depto.CantidadRegistros; i++) 
            {
                listBox2.Items.Add(depto.VerRegistro(i).VerDetalle());
            }

        }
    }
}

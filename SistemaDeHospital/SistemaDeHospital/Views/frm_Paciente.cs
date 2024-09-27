using SistemaDeHospital.Controllers;
using SistemaDeHospital.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeHospital.Views
{
    public partial class frm_Paciente : Form
    {
        private PacienteController pacienteController;

        public frm_Paciente()
        {
            InitializeComponent();
            pacienteController = new PacienteController();
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            var pacientes = pacienteController.ObtenerPacientes();
            foreach (var paciente in pacientes)
            {
                listBoxPacientes.Items.Add($"{paciente.Nombre}, {paciente.Edad} años, {paciente.Direccion}");
            }
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            Paciente nuevoPaciente = new Paciente
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text),
                Direccion = txtDireccion.Text
            };
            pacienteController.AgregarPaciente(nuevoPaciente);
            MessageBox.Show("Paciente agregado correctamente.");
            listBoxPacientes.Items.Clear();
            CargarPacientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class frm_Doctor : Form
    {
        DoctorController doctorController = new DoctorController();

        public frm_Doctor()
        {
            InitializeComponent();
        }

        private void btnBuscarDoctor_Click(object sender, EventArgs e)
        {
            // Validar el mes
            if (!int.TryParse(txtMes.Text, out int mes) || mes < 1 || mes > 12)
            {
                MessageBox.Show("Por favor, ingresa un mes válido (1-12).", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar el año
            if (!int.TryParse(txtAno.Text, out int ano) || ano < 1900 || ano > DateTime.Now.Year)
            {
                MessageBox.Show("Por favor, ingresa un año válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Deshabilitar el botón para evitar múltiples clics
            btnBuscarDoctor.Enabled = false;

            try
            {
                Doctor doctor = doctorController.ObtenerDoctorConMasConsultas(mes, ano);

                if (doctor != null)
                {
                    lblResultado.Text = $"El doctor con más consultas en {mes}/{ano} es: {doctor.Nombre}\nTotal de Consultas: {doctor.TotalConsultas}";
                }
                else
                {
                    lblResultado.Text = "No se encontró un doctor para el mes y año especificados.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar el doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Habilitar el botón nuevamente
                btnBuscarDoctor.Enabled = true;
            }
        }

        // Elimina este método si no lo necesitas
        private void label3_Click(object sender, EventArgs e)
        {
            // No se necesita implementación
        }
    }
}
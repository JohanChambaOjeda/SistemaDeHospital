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
    public partial class frm_Consulta : Form
    {
        private ConsultaController consultaController;

        public frm_Consulta()
        {
            InitializeComponent();
            consultaController = new ConsultaController();
            CargarConsultas();
        }

        private void CargarConsultas()
        {
            var consultas = consultaController.ObtenerConsultas();
            foreach (var consulta in consultas)
            {
                listBoxConsultas.Items.Add($"DoctorID: {consulta.DoctorID}, PacienteID: {consulta.PacienteID}, Fecha: {consulta.FechaConsulta.ToShortDateString()}");
            }
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            Consulta nuevaConsulta = new Consulta
            {
                DoctorID = int.Parse(txtDoctorID.Text),
                PacienteID = int.Parse(txtPacienteID.Text),
                FechaConsulta = dateTimePickerConsulta.Value
            };
            consultaController.AgregarConsulta(nuevaConsulta);
            MessageBox.Show("Consulta agregada correctamente.");
            listBoxConsultas.Items.Clear();
            CargarConsultas();
        }
    }

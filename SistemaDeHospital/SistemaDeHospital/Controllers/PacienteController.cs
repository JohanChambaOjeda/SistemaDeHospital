using SistemaDeHospital.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospital.Controllers
{
    public class PacienteController
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=HospitalDB;Integrated Security=True";

        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PacienteID, Nombre, Edad, Direccion FROM Pacientes";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pacientes paciente = new Paciente
                    {
                        PacienteID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Edad = reader.GetInt32(2),
                        Direccion = reader.GetString(3)
                    };
                    pacientes.Add(paciente);
                }
            }

            return pacientes;
        }

        public void AgregarPaciente(Paciente paciente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Pacientes (Nombre, Edad, Direccion) VALUES (@Nombre, @Edad, @Direccion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@Edad", paciente.Edad);
                cmd.Parameters.AddWithValue("@Direccion", paciente.Direccion);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
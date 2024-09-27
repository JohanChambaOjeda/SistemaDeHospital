using SistemaDeHospital.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospital.Controllers
{
    public class ConsultaController
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=HospitalDB;Integrated Security=True";

        public List<Consulta> ObtenerConsultas()
        {
            List<Consulta> consultas = new List<Consulta>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ConsultaID, DoctorID, PacienteID, FechaConsulta FROM Consultas";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Consulta consulta = new Consulta
                    {
                        ConsultaID = reader.GetInt32(0),
                        DoctorID = reader.GetInt32(1),
                        PacienteID = reader.GetInt32(2),
                        FechaConsulta = reader.GetDateTime(3)
                    };
                    consultas.Add(consulta);
                }
            }

            return consultas;
        }

        public void AgregarConsulta(Consulta consulta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Consultas (DoctorID, PacienteID, FechaConsulta) VALUES (@DoctorID, @PacienteID, @FechaConsulta)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", consulta.DoctorID);
                cmd.Parameters.AddWithValue("@PacienteID", consulta.PacienteID);
                cmd.Parameters.AddWithValue("@FechaConsulta", consulta.FechaConsulta);
                cmd.ExecuteNonQuery();
            }
        }
    }
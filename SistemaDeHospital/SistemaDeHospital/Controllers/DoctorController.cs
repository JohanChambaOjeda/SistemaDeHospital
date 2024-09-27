using SistemaDeHospital.Config;
using SistemaDeHospital.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospital.Controllers
{
    public class DoctorController
    {
        Conexion con = new Conexion();

        public Doctor ObtenerDoctorConMasConsultas(int mes)
        {
            Doctor doctor = null;
            SqlCommand comando = new SqlCommand("SELECT TOP 1 d.DoctorID, d.Nombre, COUNT(c.ConsultaID) AS TotalConsultas FROM Doctores d JOIN Consultas c ON d.DoctorID = c.DoctorID WHERE MONTH(c.FechaConsulta) = @Mes GROUP BY d.DoctorID, d.Nombre ORDER BY TotalConsultas DESC", con.AbrirConexion());
            comando.Parameters.AddWithValue("@Mes", mes);

            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                doctor = new Doctor
                {
                    DoctorID = reader.GetInt32(0),
                    Nombre = reader.GetString(1)
                };
            }

            con.CerrarConexion();
            return doctor;
        }
    }
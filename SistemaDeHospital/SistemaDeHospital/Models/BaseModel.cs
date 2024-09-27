using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospital.Models
{
    public class BaseModel
    {
        protected SqlConnection conn;

        public BaseModel()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=HospitalDB;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }

        protected void AbrirConexion()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        protected void CerrarConexion()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}

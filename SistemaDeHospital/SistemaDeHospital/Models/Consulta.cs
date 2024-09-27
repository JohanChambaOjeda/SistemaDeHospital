using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospital.Models
{
    public class Consulta
    {
        public int ConsultaID { get; set; }
        public int DoctorID { get; set; }
        public int PacienteID { get; set; }
        public DateTime FechaConsulta { get; set; }
    }
}

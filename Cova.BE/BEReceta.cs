using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEReceta
    {
        public long RecetaId { get; set; }
        public DateTime FechaPrescripcion { get; set; }
        public BEPaciente Paciente { get; set; }
        public BEMedico Medico { get; set; }
        public BEVacuna Vacuna { get; set; }
        public string Observacion { get; set; }
    }
}

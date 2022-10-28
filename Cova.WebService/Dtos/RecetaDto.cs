using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.WebService.Dtos
{
    public class RecetaDto
    {
        public long RecetaId { get; set; }
        public DateTime FechaPrescripcion { get; set; }
        public PacienteDto Paciente { get; set; }
        public MedicoDto Medico { get; set; }

        public string Observacion
        {
            get; set;
        }
    }
}

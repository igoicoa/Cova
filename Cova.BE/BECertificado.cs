using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BECertificado
    {
        public long CertificadoId { get; set; }
        public DateTime FechaPrescripcion { get; set; }
        public BEPaciente Paciente { get; set; }
        public BEMedico Medico { get; set; }
        public string Observacion { get; set; }
    }
}

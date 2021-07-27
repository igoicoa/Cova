using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEVacunaDosis
    {
        public string Lote { get; set; }
        public BEVacuna Vacuna { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public BECentroMedico CentroMedico { get; set; }        
        public BEPaciente Paciente { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public int Dosis { get; set; }
        public string ObservacionProfesional { get; set; }
        public int CentroMedicoAplicacionId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    class BEVacunaDosis
    {
        public string Lote { get; set; }
        public int CantidadDosis { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public int Stock { get; set; }
        public string ObservacionProfesional { get; set; }
        public int CentroMedicoAplicacionId { get; set; }
        public BEVacuna Vacuna { get; set; }
        public BEPaciente Paciente { get; set; }
    }
}

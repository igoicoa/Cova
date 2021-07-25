using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEVacunaAplicada
    {
        public BEVacuna VacunaAplicada { get; set; }
        public int DosisAplicada { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string ObservacionProfesional { get; set; }
        public int CentroMedicoAplicacionId { get; set; }
    }
}

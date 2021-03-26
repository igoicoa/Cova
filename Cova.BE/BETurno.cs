using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BETurno
    {
        public  long turnoId { get; set; }
        public BEVacuna vacunaAAlpicar { get; set; }
        public DateTime fechaTurno { get; set; }

        public BECentroVacunacion centroVacunacion { get; set; }

    }
}

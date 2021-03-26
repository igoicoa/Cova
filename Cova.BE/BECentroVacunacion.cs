using Cova.BE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BECentroVacunacion
    {
        public int centroVacunacionId { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public IList<BETurno> turnosAsignados { get; set; }
        public IList<BERangoHorario> rangosHorarios { get; set; }

    }
}

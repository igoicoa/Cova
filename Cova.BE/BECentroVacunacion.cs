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
        public int CentroVacunacionId { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public IList<BETurno> TurnosAsignados { get; set; }
        public IList<BERangoHorario> RangosHorarios { get; set; }

    }
}

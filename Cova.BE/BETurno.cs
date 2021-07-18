using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BETurno
    {
        public  long TurnoId { get; set; }
        public DateTime FechaTurno { get; set; }
        public BECentroMedico CentroMedico { get; set; }

    }
}

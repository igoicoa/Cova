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
        public int DosisAplicadas { get; set; }
        public IList<DateTime> FechasAplicacion { get; set; }
    }
}

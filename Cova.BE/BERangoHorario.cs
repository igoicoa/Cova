using Cova.BE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BERangoHorario
    {
        public DiasSemana diaSemana { get; set; }
        public int horaDesde { get; set; }
        public int horaHasta { get; set; }
        public int duracionTurnoMinutos { get; set; }
    }
}

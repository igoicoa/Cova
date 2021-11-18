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
        public DayOfWeek DiaSemana { get; set; }
        public int HoraDesde { get; set; }
        public int HoraHasta { get; set; }
        public int DuracionTurnoMinutos { get; set; }
    }
}

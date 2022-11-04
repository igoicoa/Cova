using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.WebService.Dtos
{
    public class TurnoDisponibleDto
    {
        public long TurnoDisponibleId { get; set; }
        public DayOfWeek DiaSemana { get; set; }
        public DateTime HoraDesde { get; set; }
        public DateTime HoraHasta { get; set; }
    }
}

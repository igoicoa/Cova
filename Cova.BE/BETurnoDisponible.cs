using System;

namespace Cova.BE
{
    public class BETurnoDisponible
    {
        public long TurnoDisponibleId { get; set; }
        public DayOfWeek DiaSemana { get; set; }
        public DateTime HoraDesde { get; set; }
        public DateTime HoraHasta { get; set; }
    }
}

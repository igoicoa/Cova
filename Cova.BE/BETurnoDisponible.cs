using System;
using Cova.BE.Enum;

namespace Cova.BE
{
    public class BETurnoDisponible
    {
        public long TurnoDisponibleId { get; set; }
        public DiasSemana DiaSemana { get; set; }
        public DateTime HoraDesde { get; set; }
        public DateTime HoraHasta { get; set; }
    }
}

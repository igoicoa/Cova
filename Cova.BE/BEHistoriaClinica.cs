using System;

namespace Cova.BE
{
    public class BEHistoriaClinica
    {
        public long HistoriaClinicaId { get; set; }
        public DateTime Fecha { get; set; }
        public BEMedico Medico { get; set; }
        public string Observacion { get; set; }
        public decimal Peso { get; set; }
    }
}

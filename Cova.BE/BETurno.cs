using System;

namespace Cova.BE
{
    public class BETurno
    {
        public  long TurnoId { get; set; }
        public DateTime FechaTurno { get; set; }
        public BECentroMedico CentroMedico { get; set; }
        public BEProfesional Profesional { get; set; }
        public BEPaciente Paciente { get; set; }
        public bool Asistio { get; set; }
        public string Comentarios { get; set; }
    }
}

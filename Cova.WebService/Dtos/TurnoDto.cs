using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.WebService.Dtos
{
    public class TurnoDto
    {
        public long TurnoId { get; set; }
        public DateTime FechaTurno { get; set; }
        public int CentroMedicoId { get; set; }
        public CentroMedicoDto CentroMedico { get; set; }
        public int ProfesionalId { get; set; }
        public ProfesionalDto Profesional { get; set; }
        public int PacienteId { get; set; }
        public PacienteDto Paciente { get; set; }
        public bool Asistio { get; set; }
        public string Comentarios { get; set; }
    }
}

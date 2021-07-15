using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEPaciente : BEUsuario
    {
        public long PacienteId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public BEDomicilio Domicilio { get; set; }
        public BECoberturaMedicaPaciente CoberturaMedica { get; set; }
        public IList<BEVacunaAplicada> VacunasAplicadas { get; set; }
        public IList<BETurno> turnosAsignados { get; set; }
        public IList<BEVacuna> VacunasSugeridas { get; set; }

    }
}

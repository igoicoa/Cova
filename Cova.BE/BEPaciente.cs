using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE.Enum;

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
        public IList<AntecedentesPersonales> AntecedentesPersonales { get; set; }
        public IList<BEHistoriaClinica> HistoriaClinica { get; set; }
        public IList<BEVacunaDosis> VacunasAplicadas { get; set; }
        public IList<BETurno> TurnosAsignados { get; set; }
        public IList<BEVacuna> VacunasSugeridas { get; set; }
        public int Edad {
            get 
            {
                return Convert.ToInt32(((DateTime.Now - FechaNacimiento).TotalDays / 365));
            }
        }
        public string ApellidoNombre
        {
            get
            {
                return this.Apellido + ", " + this.Nombre;
            }
        }
    }
}

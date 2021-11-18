using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEProfesional : BEUsuario
    {
        public long ProfesionalId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public BEDomicilio Domicilio { get; set; }
        public IList<BETurnoDisponible> TurnosDisponibles { get; set; }
        public int Edad
        {
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class PacienteYaExisteException : Exception
    {
        public PacienteYaExisteException() : base("Ya existe un paciente registrado con ese DNI")
        {

        }
    }
}

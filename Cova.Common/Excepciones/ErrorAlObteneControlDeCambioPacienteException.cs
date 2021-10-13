using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ErrorAlObteneControlDeCambioPacienteException : Exception
    {
        public ErrorAlObteneControlDeCambioPacienteException() : base("Hubo un error al obtener el control de cambio para pacientes")
        {

        }
    }
}

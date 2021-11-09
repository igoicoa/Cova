using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCancelarTurnoException : Exception
    {
        public ErrorAlCancelarTurnoException() : base("Hubo un error al cancelar el turno")
        {

        }
    }
}

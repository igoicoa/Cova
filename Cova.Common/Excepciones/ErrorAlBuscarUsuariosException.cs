using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ErrorAlBuscarUsuariosException : Exception
    {
        public ErrorAlBuscarUsuariosException() : base("Hubo un error al buscar el Usuario")
        {

        }
    }
}

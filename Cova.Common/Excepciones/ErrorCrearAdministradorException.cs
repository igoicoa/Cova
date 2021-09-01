using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ErrorCrearAdministradorException : Exception
    {
        public ErrorCrearAdministradorException() : base("Hubo un error al crear el Administrador")
        {

        }
    }
}

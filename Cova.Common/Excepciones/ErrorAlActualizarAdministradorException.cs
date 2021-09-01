using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ErrorAlActualizarAdministradorException: Exception
    {
        public ErrorAlActualizarAdministradorException() : base("Hubo un error al actualizar el Administrador")
        {

        }
    }
}

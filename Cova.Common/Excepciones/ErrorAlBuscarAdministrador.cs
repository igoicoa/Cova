using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
   public class ErrorAlBuscarAdministrador : Exception
    {
        public ErrorAlBuscarAdministrador() : base("Hubo un error al buscar datos del Administrador")
        {

        }
    }
}

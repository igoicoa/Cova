using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
   public class ErrorAlBuscarBitacoraException : Exception
    {
        public ErrorAlBuscarBitacoraException() : base("Hubo un error al buscar la bitacora")
        {

        }
    }
}

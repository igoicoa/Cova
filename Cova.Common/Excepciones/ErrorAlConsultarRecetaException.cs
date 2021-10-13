using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
   public class ErrorAlConsultarRecetaException : Exception
    {
        public ErrorAlConsultarRecetaException() : base("Hubo un error al consultar la receta")
        {

        }
    }
}

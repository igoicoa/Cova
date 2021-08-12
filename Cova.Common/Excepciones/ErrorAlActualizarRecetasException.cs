using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
   public class ErrorAlActualizarRecetasException: Exception
    {
        public ErrorAlActualizarRecetasException() : base("Hubo un error al actualizar la Receta")
        {

        }
    }
}

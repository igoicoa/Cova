using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
   public class ErrorAlCambiarPasswordException : Exception
    {
        public ErrorAlCambiarPasswordException() : base("Hubo un error al cambiar la Password")
        {

        }
    }
}

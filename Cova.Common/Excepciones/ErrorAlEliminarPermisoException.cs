using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
   public class ErrorAlEliminarPermisoException: Exception
    {
        public ErrorAlEliminarPermisoException() : base("Hubo un error al eliminar permisos")
        {

        }
    }
}

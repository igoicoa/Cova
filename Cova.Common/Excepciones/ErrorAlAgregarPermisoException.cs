using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ErrorAlAgregarPermisoException: Exception
    {
        public ErrorAlAgregarPermisoException() : base("Hubo un error al agregar permisos")
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
   public class ErrorAlObtenerPermisosException : Exception
    {
        public ErrorAlObtenerPermisosException() : base("Hubo un error al obtener los Permisos")
        {

        }
    }
}

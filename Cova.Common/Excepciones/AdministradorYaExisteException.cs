using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class AdministradorYaExisteException : Exception
    {
        public AdministradorYaExisteException() : base("Ya existe un administrador registrado con ese DNI")
        {

        }
    }
}

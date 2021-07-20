using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class UsuarioInactivoException : Exception
    {
        public UsuarioInactivoException() : base("El usuario no se encuentra activo")
        {

        } 
    }
}

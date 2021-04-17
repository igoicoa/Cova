using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;

namespace Cova.MPP
{
    public class MPPUsuario
    {
        public BEUsuario obtenerUsuario(BEUsuario usuarioALoguearse)
        {
            return new BEUsuario();
        }

        public bool ActualizarPassword(string usuario, string claveNuevaEncriptada)
        {
            return true;
        }
    }
}

using System;
using System.Text;
using Cova.BE;
using Cova.MPP;
using Cova.Common.Encriptacion;

namespace Cova.BL
{
    public class BLUsuario
    {
        public bool loguin(BEUsuario usuarioALoguearse)
        {
            bool claveCorrecta = false;
            MPPUsuario MPPUsuario = new MPPUsuario();
            string claveEncriptada = HashHelper.Hash256(usuarioALoguearse.Password);
            BEUsuario usuario = new BEUsuario();
            usuario = MPPUsuario.obtenerUsuario(usuarioALoguearse);
            if (usuario.Password == claveEncriptada)
                claveCorrecta = true;

            return claveCorrecta;
        }

    }
}

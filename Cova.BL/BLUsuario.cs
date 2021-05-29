using System;
using System.Text;
using Cova.BE;
using Cova.MPP;
using Cova.Servicios.Encriptacion;

namespace Cova.BL
{
    public class BLUsuario
    {
        public bool Login(BEUsuario usuarioALoguearse)
        {
            bool claveCorrecta = false;
            MPPUsuario MPPUsuario = new MPPUsuario();
            string claveEncriptada = HashHelper.HashMD5(usuarioALoguearse.Password);
            BEUsuario usuario = new BEUsuario();
            usuario = MPPUsuario.ObtenerUsuario(usuarioALoguearse);
            if (usuario.Password == claveEncriptada)
                claveCorrecta = true;

            return claveCorrecta;
        }

        public bool CambiarPassword(BEUsuario usuario, string nuevoPassword)
        {
            MPPUsuario MPPUsuario = new MPPUsuario();
            string claveNuevaEncriptada = HashHelper.Hash256(nuevoPassword);
            return MPPUsuario.ActualizarPassword(usuario.Usuario, claveNuevaEncriptada);
        }

    }
}

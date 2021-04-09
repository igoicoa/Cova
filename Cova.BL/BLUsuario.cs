using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;

namespace Cova.BL
{
    public class BLUsuario
    {
        public bool loguin(BEUsuario usuarioALoguearse)
        {
            bool claveCorrecta = false;
            MPPUsuario MPPUsuario = new MPPUsuario();
            string claveEncriptada = encrpitarClave(usuarioALoguearse.Password);
            BEUsuario usuario = new BEUsuario();
            usuario = MPPUsuario.obtenerUsuario(usuarioALoguearse);
            if (usuario.Password == claveEncriptada)
                claveCorrecta = true;

            return claveCorrecta;
        }

        #region Enctiptacion
        public string encrpitarClave(string clave)
        {
            string claveEncriptada = "";
            byte[] encode = new byte[clave.Length];
            encode = Encoding.UTF8.GetBytes(clave);
            claveEncriptada = Convert.ToBase64String(encode);
            return claveEncriptada;
        }

        #endregion
    }
}

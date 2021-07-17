using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.MPP;
using Cova.Servicios.Encriptacion;
using Cova.Common.Permisos;

namespace Cova.BL
{
    public class BLUsuario
    {
        public bool Login(ref BEUsuario usuarioALoguearse)
        {
            bool claveCorrecta = false;
            MPPUsuario mPPUsuario = new MPPUsuario();
            string claveEncriptada = HashHelper.HashMD5(usuarioALoguearse.Password);
            BEUsuario usuario;
            usuario = mPPUsuario.ObtenerUsuario(usuarioALoguearse);
            if (usuario.Password == claveEncriptada)
            {
                usuarioALoguearse.UsuarioID = usuario.UsuarioID;
                usuarioALoguearse.UltimoLogin = usuario.UltimoLogin;
                claveCorrecta = true;
            }

            return claveCorrecta;
        }

        public bool CambiarPassword(BEUsuario usuario, string nuevoPassword)
        {
            MPPUsuario mPPUsuario = new MPPUsuario();
            string claveNuevaEncriptada = HashHelper.Hash256(nuevoPassword);
            return mPPUsuario.ActualizarPassword(usuario.Usuario, claveNuevaEncriptada);
        }

        public ComponentePermiso ObtenerPermisosUsuario(long usuarioID)
        {
            MPPPermiso mPPPermiso = new MPPPermiso();
            return mPPPermiso.ObtenerPermisosUsuario(usuarioID);
        }

        public IList<BEUsuario> BuscarUsuarios(string nombreABuscar, string ApellidoABuscar)
        {
            MPPUsuario mPPUsuario = new MPPUsuario();
            return mPPUsuario.BuscarUsuarios(nombreABuscar, ApellidoABuscar);
        }

        public bool AgregarPermiso(long usuarioID, TipoPermiso permisoAAgregar)
        {
            MPPPermiso mPPPermiso = new MPPPermiso();
            return mPPPermiso.AgregarPermisoUsuario(usuarioID, permisoAAgregar);
        }

        public bool EliminarPermiso(long usuarioID, TipoPermiso permisoAAgregar)
        {
            MPPPermiso mPPPermiso = new MPPPermiso();
            return mPPPermiso.EliminarPermisoUsuario(usuarioID, permisoAAgregar);
        }
    }
}

using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.MPP;
using Cova.Servicios.Encriptacion;
using Cova.Common.Permisos;
using Cova.Common.Excepciones;
using Cova.Servicios.Bitacora;

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
            if(!usuario.Activo)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, usuarioALoguearse, TipoCriticidad.Warning, "El usuario a loguear esta inactivo", "Login"));
                throw new UsuarioInactivoException();
            }
            else if (usuario.Password == claveEncriptada)
            {
                usuarioALoguearse.UsuarioID = usuario.UsuarioID;
                usuarioALoguearse.UltimoLogin = usuario.UltimoLogin;
                usuarioALoguearse.TipoUsuario = usuario.TipoUsuario;
                claveCorrecta = true;
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, usuarioALoguearse, TipoCriticidad.Info, "Usuario logueado correctamente", "Login"));
            }
            else
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, usuarioALoguearse, TipoCriticidad.Warning, "Password incorrecto", "Login"));
                throw new UsuarioPasswordIncorrecto();
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

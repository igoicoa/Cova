using System;
using System.Collections.Generic;
using System.Linq;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.MPP;
using Cova.Servicios.Encriptacion;
using Cova.Common.Permisos;
using Cova.Common.Excepciones;
using Cova.Servicios.Bitacora;
using Cova.Servicios.Sesion;
using Cova.Servicios.Email;

namespace Cova.BL
{
    public class BLUsuario
    {
        private static Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

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
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, usuarioALoguearse, TipoCriticidad.Info, "Usuario logueado correctamente: " + usuario.UsuarioID, "Login"));
            }
            else
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, null, TipoCriticidad.Warning, "Password o usuario incorrecto para el usuario: " + usuarioALoguearse.Usuario, "Login"));
                throw new UsuarioPasswordIncorrecto();
            }

            return claveCorrecta;
        }

        public bool CambiarPassword(string usuario, string nuevoPassword)
        {
            bool cambiarPassword = false;
            try
            {
                MPPUsuario mPPUsuario = new MPPUsuario();
                string claveNuevaEncriptada = HashHelper.Hash256(nuevoPassword);
                cambiarPassword = mPPUsuario.ActualizarPassword(usuario, claveNuevaEncriptada);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se cambio la Password Exitosamente de la cuenta: " + usuario, "Cambiar Password"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al cambiar la Password: " + ex.Message, "Cambiar Password"));
                throw new ErrorAlCambiarPasswordException();
            }
            return cambiarPassword;
        }

        public bool RecuperarPassword(string usuario, string emailUsuario)
        {
            bool recuperarPwd = false;
            try
            {
                string claveProvisoria = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
                if (this.CambiarPassword(usuario, claveProvisoria))
                {
                    string body = "Su contraseña provisoria es: " + claveProvisoria;
                    EmailSender.SendEmail(emailUsuario, usuario, "Recuperacion contraseña", body);
                    recuperarPwd = true;
                    Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se recupero la contraseña del usuario " + usuario, "Recuperar Contraseña"));
                }
            }
            catch(Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al recuperar contraseña del usuario " + usuario + " - " + ex.Message, "Recuperar Contraseña"));
                throw new ErrorAlBuscarUsuariosException();
            }
            return recuperarPwd;
        }

        public ComponentePermiso ObtenerPermisosUsuario(long usuarioID)
        {
                MPPPermiso mPPPermiso = new MPPPermiso();
                return mPPPermiso.ObtenerPermisosUsuario(usuarioID);
        }

        public IList<BEUsuario> BuscarUsuarios(string nombreABuscar, string ApellidoABuscar)
        {
            IList<BEUsuario> usuarios;
            MPPUsuario mPPUsuario = new MPPUsuario();
            try
            {
                usuarios = mPPUsuario.BuscarUsuarios(nombreABuscar, ApellidoABuscar);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo la busqueda del usuario ", "Buscar Usuarios"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar el usuario " + ex.Message, "Buscar Usuarios"));
                throw new ErrorAlBuscarUsuariosException();
            }
            return usuarios;
        }

        public bool AgregarPermiso(long usuarioID, TipoPermiso permisoAAgregar)
        {
            bool AgregarPermiso = false;
            try
            {
                MPPPermiso mPPPermiso = new MPPPermiso();
                AgregarPermiso = mPPPermiso.AgregarPermisoUsuario(usuarioID, permisoAAgregar);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se agrego el permiso ", "Agregar Permiso"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al agregar el permiso: " + ex.Message, "Agregar Permiso"));
                throw new ErrorAlAgregarPermisoException();
            }
            return AgregarPermiso;
        }

        public bool EliminarPermiso(long usuarioID, TipoPermiso permisoAAgregar)
        {
            bool EliminarPermiso = false;
            try
            {
                MPPPermiso mPPPermiso = new MPPPermiso();
                EliminarPermiso = mPPPermiso.EliminarPermisoUsuario(usuarioID, permisoAAgregar);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se eliminó el permiso: ", "Agregar Permiso"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al eliminar el permiso: " + ex.Message, "Eliminar Permiso"));
                throw new ErrorAlEliminarPermisoException();
            }
            return EliminarPermiso;
        }

        public string ObtenerEmailUsuario(string usuario, string email)
        {
            string emailUsuario = "";
            MPPUsuario mPPUsuario = new MPPUsuario();
            try
            {
                emailUsuario = mPPUsuario.ObtenerEmailUsuario(usuario, email);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo el mail del usuario " + usuario, "Obtener Email Usuario"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al obtener el email del usuario " + usuario + " - " + ex.Message, "Obtener Email Usuario"));
                throw new ErrorAlBuscarUsuariosException();
            }
            return emailUsuario;
        }
    }
}

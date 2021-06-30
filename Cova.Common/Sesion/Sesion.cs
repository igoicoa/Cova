using System;
using Cova.BE;
using Cova.BE.Permisos;
using Cova.BE.Multiidioma;
using Cova.Servicios.Multiidioma;
using Cova.MPP;

namespace Cova.Servicios.Sesion
{
    public class Sesion
    {
        private static Sesion _sesion;

        public BEUsuario Usuario { get; set; }
        public DateTime FechaLogueo { get; set; }
        public ManejadorIdioma ManejadorIdioma { get; set; }

        public static Sesion GetInstance
        {
            get
            {
                return _sesion;
            }
        }

        public static void Login(BEUsuario usuario)
        {
            if (_sesion == null)
            {
                _sesion = new Sesion();
                _sesion.Usuario = usuario;
                _sesion.FechaLogueo = DateTime.Now;
                _sesion.CargarPermisos();
                Idioma idiomaElegido = new Idioma();
                idiomaElegido.Nombre = "Castellano";
                _sesion.ManejadorIdioma = new ManejadorIdioma(idiomaElegido);
            }
            else
            {
                throw new Exception("Ya hay una sesion iniciada");
            }
        }

        public static bool TienePermiso(TipoPermiso tipoPermiso)
        {
            if (_sesion.Usuario.Permisos.TienePermiso(tipoPermiso))
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public static void Logout()
        {
            if (_sesion != null)
            {
                _sesion = null;
            }
            else
            {
                throw new Exception("No hay sesion inicializada");
            }
        }

        private void CargarPermisos()
        {
            MPPPermiso mPPPermiso = new MPPPermiso();
            this.Usuario.Permisos = mPPPermiso.ObtenerPermisosUsuario(this.Usuario.UsuarioID);
        }

    }
}

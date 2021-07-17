using System;
using Cova.BE;
using Cova.Common.Permisos;
using Cova.Common.Multiidioma;
using Cova.Common.Excepciones;
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

        public static void Login(BEUsuario usuario, Idioma idiomaElegido = null)
        {
            if (_sesion == null)
            {
                _sesion = new Sesion();
                _sesion.Usuario = usuario;
                _sesion.FechaLogueo = DateTime.Now;
                _sesion.CargarPermisos();
                if (idiomaElegido == null)
                {
                    idiomaElegido = new Idioma();
                    idiomaElegido.Nombre = "Castellano";
                }
                _sesion.ManejadorIdioma = new ManejadorIdioma(idiomaElegido);
            }
            else
            {
                throw new SesionIniciadaException();
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
                throw new SesionNoIniciadaException();
            }
        }

        private void CargarPermisos()
        {
            MPPPermiso mPPPermiso = new MPPPermiso();
            this.Usuario.Permisos = mPPPermiso.ObtenerPermisosUsuario(this.Usuario.UsuarioID);
        }

    }
}

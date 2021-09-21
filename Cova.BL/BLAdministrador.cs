using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.Common.Excepciones;
using Cova.MPP;
using Cova.Servicios.Bitacora;
using Cova.Servicios.Sesion;

namespace Cova.BL
{
    public class BLAdministrador
    {
        public bool CrearAdministrador(BEAdministrador administrador)
        {
            bool AdministradorCreado = false;
            try
            {
                MPPAdministrador mPPAdministrador = new MPPAdministrador();
                AdministradorCreado = mPPAdministrador.CrearAdministrador(administrador);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se creo el Administrador: " + administrador.Apellido + ", " + administrador.Nombre, "Crear Administrador"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Crear el Administrador: " + administrador.Apellido + " - " + administrador.Nombre + " - " + ex.Message, "Crear Administrador"));
                throw new ErrorCrearAdministradorException();
            }
            return AdministradorCreado;

        }

        public IList<BEAdministrador> BuscarAdministrador(string Usuario, string DNI)
        {
            IList<BEAdministrador> administrador;
            MPPAdministrador mPPAdministrador = new MPPAdministrador();
            try
            {
                administrador= mPPAdministrador.BuscarAdministrador(Usuario, DNI);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo la busqueda del administrador", "Buscar Administrador"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar el administrador"  + ex.Message, "Buscar Administrador"));
                throw new ErrorAlBuscarAdministrador();
            }
            return administrador;
        }

        public bool ActualizarAdministrador(BEAdministrador administrador)
        {
            bool AdministradorActualizado = false;
            MPPAdministrador mPPAdministrador = new MPPAdministrador();
            try
            {
                AdministradorActualizado = mPPAdministrador.ActualizarAdministrador(administrador); ;
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se actualizó el Administrador: " + administrador.Apellido + ", " + administrador.Nombre, "Actualizar Administrador"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al actualizar el Administrador: " + administrador.Apellido + " - " + administrador.Nombre + " - " + ex.Message, "Actualizar Administrador"));
                throw new ErrorAlActualizarAdministradorException();
            }
            return AdministradorActualizado;
        }
    }
}

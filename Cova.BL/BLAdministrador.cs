using System;
using System.Collections.Generic;
using System.Linq;
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
                if (this.ExisteAdministrador(administrador))
                {
                    Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Warning, "No se puede crear paciente. Ya existe un paciente con el DNI: " + pacienteNuevo.DNI, "Crear Paciente"));
                    throw new AdministradorYaExisteException();
                }
                MPPAdministrador mPPAdministrador = new MPPAdministrador();
                AdministradorCreado = mPPAdministrador.CrearAdministrador(administrador);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se creo el Administrador: " + administrador.Apellido + ", " + administrador.Nombre, "Crear Administrador"));
            }
            catch (Exception ex)
            {
                if (ex.GetType() == new AdministradorYaExisteException().GetType())
                {
                    throw ex;
                }
                else
                {
                    Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Crear el Administrador: " + administrador.Apellido + " - " + administrador.Nombre + " - " + ex.Message, "Crear Administrador"));
                    throw new ErrorCrearAdministradorException();
                }
            }
            return AdministradorCreado;

        }

        public bool ExisteAdministrador(BEAdministrador administradorNuevo)
        {
            return this.BuscarAdministrador("", administradorNuevo.DNI.ToString()).Count() == 0 ? false : true;
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

        public bool ActualizarAdministrador(BEAdministrador administradorAActualizar, BEAdministrador administradorActualizado)
        {
            bool AdministradorActualizado = false;
            MPPAdministrador mPPAdministrador = new MPPAdministrador();
            try
            {
                if (administradorAActualizar.DNI != administradorActualizado.DNI)
                {
                    if (this.ExisteAdministrador(administradorActualizado))
                    {
                        Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Warning, "No se puede crear paciente. Ya existe un paciente con el DNI: " + pacienteNuevo.DNI, "Crear Paciente"));
                        throw new AdministradorYaExisteException();
                    }
                }
                AdministradorActualizado = mPPAdministrador.ActualizarAdministrador(administradorActualizado); ;
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

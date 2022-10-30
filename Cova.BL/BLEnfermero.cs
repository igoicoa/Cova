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
    public class BLEnfermero
    {
        public bool CrearProfesionalEnfermero(BEEnfermero enfermero)
        {
            bool profesionalCreado = false;
            try
            {
                MPPEnfermero mPPEnfermero = new MPPEnfermero();
                profesionalCreado = mPPEnfermero.CrearProfesionalEnfermero(enfermero);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se creo el Profesional enfermero: " + enfermero.Apellido + ", " + enfermero.Nombre, "Crear Profesional Enfermero"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Crear Profesional enfermero: " + enfermero.Apellido + " - " + enfermero.Nombre + " - " + ex.Message, "Crear Profesional Enfermero"));
                throw new ErrorAlCrearProfesionalException();
            }
            return profesionalCreado;
        }

        public bool ExisteEnfermero(BEEnfermero enfermeroNuevo)
        {
            return this.BuscarEnfermeros("", enfermeroNuevo.DNI.ToString()).Count() == 0 ? false : true;
        }

        public IList<BEEnfermero> BuscarEnfermeros(string Usuario, string DNI)
        {

            IList<BEEnfermero> enfermero;
            MPPEnfermero mPPEnfermero = new MPPEnfermero();
            try
            {
                enfermero = mPPEnfermero.BuscarEnfermeros(Usuario, DNI);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo la busqueda del enfermero", "Buscar Medicos"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar el enfermero" + ex.Message, "Buscar Medicos"));
                throw new ErrorAlCargarDatosProfesional();
            }
            return enfermero;

        }

        public bool ActualizarProfesionalEnfermero(BEEnfermero enfermeroAActualizar, BEEnfermero enfermeroActualizado)
        {
            bool Actualizarprofesional = false;
            try
            {
                MPPEnfermero mPPEnfermero = new MPPEnfermero();
                Actualizarprofesional = mPPEnfermero.ActualizarProfesionalEnfermero(enfermeroActualizado);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se actualizó el Profesional enfermero: " + enfermeroAActualizar.Apellido + ", " + enfermeroAActualizar.Nombre, "Actualizar Profesional Enfermero"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al actualizar Profesional enfermero: " + enfermeroAActualizar.Apellido + " - " + enfermeroAActualizar.Nombre + " - " + ex.Message, "Actualizar Profesional Enfermero"));
                throw new ErrorAlActualizarProfesionalException();
            }
            return Actualizarprofesional;
        }

        public bool InactivarEnfermero(BEEnfermero enfermeroAInactivar)
        {
            bool EnfermeroInactivado = false;
            try
            {
                MPPEnfermero mPPEnfermero = new MPPEnfermero();
                EnfermeroInactivado = mPPEnfermero.InactivarEnfermero(enfermeroAInactivar);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se inactivo el enfermero: " + enfermeroAInactivar.ProfesionalId + " - " + enfermeroAInactivar.Apellido, "Inactivar enfermero"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al inactivar enfermero: " + enfermeroAInactivar.ProfesionalId + " - " + enfermeroAInactivar.ApellidoNombre + " - " + ex.Message, "Inactivar enfermero"));
                throw new ErrorAlActualizarPacienteException();
            }
            return EnfermeroInactivado;
        }
    }
}
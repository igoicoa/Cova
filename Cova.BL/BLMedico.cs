using System;
using System.Collections.Generic;
using System.Linq;
using Cova.BE;
using Cova.MPP;
using Cova.Common.Excepciones;
using Cova.Servicios.Bitacora;
using Cova.BE.Bitacora;
using Cova.Servicios.Sesion;

namespace Cova.BL
{
    public class BLMedico
    {
        public bool CrearProfesionalMedico(BEMedico medico)
        {
            bool profesionalCreado = false;
            try
            {
                MPPMedico mPPMedico = new MPPMedico();
                profesionalCreado = mPPMedico.CrearProfesionalMedico(medico);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se creo el Profesional Medico: " + medico.Apellido + ", " + medico.Nombre, "Crear Profesional Medico"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Crear Profesional Medico: " + medico.Apellido + " - " + medico.Nombre + " - " + ex.Message, "Crear Profesional Medico"));
                throw new ErrorAlCrearProfesionalException();
            }
            return profesionalCreado;
        }

        public bool ExisteMedico(BEMedico medicoNuevo)
        {
            return this.BuscarMedicos("", medicoNuevo.DNI.ToString()).Count() == 0 ? false : true;
        }

        public IList<BEMedico> BuscarMedicos(string Usuario, string DNI)
        {
            IList<BEMedico> medicos;
            MPPMedico mPPMedico = new MPPMedico();
            try
            {
                medicos = mPPMedico.BuscarMedicos(Usuario, DNI);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo la busqueda del medico: ", "Buscar Medicos"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar el medico: " + ex.Message, "Buscar Medicos"));
                throw new ErrorAlBuscarDatosMedicos();
            }
            return medicos;
        }

        public bool ActualizarProfesionalMedico(BEMedico medicoAActualizar, BEMedico medicoActualizado)
        {
            bool profesionalActualizado = false;
            try
            {
                MPPMedico mPPMedico = new MPPMedico();
                profesionalActualizado = mPPMedico.ActualizarProfesionalMedico(medicoActualizado);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "El Profesional: " + medicoActualizado.ProfesionalId + "fue actualizado con exito", "Actualizar Profesional"));
            } 
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al crear el Profesional: " + medicoActualizado.Apellido + " - " + medicoActualizado.Nombre + " - " + ex.Message, "Actualizar Profesional"));
                throw new ErrorAlActualizarProfesionalException();
            }
            return profesionalActualizado;
        }
    }
}

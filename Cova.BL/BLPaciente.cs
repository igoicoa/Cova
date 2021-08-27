using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.Servicios.Bitacora;
using Cova.MPP;
using Cova.Common.Excepciones;
using Cova.Servicios.Sesion;

namespace Cova.BL
{
    public class BLPaciente
    {
        public bool CrearPaciene(BEPaciente pacienteNuevo) 
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.CrearPaciente(pacienteNuevo);
            }
            catch(Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al crear el paciente: " + ex.Message, "Crear Paciente"));
                throw new ErrorAlCrearPacienteException();
            }
            finally
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "El paciente fue creado: ", "Crear Paciente"));
            }
        }

        public IList<BEPaciente> BuscarPacientes(string Usuario, string DNI)
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.BuscarPacientes(Usuario, DNI);
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar el paciente: " + ex.Message, "Buscar Paciente"));
                throw new ErrorAlBuscarPacienteException();
            }
            finally
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se busco el Paciente: ", "Buscar Paciente"));
            }
        }

        public bool ActualizarPaciente(BEPaciente pacienteNuevo)
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.ActualizarPaciente(pacienteNuevo);
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Actualizar Paciente: " + ex.Message, "Actualizar Paciente"));
                throw new ErrorAlActualizarPacienteException();
            }
            finally
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se actualizo el Paciente: ", "Actualizar Paciente"));
            }

        }

        public IDictionary<bool, List<string>> EstaEnCondicionesDeRecibirVacuna(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            Dictionary<bool, List<string>> condicionesPaciente = new Dictionary<bool, List<string>>();
            List<string> razones = new List<string>();
            bool estaEnCondicionesDeVacunarse = true;
            if (!this.TieneRecetaMedicaParaAplicarVacuna(pacienteAVacunarse, vacunaAAplicar))
            {
                razones.Add("El paciente no tiene receta para la vacuna");
                estaEnCondicionesDeVacunarse = false;
            }
            if(!this.CorrespondeRecibirDosis(pacienteAVacunarse, vacunaAAplicar))
            {
                razones.Add("Al paciente no le corresponde recibir la dosis: " + Convert.ToString(vacunaAAplicar.Dosis));
                estaEnCondicionesDeVacunarse = false;
            }
            if (!this.EstaDentroRangoEtarioVacunacion(pacienteAVacunarse, vacunaAAplicar))
            {
                razones.Add("El paciente no se encuentra dentro del rango etario de vacunacion");
                estaEnCondicionesDeVacunarse = false;
            }

            if (estaEnCondicionesDeVacunarse)
            {
                razones.Add("El paciente esta en condiciones de vacunarse");
                condicionesPaciente.Add(true, razones);
            }
            else
            {
                condicionesPaciente.Add(false, razones);
            }
            return condicionesPaciente;
        }

        private bool TieneRecetaMedicaParaAplicarVacuna(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            BLReceta bLReceta = new BLReceta();
            BEReceta recetaVacuna = bLReceta.ObtenerRecetaParaVacunaYPaciente(vacunaAAplicar.Vacuna, pacienteAVacunarse);

            return recetaVacuna.RecetaId == 0 ? false : true;
        }

        private bool CorrespondeRecibirDosis(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            int cantidadDosisAplicadas;
            MPPPaciente mPPPaciente = new MPPPaciente();
            cantidadDosisAplicadas = mPPPaciente.ObtenerCantidadDosisAplicadasDeVacunaAPaciente(pacienteAVacunarse, vacunaAAplicar.Vacuna);
            if(vacunaAAplicar.Dosis != (cantidadDosisAplicadas + 1) || vacunaAAplicar.Vacuna.CantidadDosis < vacunaAAplicar.Dosis)
            {
                return false;
            }
            return true;
        }

        private bool EstaDentroRangoEtarioVacunacion(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            return (pacienteAVacunarse.Edad >= vacunaAAplicar.Vacuna.EdadMinimaAplicacion && pacienteAVacunarse.Edad <= vacunaAAplicar.Vacuna.EdadMaximaAplicacion);
        }

        public bool VacunarPaciente(BEPaciente pacienteAVacunar, BEVacunaDosis vacunaAAplicar)
        {
            try
            {
                MPPVacuna mPPVacuna = new MPPVacuna();
                return mPPVacuna.VacunarPaciente(pacienteAVacunar, vacunaAAplicar);
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Vacunar el Paciente: " + ex.Message, "Vacunar Paciente"));
                throw new ErrorAlVacunarPacienteException();
            }
            finally
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Vacuno el Paciente: ", "Vacunar Paciente"));
            }
        }

        public IList<BEVacunaDosis> ObtenerVacunasAplicadasEsquemaCompleto(BEPaciente paciente)
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.ObtenerVacunasAplicadasEsquemaCompleto(paciente);
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Obtener Vacunas Aplicadas Esquema Completo: " + ex.Message, "Obtener Vacunas Aplicadas Esquema Completo"));
                throw new ErrorAlObtenerVacunasAplicadasEsquemaCompletoException();
            }
            finally
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo vacunas aplicadas esquema completo para el Paciente: ", "Obtener Vacunas Aplicadas Esquema Completo"));
            }
        }

        public IList<BEVacunaDosis> ObtenerVacunasAplicadasEsquemaIncompleto(BEPaciente paciente)
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.ObtenerVacunasAplicadasEsquemaIncompleto(paciente);
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Obtener Vacunas Aplicadas Esquema incompleto: " + ex.Message, "Obtener Vacunas Aplicadas Esquema Incompleto"));
                throw new ErrorAlObtenerVacunasAplicadasEsquemaInCompletoException();
            }
            finally
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo vacunas aplicadas esquema incompleto para el Paciente: ", "Obtener Vacunas Aplicadas Esquema Incompleto"));
            }
        }

        public IList<BEVacuna> ObtenerVacunasRecetadas()
        {
            throw new NotImplementedException();
        }

        public bool AgregarCoberturaMedica(BEPaciente paciente, BECoberturaMedica coberturaMedica)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCoberturaMedica(BEPaciente paciente)
        {
            throw new NotImplementedException();
        }

        public bool AgregarTurno(BEPaciente paciente, BETurno turnoNuevo)
        {
            throw new NotImplementedException();
        }

        public bool CancelarTurno(BEPaciente paciente, BETurno turnoACancelar)
        {
            throw new NotImplementedException();
        }

    }

}

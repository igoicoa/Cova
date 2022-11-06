using System;
using System.Collections.Generic;
using System.Linq;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.MPP;
using Cova.Servicios.Bitacora;
using Cova.Servicios.Sesion;
using Cova.Common.Excepciones;
using Cova.Common.Constantes;

namespace Cova.BL
{
    public class BLTurno
    {
        public IList<BETurno> ObtenerTurnos(BEPaciente pacienteTurno = null, BEProfesional profesionalTurno = null, Especialidad? especialidad = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            IList<BETurno> turnos;
            MPPTurno mPPTurno = new MPPTurno();
            try
            {
                turnos = mPPTurno.ObtenerTurnos(pacienteTurno, profesionalTurno, especialidad, fechaDesde, fechaHasta);
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo la busqueda de turnos ", "Buscar Turnos"));
            }
            catch (Exception ex)
            {
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar turnos: " + ex.Message, "Buscar Turnos"));
                throw new ErrorAlBuscarTurnosException();
            }
            return turnos;
        }

        public bool GenerarTurno(BETurno turnoNuevo)
        {
            bool turnoGenerado = false;
            MPPTurno mPPTurno = new MPPTurno();
            try
            {
                if(ValidarDisponibilidadTurno(turnoNuevo))
                {
                    turnoGenerado = mPPTurno.GenerarTurno(turnoNuevo);
                    //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se genero con exito el turno para: " + turnoNuevo.Paciente.Apellido + " con el profesional: " + turnoNuevo.Profesional.Apellido, "Generar Turnos"));
                }
                else
                {
                    throw new TurnoNoDisponibleException();
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() == new TurnoNoDisponibleException().GetType())
                {
                    throw ex;
                }
                else
                {
                    //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al generar el turno para: " + turnoNuevo.Paciente.Apellido + " con el profesional: " + turnoNuevo.Profesional.Apellido + " - " + ex.Message, "Generar Turnos"));
                    throw new ErrorAlGenerarTurnoException();
                }
            }
            return turnoGenerado;
        }

        public bool ValidarDisponibilidadTurno(BETurno turnoNuevo)
        {
            bool turnoDisponible = false;
            MPPTurno mPPTurno = new MPPTurno();
            IList<BETurno> turnos;
            try
            {
                turnos = mPPTurno.ObtenerTurnos(null, turnoNuevo.Profesional, null, turnoNuevo.FechaTurno, turnoNuevo.FechaTurno.AddMinutes(Constantes.DURACION_TURNO)).ToList();
                turnoDisponible = turnos.Count > 0 ? false : true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return turnoDisponible;
        }

        public bool CancelarTurno(int turnoId)
        {
            bool turnoCancelado = false;
            MPPTurno mPPTurno = new MPPTurno();
            try
            {
                turnoCancelado = mPPTurno.CancelarTurno(turnoId);
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se cancelo con exito el turno para: " + turnoACancelar.Paciente.Apellido + " con el profesional: " + turnoACancelar.Profesional.Apellido, "Cancelar Turnos"));
            }
            catch (Exception ex)
            {
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al cancelar el turno para: " + turnoACancelar.Paciente.Apellido + " con el profesional: " + turnoACancelar.Profesional.Apellido + " - " + ex.Message, "Cencelar Turnos"));
                throw new ErrorAlCancelarTurnoException();
            }
            return turnoCancelado;
        }

        public bool AsistioTurno(BETurno turno)
        {
            bool asistioTurno = false;
            MPPTurno mPPTurno = new MPPTurno();
            try
            {
                asistioTurno = mPPTurno.AsistioTurno(turno);
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se concreto la visita del paciente: " + turno.Paciente.Apellido + " con el profesional: " + turno.Profesional.Apellido, "Asistencia Turnos"));
            }
            catch (Exception ex)
            {
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al marcar la aistencia del paciente: " + turno.Paciente.Apellido + " con el profesional: " + turno.Profesional.Apellido + " - " + ex.Message, "Asistencia Turnos"));
                throw new ErrorAlCancelarTurnoException();
            }
            return asistioTurno;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.MPP;
using Cova.Servicios.Bitacora;
using Cova.Servicios.Sesion;
using Cova.Common.Excepciones;
using Cova.Common.Utils;

namespace Cova.BL
{
    public class BLProfesional
    {
        public bool ActualizarTurnosDisponibles(BEProfesional profesional)
        {
            bool turnosActualizados = false;
            try
            {
                MPPTurno mPPTurno = new MPPTurno();
                if (!mPPTurno.EliminarTurnosDisponiblesProfesional(profesional))
                {
                    throw new ErrorAlActualizarTurnosDisponiblesException();
                }
                foreach(BETurnoDisponible turnoDisponible in profesional.TurnosDisponibles)
                {
                    turnosActualizados = mPPTurno.AgregarTurnoDisponible(turnoDisponible, profesional.ProfesionalId);
                    if(!turnosActualizados)
                    {
                        throw new ErrorAlActualizarTurnosDisponiblesException();
                    }
                }
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Los turnos del Profesional: " + profesional.ProfesionalId + "fueron actualizado con exito", "Actualizar Turnos Disponibles"));
            }
            catch (Exception ex)
            {
                if (ex.GetType() == new TurnoNoDisponibleException().GetType())
                {
                    throw ex;
                }
                else
                {
                    Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al actualizar los turnos del profesional:  " + profesional.ProfesionalId + " - " + ex.Message, "Actualizar Turnos Disponibles"));
                    throw new ErrorAlActualizarProfesionalException();
                }
            }
            return turnosActualizados;
        }

        public void CargarTurnosDisponibles(BEProfesional profesional)
        {
            IList<BETurnoDisponible> turnosDisponibles;
            MPPTurno mPPTurno = new MPPTurno();
            try
            {
                turnosDisponibles = mPPTurno.ObtenerTurnosDisponibles(profesional);
                profesional.TurnosDisponibles = turnosDisponibles;
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se obtuvieron los turnos disponibles de: " + profesional.ProfesionalId, "Obtener turnos disponibles"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al obtener los turnos disponibles de: " + profesional.ProfesionalId + " - " + ex.Message, "Obtener turnos disponibles"));
                throw new ErrorAlBuscarDatosMedicos();
            }
        }

        public IList<BETurno> ObtenerTurnosLibres(BEProfesional profesional, DateTime fechaDesde, DateTime fechaHasta)
        {
            IList<BETurno> turnosLibres = new List<BETurno>();
            BLTurno bLTurno = new BLTurno();
            try
            {
                this.CargarTurnosDisponibles(profesional);
                IList<BETurno> turnosOcupados = bLTurno.ObtenerTurnos(null, profesional, null, fechaDesde, fechaHasta);
                foreach (DateTime dia in CalendarioUtils.ObtenerRangoHorario(fechaDesde, fechaHasta))
                {
                    if(profesional.TurnosDisponibles.Where(x => x.DiaSemana == dia.DayOfWeek && x.HoraDesde.Hour == dia.Hour).Any())
                    {
                        if(!turnosOcupados.Where(x => x.FechaTurno == dia).Any())
                        {
                            BETurno turnoLibre = new BETurno(profesional, dia);
                            turnosLibres.Add(turnoLibre);
                        }
                    }
                }
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se obtuvieron los turnos disponibles de: " + profesional.ProfesionalId, "Obtener turnos disponibles"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al obtener los turnos disponibles de: " + profesional.ProfesionalId + " - " + ex.Message, "Obtener turnos disponibles"));
                throw new ErrorAlBuscarDatosMedicos();
            }
            return turnosLibres;
        }

    }
}

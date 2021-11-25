using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.BE.Enum;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPTurno
    {
        public IList<BETurno> ObtenerTurnos(BEPaciente pacienteTurno = null, BEProfesional profesionalTurno = null, Especialidad? especialidad = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            List<BETurno> turnos = new List<BETurno>();
            DataSet turnosDS;
            DataTable turnoT;
            Hashtable datosTurno = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerTurnos";
                if(pacienteTurno != null)
                {
                    datosTurno.Add("@PacienteId", pacienteTurno.PacienteId);
                }
                if(profesionalTurno != null)
                {
                    datosTurno.Add("@ProfesionalId", profesionalTurno.ProfesionalId);
                }
                if(especialidad != null)
                {
                    datosTurno.Add("@Especialidad", (Especialidad)Enum.Parse(typeof(Especialidad), Convert.ToString(especialidad)));
                }
                if(fechaDesde == null)
                {
                    datosTurno.Add("@FechaDesde", System.Data.SqlTypes.SqlDateTime.MinValue);
                }
                else
                {
                    datosTurno.Add("@FechaDesde", fechaDesde);
                }
                if(fechaHasta == null)
                {
                    datosTurno.Add("@FechaHasta", System.Data.SqlTypes.SqlDateTime.MaxValue);
                }
                else
                {
                    datosTurno.Add("@FechaHasta", fechaHasta);
                }
                turnosDS = conexionBDD.ObtenerDataSet(strSQL, datosTurno);
                turnoT = turnosDS.Tables[0];
                if (turnoT.Rows.Count > 0)
                {
                    foreach (DataRow fila in turnoT.Rows)
                    {
                        BETurno turno = new BETurno();
                        turno.TurnoId = Convert.ToInt64(fila["TurnoId"]);
                        turno.Comentarios = Convert.ToString(fila["Comentarios"]);
                        turno.Asistio = Convert.ToBoolean(fila["Asistio"]);
                        turno.FechaTurno = Convert.ToDateTime(fila["FechaTurno"]);

                        BEMedico medico = new BEMedico();
                        medico.ProfesionalId = Convert.ToInt64(fila["ProfesionalId"]);
                        medico.Nombre = Convert.ToString(fila["ProfesionalNombre"]);
                        medico.Apellido = Convert.ToString(fila["ProfesionalApellido"]);
                        medico.DNI = Convert.ToInt32(fila["ProfesionalDNI"]);
                        medico.FechaNacimiento = Convert.ToDateTime(fila["ProfesionalFechaNacimiento"]);
                        medico.Sexo = Convert.ToString(fila["ProfesionalSexo"]);
                        medico.EstadoCivil = Convert.ToString(fila["ProfesionalEstadoCivil"]);
                        medico.Telefono = Convert.ToString(fila["ProfesionalTelefono"]);
                        medico.Email = Convert.ToString(fila["ProfesionalEmail"]);
                        medico.MatriculaNacional = Convert.ToInt32(fila["ProfesionalMatriculaNacional"]);
                        medico.MatriculaProvincial = Convert.ToInt32(fila["ProfesionalMatriculaProvincial"]);
                        medico.Especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), Convert.ToString(fila["ProfesionalEspecialidad"]));

                        turno.Profesional = medico;

                        BEPaciente paciente = new BEPaciente();
                        paciente.PacienteId = Convert.ToInt64(fila["PacienteId"]);
                        paciente.Nombre = Convert.ToString(fila["PacienteNombre"]);
                        paciente.Apellido = Convert.ToString(fila["PacienteApellido"]);
                        paciente.DNI = Convert.ToInt32(fila["PacienteDNI"]);
                        paciente.FechaNacimiento = Convert.ToDateTime(fila["PacienteFechaNacimiento"]);
                        paciente.Sexo = Convert.ToString(fila["PacienteSexo"]);
                        paciente.EstadoCivil = Convert.ToString(fila["PacienteEstadoCivil"]);
                        paciente.Telefono = Convert.ToString(fila["PacienteTelefono"]);
                        paciente.Email = Convert.ToString(fila["PacienteEmail"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(fila["PacienteCoberturaMedica"])))
                        {
                            BECoberturaMedicaPaciente coberturaMedicaPaciente = new BECoberturaMedicaPaciente();
                            coberturaMedicaPaciente.Nombre = Convert.ToString(fila["PacienteCoberturaMedica"]);
                            BECoberturaMedicaPlan plan = new BECoberturaMedicaPlan();
                            plan.Nombre = Convert.ToString(fila["PacientePlan"]);
                            coberturaMedicaPaciente.Plan = plan;
                            coberturaMedicaPaciente.NumeroAfiliado = Convert.ToString(fila["PacienteNumeroAfiliado"]);
                            coberturaMedicaPaciente.FechaVencimiento = Convert.ToDateTime(fila["PacienteFechaVencimiento"]);

                            paciente.CoberturaMedica = coberturaMedicaPaciente;
                        }

                        turno.Paciente = paciente;

                        BECentroMedico centroMedico = new BECentroMedico();
                        centroMedico.CentroMedicoId = Convert.ToInt32(fila["CentroMedicoId"]);
                        centroMedico.Nombre = Convert.ToString(fila["CentroMedicoNombre"]);
                        centroMedico.Telefono = Convert.ToString(fila["CentroMedicoTelefono"]);

                        turno.CentroMedico = centroMedico;

                        turnos.Add(turno);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return turnos;
        }

        public bool GenerarTurno(BETurno turno)
        {
            Hashtable datosTurno = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_GenerarTurno";
                datosTurno.Add("@ProfesionalId", turno.Profesional.ProfesionalId);
                datosTurno.Add("@PacienteId", turno.Paciente.PacienteId);
                datosTurno.Add("@CentroMedicoId", turno.CentroMedico.CentroMedicoId);
                datosTurno.Add("@Fecha", turno.FechaTurno);
                if(turno.Comentarios is null)
                {
                    datosTurno.Add("@Comentarios", "");
                }
                else
                {
                    datosTurno.Add("@Comentarios", turno.Comentarios);
                }
                return conexionBDD.Escribir(strSQL, datosTurno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CancelarTurno(BETurno turno)
        {
            Hashtable datosTurno = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_CancelarTurno";
                datosTurno.Add("@TurnoId", turno.TurnoId);
                return conexionBDD.Escribir(strSQL, datosTurno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AsistioTurno(BETurno turno)
        {
            Hashtable datosTurno = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_AsistioTurno";
                datosTurno.Add("@TurnoId", turno.TurnoId);
                return conexionBDD.Escribir(strSQL, datosTurno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BETurnoDisponible> ObtenerTurnosDisponibles(BEProfesional profesional)
        {
            List<BETurnoDisponible> turnosDisponibles = new List<BETurnoDisponible>();
            DataSet turnosDS;
            DataTable turnoT;
            Hashtable datosTurno = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerTurnosDisponibles";
                datosTurno.Add("@ProfesionalId", profesional.ProfesionalId);
                turnosDS = conexionBDD.ObtenerDataSet(strSQL, datosTurno);
                turnoT = turnosDS.Tables[0];
                if (turnoT.Rows.Count > 0)
                {
                    foreach (DataRow fila in turnoT.Rows)
                    {
                        BETurnoDisponible turno = new BETurnoDisponible();
                        turno.TurnoDisponibleId = Convert.ToInt64(fila["TurnoDisponibleId"]);
                        turno.DiaSemana = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Convert.ToString(fila["DiaSemana"]));
                        turno.HoraDesde = Convert.ToDateTime(fila["HoraDesde"]);
                        turno.HoraHasta = Convert.ToDateTime(fila["HoraHasta"]);

                        turnosDisponibles.Add(turno);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return turnosDisponibles;
        }

        public bool EliminarTurnosDisponiblesProfesional(BEProfesional profesional)
        {
            Hashtable datosTurno = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_EliminarTurnosDisponibles";
                datosTurno.Add("@ProfesionalId", profesional.ProfesionalId);
                return conexionBDD.Escribir(strSQL, datosTurno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AgregarTurnoDisponible(BETurnoDisponible turnoDisponible, long profesionalId)
        {
            Hashtable datosTurno = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_AgregarTurnoDisponible";
                datosTurno.Add("@ProfesionalId", profesionalId);
                datosTurno.Add("@turnoDisponible", turnoDisponible.DiaSemana);
                datosTurno.Add("@HoraDesde", turnoDisponible.HoraDesde);
                datosTurno.Add("@HoraHasta", turnoDisponible.HoraHasta);
                return conexionBDD.Escribir(strSQL, datosTurno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPVacuna
    {
        public IList<BEVacuna> ObtenerVacunas()
        {
            List<BEVacuna> vacunas = new List<BEVacuna>();
            DataSet vacunasDS;
            DataTable vacunasT;
            Hashtable datosVacuna = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerVacunas";
                vacunasDS = conexionBDD.ObtenerDataSet(strSQL, datosVacuna);
                vacunasT = vacunasDS.Tables[0];
                if (vacunasT.Rows.Count > 0)
                {
                    foreach (DataRow fila in vacunasT.Rows)
                    {
                        BEVacuna vacuna = new BEVacuna();
                        vacuna.VacunaID = Convert.ToInt32(fila["VacunaId"]);
                        vacuna.Nombre = Convert.ToString(fila["NombreVacuna"]);
                        vacuna.Descripcion = Convert.ToString(fila["Descripcion"]);
                        vacuna.Prospecto = Convert.ToString(fila["Prospecto"]);
                        vacuna.Contraindicaciones = Convert.ToString(fila["Contraindicaciones"]);
                        vacuna.CantidadDosis = Convert.ToInt32(fila["CantidadDosis"]);
                        vacuna.EdadMinimaAplicacion = Convert.ToInt32(fila["EdadMinimaAplicacion"]);
                        vacuna.EdadMaximaAplicacion = Convert.ToInt32(fila["EdadMaximaAplicacion"]);

                        BELaboratorio laboratorio = new BELaboratorio();
                        laboratorio.LaboratorioId = Convert.ToInt32(fila["LaboratorioId"]);
                        laboratorio.Nombre = Convert.ToString(fila["NombreLaboratorio"]);

                        vacuna.Laboratorio = laboratorio;

                        vacunas.Add(vacuna);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vacunas;
        }

        public IList<BEVacunaDosis> ObtenerVacunasDosis()
        {
            List<BEVacunaDosis> vacunasDosis = new List<BEVacunaDosis>();
            DataSet vacunasDosisDS;
            DataTable vacunasDosisT;
            Hashtable datosVacunaDosis = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerVacunasDosis";
                vacunasDosisDS = conexionBDD.ObtenerDataSet(strSQL, datosVacunaDosis);
                vacunasDosisT = vacunasDosisDS.Tables[0];
                if (vacunasDosisT.Rows.Count > 0)
                {
                    foreach (DataRow fila in vacunasDosisT.Rows)
                    {
                        BEVacunaDosis vacunaDosis = new BEVacunaDosis();
                        vacunaDosis.Lote = Convert.ToString(fila["Lote"]);
                        vacunaDosis.FechaElaboracion = Convert.ToDateTime(fila["FechaElaboracion"]);
                        vacunaDosis.FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]);

                        BECentroMedico centroMedico = new BECentroMedico();
                        centroMedico.CentroMedicoId = Convert.ToInt32(fila["CentroMedicoId"]);
                        vacunaDosis.CentroMedico = centroMedico;

                        BEVacuna vacuna = new BEVacuna();
                        vacuna.VacunaID = Convert.ToInt32(fila["VacunaId"]);
                        vacunaDosis.Vacuna = vacuna;

                        BEPaciente paciente = new BEPaciente();
                        paciente.PacienteId = fila["PacienteId"] is DBNull ? -1 : Convert.ToInt32(fila["PacienteId"]);
                        vacunaDosis.Paciente = paciente;
                        vacunaDosis.FechaAplicacion = fila["FechaAplicacion"] is DBNull ? (DateTime?)null : Convert.ToDateTime(fila["FechaAplicacion"]);
                        vacunaDosis.Dosis = fila["Dosis"] is DBNull ? (int?)null : Convert.ToInt32(fila["Dosis"]);
                        vacunaDosis.ObservacionPaciente = fila["ObservacionPaciente"] is DBNull ? string.Empty : Convert.ToString(fila["ObservacionPaciente"]);
                        vacunaDosis.IndicacionMedico = fila["IndicacionMedico"] is DBNull ? string.Empty : Convert.ToString(fila["IndicacionMedico"]);
                        vacunaDosis.DVH = Convert.ToInt32(fila["DVH"]);

                        vacunasDosis.Add(vacunaDosis);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vacunasDosis;
        }

        public bool CrearVacuna(BEVacuna vacunaNueva)
        {
            Hashtable datosVacunaDosis = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_CrearVacuna";
                datosVacunaDosis.Add("@Nombre", vacunaNueva.Nombre);
                datosVacunaDosis.Add("@Descripcion", vacunaNueva.Descripcion);
                datosVacunaDosis.Add("@Prospecto", vacunaNueva.Prospecto);
                datosVacunaDosis.Add("@Contraindicaciones", vacunaNueva.Contraindicaciones);
                datosVacunaDosis.Add("@CantidadDosis", vacunaNueva.CantidadDosis);
                datosVacunaDosis.Add("@LaboratorioId", vacunaNueva.Laboratorio.LaboratorioId);
                datosVacunaDosis.Add("@EdadMinimaAplicacion", vacunaNueva.EdadMinimaAplicacion);
                datosVacunaDosis.Add("@EdadMaximaAplicacion", vacunaNueva.EdadMaximaAplicacion);
                return conexionBDD.Escribir(strSQL, datosVacunaDosis);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ModificarVacuna(BEVacuna vacunaAModificar)
        {
            Hashtable datosVacuna = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ActualizarVacuna";
                datosVacuna.Add("@VacunaId", vacunaAModificar.VacunaID);
                datosVacuna.Add("@Nombre", vacunaAModificar.Nombre);
                datosVacuna.Add("@Descripcion", vacunaAModificar.Descripcion);
                datosVacuna.Add("@Prospecto", vacunaAModificar.Prospecto);
                datosVacuna.Add("@Contraindicaciones", vacunaAModificar.Contraindicaciones);
                datosVacuna.Add("@CantidadDosis", vacunaAModificar.CantidadDosis);
                datosVacuna.Add("@LaboratorioId", vacunaAModificar.Laboratorio.LaboratorioId);
                datosVacuna.Add("@EdadMinimaAplicacion", vacunaAModificar.EdadMinimaAplicacion);
                datosVacuna.Add("@EdadMaximaAplicacion", vacunaAModificar.EdadMaximaAplicacion);
                return conexionBDD.Escribir(strSQL, datosVacuna);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BEVacunaDosis> ObtenerVacunasDeCentroMedicoAAplicar(BEVacunaDosis vacunaABuscar)
        {
            List<BEVacunaDosis> vacunasDosis = new List<BEVacunaDosis>();
            DataSet vacunasDosisDS;
            DataTable vacunasDosisT;
            Hashtable datosVacunaDosis = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerVacunaCentroMedicoAAplicar";
                datosVacunaDosis.Add("@CentroMedicoId", vacunaABuscar.CentroMedico.CentroMedicoId);
                datosVacunaDosis.Add("@VacunaNombre", vacunaABuscar.Vacuna.Nombre);
                datosVacunaDosis.Add("@LaboratorioNombre", vacunaABuscar.Vacuna.Laboratorio.Nombre);
                datosVacunaDosis.Add("@Lote", vacunaABuscar.Lote);
                vacunasDosisDS = conexionBDD.ObtenerDataSet(strSQL, datosVacunaDosis);
                vacunasDosisT = vacunasDosisDS.Tables[0];
                if (vacunasDosisT.Rows.Count > 0)
                {
                    foreach (DataRow fila in vacunasDosisT.Rows)
                    {
                        BEVacunaDosis vacunaDosis = new BEVacunaDosis();
                        vacunaDosis.Lote = Convert.ToString(fila["Lote"]);
                        vacunaDosis.FechaElaboracion = Convert.ToDateTime(fila["FechaElaboracion"]);
                        vacunaDosis.FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]);

                        BEVacuna vacuna = new BEVacuna();
                        vacuna.VacunaID = Convert.ToInt32(fila["VacunaId"]);
                        vacuna.Nombre = Convert.ToString(fila["NombreVacuna"]);
                        vacuna.Descripcion = Convert.ToString(fila["Descripcion"]);
                        vacuna.Prospecto = Convert.ToString(fila["Prospecto"]);
                        vacuna.Contraindicaciones = Convert.ToString(fila["Contraindicaciones"]);
                        vacuna.CantidadDosis = Convert.ToInt32(fila["CantidadDosis"]);
                        vacuna.EdadMinimaAplicacion = Convert.ToInt32(fila["EdadMinimaAplicacion"]);
                        vacuna.EdadMaximaAplicacion = Convert.ToInt32(fila["EdadMaximaAplicacion"]);

                        BELaboratorio laboratorio = new BELaboratorio();
                        laboratorio.LaboratorioId = Convert.ToInt32(fila["LaboratorioId"]);
                        laboratorio.Nombre = Convert.ToString(fila["NombreLaboratorio"]);

                        vacuna.Laboratorio = laboratorio;
                        vacunaDosis.Vacuna = vacuna;

                        vacunasDosis.Add(vacunaDosis);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vacunasDosis;
        }

        public bool VacunarPaciente(BEPaciente pacienteAVacunar, BEVacunaDosis vacunaAAplicar, int DVH)
        {
            Hashtable datosVacunaDosis = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_AplicarVacuna";
                datosVacunaDosis.Add("@PacienteId", pacienteAVacunar.PacienteId);
                datosVacunaDosis.Add("@FechaAplicacion", vacunaAAplicar.FechaAplicacion);
                datosVacunaDosis.Add("@Dosis", vacunaAAplicar.Dosis);
                datosVacunaDosis.Add("@Lote", vacunaAAplicar.Lote);
                datosVacunaDosis.Add("@VacunaId", vacunaAAplicar.Vacuna.VacunaID);
                datosVacunaDosis.Add("@DVH", DVH);
                return conexionBDD.Escribir(strSQL, datosVacunaDosis);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

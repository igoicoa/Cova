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

        public IList<BEVacunaDosis> ObtenerVacunasDeCentroMedico(BEVacunaDosis vacunaABuscar)
        {
            List<BEVacunaDosis> vacunasDosis = new List<BEVacunaDosis>();
            DataSet vacunasDosisDS;
            DataTable vacunasDosisT;
            Hashtable datosVacunaDosis = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BuscarVacunaCentroMedico";
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
    }
}

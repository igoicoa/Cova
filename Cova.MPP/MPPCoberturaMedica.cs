using System;
using System.Collections;
using System.Collections.Generic;
using Cova.BE;
using Cova.DAL;
using System.Data;

namespace Cova.MPP
{
    public class MPPCoberturaMedica
    {
        public IList<BECoberturaMedica> ObtenerCoberturasMedicas()
        {
            List<BECoberturaMedica> coberturasMedicas = new List<BECoberturaMedica>();
            DataSet coberturasMedicasDS;
            DataTable coberturasMedicasT;
            Hashtable datosCoberturas = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerCoberturasMedicas";
                coberturasMedicasDS = conexionBDD.ObtenerDataSet(strSQL, datosCoberturas);
                coberturasMedicasT = coberturasMedicasDS.Tables[0];
                if (coberturasMedicasT.Rows.Count > 0)
                {
                    foreach (DataRow fila in coberturasMedicasT.Rows)
                    {
                        BECoberturaMedica bECoberturaMedica = new BECoberturaMedica();
                        bECoberturaMedica.CoberturaMedicaId = Convert.ToInt32(fila["CoberturaMedicaId"]);
                        bECoberturaMedica.Nombre = Convert.ToString(fila["Nombre"]);

                        coberturasMedicas.Add(bECoberturaMedica);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObtenerCoberturasMedicasPlanes(coberturasMedicas);
        }

        private IList<BECoberturaMedica> ObtenerCoberturasMedicasPlanes(IList<BECoberturaMedica> coberturasMedicas)
        {
            try
            {
                foreach(BECoberturaMedica cobertura in coberturasMedicas)
                {
                    DataSet coberturasMedicasDS;
                    DataTable coberturasMedicasT;
                    Hashtable datosCoberturas = new Hashtable();
                    ConexionDB conexionBDD = new ConexionDB();
                    string strSQL = @"s_ObtenerCoberturasMedicasPlanes";
                    datosCoberturas.Add("@CoberturaMedicaId", cobertura.CoberturaMedicaId);
                    coberturasMedicasDS = conexionBDD.ObtenerDataSet(strSQL, datosCoberturas);
                    coberturasMedicasT = coberturasMedicasDS.Tables[0];
                    if (coberturasMedicasT.Rows.Count > 0)
                    {
                        foreach (DataRow fila in coberturasMedicasT.Rows)
                        {
                            BECoberturaMedicaPlan bECoberturaMedicaPlan = new BECoberturaMedicaPlan();
                            bECoberturaMedicaPlan.PlanId = Convert.ToInt32(fila["PlanId"]);
                            bECoberturaMedicaPlan.Nombre = Convert.ToString(fila["Nombre"]);

                            cobertura.Plan.Add(bECoberturaMedicaPlan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return coberturasMedicas;
        }

        public bool AgregarCoberturaMedica(BECoberturaMedica coberturaMedica)
        {
            Hashtable datosCoberturaMedica = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_AgregarCoberturaMedica";
                datosCoberturaMedica.Add("@coberturaNombre", coberturaMedica.Nombre);
                return conexionBDD.Escribir(strSQL, datosCoberturaMedica);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AgregarPlan(string coberturaMedicaNombre, string planNombre)
        {
            Hashtable datosCoberturaMedicaPlan = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_AgregarCoberturaMedicaPlan";
                datosCoberturaMedicaPlan.Add("@CoberturaNombre", coberturaMedicaNombre);
                datosCoberturaMedicaPlan.Add("@CoberturaPlanNombre", planNombre);
                return conexionBDD.Escribir(strSQL, datosCoberturaMedicaPlan);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

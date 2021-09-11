using System;
using System.Collections;
using System.Data;
using Cova.BE.DigitoVerificador;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPDigitoVerificador
    {
        public BEDigitoVerificador ObtenerSumaDVH(string entidad)
        {
            BEDigitoVerificador digitoVerificador = new BEDigitoVerificador();
            DataSet DVDS;
            DataTable DVT;
            Hashtable datosDV = new Hashtable();
            string tablaAVerificar = "";
            switch (entidad)
            {
                case "VacunaDosis":
                    tablaAVerificar = "[dbo].[VacunaDosis]";
                    break;
            }
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerSumaDVH";
                datosDV.Add("@Entidad", tablaAVerificar);
                DVDS = conexionBDD.ObtenerDataSet(strSQL, datosDV);
                DVT = DVDS.Tables[0];
                if (DVT.Rows.Count > 0)
                {
                    foreach (DataRow fila in DVT.Rows)
                    {
                        digitoVerificador.Entidad = entidad;
                        digitoVerificador.DVV = Convert.ToInt64(fila["DVV"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return digitoVerificador;
        }

        public BEDigitoVerificador ObtenerDVV(string entidad)
        {
            BEDigitoVerificador digitoVerificador = new BEDigitoVerificador();
            DataSet DVDS;
            DataTable DVT;
            Hashtable datosDV = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerDVV";
                datosDV.Add("@Entidad", entidad);
                DVDS = conexionBDD.ObtenerDataSet(strSQL, datosDV);
                DVT = DVDS.Tables[0];
                if (DVT.Rows.Count > 0)
                {
                    foreach (DataRow fila in DVT.Rows)
                    {
                        digitoVerificador.Entidad = entidad;
                        digitoVerificador.DVV = Convert.ToInt64(fila["DVV"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return digitoVerificador;
        }

        public bool ActualizarDVV(string entidad, long sumaDVH)
        {
            Hashtable datosDVV = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ActualizarDVV";
                datosDVV.Add("@Entidad", entidad);
                datosDVV.Add("@DVV", sumaDVH);
                return conexionBDD.Escribir(strSQL, datosDVV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ObtenerDVH(object entidad)
        {
            throw new NotImplementedException();
        }
    }
}

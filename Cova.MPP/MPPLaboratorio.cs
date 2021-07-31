using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPLaboratorio
    {
        public IList<BELaboratorio> ObtenerLaboratorios()
        {
            List<BELaboratorio> laboratorios = new List<BELaboratorio>();
            DataSet laboratorioDS;
            DataTable laboratorioT;
            Hashtable datosLaboratorio = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerLaboratorios";
                laboratorioDS = conexionBDD.ObtenerDataSet(strSQL, datosLaboratorio);
                laboratorioT = laboratorioDS.Tables[0];
                if (laboratorioT.Rows.Count > 0)
                {
                    foreach (DataRow fila in laboratorioT.Rows)
                    {
                        BELaboratorio laboratorio = new BELaboratorio();
                        laboratorio.LaboratorioId = Convert.ToInt32(fila["LaboratorioId"]);
                        laboratorio.Nombre = Convert.ToString(fila["Nombre"]);
                        laboratorio.Email = Convert.ToString(fila["Email"]);
                        laboratorio.Telefono = Convert.ToString(fila["Telefono"]);
                        laboratorio.Pais = Convert.ToString(fila["Pais"]);
                       
                        laboratorios.Add(laboratorio);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return laboratorios;
        }
    }
}

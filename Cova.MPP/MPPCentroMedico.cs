using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPCentroMedico
    {
        public IList<BECentroMedico> ObtenerCentrosMedicos()
        {
            List<BECentroMedico> centrosMedicos = new List<BECentroMedico>();
            DataSet centroMedicooDS;
            DataTable centroMedicoT;
            Hashtable datosCentroMedico = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerCentrosMedicos";
                centroMedicooDS = conexionBDD.ObtenerDataSet(strSQL, datosCentroMedico);
                centroMedicoT = centroMedicooDS.Tables[0];
                if (centroMedicoT.Rows.Count > 0)
                {
                    foreach (DataRow fila in centroMedicoT.Rows)
                    {
                        BECentroMedico centroMedico = new BECentroMedico();
                        centroMedico.CentroMedicoId = Convert.ToInt32(fila["CentroMedicoId"]);
                        centroMedico.Nombre = Convert.ToString(fila["Nombre"]);
                        centroMedico.Email = Convert.ToString(fila["Email"]);
                        centroMedico.Telefono = Convert.ToString(fila["Telefono"]);

                        BEDomicilio domicilio = new BEDomicilio();
                        domicilio.Calle = Convert.ToString(fila["Calle"]);
                        domicilio.Numero = Convert.ToInt32(fila["Numero"]);
                        domicilio.Piso = Convert.ToString(fila["Piso"]);
                        domicilio.Localidad = Convert.ToString(fila["Localidad"]);
                        domicilio.Provincia = Convert.ToString(fila["Provincia"]);
                        domicilio.Pais = Convert.ToString(fila["Pais"]);

                        centroMedico.Domicilio = domicilio;

                        centrosMedicos.Add(centroMedico);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return centrosMedicos;
        }
    }
}

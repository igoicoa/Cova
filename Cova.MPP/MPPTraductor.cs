using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.DAL;
using Cova.BE.Multiidioma;

namespace Cova.MPP
{
    public class MPPTraductor
    {
        public IDictionary<string, Traduccion> ObtenerTraducciones(Idioma idioma = null)
        {
            IDictionary<string, Traduccion> traducciones = new Dictionary<string, Traduccion>();
            DataSet traduccionesDS;
            DataTable traduccionesT;
            Hashtable datosTraduccion = new Hashtable();
            string idiomaElegido = (idioma is null) ? this.ObtenerIdiomaDefault().Nombre : idioma.Nombre;
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerTraducciones";
                datosTraduccion.Add("@Idioma", idiomaElegido);
                traduccionesDS = conexionBDD.obtenerDataSet(strSQL, datosTraduccion);
                traduccionesT = traduccionesDS.Tables[0];
                if (traduccionesT.Rows.Count > 0)
                {
                    foreach (DataRow fila in traduccionesT.Rows)
                    {
                        Traduccion traduccion = new Traduccion();
                        traduccion.Idioma = idioma;
                        Etiqueta etiqueta = new Etiqueta();
                        etiqueta.Nombre = Convert.ToString(fila["EtiquetaNombre"]);
                        traduccion.Etiqueta = etiqueta;
                        traduccion.PalabraTraducida = Convert.ToString(fila["Traduccion"]);

                        traducciones.Add(etiqueta.Nombre, traduccion);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return traducciones;
        }

        public Idioma ObtenerIdiomaDefault()
        {
            Idioma idiomaDefault = new Idioma();
            DataSet traduccionesDS;
            DataTable traduccionesT;
            Hashtable datosTraduccion = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerIdiomaDefault";
                traduccionesDS = conexionBDD.obtenerDataSet(strSQL, datosTraduccion);
                traduccionesT = traduccionesDS.Tables[0];
                if (traduccionesT.Rows.Count > 0)
                {
                    foreach (DataRow fila in traduccionesT.Rows)
                    {
                        idiomaDefault.Nombre = Convert.ToString(fila["Nombre"]);
                        idiomaDefault.Default = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return idiomaDefault;
        }

    }
}

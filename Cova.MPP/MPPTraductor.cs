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

        public IList<Idioma> ObtenerIdiomas()
        {
            List<Idioma> idiomas = new List<Idioma>();
            DataSet traduccionesDS;
            DataTable traduccionesT;
            Hashtable datosTraduccion = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerIdiomas";
                traduccionesDS = conexionBDD.obtenerDataSet(strSQL, datosTraduccion);
                traduccionesT = traduccionesDS.Tables[0];
                if (traduccionesT.Rows.Count > 0)
                {
                    foreach (DataRow fila in traduccionesT.Rows)
                    {
                        Idioma idioma = new Idioma();
                        idioma.Nombre = Convert.ToString(fila["Nombre"]);
                        idioma.Default = Convert.ToBoolean(fila["Default"]);

                        idiomas.Add(idioma);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return idiomas;
        }

        public bool CrearIdioma(Idioma idiomaNuevo)
        {
            Hashtable datosIdioma = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_AgregarIdioma";
                datosIdioma.Add("@NombreIdioma", idiomaNuevo.Nombre);
                return conexionBDD.escribir(strSQL, datosIdioma);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AgregarTraducciones(IList<Traduccion> nuevaTraduccion)
        {
            try
            {
                foreach(Traduccion traduccion in nuevaTraduccion)
                {
                    ConexionDB conexionBDD = new ConexionDB();
                    Hashtable datosTraduccion = new Hashtable();
                    string strSQL = @"s_AgregarTraduccion";
                    datosTraduccion.Add("@NombreIdioma", traduccion.Idioma.Nombre);
                    datosTraduccion.Add("@NombreEtiqueta", traduccion.Etiqueta.Nombre);
                    datosTraduccion.Add("@PalabraTraducida", traduccion.PalabraTraducida);
                    conexionBDD.escribir(strSQL, datosTraduccion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public IDictionary<string, Traduccion> ObtenerEtiquetasIdiomaDefault()
        {
            IDictionary<string, Traduccion> traducciones = new Dictionary<string, Traduccion>();
            DataSet traduccionesDS;
            DataTable traduccionesT;
            Hashtable datosTraduccion = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerEtiquetasIdiomaDefault";
                traduccionesDS = conexionBDD.obtenerDataSet(strSQL, datosTraduccion);
                traduccionesT = traduccionesDS.Tables[0];
                if (traduccionesT.Rows.Count > 0)
                {
                    foreach (DataRow fila in traduccionesT.Rows)
                    {
                        Traduccion traduccion = new Traduccion();
                        Idioma idiomaDefault = new Idioma();
                        idiomaDefault.Nombre = Convert.ToString(fila["IdiomaDefault"]);
                        traduccion.Idioma = idiomaDefault;
                        Etiqueta etiqueta = new Etiqueta();
                        etiqueta.Nombre = Convert.ToString(fila["EtiquetaNombre"]);
                        traduccion.Etiqueta = etiqueta;
                        traduccion.PalabraTraducida = Convert.ToString(fila["PalabraTraducida"]);

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

    }
}

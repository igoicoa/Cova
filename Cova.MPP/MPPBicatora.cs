using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE.Bitacora;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPBicatora
    {
        public IList<BEBitacora> BuscarBitacora(BEBitacora bitacoraABuscar, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<BEBitacora> bitacora = new List<BEBitacora>();
            DataSet bitacoraDs;
            DataTable bitacoraT;
            Hashtable datosBitacora = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BitacoraObtenerRegistros";
                datosBitacora.Add("@FechaDesde", fechaDesde);
                datosBitacora.Add("@FechaHasta", fechaHasta);
                datosBitacora.Add("@UsuarioId", bitacoraABuscar.Usuario.UsuarioID);
                datosBitacora.Add("@Criticidad", bitacoraABuscar.Criticidad);
                bitacoraDs = conexionBDD.ObtenerDataSet(strSQL, datosBitacora);
                bitacoraT = bitacoraDs.Tables[0];
                if (bitacoraT.Rows.Count > 0)
                {
                    foreach (DataRow fila in bitacoraT.Rows)
                    {
                        BEBitacora registroBitacora = new BEBitacora();
                        BEUsuario usuario = new BEUsuario();
                        usuario.Usuario = Convert.ToString(fila["Usuario"]);
                        registroBitacora.Usuario = usuario;

                        registroBitacora.BitacoraId = Convert.ToInt64(fila["BitacoraId"]);
                        registroBitacora.Fecha = Convert.ToDateTime(fila["Fecha"]);
                        registroBitacora.Criticidad = (TipoCriticidad)Enum.Parse(typeof(TipoCriticidad), Convert.ToString(fila["Criticidad"]));
                        registroBitacora.Mensaje = Convert.ToString(fila["Mensaje"]);
                        registroBitacora.Funcionalidad = Convert.ToString(fila["Funcionalidad"]);

                        bitacora.Add(registroBitacora);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bitacora;
        }

        public bool CrearRegistroBitacora(BEBitacora bitacora)
        {
            Hashtable datosBitacora = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BitacoraRegistrar";
                datosBitacora.Add("@Fecha", bitacora.Fecha);
                datosBitacora.Add("@Criticidad", bitacora.Criticidad);
                datosBitacora.Add("@Mensaje", bitacora.Mensaje);
                datosBitacora.Add("@Funcionalidad", bitacora.Funcionalidad);
                if(bitacora.Usuario != null)
                {
                    if(bitacora.Usuario.UsuarioID != 0)
                    {
                        datosBitacora.Add("@UsuarioId", bitacora.Usuario.UsuarioID);
                    }
                }
                return conexionBDD.Escribir(strSQL, datosBitacora);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPUsuario
    {
        public BEUsuario obtenerUsuario(BEUsuario usuarioALoguearse)
        {
            BEUsuario usuario = new BEUsuario();
            DataSet usuarioDS;
            DataTable usuarioT;
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerUsuario";
                datosUsuario.Add("@NombreUsuario", usuarioALoguearse.Usuario);
                usuarioDS = conexionBDD.obtenerDataSet(strSQL, datosUsuario);
                usuarioT = usuarioDS.Tables[0];
                if (usuarioT.Rows.Count > 0)
                {
                    foreach (DataRow fila in usuarioT.Rows)
                    {
                        usuario.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);
                        usuario.Usuario = Convert.ToString(fila["Usuario"]);
                        usuario.Password = Convert.ToString(fila["Password"]);
                        usuario.UltimoLogin = Convert.ToDateTime(fila["UltimoLogin"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }

        public bool ActualizarPassword(string usuario, string claveNuevaEncriptada)
        {
            return true;
        }
    }
}

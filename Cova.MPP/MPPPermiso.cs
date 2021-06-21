using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE.Permisos;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPPermiso
    { 
        public ComponentePermiso ObtenerPermisosUsuario(long usuarioID)
        {
            List<TipoPermiso> permisosUsuario = new List<TipoPermiso>();
            DataSet permisosUsuarioDS;
            DataTable permisosUsuarioT;
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerPermisosUsuario";
                datosUsuario.Add("@IDUsuario", usuarioID);
                permisosUsuarioDS = conexionBDD.obtenerDataSet(strSQL, datosUsuario);
                permisosUsuarioT = permisosUsuarioDS.Tables[0];
                if (permisosUsuarioT.Rows.Count > 0)
                {
                    foreach (DataRow fila in permisosUsuarioT.Rows)
                    {
                        permisosUsuario.Add((TipoPermiso)fila["TipoPermiso"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return this.CrearPermisosUsuario(permisosUsuario);
        }

        public ComponentePermiso CrearPermisosUsuario(IList<TipoPermiso> permisosUsuario)
        {
            PermisosMaestro permisosMaestro = new PermisosMaestro();
            FamiliaPermisos familiaPermisosUsuario = new FamiliaPermisos(TipoPermiso.Raiz);
            CrearPermisosRecursivo(permisosMaestro.PermisoMaestro, familiaPermisosUsuario, permisosUsuario);
            return familiaPermisosUsuario;
        }

        private void CrearPermisosRecursivo(ComponentePermiso componentePermiso, ComponentePermiso familiaPermisosUsuario, IList<TipoPermiso> permisosUsuario)
        {
            foreach (ComponentePermiso permiso in componentePermiso.ObtenerHijos())
            {
                if(permisosUsuario.Contains(permiso.TipoPermiso))
                {
                    if(permiso.GetType().Equals(typeof(FamiliaPermisos)))
                    {
                        FamiliaPermisos permisoHijo = new FamiliaPermisos(permiso.TipoPermiso);
                        familiaPermisosUsuario.AgregarPermiso(permisoHijo);
                        if (permiso.ObtenerHijos().Count > 0)
                        {
                            CrearPermisosRecursivo(permiso, permisoHijo, permisosUsuario);
                        }
                    }
                    else
                    {
                        Permiso permisoHijo = new Permiso(permiso.TipoPermiso);
                        familiaPermisosUsuario.AgregarPermiso(permisoHijo);
                        if (permiso.ObtenerHijos().Count > 0)
                        {
                            CrearPermisosRecursivo(permiso, permisoHijo, permisosUsuario);
                        }
                    }
                }
            }
        }

    }

}

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
            List<ArboPermisos> arbolPermisos = new List<ArboPermisos>();
            DataSet familiaPermisosDS;
            DataTable familiaPermisosT;
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerFamiliaPermisoUsuario";
                datosUsuario.Add("@IDUsuario", usuarioID);
                familiaPermisosDS = conexionBDD.obtenerDataSet(strSQL, datosUsuario);
                familiaPermisosT = familiaPermisosDS.Tables[0];
                if (familiaPermisosT.Rows.Count > 0)
                {
                    foreach (DataRow fila in familiaPermisosT.Rows)
                    {
                        ArboPermisos hoja = new ArboPermisos();

                        hoja.IDPermiso = Convert.ToInt32(fila["IDPermiso"]);
                        hoja.TipoPermiso = (TipoPermiso)Convert.ToInt32(fila["TipoPermiso"]);
                        hoja.FechaCreacion = Convert.ToDateTime(fila["FechaCreacion"]);
                        hoja.IDPermisoPadre = Convert.ToInt32(fila["IDPermisoPadre"]);
                        hoja.EsPermiso = Convert.ToBoolean(fila["EsPermiso"]);

                        arbolPermisos.Add(hoja);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return this.MapearArbolPermiso(arbolPermisos);
        }

        public ComponentePermiso MapearArbolPermiso(IList<ArboPermisos> arbolPermisos)
        {
            FamiliaPermisos familiaPermisos = new FamiliaPermisos();
            FamiliaPermisos permisoActual;

            List<ComponentePermiso> permisosNivelAnterior = new List<ComponentePermiso>();

            familiaPermisos = new FamiliaPermisos();
            familiaPermisos.IDPermiso = arbolPermisos[0].IDPermiso;
            familiaPermisos.FechaCreacion = arbolPermisos[0].FechaCreacion;
            arbolPermisos.RemoveAt(0);

            permisoActual = familiaPermisos;
            permisosNivelAnterior.Add(permisoActual);
            foreach (ArboPermisos hoja in arbolPermisos)
            {
                if (hoja.IDPermisoPadre != permisoActual.IDPermiso)
                {
                    permisoActual = this.ObtenerPermisosPadre(permisosNivelAnterior, hoja.IDPermisoPadre);
                }
                if (hoja.EsPermiso)
                {
                    Permiso permiso = new Permiso();
                    permiso.IDPermiso = hoja.IDPermiso;
                    permisoActual.AgregarPermiso(permiso);
                }
                else
                {
                    FamiliaPermisos familiaPermiso = new FamiliaPermisos();
                    familiaPermiso.IDPermiso = hoja.IDPermiso;
                    permisoActual.AgregarPermiso(familiaPermiso);
                    permisosNivelAnterior.Add(familiaPermiso);
                }
            }

            return familiaPermisos;
        }

        private FamiliaPermisos ObtenerPermisosPadre(List<ComponentePermiso> permisosNivelAnterior, int nuevaPermisoPadreId)
        {
            foreach (FamiliaPermisos familiaPermiso in permisosNivelAnterior)
            {
                if (familiaPermiso.IDPermiso == nuevaPermisoPadreId)
                {
                    return familiaPermiso;
                }
            }
            throw new OperationCanceledException();
        }

    }

    //Clase auxiliar para recorrer el arbol de informacion de la BDD
    public class ArboPermisos
    {
        public int IDPermiso { get; set; }
        public TipoPermiso TipoPermiso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IDPermisoPadre { get; set; }
        public bool EsPermiso { get; set; }
    }


}

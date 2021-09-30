using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Cova.BE.Backup;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPBackup
    {
        public bool RealizarBackup(BEBackup backup)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_RealizarBackup";
                datosUsuario.Add("@Nombre", backup.Nombre);
                datosUsuario.Add("@Archivo", backup.Archivo);
                datosUsuario.Add("@UsuarioId", backup.Usuario.UsuarioID);

                return conexionBDD.EjecutarSP(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RealizarRestore(BEBackup backup)
        {
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                return conexionBDD.RealizarRestore(backup.Archivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BEBackup> ObtenerBackups()
        {
            List<BEBackup> backups = new List<BEBackup>();
            DataSet backupDS;
            DataTable backupT;
            Hashtable datosBackup = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerBackups";
                backupDS = conexionBDD.ObtenerDataSet(strSQL, datosBackup);
                backupT = backupDS.Tables[0];
                if (backupT.Rows.Count > 0)
                {
                    foreach (DataRow fila in backupT.Rows)
                    {
                        BEBackup backup = new BEBackup();
                        backup.BackupId = Convert.ToInt32(fila["BackupId"]);
                        backup.Nombre = Convert.ToString(fila["Nombre"]);
                        backup.Archivo = Convert.ToString(fila["Archivo"]);

                        BEUsuario usuario = new BEUsuario();
                        usuario.UsuarioID = Convert.ToInt64(fila["UsuarioId"]);
                        usuario.Usuario = Convert.ToString(fila["Usuario"]);

                        backup.Usuario = usuario;
                        backup.FechaBackup = Convert.ToDateTime(fila["FechaBackup"]);

                        backups.Add(backup);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return backups;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cova.BE.Backup;
using Cova.MPP;
using Microsoft.Win32;

namespace Cova.Servicios.Backup
{
    public static class Backup
    {
        public static bool RealizarBakup(BEBackup backup)
        {
            MPPBackup mPPBackup = new MPPBackup();
            try
            {
                backup.Archivo = Directory.GetCurrentDirectory() + "\\" + backup.Nombre + ".bak";
                //string downloadPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
                //string pathToSave = downloadPath + @"\SistemaCova\Backups";
                //backup.Archivo= pathToSave + "\\" + backup.Nombre + ".bak";
                return mPPBackup.RealizarBackup(backup);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool RealizarRestore(BEBackup backup)
        {
            MPPBackup mPPBackup = new MPPBackup();
            try
            {
                return mPPBackup.RealizarRestore(backup);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IList<BEBackup> ObtenerBackups()
        {
            MPPBackup mPPBackup = new MPPBackup();
            try
            {
                return mPPBackup.ObtenerBackups();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
